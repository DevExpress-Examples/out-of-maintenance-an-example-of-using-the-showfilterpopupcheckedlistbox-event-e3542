Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList

Namespace ShowFilterPopupCheckedListBox_example
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.table1TableAdapter.Fill(Me.treelistdbDataSet.Table1)
		End Sub

		Private Sub treeList1_ShowFilterPopupCheckedListBox(ByVal sender As Object, ByVal e As FilterPopupCheckedListBoxEventArgs) Handles treeList1.ShowFilterPopupCheckedListBox
			If e.Column.FieldName <> "Department" Then
				Return
			End If
			' disable "(Select All)" item
			e.CheckedComboBox.SelectAllItemVisible = False
		End Sub
	End Class
End Namespace
