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
            this.ConfirmOrder_Button.Location = new System.Drawing.Point(611, 266);
            this.ConfirmOrder_Button.Name = "ConfirmOrder_Button";
            this.ConfirmOrder_Button.Size = new System.Drawing.Size(81, 23);
            this.ConfirmOrder_Button.TabIndex = 1;
            this.ConfirmOrder_Button.Text = "Confirm Order";
            this.ConfirmOrder_Button.UseVisualStyleBackColor = true;
            this.ConfirmOrder_Button.Click += new System.EventHandler(this.ConfirmOrder_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(65, 266);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 2;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.ConfirmOrder_Button);
            this.Controls.Add(this.PizzaList_Panel);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PizzaList_Panel;
        private System.Windows.Forms.Button ConfirmOrder_Button;
        private System.Windows.Forms.Button Back_Button;
    }
}