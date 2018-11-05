namespace PizzaOrderingApp
{
    partial class MenuForm
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
            this.SpecialityComboBox = new System.Windows.Forms.ComboBox();
            this.CreateYourOwnButton = new System.Windows.Forms.Button();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.SpecialityDescriptionLabel = new System.Windows.Forms.Label();
            this.SpecialityLabel = new System.Windows.Forms.Label();
            this.SpecialityPictureBox = new System.Windows.Forms.PictureBox();
            this.CreateYourOwnPictureBox = new System.Windows.Forms.PictureBox();
            this.DELETE_LATER = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SpecialityPizza_GroupBox = new System.Windows.Forms.GroupBox();
            this.LargePizza_radioButton = new System.Windows.Forms.RadioButton();
            this.MediumPizza_radioButton = new System.Windows.Forms.RadioButton();
            this.SmallPizza_radioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialityPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateYourOwnPictureBox)).BeginInit();
            this.SpecialityPizza_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpecialityComboBox
            // 
            this.SpecialityComboBox.FormattingEnabled = true;
            this.SpecialityComboBox.Location = new System.Drawing.Point(208, 38);
            this.SpecialityComboBox.Name = "SpecialityComboBox";
            this.SpecialityComboBox.Size = new System.Drawing.Size(121, 22);
            this.SpecialityComboBox.TabIndex = 0;
            this.SpecialityComboBox.SelectedIndexChanged += new System.EventHandler(this.SpecialityComboBox_SelectedIndexChanged);
            // 
            // CreateYourOwnButton
            // 
            this.CreateYourOwnButton.Location = new System.Drawing.Point(466, 107);
            this.CreateYourOwnButton.Name = "CreateYourOwnButton";
            this.CreateYourOwnButton.Size = new System.Drawing.Size(116, 25);
            this.CreateYourOwnButton.TabIndex = 1;
            this.CreateYourOwnButton.Text = "Create Your Own Pizza";
            this.CreateYourOwnButton.UseVisualStyleBackColor = true;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.Location = new System.Drawing.Point(262, 10);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(263, 41);
            this.CompanyLabel.TabIndex = 2;
            this.CompanyLabel.Text = "Pizza Pizzaz";
            // 
            // SpecialityDescriptionLabel
            // 
            this.SpecialityDescriptionLabel.AutoSize = true;
            this.SpecialityDescriptionLabel.Location = new System.Drawing.Point(188, 64);
            this.SpecialityDescriptionLabel.Name = "SpecialityDescriptionLabel";
            this.SpecialityDescriptionLabel.Size = new System.Drawing.Size(58, 14);
            this.SpecialityDescriptionLabel.TabIndex = 3;
            this.SpecialityDescriptionLabel.Text = "It\'s-a Pizza";
            // 
            // SpecialityLabel
            // 
            this.SpecialityLabel.AutoSize = true;
            this.SpecialityLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SpecialityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialityLabel.Location = new System.Drawing.Point(127, 54);
            this.SpecialityLabel.Name = "SpecialityLabel";
            this.SpecialityLabel.Size = new System.Drawing.Size(108, 19);
            this.SpecialityLabel.TabIndex = 4;
            this.SpecialityLabel.Text = "Speciality Pizzas";
            // 
            // SpecialityPictureBox
            // 
            this.SpecialityPictureBox.Location = new System.Drawing.Point(0, 43);
            this.SpecialityPictureBox.Name = "SpecialityPictureBox";
            this.SpecialityPictureBox.Size = new System.Drawing.Size(180, 180);
            this.SpecialityPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SpecialityPictureBox.TabIndex = 5;
            this.SpecialityPictureBox.TabStop = false;
            // 
            // CreateYourOwnPictureBox
            // 
            this.CreateYourOwnPictureBox.Location = new System.Drawing.Point(466, 153);
            this.CreateYourOwnPictureBox.Name = "CreateYourOwnPictureBox";
            this.CreateYourOwnPictureBox.Size = new System.Drawing.Size(174, 179);
            this.CreateYourOwnPictureBox.TabIndex = 6;
            this.CreateYourOwnPictureBox.TabStop = false;
            // 
            // DELETE_LATER
            // 
            this.DELETE_LATER.AutoSize = true;
            this.DELETE_LATER.Location = new System.Drawing.Point(463, 205);
            this.DELETE_LATER.Name = "DELETE_LATER";
            this.DELETE_LATER.Size = new System.Drawing.Size(156, 14);
            this.DELETE_LATER.TabIndex = 7;
            this.DELETE_LATER.Text = "Pizza with a question mark on it";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(227, 240);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add to Cart";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SpecialityPizza_GroupBox
            // 
            this.SpecialityPizza_GroupBox.Controls.Add(this.LargePizza_radioButton);
            this.SpecialityPizza_GroupBox.Controls.Add(this.MediumPizza_radioButton);
            this.SpecialityPizza_GroupBox.Controls.Add(this.SmallPizza_radioButton);
            this.SpecialityPizza_GroupBox.Controls.Add(this.AddButton);
            this.SpecialityPizza_GroupBox.Controls.Add(this.SpecialityComboBox);
            this.SpecialityPizza_GroupBox.Controls.Add(this.SpecialityPictureBox);
            this.SpecialityPizza_GroupBox.Controls.Add(this.SpecialityDescriptionLabel);
            this.SpecialityPizza_GroupBox.Location = new System.Drawing.Point(22, 54);
            this.SpecialityPizza_GroupBox.Name = "SpecialityPizza_GroupBox";
            this.SpecialityPizza_GroupBox.Size = new System.Drawing.Size(344, 278);
            this.SpecialityPizza_GroupBox.TabIndex = 9;
            this.SpecialityPizza_GroupBox.TabStop = false;
            // 
            // LargePizza_radioButton
            // 
            this.LargePizza_radioButton.AutoSize = true;
            this.LargePizza_radioButton.Location = new System.Drawing.Point(208, 158);
            this.LargePizza_radioButton.Name = "LargePizza_radioButton";
            this.LargePizza_radioButton.Size = new System.Drawing.Size(51, 18);
            this.LargePizza_radioButton.TabIndex = 11;
            this.LargePizza_radioButton.TabStop = true;
            this.LargePizza_radioButton.Text = "Large";
            this.LargePizza_radioButton.UseVisualStyleBackColor = true;
            // 
            // MediumPizza_radioButton
            // 
            this.MediumPizza_radioButton.AutoSize = true;
            this.MediumPizza_radioButton.Location = new System.Drawing.Point(208, 133);
            this.MediumPizza_radioButton.Name = "MediumPizza_radioButton";
            this.MediumPizza_radioButton.Size = new System.Drawing.Size(62, 18);
            this.MediumPizza_radioButton.TabIndex = 10;
            this.MediumPizza_radioButton.TabStop = true;
            this.MediumPizza_radioButton.Text = "Medium";
            this.MediumPizza_radioButton.UseVisualStyleBackColor = true;
            // 
            // SmallPizza_radioButton
            // 
            this.SmallPizza_radioButton.AutoSize = true;
            this.SmallPizza_radioButton.Location = new System.Drawing.Point(208, 108);
            this.SmallPizza_radioButton.Name = "SmallPizza_radioButton";
            this.SmallPizza_radioButton.Size = new System.Drawing.Size(50, 18);
            this.SmallPizza_radioButton.TabIndex = 9;
            this.SmallPizza_radioButton.TabStop = true;
            this.SmallPizza_radioButton.Text = "Small";
            this.SmallPizza_radioButton.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.SpecialityLabel);
            this.Controls.Add(this.SpecialityPizza_GroupBox);
            this.Controls.Add(this.DELETE_LATER);
            this.Controls.Add(this.CreateYourOwnPictureBox);
            this.Controls.Add(this.CompanyLabel);
            this.Controls.Add(this.CreateYourOwnButton);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MenuForm";
            this.Text = "Pizza Pizzaz - Pizza Ordering Service";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.SpecialityPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateYourOwnPictureBox)).EndInit();
            this.SpecialityPizza_GroupBox.ResumeLayout(false);
            this.SpecialityPizza_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SpecialityComboBox;
        private System.Windows.Forms.Button CreateYourOwnButton;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Label SpecialityDescriptionLabel;
        private System.Windows.Forms.Label SpecialityLabel;
        private System.Windows.Forms.PictureBox SpecialityPictureBox;
        private System.Windows.Forms.PictureBox CreateYourOwnPictureBox;
        private System.Windows.Forms.Label DELETE_LATER;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox SpecialityPizza_GroupBox;
        private System.Windows.Forms.RadioButton LargePizza_radioButton;
        private System.Windows.Forms.RadioButton MediumPizza_radioButton;
        private System.Windows.Forms.RadioButton SmallPizza_radioButton;
    }
}

