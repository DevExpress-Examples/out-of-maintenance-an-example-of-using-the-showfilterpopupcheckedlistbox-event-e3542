Namespace ShowFilterPopupCheckedListBox_example

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.colName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colDepartment = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colPosition = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.treelistdbDataSet = New ShowFilterPopupCheckedListBox_example.treelistdbDataSet()
            Me.table1TableAdapter = New ShowFilterPopupCheckedListBox_example.treelistdbDataSetTableAdapters.Table1TableAdapter()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.table1BindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.treelistdbDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colName, Me.colDepartment, Me.colPosition})
            Me.treeList1.DataSource = Me.table1BindingSource
            Me.treeList1.Location = New System.Drawing.Point(12, 12)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.EnableFiltering = True
            Me.treeList1.Size = New System.Drawing.Size(382, 233)
            Me.treeList1.TabIndex = 0
            AddHandler Me.treeList1.ShowFilterPopupCheckedListBox, New DevExpress.XtraTreeList.FilterPopupCheckedListBoxEventHandler(AddressOf Me.treeList1_ShowFilterPopupCheckedListBox)
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 0
            Me.colName.Width = 141
            ' 
            ' colDepartment
            ' 
            Me.colDepartment.FieldName = "Department"
            Me.colDepartment.Name = "colDepartment"
            Me.colDepartment.OptionsFilter.FilterPopupMode = DevExpress.XtraTreeList.FilterPopupMode.CheckedList
            Me.colDepartment.Visible = True
            Me.colDepartment.VisibleIndex = 1
            Me.colDepartment.Width = 111
            ' 
            ' colPosition
            ' 
            Me.colPosition.FieldName = "Position"
            Me.colPosition.Name = "colPosition"
            Me.colPosition.Visible = True
            Me.colPosition.VisibleIndex = 2
            Me.colPosition.Width = 112
            ' 
            ' table1BindingSource
            ' 
            Me.table1BindingSource.DataMember = "Table1"
            Me.table1BindingSource.DataSource = Me.treelistdbDataSet
            ' 
            ' treelistdbDataSet
            ' 
            Me.treelistdbDataSet.DataSetName = "treelistdbDataSet"
            Me.treelistdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' table1TableAdapter
            ' 
            Me.table1TableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(406, 257)
            Me.Controls.Add(Me.treeList1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.table1BindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.treelistdbDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private treelistdbDataSet As ShowFilterPopupCheckedListBox_example.treelistdbDataSet

        Private table1BindingSource As System.Windows.Forms.BindingSource

        Private table1TableAdapter As ShowFilterPopupCheckedListBox_example.treelistdbDataSetTableAdapters.Table1TableAdapter

        Private colName As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colDepartment As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colPosition As DevExpress.XtraTreeList.Columns.TreeListColumn
    End Class
End Namespace
