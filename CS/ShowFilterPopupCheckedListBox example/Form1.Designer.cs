namespace ShowFilterPopupCheckedListBox_example
{
    partial class Form1
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDepartment = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPosition = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treelistdbDataSet = new ShowFilterPopupCheckedListBox_example.treelistdbDataSet();
            this.table1TableAdapter = new ShowFilterPopupCheckedListBox_example.treelistdbDataSetTableAdapters.Table1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treelistdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colDepartment,
            this.colPosition});
            this.treeList1.DataSource = this.table1BindingSource;
            this.treeList1.Location = new System.Drawing.Point(12, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.EnableFiltering = true;
            this.treeList1.Size = new System.Drawing.Size(382, 233);
            this.treeList1.TabIndex = 0;
            this.treeList1.ShowFilterPopupCheckedListBox += new DevExpress.XtraTreeList.FilterPopupCheckedListBoxEventHandler(this.treeList1_ShowFilterPopupCheckedListBox);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 141;
            // 
            // colDepartment
            // 
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.OptionsFilter.FilterPopupMode = DevExpress.XtraTreeList.FilterPopupMode.CheckedList;
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 1;
            this.colDepartment.Width = 111;
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 2;
            this.colPosition.Width = 112;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.treelistdbDataSet;
            // 
            // treelistdbDataSet
            // 
            this.treelistdbDataSet.DataSetName = "treelistdbDataSet";
            this.treelistdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 257);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treelistdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private treelistdbDataSet treelistdbDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private treelistdbDataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDepartment;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPosition;
    }
}

