namespace Bacterialus
{
    partial class SpeciesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toParentButton = new System.Windows.Forms.Button();
            this.parentNameLabel = new System.Windows.Forms.Label();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.sensorRaduisLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.reproductionMassLabel = new System.Windows.Forms.Label();
            this.reproductionSpeedLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.growSpeedLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.eatSpeedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.populationLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.foodListBox = new System.Windows.Forms.ListBox();
            this.foodTypeLabel = new System.Windows.Forms.Label();
            this.parentColorDisplayBox = new Bacterialus.DisplayBox();
            this.colorDisplayBox = new Bacterialus.DisplayBox();
            this.propertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentColorDisplayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorDisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(69, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(146, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(70, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Food Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(69, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parent:";
            // 
            // toParentButton
            // 
            this.toParentButton.Enabled = false;
            this.toParentButton.Location = new System.Drawing.Point(302, 67);
            this.toParentButton.Name = "toParentButton";
            this.toParentButton.Size = new System.Drawing.Size(65, 23);
            this.toParentButton.TabIndex = 7;
            this.toParentButton.Text = "To Parent";
            this.toParentButton.UseVisualStyleBackColor = true;
            this.toParentButton.Click += new System.EventHandler(this.toParentButton_Click);
            // 
            // parentNameLabel
            // 
            this.parentNameLabel.AutoSize = true;
            this.parentNameLabel.Location = new System.Drawing.Point(175, 72);
            this.parentNameLabel.Name = "parentNameLabel";
            this.parentNameLabel.Size = new System.Drawing.Size(22, 13);
            this.parentNameLabel.TabIndex = 8;
            this.parentNameLabel.Text = "xxx";
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.propertiesGroupBox.Controls.Add(this.sensorRaduisLabel);
            this.propertiesGroupBox.Controls.Add(this.label15);
            this.propertiesGroupBox.Controls.Add(this.reproductionMassLabel);
            this.propertiesGroupBox.Controls.Add(this.reproductionSpeedLabel);
            this.propertiesGroupBox.Controls.Add(this.label12);
            this.propertiesGroupBox.Controls.Add(this.label11);
            this.propertiesGroupBox.Controls.Add(this.growSpeedLabel);
            this.propertiesGroupBox.Controls.Add(this.label9);
            this.propertiesGroupBox.Controls.Add(this.defenseLabel);
            this.propertiesGroupBox.Controls.Add(this.label7);
            this.propertiesGroupBox.Controls.Add(this.eatSpeedLabel);
            this.propertiesGroupBox.Controls.Add(this.label6);
            this.propertiesGroupBox.Controls.Add(this.speedLabel);
            this.propertiesGroupBox.Controls.Add(this.label4);
            this.propertiesGroupBox.Location = new System.Drawing.Point(13, 109);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(283, 230);
            this.propertiesGroupBox.TabIndex = 10;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Properties";
            // 
            // sensorRaduisLabel
            // 
            this.sensorRaduisLabel.AutoSize = true;
            this.sensorRaduisLabel.Location = new System.Drawing.Point(119, 195);
            this.sensorRaduisLabel.Name = "sensorRaduisLabel";
            this.sensorRaduisLabel.Size = new System.Drawing.Size(22, 13);
            this.sensorRaduisLabel.TabIndex = 20;
            this.sensorRaduisLabel.Text = "xxx";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(20, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Sensor Radius:";
            // 
            // reproductionMassLabel
            // 
            this.reproductionMassLabel.AutoSize = true;
            this.reproductionMassLabel.Location = new System.Drawing.Point(153, 165);
            this.reproductionMassLabel.Name = "reproductionMassLabel";
            this.reproductionMassLabel.Size = new System.Drawing.Size(22, 13);
            this.reproductionMassLabel.TabIndex = 18;
            this.reproductionMassLabel.Text = "xxx";
            // 
            // reproductionSpeedLabel
            // 
            this.reproductionSpeedLabel.AutoSize = true;
            this.reproductionSpeedLabel.Location = new System.Drawing.Point(153, 140);
            this.reproductionSpeedLabel.Name = "reproductionSpeedLabel";
            this.reproductionSpeedLabel.Size = new System.Drawing.Size(22, 13);
            this.reproductionSpeedLabel.TabIndex = 17;
            this.reproductionSpeedLabel.Text = "xxx";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(20, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Reproduction Mass:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(20, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Reproduction Speed:";
            // 
            // growSpeedLabel
            // 
            this.growSpeedLabel.AutoSize = true;
            this.growSpeedLabel.Location = new System.Drawing.Point(106, 110);
            this.growSpeedLabel.Name = "growSpeedLabel";
            this.growSpeedLabel.Size = new System.Drawing.Size(22, 13);
            this.growSpeedLabel.TabIndex = 14;
            this.growSpeedLabel.Text = "xxx";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(20, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Grow Speed:";
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Location = new System.Drawing.Point(106, 85);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(22, 13);
            this.defenseLabel.TabIndex = 12;
            this.defenseLabel.Text = "xxx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Defense:";
            // 
            // eatSpeedLabel
            // 
            this.eatSpeedLabel.AutoSize = true;
            this.eatSpeedLabel.Location = new System.Drawing.Point(106, 60);
            this.eatSpeedLabel.Name = "eatSpeedLabel";
            this.eatSpeedLabel.Size = new System.Drawing.Size(22, 13);
            this.eatSpeedLabel.TabIndex = 10;
            this.eatSpeedLabel.Text = "xxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Eat Speed:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(106, 35);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(22, 13);
            this.speedLabel.TabIndex = 8;
            this.speedLabel.Text = "xxx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Speed:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(302, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Population:";
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(379, 16);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(22, 13);
            this.populationLabel.TabIndex = 12;
            this.populationLabel.Text = "xxx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(313, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Food List:";
            // 
            // foodListBox
            // 
            this.foodListBox.FormattingEnabled = true;
            this.foodListBox.Location = new System.Drawing.Point(316, 126);
            this.foodListBox.Name = "foodListBox";
            this.foodListBox.Size = new System.Drawing.Size(143, 212);
            this.foodListBox.TabIndex = 14;
            // 
            // foodTypeLabel
            // 
            this.foodTypeLabel.AutoSize = true;
            this.foodTypeLabel.Location = new System.Drawing.Point(147, 43);
            this.foodTypeLabel.Name = "foodTypeLabel";
            this.foodTypeLabel.Size = new System.Drawing.Size(22, 13);
            this.foodTypeLabel.TabIndex = 15;
            this.foodTypeLabel.Text = "xxx";
            // 
            // parentColorDisplayBox
            // 
            this.parentColorDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.parentColorDisplayBox.Image = global::Bacterialus.Properties.Resources.default100x100;
            this.parentColorDisplayBox.Location = new System.Drawing.Point(146, 66);
            this.parentColorDisplayBox.Name = "parentColorDisplayBox";
            this.parentColorDisplayBox.Size = new System.Drawing.Size(23, 23);
            this.parentColorDisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.parentColorDisplayBox.TabIndex = 9;
            this.parentColorDisplayBox.TabStop = false;
            // 
            // colorDisplayBox
            // 
            this.colorDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorDisplayBox.Image = global::Bacterialus.Properties.Resources.default100x100;
            this.colorDisplayBox.Location = new System.Drawing.Point(13, 13);
            this.colorDisplayBox.Name = "colorDisplayBox";
            this.colorDisplayBox.Size = new System.Drawing.Size(50, 50);
            this.colorDisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colorDisplayBox.TabIndex = 0;
            this.colorDisplayBox.TabStop = false;
            // 
            // SpeciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 351);
            this.Controls.Add(this.foodTypeLabel);
            this.Controls.Add(this.foodListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.populationLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.propertiesGroupBox);
            this.Controls.Add(this.parentColorDisplayBox);
            this.Controls.Add(this.parentNameLabel);
            this.Controls.Add(this.toParentButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorDisplayBox);
            this.Name = "SpeciesForm";
            this.Text = "SpeciesForm";
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentColorDisplayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorDisplayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DisplayBox colorDisplayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button toParentButton;
        private System.Windows.Forms.Label parentNameLabel;
        private DisplayBox parentColorDisplayBox;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label eatSpeedLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label defenseLabel;
        private System.Windows.Forms.Label growSpeedLabel;
        private System.Windows.Forms.Label reproductionMassLabel;
        private System.Windows.Forms.Label reproductionSpeedLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label sensorRaduisLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox foodListBox;
        private System.Windows.Forms.Label foodTypeLabel;
    }
}