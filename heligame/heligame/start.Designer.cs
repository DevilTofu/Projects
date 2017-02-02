namespace heligame
{
    partial class start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.picHeli2 = new System.Windows.Forms.PictureBox();
            this.picHeli1 = new System.Windows.Forms.PictureBox();
            this.tmrHeliSwitch = new System.Windows.Forms.Timer(this.components);
            this.btnInstructions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeli2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeli1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStart.Font = new System.Drawing.Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(12, 319);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(495, 134);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHighScore
            // 
            this.btnHighScore.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHighScore.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScore.ForeColor = System.Drawing.Color.White;
            this.btnHighScore.Location = new System.Drawing.Point(513, 319);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(231, 64);
            this.btnHighScore.TabIndex = 1;
            this.btnHighScore.Text = "High Scores";
            this.btnHighScore.UseVisualStyleBackColor = false;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(516, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(199, 41);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Player Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.SteelBlue;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(523, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 40);
            this.txtName.TabIndex = 4;
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(19, 3);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(594, 310);
            this.picTitle.TabIndex = 5;
            this.picTitle.TabStop = false;
            // 
            // picHeli2
            // 
            this.picHeli2.BackColor = System.Drawing.Color.Transparent;
            this.picHeli2.Image = ((System.Drawing.Image)(resources.GetObject("picHeli2.Image")));
            this.picHeli2.Location = new System.Drawing.Point(442, 88);
            this.picHeli2.Name = "picHeli2";
            this.picHeli2.Size = new System.Drawing.Size(100, 78);
            this.picHeli2.TabIndex = 6;
            this.picHeli2.TabStop = false;
            // 
            // picHeli1
            // 
            this.picHeli1.BackColor = System.Drawing.Color.Transparent;
            this.picHeli1.Image = ((System.Drawing.Image)(resources.GetObject("picHeli1.Image")));
            this.picHeli1.Location = new System.Drawing.Point(640, 174);
            this.picHeli1.Name = "picHeli1";
            this.picHeli1.Size = new System.Drawing.Size(85, 88);
            this.picHeli1.TabIndex = 7;
            this.picHeli1.TabStop = false;
            // 
            // tmrHeliSwitch
            // 
            this.tmrHeliSwitch.Enabled = true;
            this.tmrHeliSwitch.Interval = 500;
            this.tmrHeliSwitch.Tick += new System.EventHandler(this.tmrheliSwitch_Tick);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInstructions.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.Color.White;
            this.btnInstructions.Location = new System.Drawing.Point(513, 389);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(231, 64);
            this.btnInstructions.TabIndex = 9;
            this.btnInstructions.Text = "How to Play";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(756, 465);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.picHeli2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.picHeli1);
            this.DoubleBuffered = true;
            this.Name = "start";
            this.Text = "Spongebob Adventures";
            this.Load += new System.EventHandler(this.start_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.start_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeli2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeli1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picHeli2;
        private System.Windows.Forms.PictureBox picHeli1;
        private System.Windows.Forms.Timer tmrHeliSwitch;
        private System.Windows.Forms.Button btnInstructions;
    }
}