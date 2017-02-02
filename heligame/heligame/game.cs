/* Programmers: Daniel Kim and Kevin Choi
 * Date: December 21, 2011
 * Purpose: Helicopter Game
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace heligame
{
    public partial class game : Form
    {
        bool upPressed = false; //tells comp. if user is clicking a button or not
        int verticalSpeed = 3; //speed that heli will go down
        int blockSpeed = 2; //speed of blocks 1, 2 and 3
        int score = 0; //counts user's score
        int heliCurrent = 1; //tells comp. which heli is currently displayed
        string playersName; //tells comp. the name of the user. (txtName from start)

        public game(string playerName)
        {
            InitializeComponent();

            //bring txtName.text from start menu into game form
            playersName = playerName;
        }

        private void tmrBg_Tick(object sender, EventArgs e)
        {
            //moves background (top and bottom) to the left by same speed as blocks
            picBgBottom1.Left += - blockSpeed;
            picBgBottom2.Left += - blockSpeed;
            picBgTop1.Left += - blockSpeed;
            picBgTop2.Left += - blockSpeed;

            if (picBgBottom1.Right <= 0)
            {
                //changing position of bgBottom1
                picBgBottom1.Left = this.Right;
            }

            if (picBgBottom2.Right <= 0)
            {
                //changing position of bgBottom2
                picBgBottom2.Left = this.Right;
            }

            if (picBgTop1.Right <= 0)
            {
                //changing position of bgTop1
                picBgTop1.Left = this.Right;
            }

            if (picBgTop2.Right <= 0)
            {
                //changing position of bgTop2
                picBgTop2.Left = this.Right;
            }
        }

        private void tmrVerticalSpeed_Tick(object sender, EventArgs e)
        {
            if (upPressed == true)
            {
                //bring spongebob up if user clicks up button
                verticalSpeed = verticalSpeed - 1;
            }

            picHeli1.Top = picHeli1.Top + verticalSpeed;
            picHeli2.Top = picHeli2.Top + verticalSpeed;
        }

        private void tmrScore_Tick(object sender, EventArgs e)
        {
            //counting score
            score = score + 1;
            lblScore.Text = " " + score;

            if (score > 1000)
            {
                //increase speed of blocks, heli.
                blockSpeed = 4;
                verticalSpeed = 4;

                if (upPressed == true)
                {
                    verticalSpeed = verticalSpeed - 7;
                    tmrVerticalSpeed.Interval = 20;
                }
            }

            if (score > 2000)
            {
                //increase speed of blocks, heli, timers
                blockSpeed = 6;
                verticalSpeed = 6;
                picBgBottom1.Left += -5;
                picBgBottom2.Left += -5;
                picBgTop1.Left += -5;
                picBgTop2.Left += -5;

                if (upPressed == true)
                {
                    verticalSpeed = verticalSpeed - 12;
                    tmrVerticalSpeed.Interval = 16;
                }
            }

            if (score > 2500)
            {
                //increase speed of blocks, heli, timers
                blockSpeed = 7;
                verticalSpeed = 7;
                picBgBottom1.Left += -6;
                picBgBottom2.Left += -6;
                picBgTop1.Left += -6;
                picBgTop2.Left += -6;

                if (upPressed == true)
                {
                    verticalSpeed = verticalSpeed - 14;
                    tmrVerticalSpeed.Interval = 12;
                }
            }

            if (score > 5000)
            {
                //increase speed of blocks, heli, timers
                blockSpeed = 10;
                verticalSpeed = 10;
                picBgBottom1.Left += -4;
                picBgBottom2.Left += -4;
                picBgTop1.Left += -4;
                picBgTop2.Left += -4;

                if (upPressed == true)
                {
                    verticalSpeed = verticalSpeed - 20;
                    tmrVerticalSpeed.Interval = 1;
                }
            }
        }



        private void tmrBlock_Tick(object sender, EventArgs e)
        {
            //move blocks to the left by speed of blockSpeed
            picBlock1.Left += -blockSpeed;
            picBlock2.Left += -blockSpeed;
            picBlock3.Left += -blockSpeed;

            if (picBlock1.Right <= 0)
            {
                //changing position of block1
                Random img = new Random();
                int randomLocation = (img.Next() % this.Height) - picBlock1.Height;
                picBlock1.Left = this.Right;
                picBlock1.Top = randomLocation;
            }

            if (picBlock2.Right <= 0)
            {
                //changing position of block2
                Random img = new Random();
                int randomLocation = (img.Next() % this.Height) - picBlock1.Height;
                picBlock2.Left = this.Right;
                picBlock2.Top = randomLocation;
            }

            if (picBlock3.Right <= 0)
            {
                //changing position of block3
                Random img = new Random();
                int randomLocation = (img.Next() % this.Height) - picBlock1.Height;
                picBlock3.Left = this.Right;
                picBlock3.Top = randomLocation;
            }

            if (heliCurrent == 1)
            {
                ///
                ///HELI 1 CRASHING CODE
                ///

                if ((picHeli1.Right >= picBlock1.Left && picHeli1.Right <= picBlock1.Right) && (picHeli1.Bottom >= picBlock1.Top && picHeli1.Top <= picBlock1.Bottom) || picHeli1.Bottom >= picBlock1.Top && picHeli1.Top <= picBlock1.Bottom && picHeli1.Left <= picBlock1.Right && picHeli1.Right >= picBlock1.Left)
                {
                    //heli crashes when any of the above statements are true
                    //disable heli movement, all timers
                    //change heli image to crash image & hide heli image
                    upPressed = false;
                    verticalSpeed = 0;

                    tmrScore.Enabled = false;
                    tmrBg.Enabled = false;
                    tmrHeliSwitch.Enabled = false;
                    tmrBlock.Enabled = false;
                    tmrVerticalSpeed.Enabled = false;

                    picCrash.Left = picHeli1.Left;
                    picCrash.Top = picHeli1.Top;

                    picCrash.Visible = true;
                    picHeli1.Visible = false;

                    System.Windows.Forms.MessageBox.Show("Spongebob Died. FINAL SCORE: " + score);

                    //message box shows user has crashed
                    using (StreamWriter hsw = new StreamWriter("highScores.txt", true))
                    {
                        //save user's score to view in high scores list
                        if (playersName.Equals(""))
                        {
                            playersName = "No Name";
                        }

                        hsw.WriteLine(playersName);
                        hsw.WriteLine("Score: " + score);
                        hsw.WriteLine(" ");

                    }
                    //open highscores menu and hide this form
                    highscores highScores = new highscores();
                    highScores.Show();
                    this.Hide();
                }

                else if ((picHeli1.Right >= picBlock2.Left && picHeli1.Right <= picBlock2.Right) && (picHeli1.Bottom >= picBlock2.Top && picHeli1.Top <= picBlock2.Bottom) || picHeli1.Bottom >= picBlock2.Top && picHeli1.Top <= picBlock2.Bottom && picHeli1.Left <= picBlock2.Right && picHeli1.Right >= picBlock2.Left)
                {
                    //heli crashes when any of the above statements are true
                    //disable heli movement, all timers
                    //change heli image to crash image & hide heli image
                    upPressed = false;
                    verticalSpeed = 0;

                    tmrScore.Enabled = false;
                    tmrBg.Enabled = false;
                    tmrHeliSwitch.Enabled = false;
                    tmrBlock.Enabled = false;
                    tmrVerticalSpeed.Enabled = false;

                    picCrash.Left = picHeli1.Left;
                    picCrash.Top = picHeli1.Top;

                    picCrash.Visible = true;
                    picHeli1.Visible = false;

                    //message box shows user has crashed
                    System.Windows.Forms.MessageBox.Show("Spongebob Died. FINAL SCORE: " + score);

                    using (StreamWriter hsw = new StreamWriter("highScores.txt", true))
                    {
                        //save user's score to view in high scores list
                        if (playersName.Equals(""))
                        {
                            playersName = "No Name";
                        }

                        hsw.WriteLine(playersName);
                        hsw.WriteLine("Score: " + score);
                        hsw.WriteLine(" ");

                    }
                    //open highscores menu and hide this form
                    highscores highScores = new highscores();
                    highScores.Show();
                    this.Hide();
                }
                else if ((picHeli1.Right >= picBlock3.Left && picHeli1.Right <= picBlock3.Right) && (picHeli1.Bottom >= picBlock3.Top && picHeli1.Top <= picBlock3.Bottom) || picHeli1.Bottom >= picBlock3.Top && picHeli1.Top <= picBlock3.Bottom && picHeli1.Left <= picBlock3.Right && picHeli1.Right >= picBlock3.Left)
                {
                    //heli crashes when any of the above statements are true
                    //disable heli movement, all timers
                    //change heli image to crash image & hide heli image
                    upPressed = false;
                    verticalSpeed = 0;

                    tmrScore.Enabled = false;
                    tmrBg.Enabled = false;
                    tmrHeliSwitch.Enabled = false;
                    tmrBlock.Enabled = false;
                    tmrVerticalSpeed.Enabled = false;

                    picCrash.Left = picHeli1.Left;
                    picCrash.Top = picHeli1.Top;

                    picCrash.Visible = true;
                    picHeli1.Visible = false;

                    //message box shows user has crashed
                    System.Windows.Forms.MessageBox.Show("Spongebob Died. FINAL SCORE: " + score);

                    using (StreamWriter hsw = new StreamWriter("highScores.txt", true))
                    {
                        //save user's score to view in high scores list
                        if (playersName.Equals(""))
                        {
                            playersName = "No Name";
                        }

                        hsw.WriteLine(playersName);
                        hsw.WriteLine("Score: " + score);
                        hsw.WriteLine(" ");

                    }
                    //open highscores menu and hide this form
                    highscores highScores = new highscores();
                    highScores.Show();
                    this.Hide();
                }

                else if (picHeli1.Top + picHeli1.Height <= picBgTop1.Bottom || picHeli1.Top + picHeli1.Height <= picBgTop2.Bottom)
                {
                    //heli crashes when any of the above statements are true
                    //disable heli movement, all timers
                    //change heli image to crash image & hide heli image
                    upPressed = false;
                    verticalSpeed = 0;

                    tmrScore.Enabled = false;
                    tmrBg.Enabled = false;
                    tmrHeliSwitch.Enabled = false;
                    tmrBlock.Enabled = false;
                    tmrVerticalSpeed.Enabled = false;

                    picCrash.Left = picHeli1.Left;
                    picCrash.Top = picHeli1.Top;

                    picCrash.Visible = true;
                    picHeli1.Visible = false;

                    //message box shows user has crashed
                    System.Windows.Forms.MessageBox.Show("Spongebob Died. FINAL SCORE: " + score);

                    using (StreamWriter hsw = new StreamWriter("highScores.txt", true))
                    {
                        //save user's score to view in high scores list
                        if (playersName.Equals(""))
                        {
                            playersName = "No Name";
                        }

                        hsw.WriteLine(playersName);
                        hsw.WriteLine("Score: " + score);
                        hsw.WriteLine(" ");

                    }
                    //open highscores menu and hide this form
                    highscores highScores = new highscores();
                    highScores.Show();
                    this.Hide();
                }

                else if (picHeli1.Top + picHeli1.Height >= picBgBottom1.Top || picHeli1.Top + picHeli1.Height >= picBgBottom2.Top)
                {
                    //heli crashes when any of the above statements are true
                    //disable heli movement, all timers
                    //change heli image to crash image & hide heli image
                    upPressed = false;
                    verticalSpeed = 0;

                    tmrScore.Enabled = false;
                    tmrBg.Enabled = false;
                    tmrHeliSwitch.Enabled = false;
                    tmrBlock.Enabled = false;
                    tmrVerticalSpeed.Enabled = false;

                    picCrash.Left = picHeli1.Left;
                    picCrash.Top = picHeli1.Top;

                    picCrash.Visible = true;
                    picHeli1.Visible = false;

                    //message box shows user has crashed
                    System.Windows.Forms.MessageBox.Show("Spongebob Died. FINAL SCORE: " + score);

                    using (StreamWriter hsw = new StreamWriter("highScores.txt", true))
                    {
                        //save user's score to view in high scores list
                        if (playersName.Equals(""))
                        {
                            playersName = "No Name";
                        }

                        hsw.WriteLine(playersName);
                        hsw.WriteLine("Score: " + score);
                        hsw.WriteLine(" ");

                    }
                    //open highscores menu and hide this form
                    highscores highScores = new highscores();
                    highScores.Show();
                    this.Hide();
                }
            }


            else
            {
                ///
                ///HELI 2 CRASHING CODE
                ///

                if ((picHeli2.Right >= picBlock1.Left && picHeli2.Right <= picBlock1.Right) && (picHeli2.Bottom >= picBlock1.Top && picHeli2.Top <= picBlock1.Bottom) || picHeli2.Bottom >= picBlock1.Top && picHeli2.Top <= picBlock1.Bottom && picHeli2.Left <= picBlock1.Right && picHeli2.Right >= picBlock1.Left)
                {
                    //heli crashes when any of the above statements are true
                    //disable heli movement, all timers
                    //change heli image to crash image & hide heli image
                    upPressed = false;
                    verticalSpeed = 0;

                    tmrScore.Enabled = false;
                    tmrBg.Enabled = false;
                    tmrHeliSwitch.Enabled = false;
                    tmrBlock.Enabled = false;
                    tmrVerticalSpeed.Enabled = false;

                    picCrash.Left = picHeli2.Left;
                    picCrash.Top = picHeli2.Top;

                    picCrash.Visible = true;
                    picHeli2.Visible = false;

                    //message box shows user has crashed
                    System.Windows.Forms.MessageBox.Show("Spongebob Died. FINAL SCORE: " + score);

                    using (StreamWriter hsw = new StreamWriter("highScores.txt", true))
                    {
                        //save user's score to view in high scores list
                        if (playersName.Equals(""))
                        {
                            playersName = "No Name";
                        }

                        hsw.WriteLine(playersName);
                        hsw.WriteLine("Score: " + score);
                        hsw.WriteLine(" ");

                    }
                    //open highscores menu and hide this form
                    highscores highScores = new highscores();
                    highScores.Show();
                    this.Hide();
                }

                else if ((picHeli2.Right >= picBlock2.Left && picHeli2.Right <= picBlock2.Right) && (picHeli2.Bottom >= picBlock2.Top && picHeli2.Top <= picBlock2.Bottom) || picHeli2.Bottom >= picBlock2.Top && picHeli2.Top <= picBlock2.Bottom && picHeli2.Left <= picBlock2.Right && picHeli2.Right >= picBlock2.Left)
                {
                    //heli crashes when any of the above statements are true
                    //disable heli movement, all timers
                    //change heli image to crash image & hide heli image
                    upPressed = false;
                    verticalSpeed = 0;

                    tmrScore.Enabled = false;
                    tmrBg.Enabled = false;
                    tmrHeliSwitch.Enabled = false;
                    tmrBlock.Enabled = false;
                    tmrVerticalSpeed.Enabled = false;

                    picCrash.Left = picHeli2.Left;
                    picCrash.Top = picHeli2.Top;

                    picCrash.Visible = true;
                    picHeli2.Visible = false;

                    //message box shows user has crashed
                    System.Windows.Forms.MessageBox.Show("Spongebob Died. FINAL SCORE: " + score);

                    using (StreamWriter hsw = new StreamWriter("highScores.txt", true))
                    {
                        //save user's score to view in high scores list
                        if (playersName.Equals(""))
                        {
                            playersName = "No Name";
                        }

                        hsw.WriteLine(playersName);
                        hsw.WriteLine("Score: " + score);
                        hsw.WriteLine(" ");

                    }
                    //open highscores menu and hide this form
                    highscores highScores = new highscores();
                    highScores.Show();
                    this.Hide();
                }
                else if ((picHeli2.Right >= picBlock3.Left && picHeli2.Right <= picBlock3.Right) && (picHeli2.Bottom >= picBlock3.Top && picHeli2.Top <= picBlock3.Bottom) || picHeli2.Bottom >= picBlock3.Top && picHeli2.Top <= picBlock3.Bottom && picHeli2.Left <= picBlock3.Right && picHeli2.Right >= picBlock3.Left)
                {
                    //heli crashes when any of the above statements are true
                    //disable heli movement, all timers
                    //change heli image to crash image & hide heli image
                    upPressed = false;
                    verticalSpeed = 0;

                    tmrScore.Enabled = false;
                    tmrBg.Enabled = false;
                    tmrHeliSwitch.Enabled = false;
                    tmrBlock.Enabled = false;
                    tmrVerticalSpeed.Enabled = false;

                    picCrash.Left = picHeli2.Left;
                    picCrash.Top = picHeli2.Top;

                    picCrash.Visible = true;
                    picHeli2.Visible = false;

                    //message box shows user has crashed
                    System.Windows.Forms.MessageBox.Show("Spongebob Died. FINAL SCORE: " + score);

                    using (StreamWriter hsw = new StreamWriter("highScores.txt", true))
                    {
                        //save user's score to view in high scores list
                        if (playersName.Equals(""))
                        {
                            playersName = "No Name";
                        }

                        hsw.WriteLine(playersName);
                        hsw.WriteLine("Score: " + score);
                        hsw.WriteLine(" ");

                    }
                    //open highscores menu and hide this form
                    highscores highScores = new highscores();
                    highScores.Show();
                    this.Hide();
                }

                else if (picHeli2.Top <= picBgTop1.Bottom || picHeli2.Top <= picBgTop2.Bottom)
                {
                    //heli crashes when any of the above statements are true
                    //disable heli movement, all timers
                    //change heli image to crash image & hide heli image
                    upPressed = false;
                    verticalSpeed = 0;

                    tmrScore.Enabled = false;
                    tmrBg.Enabled = false;
                    tmrHeliSwitch.Enabled = false;
                    tmrBlock.Enabled = false;
                    tmrVerticalSpeed.Enabled = false;

                    picCrash.Left = picHeli2.Left;
                    picCrash.Top = picHeli2.Top;

                    picCrash.Visible = true;
                    picHeli2.Visible = false;

                    //message box shows user has crashed
                    System.Windows.Forms.MessageBox.Show("Spongebob Died. FINAL SCORE: " + score);

                    using (StreamWriter hsw = new StreamWriter("highScores.txt", true))
                    {
                        //save user's score to view in high scores list
                        if (playersName.Equals(""))
                        {
                            playersName = "No Name";
                        }

                        hsw.WriteLine(playersName);
                        hsw.WriteLine("Score: " + score);
                        hsw.WriteLine(" ");

                    }
                    //open highscores menu and hide this form
                    highscores highScores = new highscores();
                    highScores.Show();
                    this.Hide();
                }

                else if (picHeli2.Top + picHeli2.Height >= picBgBottom1.Top || picHeli2.Top + picHeli2.Height >= picBgBottom2.Top)
                {
                    //heli crashes when any of the above statements are true
                    //disable heli movement, all timers
                    //change heli image to crash image & hide heli image
                    upPressed = false;
                    verticalSpeed = 0;

                    tmrScore.Enabled = false;
                    tmrBg.Enabled = false;
                    tmrHeliSwitch.Enabled = false;
                    tmrBlock.Enabled = false;
                    tmrVerticalSpeed.Enabled = false;

                    picCrash.Left = picHeli2.Left;
                    picCrash.Top = picHeli2.Top;

                    picCrash.Visible = true;
                    picHeli2.Visible = false;

                    //message box shows user has crashed
                    System.Windows.Forms.MessageBox.Show("Spongebob Died. FINAL SCORE: " + score);

                    using (StreamWriter hsw = new StreamWriter("highScores.txt", true))
                    {
                        //save user's score to view in high scores list
                        if (playersName.Equals(""))
                        {
                            playersName = "No Name";
                        }

                        hsw.WriteLine(playersName);
                        hsw.WriteLine("Score: " + score);
                        hsw.WriteLine(" ");

                    }

                    //open highscores menu and hide this form
                    highscores highScores = new highscores();
                    highScores.Show();
                    this.Hide();

                }
            }
        }

        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                //if user presses up arrow key, upPressed is true, meaning heli will move up
                upPressed = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                //if user presses ESC, open options menu and disable all movement
                upPressed = false;
                verticalSpeed = 0;

                tmrScore.Enabled = false;
                tmrBg.Enabled = false;
                tmrHeliSwitch.Enabled = false;
                tmrBlock.Enabled = false;
                tmrVerticalSpeed.Enabled = false;

                Options options = new Options(tmrScore, tmrBg, tmrHeliSwitch, tmrBlock, tmrVerticalSpeed, verticalSpeed, upPressed);
                options.Show();
            }
        }

        private void heligame_KeyUp(object sender, KeyEventArgs e)
        {
            //if user releases/is not pressing up arrow key, heli keeps descending
            upPressed = false;
            verticalSpeed = 3;
        }

        private void tmrHeliSwitch_Tick(object sender, EventArgs e)
        {
            if (picHeli2.Visible == false)
            {
                //switch to heli2 (looks like swimming)
                picHeli2.Left = picHeli1.Left;
                picHeli2.Top = picHeli1.Top;

                picHeli2.Visible = true;
                picHeli1.Visible = false;

                heliCurrent = 2;
            }

            else
            {
                //switch to heli (looks like swimming)
                picHeli1.Left = picHeli2.Left;
                picHeli1.Top = picHeli2.Top;

                picHeli1.Visible = true;
                picHeli2.Visible = false;
                heliCurrent = 1;
            }
        }

        private void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            //end whole application when this form is closed (user clicks x)
            Application.Exit();
        }

        private void game_Load(object sender, EventArgs e)
        {

        }
    }
}
