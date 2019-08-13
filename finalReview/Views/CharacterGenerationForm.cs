using finalReview.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
/*
 * Yeseul Kang #301029474
 * Description: This is the main form of the character generation
 */
namespace finalReview
{
    public partial class CharacterGenerationForm : finalReview.Views.MasterForm
    {
        public CharacterGenerationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the back button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }
        /// <summary>
        /// This is the event handler for the next button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count -1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is event handler for generating names
        /// Read the files and create array, generate random numbers and make random name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeneratesNameButton_Click(object sender, EventArgs e)
        {
            
            string[] firstNames = File.ReadAllLines(@"..\..\Data\firstNames.txt");
            string[] lastNames = File.ReadAllLines(@"..\..\Data\lastNames.txt");

            Random fNameRand = new Random();
            string fName = firstNames[fNameRand.Next(0, firstNames.Length - 1)];
            FirstNameDataLabel.Text = fName;

            Random lNameRand = new Random();
            string lName = lastNames[lNameRand.Next(0, lastNames.Length - 1)];
            LastNameDataLabel.Text = lName;

        }
    }
}
