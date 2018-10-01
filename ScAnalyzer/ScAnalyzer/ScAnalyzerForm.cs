using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScAnalyzer
{
    public partial class ScAnalyzerForm : Form
    {
        // declare a FindSampleGame object that controls a bulk of the game
        FindSampleGame Game;
        public ScAnalyzerForm()
        {
            InitializeComponent();
            // show an example of what the grid will look like
            ScanalyzerLabel.Text = "  0123456\n" +
                "0 ~~~~~~~\n1 ~~~~~~~\n2 ~~~~~~~";
            // disable the submit button
            submitButton.Enabled = false;
            // show where the user should look to know what their previous
            //guess was
            PreviousGuessLabel.Text = "Your Previous Guess is N/A";
            // present instructions to the user
            UserPromptLabel.Text = "Please select the size of the piece of" +
                " evidence to examine";

        }
        // event handler for when the user clicks on the playButton (play/quit
        //button)
        private void playButton_Click(object sender, EventArgs e)
        {
            // check the play button says Play
            if (playButton.Text == "Play")
            {
                // take the value from the RowTextBox
                string rows = RowTextBox.Text;
                // take the value from the ColumnTextBox
                string cols = ColumnTextBox.Text;
                // attempt to set up the game. issues include:
                // rows or columns not being integers
                try
                {
                    // instantiate Game with the integer translations of rows and 
                    //cols
                    Game = new FindSampleGame(Int32.Parse(rows),
                        Int32.Parse(cols));
                    // display the newly created grid
                    ScanalyzerLabel.Text = Game.Display();
                    // display the grid size that was just entered
                    ScanerDimensionsLabel.Text = " Grid size: " + rows + 'x' +
                        cols;
                    // provide user instruction
                    UserPromptLabel.Text = "Please make a guess for where to find" +
                        " the evidence";
                    // change the play button text to Quit
                    playButton.Text = "Quit";
                    // enable the submit button so the user can make guesses
                    submitButton.Enabled = true;
                    // change the RowTextBox text to row
                    RowTextBox.Text = "row";
                    // change the ColumnsTextBox text to column
                    ColumnTextBox.Text = "column";
                }
                // handle any errors that occur in the above code
                catch
                {
                    // Further explain the rules
                    UserPromptLabel.Text = "Please enter the number of rows" +
                        " where it says rows and the\nnumber of columns where" +
                        " it says columns";
                    // change the RowTextBox text to rows
                    RowTextBox.Text = "rows";
                    // change the ColumnsTextBox text to columns
                    ColumnTextBox.Text = "columns";
                }
            }
            // check if the play button says Quit
            else if (playButton.Text == "Quit")
            {
                // indicate that the user should not focus on the grid
                ScanerDimensionsLabel.Text = "Not Playing";
                // disable the submit button to prevent the user from 
                submitButton.Enabled = false;
                // change the play button text to Play
                playButton.Text = "Play";
                // reset the previous guess message
                PreviousGuessLabel.Text = "Your Previous Guess is N/A";
                // reset the user prompt
                UserPromptLabel.Text = "Please select the size of the piece of" +
                    " evidence to examine";
                // change the RowTextBox text to rows
                RowTextBox.Text = "rows";
                // change the ColumnsTextBox text to columns
                ColumnTextBox.Text = "columns";

            }
        }
        // event handler for when the user clicks on the submit button
        private void submitButton_Click(object sender, EventArgs e)
        {
            // attempt to evaluate the users guess. Potential issues include:
                // user entering a non-integer value for the row or column
            try
            {
                // create a point that holds the users guess. The users guess
                    // is determined by the strings in the RowTextBox and the
                    // ColumnTextBox converted into integers
                Point userGuess = new Point(Int32.Parse(RowTextBox.Text),
                    Int32.Parse(ColumnTextBox.Text));
                // Game.Guess returns a message for the user based on their guess
                string userPrompt = Game.Guess(userGuess);
                // update the grid display
                ScanalyzerLabel.Text = Game.Display();
                // check if the user has not found enough clues to move to the
                    // next level
                if (Game.IsPlaying)
                {
                    // show the users previous guess as an ordered pair
                    PreviousGuessLabel.Text = "Your Previous Guess Was (" +
                        userGuess.Row + ", " + userGuess.Column + ")";
                    // change the RowTextBox text to row
                    RowTextBox.Text = "row";
                    // change the ColumnTextBox text to column
                    ColumnTextBox.Text = "column";
                }
                else // the user has found sufficient clues to move on
                {
                    // disable the submit button
                    submitButton.Enabled = false;
                    // change the play button text to Play
                    playButton.Text = "Play";
                    // change previous guess message to say they guessed right
                    PreviousGuessLabel.Text = "Your Previous Guess Was Right!";
                    // bring a pop up box that displays a celebratory message
                    MessageBox.Show("Congratulations!! You found enough clues to" +
                        " lead you to another piece of evidence.\nYour number of" +
                        "guesses was " + ScanAnalyzer.Guesses);
                    // change the RowTextBox text to rows
                    RowTextBox.Text = "rows";
                    // change the ColumTextBox text to rows
                    ColumnTextBox.Text = "columns";
                }
                // update the user prompt
                UserPromptLabel.Text = userPrompt;
            }
            // handle the columns or rows being invalid
            catch
            {
                // further provide instruction
                UserPromptLabel.Text = "Please enter the row number where it" +
                    " says row and the column\nnumber where it says column.";
                // change RowTextBox text to rows
                RowTextBox.Text = "row";
                // change ColumnTextBox to column
                ColumnTextBox.Text = "column";
            }
        }
    }
}
