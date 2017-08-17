using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Wayne Pud
 * Date: Aug 17th, 2017
 * StudentID: 300931522 
 * Description: This is the ScoreBoard class
 * Version: 1.2 - Added updatetime and constructor methods
 */

namespace COMP123_S2017_FinalExam_3009315221
{
    class ScoreBoard
    {
        // PRIVATE INSTANCE VARIABLES
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        // PUBLIC PROPERTIES
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }

        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this.Score = value;
                ScoreTextBox.Text = Convert.ToString(_score);
                FinalScoreTextBox.Text = Convert.ToString(_score);
            }
        }

        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                TimeTextBox.Text = Convert.ToString(_time);
            }
        }

        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }


        /// <summary>
        /// This is the main constructor
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTextBox"></param>
        /// <param name="finalScoreTextBox"></param>
        // CONSTRUCTORS
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }


        /// <summary>
        /// This is the updatetime Method that
        /// </summary>
        // PUBLIC METHODS
        public void UpdateTime()
        {
            Time = Convert.ToInt32(TimeTextBox.Text) - 1;
        }


    }
}
