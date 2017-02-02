/* Programmers: Daniel Kim and Kevin Choi
 * Date: January 19, 2012
 * Purpose: Options menu for the heli game. (press ESC)
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
    public partial class Options : Form
    {
        int counter = 2, verticalSpeed1;
        bool upPressed1;
        Timer tmrScore1, tmrBg1, tmrHeliSwitch1, tmrBlock1, tmrVerticalSpeed1;

        public Options(Timer tmrScore, Timer tmrBg, Timer tmrHeliSwitch, Timer tmrBlock, Timer tmrVerticalSpeed, int verticalSpeed, bool upPressed)
        {
            //bring all timers/score/upPressed into Options so that we can re-enable them when user exits
            InitializeComponent();

            tmrScore1 = tmrScore;
            tmrBg1 = tmrBg;
            tmrHeliSwitch1 = tmrHeliSwitch;
            tmrBlock1 = tmrBlock;
            tmrVerticalSpeed1 = tmrVerticalSpeed;
            verticalSpeed1 = verticalSpeed;
            upPressed1 = upPressed;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            //resume everything when user presses this button
            tmrScore1.Enabled = true;
            tmrBg1.Enabled = true;
            tmrHeliSwitch1.Enabled = true;
            tmrBlock1.Enabled = true;
            tmrVerticalSpeed1.Enabled = true;

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //end whole program when user clicks exit 
            Application.Exit();
        }
    }
}
