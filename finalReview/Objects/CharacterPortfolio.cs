using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Yeseul Kang #301029474
 * Description: This is the main container class for the application
 */
namespace finalReview.Objects
{
    public class CharacterPortfolio
    {
        //Identity
        public Identity Identity { get; set; }
        
        //characteristics
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Endurance { get; set; }
        public string Intellect { get; set; }
        public string Education { get; set; }
        public string SocialStanding { get; set; }

        //skill list
        List<Skill> Skills;

        //constructor
        public CharacterPortfolio()
        {
            this.Identity = new Identity();
            Skills = new List<Skill>();
        }
    }
}
