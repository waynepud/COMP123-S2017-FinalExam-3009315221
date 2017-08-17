using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Wayne Pud
 * Date: Aug 17th, 2017
 * StudentID: 300931522 
 * Description: This is the program driver class
 * Version: 1.1 - Changed application run to splashform and created reference pickHighestCardForm used in splashform
 */

namespace COMP123_S2017_FinalExam_3009315221
{
    public static class Program
    {
        //This is a reference to the forms
        public static PickHighestCardForm pickHighestCardForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            pickHighestCardForm = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
