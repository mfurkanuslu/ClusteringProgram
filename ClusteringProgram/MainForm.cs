using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClusteringProgram.Graph;
using ClusteringProgram.Heap;

namespace ClusteringProgram
{
    public partial class MainForm : Form
    {
        List<CPPoint> points;
        readonly Bitmap bitmap;
        readonly Graphics graphics;
        static readonly Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow,
        Color.Purple, Color.Magenta, Color.SteelBlue, Color.Lime, Color.SpringGreen, Color.IndianRed,
            Color.HotPink, Color.DarkOrchid, Color.Goldenrod, Color.Azure, Color.Indigo, Color.Olive, Color.Plum,
            Color.Maroon, Color.Turquoise, Color.RoyalBlue}; //TODO: automatic color generation may be added

        public MainForm()
        {
            InitializeComponent();
            bitmap = new Bitmap(panelDraw.Width, panelDraw.Height);
            graphics = Graphics.FromImage(bitmap);
            Reset();
            inputClusterCount.Value = colors.Length;
            inputRandomPointCount.Value = colors.Length;
        }

        public void Reset()
        {
            points = new List<CPPoint>();
            graphics.FillRectangle(Brushes.LightGray, 0, 0, bitmap.Width, bitmap.Height);
            graphics.DrawRectangle(new Pen(Color.Black), 0, 0, bitmap.Width - 1, bitmap.Height - 1);
            labelPointCount.Text = "Total point count: " + points.Count;
        }

        public void AddPoint(CPPoint point)
        {
            if (points.Contains(point))
            {
                return;
            }
            points.Add(point);
            DrawPoint(point.X, point.Y, Brushes.Black);
            labelPointCount.Text = "Total points count: " + points.Count;
        }

        public void DrawPoint(int x, int y, Brush brush)
        {
            graphics.FillEllipse(brush, x - 5, y - 5, 10, 10);
        }

        public void DrawPointPerimeter(int x, int y, Color color)
        {
            graphics.DrawEllipse(new Pen(color, 3), x - 5, y - 5, 10, 10);
        }

        public void DrawMassCenter(int x, int y, Color color)
        {
            graphics.DrawEllipse(new Pen(color, 2), x - 10, y - 5, 20, 10);
            graphics.DrawEllipse(new Pen(color, 2), x - 5, y - 10, 10, 20);
            graphics.DrawEllipse(new Pen(color, 2), x - 10, y - 10, 20, 20);
        }

        void ButtonAddRandomPointsClick(object sender, EventArgs e)
        {
            var rnd = new Random();
            var count = (int)inputRandomPointCount.Value;
            var tooManyRepeats = false;
            for (int i = 0; i < count; i++)
            {
                int x, y;
                int repeatCount = 0;
                CPPoint v;
                do
                {
                    x = rnd.Next(bitmap.Width);
                    y = rnd.Next(bitmap.Height);
                    v = new CPPoint(x, y);
                    repeatCount++;
                    if (repeatCount > 10)
                    {
                        tooManyRepeats = true;
                        break;
                    }
                } while (points.Contains(v));
                if (tooManyRepeats)
                {
                    MessageBox.Show("No more points can be added!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                AddPoint(v);
            }
            panelDraw.Refresh();
        }

        void PanelDrawPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        void PanelDrawMouseClick(object sender, MouseEventArgs e)
        {
            AddPoint(new CPPoint(e.X, e.Y));
            panelDraw.Refresh();
        }

        public void AddStatistics(string text, Color color)
        {
            textBoxStatistics.SelectionStart = textBoxStatistics.TextLength;
            textBoxStatistics.SelectionLength = 0;
            textBoxStatistics.SelectionColor = color;
            textBoxStatistics.AppendText(text + "\n");
            textBoxStatistics.SelectionColor = textBoxStatistics.ForeColor;
        }

        void ButtonDoClustering(object sender, EventArgs e)
        {
            var clustersCount = (int)inputClusterCount.Value;
            var clusters = new List<HashSet<CPPoint>>();
            var edges = Helper.MakeEdges(points);
            MinHeap heap = new MinHeap(edges.Count);

            foreach (var edge in edges)
            {
                heap.InsertElement(edge);
            }

            while (clusters.Count + points.Count > clustersCount)
            {
                var edge = (Edge)heap.DeleteMin();
                var x = edge.GetStartPoint();
                var y = edge.GetEndPoint();
                var added = false;

                foreach (var cluster in clusters)
                {
                    if (cluster.Contains(x) || cluster.Contains(y))
                    {
                        cluster.Add(x);
                        cluster.Add(y);
                        added = true;
                        for (int i = clusters.IndexOf(cluster) + 1; i < clusters.Count; i++)
                        {
                            var otherCluster = clusters[i];
                            if (otherCluster.Contains(x) || otherCluster.Contains(y))
                            {
                                foreach (var item in otherCluster)
                                {
                                    cluster.Add(item);
                                }
                                clusters.Remove(otherCluster);
                            }
                        }
                        break;
                    }
                }
                if (added == false)
                {
                    var cluster2 = new HashSet<CPPoint>
                    {
                        x,
                        y
                    };
                    clusters.Add(cluster2);
                }
                points.Remove(x);
                points.Remove(y);
            }

            foreach (var item in points)
            {
                var tempCluster = new HashSet<CPPoint>
                {
                    item
                };
                clusters.Add(tempCluster);
            }

            for (int i = 0; i < clusters.Count; i++)
            {
                var cluster = clusters[i];
                var clusterAsList = new List<CPPoint>(cluster);
                var color = colors[i % colors.Length];
                AddStatistics((i + 1).ToString() + ". Cluster", color);
                AddStatistics("CPPoint Count: " + cluster.Count, color);
                var massCenter = Helper.GetMassCenter(clusterAsList);
                AddStatistics("Mass Center: " + massCenter + "", color);

                var xList = new List<int>();
                var yList = new List<int>();
                foreach (var item in cluster)
                {
                    xList.Add(item.X);
                    yList.Add(item.Y);
                }

                var stdDeviation = Helper.CalculateStandardDeviation(cluster);

                AddStatistics("Std. deviation: " + stdDeviation + "\n", color);

                foreach (var point in cluster)
                {
                    DrawPointPerimeter(point.X, point.Y, color);
                }
                DrawMassCenter(massCenter.X, massCenter.Y, color);
            }
            panelDraw.Refresh();
            panelClusteringOperation.Enabled = false;
            groupBoxAddPoint.Enabled = false;
            panelDraw.Enabled = false;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            Reset();
            panelDraw.Refresh();
            textBoxStatistics.Clear();
            panelClusteringOperation.Enabled = true;
            groupBoxAddPoint.Enabled = true;
            panelDraw.Enabled = true;
        }
    }
}
