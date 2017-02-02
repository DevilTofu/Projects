/* Programmers: Daniel Kim and Kevin Choi
 * Date: January 12, 2012
 * Purpose: Start menu for Spongebob Adventures. (this will run first, before all other forms)
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace heligame
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            //make picHeli2 invisible when form starts. (alternate spongebob)
            picHeli2.Visible = false;
        }

        private void tmrheliSwitch_Tick(object sender, EventArgs e)
        {
            if (picHeli2.Visible == false)
            {
                //switch to heli2 (looks like swimming)
                picHeli2.Left = picHeli1.Left;
                picHeli2.Top = picHeli1.Top;

                picHeli2.Visible = true;
                picHeli1.Visible = false;
            }

            else
            {
                //switch to heli1 (looks like swimming)
                picHeli1.Left = picHeli2.Left;
                picHeli1.Top = picHeli2.Top;

                picHeli1.Visible = true;
                picHeli2.Visible = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //open game form when user clicks btn and hide this form
            //send user's name info to game (so that it can be displayed to the highscores menu later)
            game game = new game(txtName.Text);
            game.Show();
            this.Hide();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            //open highscores form when user clicks btn and hide this form
            highscores highScores = new highscores();
            highScores.Show();
            this.Hide();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //open instructions form when user clicks this button
            instructions instructions = new instructions();
            instructions.Show();
            this.Hide();
        }

        private void start_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit whole program when user clicks 'x' on this window
            Application.Exit();
        }
    }
}
