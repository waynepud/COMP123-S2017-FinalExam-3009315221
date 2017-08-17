using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Wayne Pud
 * Date: Aug 8th, 2017
 * StudentID: 300931522 
 * Description: This is the program driver class
 * Version: 1.0 - Created template and project with student ID renamed
 */

namespace COMP123_S2017_FinalExam_3009315221
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PickHighestCardForm());
        }
    }
}
