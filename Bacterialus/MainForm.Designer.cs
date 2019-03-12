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
            this.zoomInbutton = new System.Windows.Forms.Button();
            this.zoomOutbutton = new System.Windows.Forms.Button();
            this.humTimer = new System.Windows.Forms.Timer(this.components);
            this.fpsTimer = new System.Windows.Forms.Timer(this.components);
            this.slowestButton = new System.Windows.Forms.Button();
            this.fastestButton = new System.Windows.Forms.Button();
            this.displayBox1 = new Bacterialus.DisplayBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorOneButton = new System.Windows.Forms.Button();
            this.colorTwoButton = new System.Windows.Forms.Button();
            this.showLoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
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
            this.startToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.showLoxToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fullScreenToolStripMenuItem.Text = "FullScreen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // startPauseButton
            // 
            this.startPauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startPauseButton.Location = new System.Drawing.Point(618, 36);
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
            this.toolStripStatusFPSLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(705, 22);
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
            // zoomInbutton
            // 
            this.zoomInbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomInbutton.Location = new System.Drawing.Point(619, 66);
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
            this.zoomOutbutton.Location = new System.Drawing.Point(619, 95);
            this.zoomOutbutton.Name = "zoomOutbutton";
            this.zoomOutbutton.Size = new System.Drawing.Size(75, 23);
            this.zoomOutbutton.TabIndex = 5;
            this.zoomOutbutton.Text = "Zoom Out";
            this.zoomOutbutton.UseVisualStyleBackColor = true;
            this.zoomOutbutton.Click += new System.EventHandler(this.ZoomOutbutton_Click);
            // 
            // humTimer
            // 
            this.humTimer.Interval = 17;
            this.humTimer.Tick += new System.EventHandler(this.humTimer_Tick);
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
            this.slowestButton.Location = new System.Drawing.Point(620, 143);
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
            this.fastestButton.Location = new System.Drawing.Point(620, 173);
            this.fastestButton.Name = "fastestButton";
            this.fastestButton.Size = new System.Drawing.Size(75, 23);
            this.fastestButton.TabIndex = 9;
            this.fastestButton.Text = "Fastest";
            this.fastestButton.UseVisualStyleBackColor = true;
            this.fastestButton.Click += new System.EventHandler(this.fastestButton_Click);
            // 
            // displayBox1
            // 
            this.displayBox1.Image = global::Bacterialus.Properties.Resources.default100x100;
            this.displayBox1.Location = new System.Drawing.Point(13, 28);
            this.displayBox1.Name = "displayBox1";
            this.displayBox1.Size = new System.Drawing.Size(600, 247);
            this.displayBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displayBox1.TabIndex = 7;
            this.displayBox1.TabStop = false;
            this.displayBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.displayBox1_MouseClick);
            // 
            // colorOneButton
            // 
            this.colorOneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorOneButton.ForeColor = System.Drawing.Color.Blue;
            this.colorOneButton.Location = new System.Drawing.Point(620, 220);
            this.colorOneButton.Name = "colorOneButton";
            this.colorOneButton.Size = new System.Drawing.Size(75, 23);
            this.colorOneButton.TabIndex = 10;
            this.colorOneButton.Text = "Color1";
            this.colorOneButton.UseVisualStyleBackColor = true;
            this.colorOneButton.Click += new System.EventHandler(this.colorOneButton_Click);
            // 
            // colorTwoButton
            // 
            this.colorTwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorTwoButton.ForeColor = System.Drawing.Color.Aqua;
            this.colorTwoButton.Location = new System.Drawing.Point(620, 249);
            this.colorTwoButton.Name = "colorTwoButton";
            this.colorTwoButton.Size = new System.Drawing.Size(75, 23);
            this.colorTwoButton.TabIndex = 11;
            this.colorTwoButton.Text = "Color2";
            this.colorTwoButton.UseVisualStyleBackColor = true;
            this.colorTwoButton.Click += new System.EventHandler(this.colorTwoButton_Click);
            // 
            // showLoxToolStripMenuItem
            // 
            this.showLoxToolStripMenuItem.Name = "showLoxToolStripMenuItem";
            this.showLoxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showLoxToolStripMenuItem.Text = "Show Lox";
            this.showLoxToolStripMenuItem.Click += new System.EventHandler(this.showLoxToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 300);
            this.Controls.Add(this.colorTwoButton);
            this.Controls.Add(this.colorOneButton);
            this.Controls.Add(this.fastestButton);
            this.Controls.Add(this.slowestButton);
            this.Controls.Add(this.displayBox1);
            this.Controls.Add(this.zoomOutbutton);
            this.Controls.Add(this.zoomInbutton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.startPauseButton);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "TechnoFire";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox1)).EndInit();
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
        private DisplayBox displayBox1;
        private System.Windows.Forms.Timer humTimer;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.Timer fpsTimer;
        private System.Windows.Forms.Button slowestButton;
        private System.Windows.Forms.Button fastestButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorOneButton;
        private System.Windows.Forms.Button colorTwoButton;
        private System.Windows.Forms.ToolStripMenuItem showLoxToolStripMenuItem;
    }
}

