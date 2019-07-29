namespace GMapDemo
{
    partial class MissionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Missino_Panel = new System.Windows.Forms.SplitContainer();
            this.MissionMap = new GMap.NET.WindowsForms.GMapControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MissionInfopanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Missino_Panel)).BeginInit();
            this.Missino_Panel.Panel1.SuspendLayout();
            this.Missino_Panel.Panel2.SuspendLayout();
            this.Missino_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Missino_Panel
            // 
            this.Missino_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Missino_Panel.Location = new System.Drawing.Point(0, 0);
            this.Missino_Panel.Name = "Missino_Panel";
            this.Missino_Panel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Missino_Panel.Panel1
            // 
            this.Missino_Panel.Panel1.Controls.Add(this.MissionMap);
            // 
            // Missino_Panel.Panel2
            // 
            this.Missino_Panel.Panel2.Controls.Add(this.MissionInfopanel);
            this.Missino_Panel.Size = new System.Drawing.Size(722, 703);
            this.Missino_Panel.SplitterDistance = 579;
            this.Missino_Panel.TabIndex = 1;
            // 
            // MissionMap
            // 
            this.MissionMap.AutoSize = true;
            this.MissionMap.Bearing = 0F;
            this.MissionMap.CanDragMap = true;
            this.MissionMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MissionMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MissionMap.GrayScaleMode = false;
            this.MissionMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MissionMap.LevelsKeepInMemmory = 5;
            this.MissionMap.Location = new System.Drawing.Point(0, 0);
            this.MissionMap.MarkersEnabled = true;
            this.MissionMap.MaxZoom = 2;
            this.MissionMap.MinZoom = 2;
            this.MissionMap.MouseWheelZoomEnabled = true;
            this.MissionMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MissionMap.Name = "MissionMap";
            this.MissionMap.NegativeMode = false;
            this.MissionMap.PolygonsEnabled = true;
            this.MissionMap.RetryLoadTile = 0;
            this.MissionMap.RoutesEnabled = true;
            this.MissionMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MissionMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MissionMap.ShowTileGridLines = false;
            this.MissionMap.Size = new System.Drawing.Size(722, 579);
            this.MissionMap.TabIndex = 1;
            this.MissionMap.Zoom = 0D;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MissionInfopanel
            // 
            this.MissionInfopanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MissionInfopanel.Location = new System.Drawing.Point(0, 0);
            this.MissionInfopanel.Name = "MissionInfopanel";
            this.MissionInfopanel.Size = new System.Drawing.Size(722, 120);
            this.MissionInfopanel.TabIndex = 0;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 703);
            this.Controls.Add(this.Missino_Panel);
            this.Name = "MapForm";
            this.Text = "MapForm";
            this.Load += new System.EventHandler(this.MapForm_Load);
            this.Missino_Panel.Panel1.ResumeLayout(false);
            this.Missino_Panel.Panel1.PerformLayout();
            this.Missino_Panel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Missino_Panel)).EndInit();
            this.Missino_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Missino_Panel;
        private GMap.NET.WindowsForms.GMapControl MissionMap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel MissionInfopanel;
    }
}