namespace Workshop_Inventory_Manager
{
    partial class WorkshopName_Dialog
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
            this.UserPrompt_Label = new System.Windows.Forms.Label();
            this.WorkshopName_TextBox = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserPrompt_Label
            // 
            this.UserPrompt_Label.Location = new System.Drawing.Point(63, 21);
            this.UserPrompt_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserPrompt_Label.Name = "UserPrompt_Label";
            this.UserPrompt_Label.Size = new System.Drawing.Size(341, 111);
            this.UserPrompt_Label.TabIndex = 0;
            this.UserPrompt_Label.Text = "Please enter the name of the workshop you wish to open/create:";
            this.UserPrompt_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkshopName_TextBox
            // 
            this.WorkshopName_TextBox.Location = new System.Drawing.Point(143, 148);
            this.WorkshopName_TextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.WorkshopName_TextBox.Name = "WorkshopName_TextBox";
            this.WorkshopName_TextBox.Size = new System.Drawing.Size(180, 37);
            this.WorkshopName_TextBox.TabIndex = 1;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(161, 223);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(138, 41);
            this.OK_Button.TabIndex = 2;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // WorkshopName_Dialog
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 297);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.WorkshopName_TextBox);
            this.Controls.Add(this.UserPrompt_Label);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "WorkshopName_Dialog";
            this.Text = "Workshop Name";
            this.Load += new System.EventHandler(this.WorkshopName_Dialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserPrompt_Label;
        private System.Windows.Forms.TextBox WorkshopName_TextBox;
        private System.Windows.Forms.Button OK_Button;
    }
}