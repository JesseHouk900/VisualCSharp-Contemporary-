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
            this.Speciality_ComboBox = new System.Windows.Forms.ComboBox();
            this.CreateYourOwn_Button = new System.Windows.Forms.Button();
            this.Company_Label = new System.Windows.Forms.Label();
            this.SpecialityDescription_Label = new System.Windows.Forms.Label();
            this.Speciality_Label = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.SpecialityPizza_GroupBox = new System.Windows.Forms.GroupBox();
            this.SIZE_Personal_radioButton = new System.Windows.Forms.RadioButton();
            this.SIZE_Large_radioButton = new System.Windows.Forms.RadioButton();
            this.SIZE_Medium_radioButton = new System.Windows.Forms.RadioButton();
            this.SIZE_Small_radioButton = new System.Windows.Forms.RadioButton();
            this.Checkout_Label = new System.Windows.Forms.Label();
            this.Checkout_Button = new System.Windows.Forms.Button();
            this.SpecialityPizzaCost_Label = new System.Windows.Forms.Label();
            this.SpecialityPizza_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Speciality_ComboBox
            // 
            this.Speciality_ComboBox.FormattingEnabled = true;
            this.Speciality_ComboBox.Location = new System.Drawing.Point(21, 39);
            this.Speciality_ComboBox.Name = "Speciality_ComboBox";
            this.Speciality_ComboBox.Size = new System.Drawing.Size(121, 22);
            this.Speciality_ComboBox.TabIndex = 0;
            this.Speciality_ComboBox.SelectedIndexChanged += new System.EventHandler(this.SpecialityComboBox_SelectedIndexChanged);
            // 
            // CreateYourOwn_Button
            // 
            this.CreateYourOwn_Button.Location = new System.Drawing.Point(390, 54);
            this.CreateYourOwn_Button.Name = "CreateYourOwn_Button";
            this.CreateYourOwn_Button.Size = new System.Drawing.Size(116, 25);
            this.CreateYourOwn_Button.TabIndex = 1;
            this.CreateYourOwn_Button.Text = "Create Your Own Pizza";
            this.CreateYourOwn_Button.UseVisualStyleBackColor = true;
            this.CreateYourOwn_Button.Click += new System.EventHandler(this.CreateYourOwnButton_Click);
            // 
            // Company_Label
            // 
            this.Company_Label.AutoSize = true;
            this.Company_Label.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company_Label.Location = new System.Drawing.Point(182, 10);
            this.Company_Label.Name = "Company_Label";
            this.Company_Label.Size = new System.Drawing.Size(263, 41);
            this.Company_Label.TabIndex = 2;
            this.Company_Label.Text = "Pizza Pizzaz";
            // 
            // SpecialityDescription_Label
            // 
            this.SpecialityDescription_Label.AutoSize = true;
            this.SpecialityDescription_Label.Location = new System.Drawing.Point(18, 64);
            this.SpecialityDescription_Label.Name = "SpecialityDescription_Label";
            this.SpecialityDescription_Label.Size = new System.Drawing.Size(58, 14);
            this.SpecialityDescription_Label.TabIndex = 3;
            this.SpecialityDescription_Label.Text = "It\'s-a Pizza";
            // 
            // Speciality_Label
            // 
            this.Speciality_Label.AutoSize = true;
            this.Speciality_Label.BackColor = System.Drawing.SystemColors.Window;
            this.Speciality_Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speciality_Label.Location = new System.Drawing.Point(45, 16);
            this.Speciality_Label.Name = "Speciality_Label";
            this.Speciality_Label.Size = new System.Drawing.Size(108, 19);
            this.Speciality_Label.TabIndex = 4;
            this.Speciality_Label.Text = "Speciality Pizzas";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(21, 221);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 8;
            this.Add_Button.Text = "Add to Cart";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SpecialityPizza_GroupBox
            // 
            this.SpecialityPizza_GroupBox.Controls.Add(this.SpecialityPizzaCost_Label);
            this.SpecialityPizza_GroupBox.Controls.Add(this.SIZE_Personal_radioButton);
            this.SpecialityPizza_GroupBox.Controls.Add(this.SIZE_Large_radioButton);
            this.SpecialityPizza_GroupBox.Controls.Add(this.Speciality_Label);
            this.SpecialityPizza_GroupBox.Controls.Add(this.SIZE_Medium_radioButton);
            this.SpecialityPizza_GroupBox.Controls.Add(this.SIZE_Small_radioButton);
            this.SpecialityPizza_GroupBox.Controls.Add(this.Add_Button);
            this.SpecialityPizza_GroupBox.Controls.Add(this.Speciality_ComboBox);
            this.SpecialityPizza_GroupBox.Controls.Add(this.SpecialityDescription_Label);
            this.SpecialityPizza_GroupBox.Location = new System.Drawing.Point(76, 54);
            this.SpecialityPizza_GroupBox.Name = "SpecialityPizza_GroupBox";
            this.SpecialityPizza_GroupBox.Size = new System.Drawing.Size(232, 278);
            this.SpecialityPizza_GroupBox.TabIndex = 9;
            this.SpecialityPizza_GroupBox.TabStop = false;
            // 
            // SIZE_Personal_radioButton
            // 
            this.SIZE_Personal_radioButton.AutoSize = true;
            this.SIZE_Personal_radioButton.Location = new System.Drawing.Point(21, 94);
            this.SIZE_Personal_radioButton.Name = "SIZE_Personal_radioButton";
            this.SIZE_Personal_radioButton.Size = new System.Drawing.Size(65, 18);
            this.SIZE_Personal_radioButton.TabIndex = 12;
            this.SIZE_Personal_radioButton.TabStop = true;
            this.SIZE_Personal_radioButton.Text = "Personal";
            this.SIZE_Personal_radioButton.UseVisualStyleBackColor = true;
            // 
            // SIZE_Large_radioButton
            // 
            this.SIZE_Large_radioButton.AutoSize = true;
            this.SIZE_Large_radioButton.Location = new System.Drawing.Point(21, 165);
            this.SIZE_Large_radioButton.Name = "SIZE_Large_radioButton";
            this.SIZE_Large_radioButton.Size = new System.Drawing.Size(51, 18);
            this.SIZE_Large_radioButton.TabIndex = 11;
            this.SIZE_Large_radioButton.TabStop = true;
            this.SIZE_Large_radioButton.Text = "Large";
            this.SIZE_Large_radioButton.UseVisualStyleBackColor = true;
            // 
            // SIZE_Medium_radioButton
            // 
            this.SIZE_Medium_radioButton.AutoSize = true;
            this.SIZE_Medium_radioButton.Location = new System.Drawing.Point(21, 141);
            this.SIZE_Medium_radioButton.Name = "SIZE_Medium_radioButton";
            this.SIZE_Medium_radioButton.Size = new System.Drawing.Size(62, 18);
            this.SIZE_Medium_radioButton.TabIndex = 10;
            this.SIZE_Medium_radioButton.TabStop = true;
            this.SIZE_Medium_radioButton.Text = "Medium";
            this.SIZE_Medium_radioButton.UseVisualStyleBackColor = true;
            // 
            // SIZE_Small_radioButton
            // 
            this.SIZE_Small_radioButton.AutoSize = true;
            this.SIZE_Small_radioButton.Location = new System.Drawing.Point(21, 117);
            this.SIZE_Small_radioButton.Name = "SIZE_Small_radioButton";
            this.SIZE_Small_radioButton.Size = new System.Drawing.Size(50, 18);
            this.SIZE_Small_radioButton.TabIndex = 9;
            this.SIZE_Small_radioButton.TabStop = true;
            this.SIZE_Small_radioButton.Text = "Small";
            this.SIZE_Small_radioButton.UseVisualStyleBackColor = true;
            // 
            // Checkout_Label
            // 
            this.Checkout_Label.AutoSize = true;
            this.Checkout_Label.Location = new System.Drawing.Point(376, 249);
            this.Checkout_Label.Name = "Checkout_Label";
            this.Checkout_Label.Size = new System.Drawing.Size(139, 14);
            this.Checkout_Label.TabIndex = 10;
            this.Checkout_Label.Text = "Your current total is : $ 0.00";
            // 
            // Checkout_Button
            // 
            this.Checkout_Button.Location = new System.Drawing.Point(411, 298);
            this.Checkout_Button.Name = "Checkout_Button";
            this.Checkout_Button.Size = new System.Drawing.Size(75, 23);
            this.Checkout_Button.TabIndex = 11;
            this.Checkout_Button.Text = "Checkout";
            this.Checkout_Button.UseVisualStyleBackColor = true;
            this.Checkout_Button.Click += new System.EventHandler(this.Checkout_Button_Click);
            // 
            // SpecialityPizzaCost_Label
            // 
            this.SpecialityPizzaCost_Label.AutoSize = true;
            this.SpecialityPizzaCost_Label.Location = new System.Drawing.Point(18, 195);
            this.SpecialityPizzaCost_Label.Name = "SpecialityPizzaCost_Label";
            this.SpecialityPizzaCost_Label.Size = new System.Drawing.Size(34, 14);
            this.SpecialityPizzaCost_Label.TabIndex = 13;
            this.SpecialityPizzaCost_Label.Text = "$0.00";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 485);
            this.Controls.Add(this.Checkout_Button);
            this.Controls.Add(this.Checkout_Label);
            this.Controls.Add(this.SpecialityPizza_GroupBox);
            this.Controls.Add(this.Company_Label);
            this.Controls.Add(this.CreateYourOwn_Button);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MenuForm";
            this.Text = "Pizza Pizzaz - Pizza Ordering Service";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.SpecialityPizza_GroupBox.ResumeLayout(false);
            this.SpecialityPizza_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Speciality_ComboBox;
        private System.Windows.Forms.Button CreateYourOwn_Button;
        private System.Windows.Forms.Label Company_Label;
        private System.Windows.Forms.Label SpecialityDescription_Label;
        private System.Windows.Forms.Label Speciality_Label;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.GroupBox SpecialityPizza_GroupBox;
        private System.Windows.Forms.RadioButton SIZE_Large_radioButton;
        private System.Windows.Forms.RadioButton SIZE_Medium_radioButton;
        private System.Windows.Forms.RadioButton SIZE_Small_radioButton;
        private System.Windows.Forms.RadioButton SIZE_Personal_radioButton;
        private System.Windows.Forms.Label Checkout_Label;
        private System.Windows.Forms.Button Checkout_Button;
        private System.Windows.Forms.Label SpecialityPizzaCost_Label;
    }
}

