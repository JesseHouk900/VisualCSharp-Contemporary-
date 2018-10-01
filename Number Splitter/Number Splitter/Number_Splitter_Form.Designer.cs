namespace Number_Splitter
{
    partial class Number_Splitter_Form
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
            this.UserMessageLabel = new System.Windows.Forms.Label();
            this.UserNumberTextBox = new System.Windows.Forms.TextBox();
            this.SplitterGroupBox = new System.Windows.Forms.GroupBox();
            this.SplitButton = new System.Windows.Forms.Button();
            this.SplitNumberLabel = new System.Windows.Forms.Label();
            this.SplitNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.SplitterGroupBox.SuspendLayout();
            this.SplitNumberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserMessageLabel
            // 
            this.UserMessageLabel.AutoSize = true;
            this.UserMessageLabel.Location = new System.Drawing.Point(17, 28);
            this.UserMessageLabel.Name = "UserMessageLabel";
            this.UserMessageLabel.Size = new System.Drawing.Size(144, 13);
            this.UserMessageLabel.TabIndex = 0;
            this.UserMessageLabel.Text = "Please enter a 5 digit number";
            // 
            // UserNumberTextBox
            // 
            this.UserNumberTextBox.Location = new System.Drawing.Point(35, 51);
            this.UserNumberTextBox.Name = "UserNumberTextBox";
            this.UserNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserNumberTextBox.TabIndex = 1;
            this.UserNumberTextBox.Text = "12334";
            // 
            // SplitterGroupBox
            // 
            this.SplitterGroupBox.Controls.Add(this.SplitButton);
            this.SplitterGroupBox.Controls.Add(this.UserNumberTextBox);
            this.SplitterGroupBox.Controls.Add(this.UserMessageLabel);
            this.SplitterGroupBox.Location = new System.Drawing.Point(23, 22);
            this.SplitterGroupBox.Name = "SplitterGroupBox";
            this.SplitterGroupBox.Size = new System.Drawing.Size(174, 115);
            this.SplitterGroupBox.TabIndex = 2;
            this.SplitterGroupBox.TabStop = false;
            this.SplitterGroupBox.Text = "Splitter";
            // 
            // SplitButton
            // 
            this.SplitButton.Location = new System.Drawing.Point(48, 77);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(75, 23);
            this.SplitButton.TabIndex = 2;
            this.SplitButton.Text = "Split";
            this.SplitButton.UseVisualStyleBackColor = true;
            this.SplitButton.Click += new System.EventHandler(this.SplitButton_Click);
            // 
            // SplitNumberLabel
            // 
            this.SplitNumberLabel.AutoSize = true;
            this.SplitNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitNumberLabel.Location = new System.Drawing.Point(6, 36);
            this.SplitNumberLabel.Name = "SplitNumberLabel";
            this.SplitNumberLabel.Size = new System.Drawing.Size(168, 26);
            this.SplitNumberLabel.TabIndex = 2;
            this.SplitNumberLabel.Text = "1\\t\\t2\\t\\t3\\t\\t3\\t\\t4";
            // 
            // SplitNumberGroupBox
            // 
            this.SplitNumberGroupBox.Controls.Add(this.SplitNumberLabel);
            this.SplitNumberGroupBox.Location = new System.Drawing.Point(218, 22);
            this.SplitNumberGroupBox.Name = "SplitNumberGroupBox";
            this.SplitNumberGroupBox.Size = new System.Drawing.Size(189, 184);
            this.SplitNumberGroupBox.TabIndex = 3;
            this.SplitNumberGroupBox.TabStop = false;
            this.SplitNumberGroupBox.Text = "Split Number";
            // 
            // Number_Splitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SplitNumberGroupBox);
            this.Controls.Add(this.SplitterGroupBox);
            this.Name = "Number_Splitter";
            this.Text = "Form1";
            this.SplitterGroupBox.ResumeLayout(false);
            this.SplitterGroupBox.PerformLayout();
            this.SplitNumberGroupBox.ResumeLayout(false);
            this.SplitNumberGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserMessageLabel;
        private System.Windows.Forms.TextBox UserNumberTextBox;
        private System.Windows.Forms.GroupBox SplitterGroupBox;
        private System.Windows.Forms.Label SplitNumberLabel;
        private System.Windows.Forms.Button SplitButton;
        private System.Windows.Forms.GroupBox SplitNumberGroupBox;
    }
}

