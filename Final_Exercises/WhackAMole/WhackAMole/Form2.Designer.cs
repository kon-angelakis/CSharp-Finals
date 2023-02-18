namespace WhackAMole
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.posTimer = new System.Windows.Forms.Timer(this.components);
            this.remTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyPic = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPic)).BeginInit();
            this.SuspendLayout();
            // 
            // posTimer
            // 
            this.posTimer.Tick += new System.EventHandler(this.posTimer_Tick);
            // 
            // remTimer
            // 
            this.remTimer.Interval = 1000;
            this.remTimer.Tick += new System.EventHandler(this.remTimer_Tick);
            // 
            // enemyPic
            // 
            this.enemyPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemyPic.BackgroundImage")));
            this.enemyPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyPic.Location = new System.Drawing.Point(310, 130);
            this.enemyPic.Name = "enemyPic";
            this.enemyPic.Size = new System.Drawing.Size(150, 150);
            this.enemyPic.TabIndex = 0;
            this.enemyPic.TabStop = false;
            this.enemyPic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.enemyPic_MouseClick);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(700, 430);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 1;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(10, 430);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(55, 13);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: 0";
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitButton.Location = new System.Drawing.Point(10, 10);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 25);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(215)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.enemyPic);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enemyPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer posTimer;
        private System.Windows.Forms.Timer remTimer;
        private System.Windows.Forms.PictureBox enemyPic;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button quitButton;
    }
}