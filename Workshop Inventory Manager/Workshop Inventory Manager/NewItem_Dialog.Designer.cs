namespace Workshop_Inventory_Manager
{
    partial class NewItem_Dialog
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Insert_Button = new System.Windows.Forms.Button();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Price_TextBox = new System.Windows.Forms.TextBox();
            this.Quantity_TextBox = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Price_Label = new System.Windows.Forms.Label();
            this.Quantity_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(53, 301);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(87, 27);
            this.Cancel_Button.TabIndex = 4;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Insert_Button
            // 
            this.Insert_Button.Location = new System.Drawing.Point(303, 301);
            this.Insert_Button.Name = "Insert_Button";
            this.Insert_Button.Size = new System.Drawing.Size(87, 27);
            this.Insert_Button.TabIndex = 3;
            this.Insert_Button.Text = "Insert";
            this.Insert_Button.UseVisualStyleBackColor = true;
            this.Insert_Button.Click += new System.EventHandler(this.Insert_Button_Click);
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(288, 64);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(116, 24);
            this.Name_TextBox.TabIndex = 0;
            // 
            // Price_TextBox
            // 
            this.Price_TextBox.Location = new System.Drawing.Point(288, 136);
            this.Price_TextBox.Name = "Price_TextBox";
            this.Price_TextBox.Size = new System.Drawing.Size(116, 24);
            this.Price_TextBox.TabIndex = 1;
            // 
            // Quantity_TextBox
            // 
            this.Quantity_TextBox.Location = new System.Drawing.Point(288, 196);
            this.Quantity_TextBox.Name = "Quantity_TextBox";
            this.Quantity_TextBox.Size = new System.Drawing.Size(116, 24);
            this.Quantity_TextBox.TabIndex = 2;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(79, 68);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(41, 15);
            this.Name_Label.TabIndex = 5;
            this.Name_Label.Text = "Name:";
            // 
            // Price_Label
            // 
            this.Price_Label.AutoSize = true;
            this.Price_Label.Location = new System.Drawing.Point(79, 139);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(205, 15);
            this.Price_Label.TabIndex = 6;
            this.Price_Label.Text = "Price per Item:                                      $";
            // 
            // Quantity_Label
            // 
            this.Quantity_Label.AutoSize = true;
            this.Quantity_Label.Location = new System.Drawing.Point(79, 204);
            this.Quantity_Label.Name = "Quantity_Label";
            this.Quantity_Label.Size = new System.Drawing.Size(56, 15);
            this.Quantity_Label.TabIndex = 7;
            this.Quantity_Label.Text = "Quantity:";
            // 
            // NewItem_Dialog
            // 
            this.AcceptButton = this.Insert_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.Quantity_Label);
            this.Controls.Add(this.Price_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Quantity_TextBox);
            this.Controls.Add(this.Price_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Insert_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NewItem_Dialog";
            this.Text = "Insert Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Insert_Button;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox Price_TextBox;
        private System.Windows.Forms.TextBox Quantity_TextBox;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Price_Label;
        private System.Windows.Forms.Label Quantity_Label;
    }
}