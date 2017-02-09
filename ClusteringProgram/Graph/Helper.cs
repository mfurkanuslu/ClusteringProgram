    using System;
using System.Collections.Generic;

namespace ClusteringProgram.Graph
{
    public static class Helper
    {
        public static List<Edge> MakeEdges(List<CPPoint> Points)
        {
            var edges = new List<Edge>();
            for (int i = 0; i < Points.Count; i++)
            {
                for (int j = i + 1; j < Points.Count; j++)
                {
                    edges.Add(new Edge(Points[i], Points[j]));
                }
            }
            return edges;
        }

        public static CPPoint GetMassCenter(ICollection<CPPoint> Points)
        {
            var x = 0;
            var y = 0;
            var count = Points.Count;
            foreach (var Point in Points)
            {
                x += Point.X;
                y += Point.Y;
            }
            return new CPPoint(x / count, y / count);
        }

        public static double CalculateStandardDeviation(ICollection<CPPoint> Points)
        {
            var mean = GetMassCenter(Points);
            var variance = 0d;
            int count = Points.Count;
            foreach (var v in Points)
            {
                variance += Math.Pow(v - mean, 2);
            }
            variance /= count;
            return Math.Round(Math.Sqrt(variance), 2);
        }
    }
}
