namespace Tetris
{
    partial class Launcher
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.btnInstructiuni = new System.Windows.Forms.Button();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.btnResetHs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(916, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart1
            // 
            this.btnStart1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnStart1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart1.Location = new System.Drawing.Point(78, 298);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(176, 45);
            this.btnStart1.TabIndex = 3;
            this.btnStart1.Text = "START";
            this.btnStart1.UseVisualStyleBackColor = false;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // btnInstructiuni
            // 
            this.btnInstructiuni.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnInstructiuni.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnInstructiuni.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructiuni.Location = new System.Drawing.Point(78, 366);
            this.btnInstructiuni.Name = "btnInstructiuni";
            this.btnInstructiuni.Size = new System.Drawing.Size(176, 47);
            this.btnInstructiuni.TabIndex = 5;
            this.btnInstructiuni.Text = "Instructions";
            this.btnInstructiuni.UseVisualStyleBackColor = false;
            this.btnInstructiuni.Click += new System.EventHandler(this.btnInstructiuni_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHighScore.Location = new System.Drawing.Point(220, 495);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(202, 37);
            this.lblHighScore.TabIndex = 6;
            this.lblHighScore.Text = "0";
            // 
            // btnResetHs
            // 
            this.btnResetHs.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnResetHs.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetHs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResetHs.Location = new System.Drawing.Point(78, 431);
            this.btnResetHs.Name = "btnResetHs";
            this.btnResetHs.Size = new System.Drawing.Size(176, 38);
            this.btnResetHs.TabIndex = 7;
            this.btnResetHs.Text = "Reset HighScore";
            this.btnResetHs.UseVisualStyleBackColor = false;
            this.btnResetHs.Click += new System.EventHandler(this.btnResetHs_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "HighScore :  ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Tetris.Properties.Resources.LauncherBackground03;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1003, 689);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 689);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetHs);
            this.Controls.Add(this.btnInstructiuni);
            this.Controls.Add(this.btnStart1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.Text = "Tetris Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInstructiuni;
        public System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Button btnResetHs;
        public System.Windows.Forms.Label label1;
    }
}

