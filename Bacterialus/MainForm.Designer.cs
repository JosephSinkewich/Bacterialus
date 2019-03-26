namespace Bacterialus
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startPauseButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusFPSLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.resolutionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.coordsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.zoomInbutton = new System.Windows.Forms.Button();
            this.zoomOutbutton = new System.Windows.Forms.Button();
            this.simulationTagTimer = new System.Windows.Forms.Timer(this.components);
            this.fpsTimer = new System.Windows.Forms.Timer(this.components);
            this.slowestButton = new System.Windows.Forms.Button();
            this.fastestButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.turnButton = new System.Windows.Forms.Button();
            this.minimapDisplayBox = new Bacterialus.DisplayBox();
            this.cameraDisplayBox = new Bacterialus.DisplayBox();
            this.toNormalStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimapDisplayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraDisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.toNormalStateToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.fullScreenToolStripMenuItem.Text = "FullScreen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // startPauseButton
            // 
            this.startPauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startPauseButton.Location = new System.Drawing.Point(319, 28);
            this.startPauseButton.Name = "startPauseButton";
            this.startPauseButton.Size = new System.Drawing.Size(75, 23);
            this.startPauseButton.TabIndex = 2;
            this.startPauseButton.Text = "Start";
            this.startPauseButton.UseVisualStyleBackColor = true;
            this.startPauseButton.Click += new System.EventHandler(this.startPauseButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusFPSLabel,
            this.toolStripStatusLabel2,
            this.resolutionToolStripStatusLabel,
            this.toolStripStatusLabel3,
            this.coordsToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 283);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(501, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "FPS:";
            // 
            // toolStripStatusFPSLabel
            // 
            this.toolStripStatusFPSLabel.Name = "toolStripStatusFPSLabel";
            this.toolStripStatusFPSLabel.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusFPSLabel.Text = "xxx";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel2.Text = "Resolution:";
            // 
            // resolutionToolStripStatusLabel
            // 
            this.resolutionToolStripStatusLabel.Name = "resolutionToolStripStatusLabel";
            this.resolutionToolStripStatusLabel.Size = new System.Drawing.Size(28, 17);
            this.resolutionToolStripStatusLabel.Text = "xxx";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel3.Text = "Coords=";
            // 
            // coordsToolStripStatusLabel
            // 
            this.coordsToolStripStatusLabel.Name = "coordsToolStripStatusLabel";
            this.coordsToolStripStatusLabel.Size = new System.Drawing.Size(28, 17);
            this.coordsToolStripStatusLabel.Text = "xxx";
            // 
            // zoomInbutton
            // 
            this.zoomInbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomInbutton.Location = new System.Drawing.Point(319, 86);
            this.zoomInbutton.Name = "zoomInbutton";
            this.zoomInbutton.Size = new System.Drawing.Size(75, 23);
            this.zoomInbutton.TabIndex = 4;
            this.zoomInbutton.Text = "Zoom In";
            this.zoomInbutton.UseVisualStyleBackColor = true;
            this.zoomInbutton.Click += new System.EventHandler(this.ZoomInbutton_Click);
            // 
            // zoomOutbutton
            // 
            this.zoomOutbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomOutbutton.Location = new System.Drawing.Point(319, 115);
            this.zoomOutbutton.Name = "zoomOutbutton";
            this.zoomOutbutton.Size = new System.Drawing.Size(75, 23);
            this.zoomOutbutton.TabIndex = 5;
            this.zoomOutbutton.Text = "Zoom Out";
            this.zoomOutbutton.UseVisualStyleBackColor = true;
            this.zoomOutbutton.Click += new System.EventHandler(this.ZoomOutbutton_Click);
            // 
            // simulationTagTimer
            // 
            this.simulationTagTimer.Interval = 17;
            this.simulationTagTimer.Tick += new System.EventHandler(this.simulationTagTimer_Tick);
            // 
            // fpsTimer
            // 
            this.fpsTimer.Enabled = true;
            this.fpsTimer.Interval = 1000;
            this.fpsTimer.Tick += new System.EventHandler(this.fpsTimer_Tick);
            // 
            // slowestButton
            // 
            this.slowestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.slowestButton.Location = new System.Drawing.Point(414, 86);
            this.slowestButton.Name = "slowestButton";
            this.slowestButton.Size = new System.Drawing.Size(75, 23);
            this.slowestButton.TabIndex = 8;
            this.slowestButton.Text = "Slowest";
            this.slowestButton.UseVisualStyleBackColor = true;
            this.slowestButton.Click += new System.EventHandler(this.slowestButton_Click);
            // 
            // fastestButton
            // 
            this.fastestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fastestButton.Location = new System.Drawing.Point(414, 115);
            this.fastestButton.Name = "fastestButton";
            this.fastestButton.Size = new System.Drawing.Size(75, 23);
            this.fastestButton.TabIndex = 9;
            this.fastestButton.Text = "Fastest";
            this.fastestButton.UseVisualStyleBackColor = true;
            this.fastestButton.Click += new System.EventHandler(this.fastestButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restartButton.Location = new System.Drawing.Point(414, 39);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 10;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // turnButton
            // 
            this.turnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.turnButton.Location = new System.Drawing.Point(320, 58);
            this.turnButton.Name = "turnButton";
            this.turnButton.Size = new System.Drawing.Size(75, 23);
            this.turnButton.TabIndex = 12;
            this.turnButton.Text = "Turn";
            this.turnButton.UseVisualStyleBackColor = true;
            this.turnButton.Click += new System.EventHandler(this.turnButton_Click);
            // 
            // minimapDisplayBox
            // 
            this.minimapDisplayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.minimapDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minimapDisplayBox.Location = new System.Drawing.Point(320, 145);
            this.minimapDisplayBox.Name = "minimapDisplayBox";
            this.minimapDisplayBox.Size = new System.Drawing.Size(169, 130);
            this.minimapDisplayBox.TabIndex = 11;
            this.minimapDisplayBox.TabStop = false;
            // 
            // cameraDisplayBox
            // 
            this.cameraDisplayBox.Image = global::Bacterialus.Properties.Resources.default100x100;
            this.cameraDisplayBox.Location = new System.Drawing.Point(13, 28);
            this.cameraDisplayBox.Name = "cameraDisplayBox";
            this.cameraDisplayBox.Size = new System.Drawing.Size(300, 247);
            this.cameraDisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraDisplayBox.TabIndex = 7;
            this.cameraDisplayBox.TabStop = false;
            this.cameraDisplayBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.displayBox1_MouseClick);
            this.cameraDisplayBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cameraDisplayBox_MouseMove);
            // 
            // toNormalStateToolStripMenuItem
            // 
            this.toNormalStateToolStripMenuItem.Name = "toNormalStateToolStripMenuItem";
            this.toNormalStateToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.toNormalStateToolStripMenuItem.Text = "To Normal State";
            this.toNormalStateToolStripMenuItem.Click += new System.EventHandler(this.toNormalStateToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(501, 305);
            this.Controls.Add(this.turnButton);
            this.Controls.Add(this.minimapDisplayBox);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.fastestButton);
            this.Controls.Add(this.slowestButton);
            this.Controls.Add(this.cameraDisplayBox);
            this.Controls.Add(this.zoomOutbutton);
            this.Controls.Add(this.zoomInbutton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.startPauseButton);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Bacterialus";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimapDisplayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraDisplayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button startPauseButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button zoomInbutton;
        private System.Windows.Forms.Button zoomOutbutton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFPSLabel;
        private DisplayBox cameraDisplayBox;
        private System.Windows.Forms.Timer simulationTagTimer;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.Timer fpsTimer;
        private System.Windows.Forms.Button slowestButton;
        private System.Windows.Forms.Button fastestButton;
        private System.Windows.Forms.Button restartButton;
        private DisplayBox minimapDisplayBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel resolutionToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel coordsToolStripStatusLabel;
        private System.Windows.Forms.Button turnButton;
        private System.Windows.Forms.ToolStripMenuItem toNormalStateToolStripMenuItem;
    }
}

