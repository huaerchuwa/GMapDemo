namespace GMapDemo
{
    partial class NaviForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.ParamsInfoPanel = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.SplitContainer();
            this.navi_panel = new System.Windows.Forms.SplitContainer();
            this.OSDPanel = new System.Windows.Forms.Panel();
            this.DashBoardPanel = new System.Windows.Forms.Panel();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.ParamsInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_panel)).BeginInit();
            this.main_panel.Panel1.SuspendLayout();
            this.main_panel.Panel2.SuspendLayout();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navi_panel)).BeginInit();
            this.navi_panel.Panel1.SuspendLayout();
            this.navi_panel.Panel2.SuspendLayout();
            this.navi_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(311, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ParamsInfoPanel
            // 
            this.ParamsInfoPanel.Controls.Add(this.imageBox1);
            this.ParamsInfoPanel.Controls.Add(this.button1);
            this.ParamsInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamsInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.ParamsInfoPanel.Name = "ParamsInfoPanel";
            this.ParamsInfoPanel.Size = new System.Drawing.Size(386, 460);
            this.ParamsInfoPanel.TabIndex = 2;
            // 
            // main_panel
            // 
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            // 
            // main_panel.Panel1
            // 
            this.main_panel.Panel1.Controls.Add(this.ParamsInfoPanel);
            // 
            // main_panel.Panel2
            // 
            this.main_panel.Panel2.Controls.Add(this.navi_panel);
            this.main_panel.Size = new System.Drawing.Size(810, 460);
            this.main_panel.SplitterDistance = 386;
            this.main_panel.TabIndex = 3;
            // 
            // navi_panel
            // 
            this.navi_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navi_panel.Location = new System.Drawing.Point(0, 0);
            this.navi_panel.Name = "navi_panel";
            this.navi_panel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // navi_panel.Panel1
            // 
            this.navi_panel.Panel1.Controls.Add(this.OSDPanel);
            // 
            // navi_panel.Panel2
            // 
            this.navi_panel.Panel2.Controls.Add(this.DashBoardPanel);
            this.navi_panel.Size = new System.Drawing.Size(420, 460);
            this.navi_panel.SplitterDistance = 203;
            this.navi_panel.TabIndex = 0;
            // 
            // OSDPanel
            // 
            this.OSDPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OSDPanel.Location = new System.Drawing.Point(0, 0);
            this.OSDPanel.Name = "OSDPanel";
            this.OSDPanel.Size = new System.Drawing.Size(420, 203);
            this.OSDPanel.TabIndex = 0;
            // 
            // DashBoardPanel
            // 
            this.DashBoardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashBoardPanel.Name = "DashBoardPanel";
            this.DashBoardPanel.Size = new System.Drawing.Size(420, 253);
            this.DashBoardPanel.TabIndex = 0;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(83, 101);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(271, 264);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // NaviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 460);
            this.Controls.Add(this.main_panel);
            this.Name = "NaviForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.NAVForm_Resize);
            this.ParamsInfoPanel.ResumeLayout(false);
            this.ParamsInfoPanel.PerformLayout();
            this.main_panel.Panel1.ResumeLayout(false);
            this.main_panel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_panel)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.navi_panel.Panel1.ResumeLayout(false);
            this.navi_panel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navi_panel)).EndInit();
            this.navi_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ParamsInfoPanel;
        private System.Windows.Forms.SplitContainer main_panel;
        private System.Windows.Forms.SplitContainer navi_panel;
        private System.Windows.Forms.Panel OSDPanel;
        private System.Windows.Forms.Panel DashBoardPanel;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}

