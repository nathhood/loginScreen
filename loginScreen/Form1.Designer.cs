namespace loginScreen
{
    partial class Form1
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
            this.easyButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.outputMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.easyButton.Location = new System.Drawing.Point(147, 139);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(134, 53);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "EASY";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(258, 39);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(109, 22);
            this.nameBox.TabIndex = 1;
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enterNameLabel.Location = new System.Drawing.Point(45, 41);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(184, 20);
            this.enterNameLabel.TabIndex = 2;
            this.enterNameLabel.Text = "Enter Your Name Hero:";
            this.enterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(110, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Your Difficulty Level:";
            // 
            // mediumButton
            // 
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mediumButton.Location = new System.Drawing.Point(147, 214);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(134, 55);
            this.mediumButton.TabIndex = 4;
            this.mediumButton.Text = "MEDIUM";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hardButton.Location = new System.Drawing.Point(147, 289);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(134, 55);
            this.hardButton.TabIndex = 5;
            this.hardButton.Text = "HARD";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // outputMessageLabel
            // 
            this.outputMessageLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputMessageLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.outputMessageLabel.Location = new System.Drawing.Point(61, 409);
            this.outputMessageLabel.Name = "outputMessageLabel";
            this.outputMessageLabel.Size = new System.Drawing.Size(320, 73);
            this.outputMessageLabel.TabIndex = 6;
            this.outputMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(426, 515);
            this.Controls.Add(this.outputMessageLabel);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterNameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.easyButton);
            this.Name = "Form1";
            this.Text = "Hero Quest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Label outputMessageLabel;
    }
}

