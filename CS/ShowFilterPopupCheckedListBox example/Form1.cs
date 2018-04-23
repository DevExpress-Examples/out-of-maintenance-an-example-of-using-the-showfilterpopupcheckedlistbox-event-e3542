using System;
using System.Windows.Forms;
using DevExpress.XtraTreeList;

namespace ShowFilterPopupCheckedListBox_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.table1TableAdapter.Fill(this.treelistdbDataSet.Table1);
        }

        private void treeList1_ShowFilterPopupCheckedListBox(object sender, FilterPopupCheckedListBoxEventArgs e)
        {
            if (e.Column.FieldName != "Department") return;
            // disable "(Select All)" item
            e.CheckedComboBox.SelectAllItemVisible = false;
        }
    }
}
