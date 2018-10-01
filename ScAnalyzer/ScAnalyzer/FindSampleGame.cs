using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScAnalyzer
{
    // FindSampleGame is the driving class the operates the ScanAnalyzer
    class FindSampleGame
    {
        // private boolean that tells weather the player has found all clues
        private bool isPlaying;
        // private integer that indexes the surrent clue number
        private int clueNumber;
        // public declaration of a ScanAnalyzer
        public ScanAnalyzer scAnalyzer;
        // public array of Points
        public Point[] clues;
        // public property allowing access to get and set the isPlaying attribute
        public bool IsPlaying
        {
            get
            {
                return isPlaying;
            }
            set
            {
                isPlaying = value;
            }
        }
        // constructor that takes in the max number of rows and the max number
            // of columns
        public FindSampleGame(int rows, int cols)
        {
            // default the value of isPlaying to true, meaning the user is
                // trying to guess where a clue is
            isPlaying = true;
            // initialize the value of clueNumber to 0, the index of the first
                // clue
            clueNumber = 0;
            // make clues an array with 2 Point
            clues = new Point[2];
            // declare and instantiate an object of type random
            Random rand = new Random();
            // get a random row value using method that takes a lower bound and
                // upper bound that is not included in the range
            int sr = rand.Next(0, rows);
            // get a random column value using method that takes a lower bound
                // and upper bound that is not included in the range
            int sc = rand.Next(0, cols);
            // create a new point that holds the secret location of the first
                // clue
            clues[0] = new Point(sr, sc);
            // get new random point values and keep getting new values while
                // the position is that same as the first hint
            do
            {
                // get a random row value using method that takes a lower bound
                    // and upper bound that is not included in the range
                sr = rand.Next(0, rows);
                // get a random column value using method that takes a lower
                    // bound and upper bound that is not included in the range
                sc = rand.Next(0, cols);
            // check if the point is the same as the first
            } while (sr == clues[0].Row && sc == clues[0].Column);
            // make a new point for the second hidden clue
            clues[1] = new Point(sr, sc);
            // instantiate a new ScanAnalyzer with the number of rows and columns
                // as specified by the user and with the first clue location
            scAnalyzer = new ScanAnalyzer(rows, cols, clues[0]);
        }
        // take in a point that is the users guess and return a message back
            //to the user
        public string Guess(Point p)
        {
            // shorthand for the users row guess
            int row = p.Row;
            // shorthand for the users column guess
            int col = p.Column;
            // start with an empty string to be returned containing a message
                // to the user
            string feedback = "";
            // check that the users guess is within the grid
            if (row < scAnalyzer.Rows && row >= 0 && col < scAnalyzer.Columns
                && col >= 0)
            {
                // boolean that is the result of EvaluateGuess which returns
                    // true if the user guessed the correct location of the clue
                    // otherwise, false
                bool isFound = scAnalyzer.EvaluateGuess(row, col);
                // check if the user guessed the correct location
                if (isFound)
                {
                    // get feedback based on the result of geting the next clue
                    feedback = NextClue();
                }
                else
                {   
                    // save a negative message
                    feedback = "Sorry, Try Again";
                }
            }
            // return feedback message
            return feedback;
        }
        // NextClue returns the feedback to the user based on their guess
        public string NextClue()
        {
            // start with a string for a message back to the user
            string msg;
            // increment the clue number so the next clue can be created
            clueNumber++;
            // if the max number of clues has been reached...
            if (clueNumber == 2)
            {
                // save a message of success with a tempting offer
                msg = "SUCCESS           Play Again?";
                // set isPlaying to false
                isPlaying = false;
            }
            else // there are more clues to find
            {
                // instantiate a new clue
                scAnalyzer.CurrentClue = new Point(clues[clueNumber].Row, 
                    clues[clueNumber].Column);
                //  alert the user of their accomplishment, but that there is
                    // still work to do
                msg = "Good Job, But There Is One More Clue To Find";
            }
            // return feedback
            return msg;
        }
        // Returns the overloaded ToString method of the scAnalyzer
        public string Display()
        {
            return scAnalyzer.ToString();
        }
    }
}
