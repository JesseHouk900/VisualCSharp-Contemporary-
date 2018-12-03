namespace AddQueryResult
{
    partial class TitleQueriesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleQueriesForm));
            this.titleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.titleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.titleDataGridView = new System.Windows.Forms.DataGridView();
            this.queriesComboBox = new System.Windows.Forms.ComboBox();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyrightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingNavigator)).BeginInit();
            this.titleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBindingSource
            // 
            this.titleBindingSource.DataSource = typeof(BooksExample.Title);
            // 
            // titleBindingNavigator
            // 
            this.titleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.titleBindingNavigator.BindingSource = this.titleBindingSource;
            this.titleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.titleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.titleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.titleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.titleBindingNavigatorSaveItem});
            this.titleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.titleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.titleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.titleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.titleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.titleBindingNavigator.Name = "titleBindingNavigator";
            this.titleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.titleBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.titleBindingNavigator.TabIndex = 0;
            this.titleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // titleBindingNavigatorSaveItem
            // 
            this.titleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.titleBindingNavigatorSaveItem.Enabled = false;
            this.titleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("titleBindingNavigatorSaveItem.Image")));
            this.titleBindingNavigatorSaveItem.Name = "titleBindingNavigatorSaveItem";
            this.titleBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.titleBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // titleDataGridView
            // 
            this.titleDataGridView.AutoGenerateColumns = false;
            this.titleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.titleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.title1DataGridViewTextBoxColumn,
            this.editionNumberDataGridViewTextBoxColumn,
            this.copyrightDataGridViewTextBoxColumn});
            this.titleDataGridView.DataSource = this.titleBindingSource;
            this.titleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleDataGridView.Location = new System.Drawing.Point(0, 27);
            this.titleDataGridView.Name = "titleDataGridView";
            this.titleDataGridView.RowTemplate.Height = 24;
            this.titleDataGridView.Size = new System.Drawing.Size(800, 423);
            this.titleDataGridView.TabIndex = 1;
            // 
            // queriesComboBox
            // 
            this.queriesComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.queriesComboBox.FormattingEnabled = true;
            this.queriesComboBox.Items.AddRange(new object[] {
            "All titles",
            "Titles with 2016 copyright",
            "Titles ending with “How to Program”"});
            this.queriesComboBox.Location = new System.Drawing.Point(0, 426);
            this.queriesComboBox.Name = "queriesComboBox";
            this.queriesComboBox.Size = new System.Drawing.Size(800, 24);
            this.queriesComboBox.TabIndex = 2;
            this.queriesComboBox.SelectedIndexChanged += new System.EventHandler(this.queriesComboBox_SelectedIndexChanged);
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // title1DataGridViewTextBoxColumn
            // 
            this.title1DataGridViewTextBoxColumn.DataPropertyName = "Title1";
            this.title1DataGridViewTextBoxColumn.HeaderText = "Title1";
            this.title1DataGridViewTextBoxColumn.Name = "title1DataGridViewTextBoxColumn";
            this.title1DataGridViewTextBoxColumn.Width = 150;
            // 
            // editionNumberDataGridViewTextBoxColumn
            // 
            this.editionNumberDataGridViewTextBoxColumn.DataPropertyName = "EditionNumber";
            this.editionNumberDataGridViewTextBoxColumn.HeaderText = "EditionNumber";
            this.editionNumberDataGridViewTextBoxColumn.Name = "editionNumberDataGridViewTextBoxColumn";
            // 
            // copyrightDataGridViewTextBoxColumn
            // 
            this.copyrightDataGridViewTextBoxColumn.DataPropertyName = "Copyright";
            this.copyrightDataGridViewTextBoxColumn.HeaderText = "Copyright";
            this.copyrightDataGridViewTextBoxColumn.Name = "copyrightDataGridViewTextBoxColumn";
            // 
            // TitleQueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queriesComboBox);
            this.Controls.Add(this.titleDataGridView);
            this.Controls.Add(this.titleBindingNavigator);
            this.Name = "TitleQueriesForm";
            this.Text = "Title Queries";
            this.Load += new System.EventHandler(this.TitleQueriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingNavigator)).EndInit();
            this.titleBindingNavigator.ResumeLayout(false);
            this.titleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource titleBindingSource;
        private System.Windows.Forms.BindingNavigator titleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton titleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView titleDataGridView;
        private System.Windows.Forms.ComboBox queriesComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn title1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copyrightDataGridViewTextBoxColumn;
    }
}

