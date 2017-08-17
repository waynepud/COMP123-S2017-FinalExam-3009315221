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
 * Version: 1.1 - Added private instance variables and public properties to scoreboard class
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
                this._score = value;
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



        // CONSTRUCTORS




    }
}
