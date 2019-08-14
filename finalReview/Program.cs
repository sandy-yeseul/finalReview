using finalReview.Objects;
using finalReview.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalReview
{
    public static class Program
    {
        //
        public static CharacterGenerationForm characterForm;
        public static CharacterPortfolio character;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGenerationForm();
            character = new CharacterPortfolio();

            Application.Run(characterForm);
        }
    }
}
