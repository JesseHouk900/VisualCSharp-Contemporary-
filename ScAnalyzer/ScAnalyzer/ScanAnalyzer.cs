using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScAnalyzer
{
    // composed of a 2d grid of chars, previous guesses in an array of Points
    class ScanAnalyzer
    {
        // private shared number of guesses
        private static int numberGuesses;
        // private number of rows
        private int maxRows;
        // private number of columns
        private int maxColumns;
        // private 2d array of chars that will be used as the grid the user
            // is scanning for clues
        private char[,] scaner;
        // array of Points previously guessed by the user
        private Point[] previousGuesses;
        // private Point that is the current clue that the ScanAlyzer is set to
            // search for
        private Point currentClue;
        // private boolean that represents whether to give an up-down or
            // left-right hint. true means left-right, false means up-down
        private bool hintDirection;
        // public property that is shared between all instances of ScAnalyzer.
            // Keeps track of the number of guesses the user has made with
            // a getter
        public static int Guesses
        {
            get
            {
                return numberGuesses;
            }
        }
        // public property that provides access to the number of rows for the
            // scAnalyzer 
        public int Rows
        {
            get
            {
                return maxRows;
            }
            set
            {
                maxRows = value;
            }
        }
        // public property that provides access to the number of columns for
            // the scAnalyer
        public int Columns
        {
            get
            {
                return maxColumns;
            }
            set
            {
                maxColumns = value;
            }
        }
        // public property that provides access to the current clue location
        public Point CurrentClue
        {
            get
            {
                return currentClue;
            }
            set
            {
                currentClue = value;
            }
        }
        // constructor that takes in the number of rows, the number of columns,
            // and the first clue location. Initializes the scaner and readied
        public ScanAnalyzer(int rows, int columns, Point Clue)
        {
            // set default hint to left-right
            hintDirection = true;
            // set the current clue to a new instance created with the 
            currentClue = new Point (Clue.Row, Clue.Column);
            // set the default number of guesses to 0
            numberGuesses = 0;
            // save the number of rows to the maxRows attribute
            maxRows = rows;
            // save the number of columns to the macColumns attribute
            maxColumns = columns;
            // instantiate scaner as a 2d array of chars with rows rows, columns
                //columns
            scaner = new char[rows, columns];
            // loop through each element of scaner and initialize it to ~
            for (int r = 0; r < maxRows; r++)
            {
                for (int c = 0; c < maxColumns; c++)
                {
                    scaner[r, c] = '~';
                }
            }
            // make previous guess a max size
            previousGuesses = new Point[rows * columns];
        }
        // override the ToString method that returns a string
        public override string ToString()
        {
            // have a string that will be modified and eventually returned
            string gridText = "  ";
            // get the possible indicies of the columns and print them along the
                // top of the string
            for (int c = 0; c < maxColumns; c++)
            {
                gridText += c;
            }
            // add a new line
            gridText += '\n';
            // loop through the grid adding to the gridText
            for (int r = 0; r < maxRows; r++)
            {
                // add the row index and a space
                gridText += r + " ";
                for (int c = 0; c < maxColumns; c++)
                {
                    // add an element from scaner to the gridText
                    gridText += scaner[r, c];
                }
                // add a new line
                gridText += '\n';
            }
            return gridText;
        }
        // take in a users guess and return whether or not the guess was right
        public bool EvaluateGuess(int row, int col)
        {
            // boolean that tracks whether the user guessed correctly or not
            bool isFound = false;
            // shorthand for the secret location of the current clue's row
            int sr = currentClue.Row;
            // shorthand for the secret location of the current clue's column
            int sc = currentClue.Column;
            // if the guess is correct...
            if (row == sr && col == sc)
            {
                // fignal that the guess is correct
                isFound = true;
                // change the element in the position of the correct guess to
                    // an X
                scaner[row, col] = 'X';
                // reset the grid except for the any Xs
                Refresh();
            }
            else // if the guess is incorrect
            {
                // signal that the guess was incorrect
                isFound = false;
                // check if the users row guess and column guess was incorrect
                if (row != sr && col != sc)
                {
                    // if there should be a left-right hint
                    if (hintDirection)
                    {
                        // do a left-right column comparison with the users
                            // guess and the secret column
                        _check_left_right_(row, col, sc);
                    }
                    
                    else // check up-down
                    {
                        // do an up-down column comparison with the users guess and the secret row
                        _check_up_down_(row, col, sr);
                    }
                    // alternate the next direction of 
                    hintDirection = !hintDirection;
                }
                else if (row != sr)
                {
                    // do a left right column comparison with the users guess and the secret column
                    _check_up_down_(row, col, sr);
                    // force the next hint direction to be left-right
                    hintDirection = true;
                }
                else
                {
                    // do a left right column comparison with the users guess and the secret column
                    _check_left_right_(row, col, sc);
                    // force the next hint direction to be up-down
                    hintDirection = false;
                }
            }
            // add the user guess to the previous guess array
            previousGuesses[numberGuesses] = new Point(row, col);
            // increment the number of guesses made
            numberGuesses++;
            // return whether theguess was correct
            return isFound;
        }
        // private method that compares the users guess to the secret row and
            // changes the element at the position the user guessed accordingly
        private void _check_up_down_(int r, int c, int sr)
        {
            // if (r < sr) scaner[r, c] = 'V'; else scaner[r,c] = '^';
            scaner[r, c] = (r < sr) ? 'V' : '^';
        }
        // private method that compares the users guess to the secret column and
            // changes the element at the position the user guesses accordingly
        private void _check_left_right_(int r, int c, int sc)
        {
            // if (c < sc) scaner[r, c] = '>'; else scaner[r, c] = '<';
            scaner[r, c] = (c < sc) ? '>' : '<';
        }
        // method cleans the grid to only have the Xs
        public void Refresh()
        {
            // loop through the previous geuesses...
            for (int p = 0; p < previousGuesses.Length && 
                previousGuesses[p] != null; p++)
            {
                //reset the elements where preveiously guessed
                scaner[previousGuesses[p].Row, previousGuesses[p].Column] = '~';
            }
            // make previous guess an appropriate size
            previousGuesses = new Point[maxColumns * maxRows];
            // set number of guesses back to 0;
            //numberGuesses = 0;
        }
    }
}
