using finalReview.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            if (MainTabControl.SelectedIndex == 3)
            {
                CreateCharacterSheet();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is event handler for generating names
        /// Read the files and create array, generate random numbers and make random name  and saving to Program.Character
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
        /// This is event handler to generate random abilities level and saving to Program.Character
        /// </summary>
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

        private void NameDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void CharacterGenerationForm_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// This is an generating Character Sheet
        /// </summary>
        private void CreateCharacterSheet()
        {
            string name = Program.character.Identity.FirstName + " " +Program.character.Identity.LastName;
            NameDataLabel.Text = name;

            string abilities =
                "Strength: " + Program.character.Strength + ", " +
                "Dexterity: " + Program.character.Dexterity + ", " +
                "Endurance: " + Program.character.Endurance + ", " +
                "Intellect: " + Program.character.Intellect + ", " +
                "Education: " + Program.character.Education + ", " +
                "Social Standing: " + Program.character.SocialStanding;
            AbilitiesDataLabel.Text = abilities;

            string skills = 
                FirstSkillNameDataLabel.Text + ": " + FirstSkillLevelDataLabel.Text + ", " +
                SecondSkillNameDataLabel.Text + ": " + SecondSkillLevelDataLabel.Text + ", " +
                ThirdSkillNameDataLabel.Text + ": " + ThirdSkillLevelDataLabel.Text + ", " +
                FourthSkillNameDataLabel.Text + ": " + FourthSkillLevelDataLabel.Text ;
            SkillsDataLabel.Text = skills;


        }
        /// <summary>
        /// This is the event handler to save the file(BUT can I just copy your code to mine?)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // configure the file dialog
            saveFileDialog.FileName = "CharacterSheet.txt";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = saveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open the stream for writing
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(saveFileDialog.FileName, FileMode.Create)))
                {
                    // write content - string type - to the file
                    outputStream.WriteLine(Program.character.Identity.FirstName);
                    outputStream.WriteLine(Program.character.Identity.LastName);
                    outputStream.WriteLine(Program.character.Strength);
                    outputStream.WriteLine(Program.character.Dexterity);
                    outputStream.WriteLine(Program.character.Endurance);
                    outputStream.WriteLine(Program.character.Intellect);
                    outputStream.WriteLine(Program.character.Education);
                    outputStream.WriteLine(Program.character.SocialStanding);
                    outputStream.WriteLine(SkillsDataLabel.Text);


                    // cleanup
                    outputStream.Close();
                    outputStream.Dispose();

                    // give feedback to the user that the file has been saved
                    // this is a "modal" form
                    MessageBox.Show("File Saved...", "Saving File...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// This is the event handler to open the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // configure the file dialog
            openFileDialog.FileName = "CharacterSheet.txt";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = openFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // Open the  streawm for reading
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(openFileDialog.FileName, FileMode.Open)))
                    {
                        // read from the file
                        Program.character.Identity.FirstName = inputStream.ReadLine();
                        Program.character.Identity.LastName = inputStream.ReadLine();
                        Program.character.Strength = inputStream.ReadLine();
                        Program.character.Dexterity = inputStream.ReadLine();
                        Program.character.Endurance = inputStream.ReadLine();
                        Program.character.Intellect = inputStream.ReadLine();
                        Program.character.Education = inputStream.ReadLine();
                        Program.character.SocialStanding = inputStream.ReadLine();
                        SkillsDataLabel.Text = inputStream.ReadLine();

                        // cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }

                    NextButton_Click(sender, e);
                }
                catch (IOException exception)
                {

                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message + "\n\nPlease select the appropriate file type", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// this is the evnet handler to open about form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBox.ShowDialog();
        }
    }
}
