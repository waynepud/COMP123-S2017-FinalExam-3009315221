﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Wayne Pud
 * Date: Aug 17th, 2017
 * StudentID: 300931522 
 * Description: This is the splashform for the exam
 * Version: 1.0 - Created splashform and initialized design settings with timer event
 */

namespace COMP123_S2017_FinalExam_3009315221
{
    public partial class SplashForm : Form
    {
        //PUBLIC PROPERTIES
        public PickHighestCardForm PickHighestCardForm
        {
            get
            {
                return Program.pickHighestCardForm;
            }
        }

        //CONSTRUCTORS
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for timer of the splashform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show();
            this.Hide();
            timer1.Enabled = false;
        }
    }
}
