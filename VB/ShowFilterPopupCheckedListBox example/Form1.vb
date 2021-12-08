Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList

Namespace ShowFilterPopupCheckedListBox_example

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            table1TableAdapter.Fill(treelistdbDataSet.Table1)
        End Sub

        Private Sub treeList1_ShowFilterPopupCheckedListBox(ByVal sender As Object, ByVal e As FilterPopupCheckedListBoxEventArgs)
            If Not Equals(e.Column.FieldName, "Department") Then Return
            ' disable "(Select All)" item
            e.CheckedComboBox.SelectAllItemVisible = False
        End Sub
    End Class
End Namespace
