/* Programmers: Daniel Kim and Kevin Choi
 * Date: January 20, 2012
 * Purpose: Tells user how to play the game
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
    public partial class instructions : Form
    {
        public instructions()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //goes back to homepage when user clicks back button
            start start = new start();
            start.Show();
            this.Hide();
        }
    }
}
