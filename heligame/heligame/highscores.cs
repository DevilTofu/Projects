/* Programmers: Daniel Kim and Kevin Choi
 * Date: January 9, 2012
 * Purpose: High Scores chart for Spongebob Adventures
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
    public partial class highscores : Form
    {
        //variable tells computer what line is being read when previous local scores are being displayed to user
        string currentLine;
        //variable makes fake world high scores
        int[] fakeScores = new int[10];
        //variable makes fake world high score names
        string[] fakeName = new string[10];

        public highscores()
        {
            InitializeComponent();
        }

        private void highscores_Load(object sender, EventArgs e)
        {
            fakeName[0] = "Dave";
            fakeName[1] = "Ken";
            fakeName[2] = "Bob";
            fakeName[3] = "Jenny";
            fakeName[4] = "Claire";
            fakeName[5] = "Joey";
            fakeName[6] = "Terry";
            fakeName[7] = "Lisa";
            fakeName[8] = "Fred";
            fakeName[9] = "Jaden";

            using (StreamReader hsr = new StreamReader("highScores.txt"))
            {
                //read all previously saved scores when highscores.cs runs
                do
                {
                    currentLine = hsr.ReadLine();

                    if (currentLine != null)
                    {
                        //displays high scores to user
                        lsthighScores.Items.Add(currentLine);
                    }

                } while (currentLine != null);
            }

            if (lstWorldHighScores.Text == "")
            {
                for (int index = 0; index < 10; index = index + 1)
                {
                    fakeScores[index] = 999999;
                    lstWorldHighScores.Items.Add(fakeName[index]);
                    lstWorldHighScores.Items.Add("Score: " + fakeScores[index]);
                    Console.WriteLine(" ");
                }
            }
        }

        private void btnScoreClear_Click(object sender, EventArgs e)
        {
            //delete all high scores when user clicks the 'Clear' button
            File.Delete("highScores.txt");
            File.Create("highScores.txt");

            //restart application to be able to create file without "process is being used" error
            System.Windows.Forms.MessageBox.Show("Spongebob Adventures will Restart");
            Application.Restart();
        }

        private void highscores_FormClosed(object sender, FormClosedEventArgs e)
        {
            //fully close application when user exits this window (close all 'hiding' windows)
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //go back to the start menu when user clicks 'Home' button
            start start = new start();
            start.Show();
            this.Hide();
        }
    }
}
