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
            string[] firstNameArray = File.ReadAllLines(@"..\..\Data\firstNames.txt");
            string[] lastNameArray = File.ReadAllLines(@"..\..\Data\lastNames.txt");

            Random rand = new Random();
            string fName = firstNameArray[rand.Next(0, firstNameArray.Length - 1)];
            string lName = lastNameArray[rand.Next(0, lastNameArray.Length - 1)];

            FirstNameDataLabel.Text = fName;
            LastNameDataLabel.Text = lName;

            Program.character.Identity.FirstName = fName;
            Program.character.Identity.LastName = lName;
            FirstNameDataLabel.Text = Program.character.Identity.FirstName;
            LastNameDataLabel.Text = Program.character.Identity.LastName;

        }
        /// <summary>
        /// This is event handler to generate random abilities level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            string strength = ""+ rand.Next(1, 16);
            string dexeterity = "" + rand.Next(1, 16);
            string endurance = "" + rand.Next(1, 16);
            string intellect = "" + rand.Next(1, 16);
            string education = "" + rand.Next(1, 16);
            string socialStanding = "" + rand.Next(1, 16);

            Program.character.Strength = strength;
            Program.character.Dexterity = dexeterity;
            Program.character.Endurance = endurance;
            Program.character.Intellect = intellect;
            Program.character.Education = education;
            Program.character.SocialStanding = socialStanding;

            StrengthDataLabel.Text = Program.character.Strength;
            DexeterityDataLabel.Text = Program.character.Dexterity;
            EnduranceDataLabel.Text = Program.character.Endurance;
            IntellectDataLabel.Text = Program.character.Intellect;
            EducationDataLabel.Text = Program.character.Education;
            SocialstandingDataLabel.Text = Program.character.SocialStanding;

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
            string firstSkillName = skills[rand.Next(0, skills.Length - 1)];
            string secondSkillName = skills[rand.Next(0, skills.Length - 1)];
            string thirdSkillName = skills[rand.Next(0, skills.Length - 1)];
            string fourthSkillName = skills[rand.Next(0, skills.Length - 1)];
            

            string firstSkillLev = "" + rand.Next(1, 16);
            string secondSkillLev = "" + rand.Next(1, 16);
            string thirdSkillLev = "" + rand.Next(1, 16);
            string fourthSkillLev = "" + rand.Next(1, 16);

            FirstSkillNameDataLabel.Text = firstSkillName;
            SecondSkillNameDataLabel.Text = secondSkillName;
            ThirdSkillNameDataLabel.Text = thirdSkillName;
            FourthSkillNameDataLabel.Text = fourthSkillName;

            FirstSkillLevelDataLabel.Text = firstSkillLev;
            SecondSkillLevelDataLabel.Text = secondSkillLev;
            ThirdSkillLevelDataLabel.Text = thirdSkillLev;
            FourthSkillLevelDataLabel.Text = fourthSkillLev;
        }
    }
}
