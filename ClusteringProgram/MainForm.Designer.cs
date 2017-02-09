namespace ClusteringProgram
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.GroupBox groupBoxAddPoint;
		private System.Windows.Forms.NumericUpDown inputRandomPointCount;
		private System.Windows.Forms.Button buttonAddRandomPoints;
		private System.Windows.Forms.GroupBox groupBoxClustering;
		private System.Windows.Forms.Panel panelClusteringOperation;
		private System.Windows.Forms.Label labelClusterCount;
		private System.Windows.Forms.NumericUpDown inputClusterCount;
		private System.Windows.Forms.Button buttonDoClustering;
		private System.Windows.Forms.RichTextBox textBoxStatistics;
		private System.Windows.Forms.GroupBox groupBoxDraw;
		private System.Windows.Forms.Panel panelDraw;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
                bitmap.Dispose(); // added manually
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxClustering = new System.Windows.Forms.GroupBox();
            this.textBoxStatistics = new System.Windows.Forms.RichTextBox();
            this.panelClusteringOperation = new System.Windows.Forms.Panel();
            this.buttonDoClustering = new System.Windows.Forms.Button();
            this.inputClusterCount = new System.Windows.Forms.NumericUpDown();
            this.labelClusterCount = new System.Windows.Forms.Label();
            this.groupBoxAddPoint = new System.Windows.Forms.GroupBox();
            this.buttonAddRandomPoints = new System.Windows.Forms.Button();
            this.inputRandomPointCount = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDraw = new System.Windows.Forms.GroupBox();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelPointCount = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.groupBoxClustering.SuspendLayout();
            this.panelClusteringOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputClusterCount)).BeginInit();
            this.groupBoxAddPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputRandomPointCount)).BeginInit();
            this.groupBoxDraw.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxClustering);
            this.panelLeft.Controls.Add(this.groupBoxAddPoint);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(237, 533);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxClustering
            // 
            this.groupBoxClustering.Controls.Add(this.textBoxStatistics);
            this.groupBoxClustering.Controls.Add(this.panelClusteringOperation);
            this.groupBoxClustering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxClustering.Location = new System.Drawing.Point(0, 56);
            this.groupBoxClustering.Name = "groupBoxClustering";
            this.groupBoxClustering.Size = new System.Drawing.Size(237, 477);
            this.groupBoxClustering.TabIndex = 2;
            this.groupBoxClustering.TabStop = false;
            this.groupBoxClustering.Text = "Clustering Operation";
            // 
            // textBoxStatistics
            // 
            this.textBoxStatistics.BackColor = System.Drawing.Color.Black;
            this.textBoxStatistics.DetectUrls = false;
            this.textBoxStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxStatistics.Location = new System.Drawing.Point(3, 88);
            this.textBoxStatistics.Name = "textBoxStatistics";
            this.textBoxStatistics.ReadOnly = true;
            this.textBoxStatistics.Size = new System.Drawing.Size(231, 386);
            this.textBoxStatistics.TabIndex = 2;
            this.textBoxStatistics.Text = "";
            // 
            // panelClusteringOperation
            // 
            this.panelClusteringOperation.Controls.Add(this.buttonDoClustering);
            this.panelClusteringOperation.Controls.Add(this.inputClusterCount);
            this.panelClusteringOperation.Controls.Add(this.labelClusterCount);
            this.panelClusteringOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClusteringOperation.Location = new System.Drawing.Point(3, 16);
            this.panelClusteringOperation.Name = "panelClusteringOperation";
            this.panelClusteringOperation.Size = new System.Drawing.Size(231, 72);
            this.panelClusteringOperation.TabIndex = 0;
            // 
            // buttonDoClustering
            // 
            this.buttonDoClustering.Location = new System.Drawing.Point(107, 32);
            this.buttonDoClustering.Name = "buttonDoClustering";
            this.buttonDoClustering.Size = new System.Drawing.Size(81, 34);
            this.buttonDoClustering.TabIndex = 2;
            this.buttonDoClustering.Text = "Run";
            this.buttonDoClustering.UseVisualStyleBackColor = true;
            this.buttonDoClustering.Click += new System.EventHandler(this.ButtonDoClustering);
            // 
            // inputClusterCount
            // 
            this.inputClusterCount.Location = new System.Drawing.Point(107, 6);
            this.inputClusterCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.inputClusterCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputClusterCount.Name = "inputClusterCount";
            this.inputClusterCount.Size = new System.Drawing.Size(81, 20);
            this.inputClusterCount.TabIndex = 1;
            this.inputClusterCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelClusterCount
            // 
            this.labelClusterCount.Location = new System.Drawing.Point(7, 8);
            this.labelClusterCount.Name = "labelClusterCount";
            this.labelClusterCount.Size = new System.Drawing.Size(87, 17);
            this.labelClusterCount.TabIndex = 0;
            this.labelClusterCount.Text = "Cluster Count:";
            // 
            // groupBoxAddPoint
            // 
            this.groupBoxAddPoint.Controls.Add(this.buttonAddRandomPoints);
            this.groupBoxAddPoint.Controls.Add(this.inputRandomPointCount);
            this.groupBoxAddPoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAddPoint.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAddPoint.Name = "groupBoxAddPoint";
            this.groupBoxAddPoint.Size = new System.Drawing.Size(237, 56);
            this.groupBoxAddPoint.TabIndex = 1;
            this.groupBoxAddPoint.TabStop = false;
            this.groupBoxAddPoint.Text = "Add Random Points";
            // 
            // buttonAddRandomPoints
            // 
            this.buttonAddRandomPoints.Location = new System.Drawing.Point(110, 16);
            this.buttonAddRandomPoints.Name = "buttonAddRandomPoints";
            this.buttonAddRandomPoints.Size = new System.Drawing.Size(81, 31);
            this.buttonAddRandomPoints.TabIndex = 1;
            this.buttonAddRandomPoints.Text = "Add";
            this.buttonAddRandomPoints.UseVisualStyleBackColor = true;
            this.buttonAddRandomPoints.Click += new System.EventHandler(this.ButtonAddRandomPointsClick);
            // 
            // inputRandomPointCount
            // 
            this.inputRandomPointCount.Location = new System.Drawing.Point(10, 22);
            this.inputRandomPointCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.inputRandomPointCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputRandomPointCount.Name = "inputRandomPointCount";
            this.inputRandomPointCount.Size = new System.Drawing.Size(87, 20);
            this.inputRandomPointCount.TabIndex = 0;
            this.inputRandomPointCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxDraw
            // 
            this.groupBoxDraw.Controls.Add(this.panelDraw);
            this.groupBoxDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDraw.Location = new System.Drawing.Point(237, 0);
            this.groupBoxDraw.Name = "groupBoxDraw";
            this.groupBoxDraw.Size = new System.Drawing.Size(547, 533);
            this.groupBoxDraw.TabIndex = 1;
            this.groupBoxDraw.TabStop = false;
            this.groupBoxDraw.Text = "Drawing Panel";
            // 
            // panelDraw
            // 
            this.panelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDraw.Location = new System.Drawing.Point(3, 16);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(541, 514);
            this.panelDraw.TabIndex = 0;
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDrawPaint);
            this.panelDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelDrawMouseClick);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.buttonReset);
            this.panelInfo.Controls.Add(this.labelPointCount);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 533);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(784, 28);
            this.panelInfo.TabIndex = 2;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(706, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // labelPointCount
            // 
            this.labelPointCount.AutoSize = true;
            this.labelPointCount.BackColor = System.Drawing.Color.White;
            this.labelPointCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPointCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPointCount.ForeColor = System.Drawing.Color.Red;
            this.labelPointCount.Location = new System.Drawing.Point(7, 3);
            this.labelPointCount.Name = "labelPointCount";
            this.labelPointCount.Size = new System.Drawing.Size(2, 18);
            this.labelPointCount.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxDraw);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clustering Program";
            this.panelLeft.ResumeLayout(false);
            this.groupBoxClustering.ResumeLayout(false);
            this.panelClusteringOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputClusterCount)).EndInit();
            this.groupBoxAddPoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputRandomPointCount)).EndInit();
            this.groupBoxDraw.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelPointCount;
        private System.Windows.Forms.Button buttonReset;
    }
}
