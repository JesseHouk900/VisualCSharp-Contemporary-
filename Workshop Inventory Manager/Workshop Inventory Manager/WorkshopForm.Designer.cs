/*      Jesse Houk - WorkshopFormDesigner.cs
 *      Purpose - modified dispose to hide the save option if the number of 
 *      child forms is 0 and made the Items_ListBox public (private by default)
 */
namespace Workshop_Inventory_Manager
{
    partial class Workshop_Form
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
            // if the form is disposing...
            if(disposing)
            {
                // and the number of mdi children will be 0 after disposing...
                if (MdiParent.MdiChildren.GetLength(0) - 1 == 0) {
                    // make the save option invisible
                    ((WorkshopManagerForm)MdiParent).saveToolStripMenuItem.Visible = false;
                }
                if (components != null)
                {
                    components.Dispose();
                }

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
            this.Items_ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Items_ListBox
            // 
            this.Items_ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Items_ListBox.FormattingEnabled = true;
            this.Items_ListBox.ItemHeight = 15;
            this.Items_ListBox.Location = new System.Drawing.Point(0, 0);
            this.Items_ListBox.MultiColumn = true;
            this.Items_ListBox.Name = "Items_ListBox";
            this.Items_ListBox.Size = new System.Drawing.Size(464, 321);
            this.Items_ListBox.TabIndex = 0;
            this.Items_ListBox.SelectedIndexChanged += new System.EventHandler(this.Items_ListBox_SelectedIndexChanged);
            // 
            // Workshop_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.Items_ListBox);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Workshop_Form";
            this.Text = "WorkshopForm";
            this.Enter += new System.EventHandler(this.Workshop_Form_Enter);
            this.ResumeLayout(false);

        }

        #endregion
        // make the listbox available anywhere with an instance of a workshopForm
        public System.Windows.Forms.ListBox Items_ListBox;
    }
}