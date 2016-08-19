using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public static class Program
    {
        public static Character character; 
        public static SplashForm splashForm;
        public static GenerateNameForm generateNameForm; 
        public static AbilityGeneratorForm abilityGeneratorForm;

        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


                         character = new Character();
                         splashForm = new SplashForm();
                         generateNameForm = new GenerateNameForm();
                         abilityGeneratorForm = new AbilityGeneratorForm();
                         Application.Run(splashForm);

        }
    }
}
