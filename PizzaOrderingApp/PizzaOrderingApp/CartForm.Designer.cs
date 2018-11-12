namespace PizzaOrderingApp
{
    partial class CartForm
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
            this.PizzaList_Panel = new System.Windows.Forms.Panel();
            this.ConfirmOrder_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Total_Label = new System.Windows.Forms.Label();
            this.Subtotal_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PizzaList_Panel
            // 
            this.PizzaList_Panel.AutoScroll = true;
            this.PizzaList_Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaList_Panel.Location = new System.Drawing.Point(36, 53);
            this.PizzaList_Panel.Name = "PizzaList_Panel";
            this.PizzaList_Panel.Size = new System.Drawing.Size(730, 192);
            this.PizzaList_Panel.TabIndex = 0;
            // 
            // ConfirmOrder_Button
            // 
            this.ConfirmOrder_Button.Location = new System.Drawing.Point(606, 322);
            this.ConfirmOrder_Button.Name = "ConfirmOrder_Button";
            this.ConfirmOrder_Button.Size = new System.Drawing.Size(81, 23);
            this.ConfirmOrder_Button.TabIndex = 1;
            this.ConfirmOrder_Button.Text = "Confirm Order";
            this.ConfirmOrder_Button.UseVisualStyleBackColor = true;
            this.ConfirmOrder_Button.Click += new System.EventHandler(this.ConfirmOrder_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(107, 313);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 2;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Total_Label
            // 
            this.Total_Label.AutoSize = true;
            this.Total_Label.Location = new System.Drawing.Point(489, 322);
            this.Total_Label.Name = "Total_Label";
            this.Total_Label.Size = new System.Drawing.Size(73, 13);
            this.Total_Label.TabIndex = 3;
            this.Total_Label.Text = "Total - $21.12";
            // 
            // Subtotal_Label
            // 
            this.Subtotal_Label.AutoSize = true;
            this.Subtotal_Label.Location = new System.Drawing.Point(492, 282);
            this.Subtotal_Label.Name = "Subtotal_Label";
            this.Subtotal_Label.Size = new System.Drawing.Size(82, 13);
            this.Subtotal_Label.TabIndex = 4;
            this.Subtotal_Label.Text = "Subtotal - $0.00";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Subtotal_Label);
            this.Controls.Add(this.Total_Label);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.ConfirmOrder_Button);
            this.Controls.Add(this.PizzaList_Panel);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PizzaList_Panel;
        private System.Windows.Forms.Button ConfirmOrder_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label Total_Label;
        private System.Windows.Forms.Label Subtotal_Label;
    }
}