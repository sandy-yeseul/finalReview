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

            Random rand = new Random();
            string fName = firstNames[rand.Next(0, firstNames.Length - 1)];
            string lName = lastNames[rand.Next(0, lastNames.Length - 1)];

            FirstNameDataLabel.Text = fName;
            LastNameDataLabel.Text = lName;

            CharacterPortfolio characterPortfolio = new CharacterPortfolio(fName, lName);

        }
        /// <summary>
        /// This is event handler to generate random abilities level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            string strength = ""+ rand.Next(0, 10);
            StrengthDataLabel.Text = strength;
            string dexeterity = "" + rand.Next(0, 10);
            DexeterityDataLabel.Text = dexeterity;
            string endurance = "" + rand.Next(0, 10);
            EnduranceDataLabel.Text = endurance;
            string intellect = "" + rand.Next(0, 10);
            IntellectDataLabel.Text = intellect;
            string education = "" + rand.Next(0, 10);
            EducationDataLabel.Text = education;
            string socialStanding = "" + rand.Next(0, 10);
            SocialstandingDataLabel.Text = socialStanding;
            CharacterPortfolio characterPortfolio = new CharacterPortfolio(strength, dexeterity, endurance, intellect, education, socialStanding);
        }
        /// <summary>
        /// This is event handler for generating random skills
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateSkillsButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] skills = File.ReadAllLines(@"..\..\Data\skills.txt");
            string firstSkillNam = skills[rand.Next(0, skills.Length - 1)];
            string secondSkillNam = skills[rand.Next(0, skills.Length - 1)];
            if (secondSkillNam == firstSkillNam)
            {
                while(secondSkillNam != firstSkillNam)
                {
                    secondSkillNam = skills[rand.Next(0, skills.Length - 1)];
                }
            }
            string firstSkillLev = "" + rand.Next(0, 10);
            string secondSkillLev = "" + rand.Next(0, 10);
            FirstSkillNameDataLabel.Text = firstSkillNam;
            FirstSkillLevelDataLabel.Text = firstSkillLev;
            SecondSkillNameDataLabel.Text = secondSkillNam;
            SecondSkillLevelDataLabel.Text = secondSkillLev;
            CharacterPortfolio characterPortfolio = new CharacterPortfolio(firstSkillNam, firstSkillLev);
            characterPortfolio = new CharacterPortfolio(secondSkillNam, secondSkillLev);
        }
    }
}
