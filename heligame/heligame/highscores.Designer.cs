namespace heligame
{
    partial class highscores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(highscores));
            this.lsthighScores = new System.Windows.Forms.ListBox();
            this.btnScoreClear = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lstWorldHighScores = new System.Windows.Forms.ListBox();
            this.lblWorld = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsthighScores
            // 
            this.lsthighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsthighScores.FormattingEnabled = true;
            this.lsthighScores.ItemHeight = 20;
            this.lsthighScores.Location = new System.Drawing.Point(11, 103);
            this.lsthighScores.Name = "lsthighScores";
            this.lsthighScores.Size = new System.Drawing.Size(222, 184);
            this.lsthighScores.TabIndex = 0;
            // 
            // btnScoreClear
            // 
            this.btnScoreClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnScoreClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreClear.ForeColor = System.Drawing.Color.White;
            this.btnScoreClear.Location = new System.Drawing.Point(256, 293);
            this.btnScoreClear.Name = "btnScoreClear";
            this.btnScoreClear.Size = new System.Drawing.Size(215, 38);
            this.btnScoreClear.TabIndex = 1;
            this.btnScoreClear.Text = "Clear Local Scores";
            this.btnScoreClear.UseVisualStyleBackColor = false;
            this.btnScoreClear.Click += new System.EventHandler(this.btnScoreClear_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(76, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(328, 76);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "HIGHSCORES";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(11, 293);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(81, 38);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lstWorldHighScores
            // 
            this.lstWorldHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWorldHighScores.FormattingEnabled = true;
            this.lstWorldHighScores.ItemHeight = 20;
            this.lstWorldHighScores.Location = new System.Drawing.Point(245, 103);
            this.lstWorldHighScores.Name = "lstWorldHighScores";
            this.lstWorldHighScores.Size = new System.Drawing.Size(231, 184);
            this.lstWorldHighScores.TabIndex = 4;
            // 
            // lblWorld
            // 
            this.lblWorld.AutoSize = true;
            this.lblWorld.BackColor = System.Drawing.Color.Transparent;
            this.lblWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorld.Location = new System.Drawing.Point(407, 80);
            this.lblWorld.Name = "lblWorld";
            this.lblWorld.Size = new System.Drawing.Size(74, 20);
            this.lblWorld.TabIndex = 5;
            this.lblWorld.Text = "WORLD";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.BackColor = System.Drawing.Color.Transparent;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(7, 80);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(66, 20);
            this.lblLocal.TabIndex = 6;
            this.lblLocal.Text = "LOCAL";
            // 
            // highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(483, 337);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblWorld);
            this.Controls.Add(this.lstWorldHighScores);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnScoreClear);
            this.Controls.Add(this.lsthighScores);
            this.Name = "highscores";
            this.Text = "Spongebob Adventures";
            this.Load += new System.EventHandler(this.highscores_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.highscores_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsthighScores;
        private System.Windows.Forms.Button btnScoreClear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ListBox lstWorldHighScores;
        private System.Windows.Forms.Label lblWorld;
        private System.Windows.Forms.Label lblLocal;

    }
}