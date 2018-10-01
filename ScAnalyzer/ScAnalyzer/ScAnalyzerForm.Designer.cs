namespace ScAnalyzer
{
    partial class ScAnalyzerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScanalyzerLabel = new System.Windows.Forms.Label();
            this.UserPromptLabel = new System.Windows.Forms.Label();
            this.RowTextBox = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.ScanerDimensionsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColumnTextBox = new System.Windows.Forms.TextBox();
            this.PreviousGuessLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScanalyzerLabel
            // 
            this.ScanalyzerLabel.AutoSize = true;
            this.ScanalyzerLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanalyzerLabel.Location = new System.Drawing.Point(315, 129);
            this.ScanalyzerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScanalyzerLabel.Name = "ScanalyzerLabel";
            this.ScanalyzerLabel.Size = new System.Drawing.Size(128, 16);
            this.ScanalyzerLabel.TabIndex = 0;
            this.ScanalyzerLabel.Text = " 1 2 3 4 5 6";
            // 
            // UserPromptLabel
            // 
            this.UserPromptLabel.AutoSize = true;
            this.UserPromptLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPromptLabel.Location = new System.Drawing.Point(20, 22);
            this.UserPromptLabel.Name = "UserPromptLabel";
            this.UserPromptLabel.Size = new System.Drawing.Size(508, 16);
            this.UserPromptLabel.TabIndex = 1;
            this.UserPromptLabel.Text = "Please make a guess for where to find the evidence";
            // 
            // RowTextBox
            // 
            this.RowTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowTextBox.Location = new System.Drawing.Point(23, 103);
            this.RowTextBox.Name = "RowTextBox";
            this.RowTextBox.Size = new System.Drawing.Size(112, 23);
            this.RowTextBox.TabIndex = 2;
            this.RowTextBox.Text = "rows";
            this.RowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(23, 166);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(91, 48);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(147, 166);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(95, 48);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ScanerDimensionsLabel
            // 
            this.ScanerDimensionsLabel.AutoSize = true;
            this.ScanerDimensionsLabel.Location = new System.Drawing.Point(314, 71);
            this.ScanerDimensionsLabel.Name = "ScanerDimensionsLabel";
            this.ScanerDimensionsLabel.Size = new System.Drawing.Size(38, 16);
            this.ScanerDimensionsLabel.TabIndex = 5;
            this.ScanerDimensionsLabel.Text = "3x7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PreviousGuessLabel);
            this.groupBox1.Controls.Add(this.ColumnTextBox);
            this.groupBox1.Controls.Add(this.playButton);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.ScanerDimensionsLabel);
            this.groupBox1.Controls.Add(this.UserPromptLabel);
            this.groupBox1.Controls.Add(this.ScanalyzerLabel);
            this.groupBox1.Controls.Add(this.RowTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 356);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ScAnalyzer Game";
            // 
            // ColumnTextBox
            // 
            this.ColumnTextBox.Location = new System.Drawing.Point(147, 103);
            this.ColumnTextBox.Name = "ColumnTextBox";
            this.ColumnTextBox.Size = new System.Drawing.Size(104, 23);
            this.ColumnTextBox.TabIndex = 6;
            this.ColumnTextBox.Text = "columns";
            // 
            // PreviousGuessLabel
            // 
            this.PreviousGuessLabel.AutoSize = true;
            this.PreviousGuessLabel.Location = new System.Drawing.Point(20, 71);
            this.PreviousGuessLabel.Name = "PreviousGuessLabel";
            this.PreviousGuessLabel.Size = new System.Drawing.Size(68, 16);
            this.PreviousGuessLabel.TabIndex = 7;
            this.PreviousGuessLabel.Text = "(1, 3)";
            // 
            // ScAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 461);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScAnalyzerForm";
            this.Text = "ScAnalyzerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ScanalyzerLabel;
        private System.Windows.Forms.Label UserPromptLabel;
        private System.Windows.Forms.TextBox RowTextBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label ScanerDimensionsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ColumnTextBox;
        private System.Windows.Forms.Label PreviousGuessLabel;
    }
}

