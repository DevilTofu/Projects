namespace heligame
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.picBgTop1 = new System.Windows.Forms.PictureBox();
            this.picBgBottom1 = new System.Windows.Forms.PictureBox();
            this.picBlock1 = new System.Windows.Forms.PictureBox();
            this.tmrBlock = new System.Windows.Forms.Timer(this.components);
            this.picBlock2 = new System.Windows.Forms.PictureBox();
            this.picBlock3 = new System.Windows.Forms.PictureBox();
            this.picHeli1 = new System.Windows.Forms.PictureBox();
            this.tmrVerticalSpeed = new System.Windows.Forms.Timer(this.components);
            this.tmrScore = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.picBgBottom2 = new System.Windows.Forms.PictureBox();
            this.tmrBg = new System.Windows.Forms.Timer(this.components);
            this.picCrash = new System.Windows.Forms.PictureBox();
            this.picBgSpace = new System.Windows.Forms.PictureBox();
            this.picHeli2 = new System.Windows.Forms.PictureBox();
            this.tmrHeliSwitch = new System.Windows.Forms.Timer(this.components);
            this.picBgTop2 = new System.Windows.Forms.PictureBox();
            this.picBgTopSpace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBgTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeli1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeli2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgTopSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // picBgTop1
            // 
            this.picBgTop1.BackColor = System.Drawing.Color.Transparent;
            this.picBgTop1.Image = ((System.Drawing.Image)(resources.GetObject("picBgTop1.Image")));
            this.picBgTop1.Location = new System.Drawing.Point(0, 0);
            this.picBgTop1.Name = "picBgTop1";
            this.picBgTop1.Size = new System.Drawing.Size(774, 59);
            this.picBgTop1.TabIndex = 0;
            this.picBgTop1.TabStop = false;
            // 
            // picBgBottom1
            // 
            this.picBgBottom1.BackColor = System.Drawing.Color.Transparent;
            this.picBgBottom1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBgBottom1.BackgroundImage")));
            this.picBgBottom1.Location = new System.Drawing.Point(1, 370);
            this.picBgBottom1.Name = "picBgBottom1";
            this.picBgBottom1.Size = new System.Drawing.Size(773, 59);
            this.picBgBottom1.TabIndex = 2;
            this.picBgBottom1.TabStop = false;
            // 
            // picBlock1
            // 
            this.picBlock1.BackColor = System.Drawing.Color.Transparent;
            this.picBlock1.Image = ((System.Drawing.Image)(resources.GetObject("picBlock1.Image")));
            this.picBlock1.Location = new System.Drawing.Point(12, 300);
            this.picBlock1.Name = "picBlock1";
            this.picBlock1.Size = new System.Drawing.Size(71, 50);
            this.picBlock1.TabIndex = 3;
            this.picBlock1.TabStop = false;
            // 
            // tmrBlock
            // 
            this.tmrBlock.Enabled = true;
            this.tmrBlock.Interval = 10;
            this.tmrBlock.Tick += new System.EventHandler(this.tmrBlock_Tick);
            // 
            // picBlock2
            // 
            this.picBlock2.BackColor = System.Drawing.Color.Transparent;
            this.picBlock2.Image = ((System.Drawing.Image)(resources.GetObject("picBlock2.Image")));
            this.picBlock2.Location = new System.Drawing.Point(261, 65);
            this.picBlock2.Name = "picBlock2";
            this.picBlock2.Size = new System.Drawing.Size(80, 66);
            this.picBlock2.TabIndex = 4;
            this.picBlock2.TabStop = false;
            // 
            // picBlock3
            // 
            this.picBlock3.BackColor = System.Drawing.Color.Transparent;
            this.picBlock3.Image = ((System.Drawing.Image)(resources.GetObject("picBlock3.Image")));
            this.picBlock3.Location = new System.Drawing.Point(755, 315);
            this.picBlock3.Name = "picBlock3";
            this.picBlock3.Size = new System.Drawing.Size(52, 49);
            this.picBlock3.TabIndex = 5;
            this.picBlock3.TabStop = false;
            // 
            // picHeli1
            // 
            this.picHeli1.BackColor = System.Drawing.Color.Transparent;
            this.picHeli1.Image = ((System.Drawing.Image)(resources.GetObject("picHeli1.Image")));
            this.picHeli1.Location = new System.Drawing.Point(79, 166);
            this.picHeli1.Name = "picHeli1";
            this.picHeli1.Size = new System.Drawing.Size(82, 84);
            this.picHeli1.TabIndex = 6;
            this.picHeli1.TabStop = false;
            // 
            // tmrVerticalSpeed
            // 
            this.tmrVerticalSpeed.Enabled = true;
            this.tmrVerticalSpeed.Interval = 25;
            this.tmrVerticalSpeed.Tick += new System.EventHandler(this.tmrVerticalSpeed_Tick);
            // 
            // tmrScore
            // 
            this.tmrScore.Enabled = true;
            this.tmrScore.Interval = 20;
            this.tmrScore.Tick += new System.EventHandler(this.tmrScore_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(693, 382);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(81, 35);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "0000";
            // 
            // picBgBottom2
            // 
            this.picBgBottom2.BackColor = System.Drawing.Color.Transparent;
            this.picBgBottom2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBgBottom2.BackgroundImage")));
            this.picBgBottom2.Location = new System.Drawing.Point(772, 370);
            this.picBgBottom2.Name = "picBgBottom2";
            this.picBgBottom2.Size = new System.Drawing.Size(781, 59);
            this.picBgBottom2.TabIndex = 8;
            this.picBgBottom2.TabStop = false;
            // 
            // tmrBg
            // 
            this.tmrBg.Enabled = true;
            this.tmrBg.Interval = 10;
            this.tmrBg.Tick += new System.EventHandler(this.tmrBg_Tick);
            // 
            // picCrash
            // 
            this.picCrash.BackColor = System.Drawing.Color.Transparent;
            this.picCrash.Image = ((System.Drawing.Image)(resources.GetObject("picCrash.Image")));
            this.picCrash.Location = new System.Drawing.Point(200, 92);
            this.picCrash.Name = "picCrash";
            this.picCrash.Size = new System.Drawing.Size(102, 78);
            this.picCrash.TabIndex = 10;
            this.picCrash.TabStop = false;
            this.picCrash.Visible = false;
            // 
            // picBgSpace
            // 
            this.picBgSpace.BackColor = System.Drawing.Color.Transparent;
            this.picBgSpace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBgSpace.BackgroundImage")));
            this.picBgSpace.Location = new System.Drawing.Point(0, 370);
            this.picBgSpace.Name = "picBgSpace";
            this.picBgSpace.Size = new System.Drawing.Size(774, 59);
            this.picBgSpace.TabIndex = 11;
            this.picBgSpace.TabStop = false;
            // 
            // picHeli2
            // 
            this.picHeli2.BackColor = System.Drawing.Color.Transparent;
            this.picHeli2.Image = ((System.Drawing.Image)(resources.GetObject("picHeli2.Image")));
            this.picHeli2.Location = new System.Drawing.Point(64, 65);
            this.picHeli2.Name = "picHeli2";
            this.picHeli2.Size = new System.Drawing.Size(97, 81);
            this.picHeli2.TabIndex = 12;
            this.picHeli2.TabStop = false;
            this.picHeli2.Visible = false;
            // 
            // tmrHeliSwitch
            // 
            this.tmrHeliSwitch.Enabled = true;
            this.tmrHeliSwitch.Interval = 300;
            this.tmrHeliSwitch.Tick += new System.EventHandler(this.tmrHeliSwitch_Tick);
            // 
            // picBgTop2
            // 
            this.picBgTop2.BackColor = System.Drawing.Color.Transparent;
            this.picBgTop2.Image = ((System.Drawing.Image)(resources.GetObject("picBgTop2.Image")));
            this.picBgTop2.Location = new System.Drawing.Point(772, 0);
            this.picBgTop2.Name = "picBgTop2";
            this.picBgTop2.Size = new System.Drawing.Size(788, 59);
            this.picBgTop2.TabIndex = 14;
            this.picBgTop2.TabStop = false;
            // 
            // picBgTopSpace
            // 
            this.picBgTopSpace.BackColor = System.Drawing.Color.Transparent;
            this.picBgTopSpace.Image = ((System.Drawing.Image)(resources.GetObject("picBgTopSpace.Image")));
            this.picBgTopSpace.Location = new System.Drawing.Point(0, 0);
            this.picBgTopSpace.Name = "picBgTopSpace";
            this.picBgTopSpace.Size = new System.Drawing.Size(784, 59);
            this.picBgTopSpace.TabIndex = 13;
            this.picBgTopSpace.TabStop = false;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(785, 426);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picBgTop1);
            this.Controls.Add(this.picBgTop2);
            this.Controls.Add(this.picBgTopSpace);
            this.Controls.Add(this.picBgBottom2);
            this.Controls.Add(this.picBgBottom1);
            this.Controls.Add(this.picHeli2);
            this.Controls.Add(this.picCrash);
            this.Controls.Add(this.picHeli1);
            this.Controls.Add(this.picBlock3);
            this.Controls.Add(this.picBlock2);
            this.Controls.Add(this.picBlock1);
            this.Controls.Add(this.picBgSpace);
            this.DoubleBuffered = true;
            this.Name = "game";
            this.Text = "Spongebob Adventures";
            this.Load += new System.EventHandler(this.game_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.game_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.heligame_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBgTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeli1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeli2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgTopSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBgTop1;
        private System.Windows.Forms.PictureBox picBgBottom1;
        private System.Windows.Forms.PictureBox picBlock1;
        private System.Windows.Forms.Timer tmrBlock;
        private System.Windows.Forms.PictureBox picBlock2;
        private System.Windows.Forms.PictureBox picBlock3;
        private System.Windows.Forms.PictureBox picHeli1;
        private System.Windows.Forms.Timer tmrVerticalSpeed;
        private System.Windows.Forms.Timer tmrScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picBgBottom2;
        private System.Windows.Forms.Timer tmrBg;
        private System.Windows.Forms.PictureBox picCrash;
        private System.Windows.Forms.PictureBox picBgSpace;
        private System.Windows.Forms.PictureBox picHeli2;
        private System.Windows.Forms.Timer tmrHeliSwitch;
        private System.Windows.Forms.PictureBox picBgTop2;
        private System.Windows.Forms.PictureBox picBgTopSpace;
    }
}

