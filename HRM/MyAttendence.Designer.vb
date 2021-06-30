<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyAttendence
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyAttendence))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HRMDataSet = New HRM.HRMDataSet()
        Me.AttendenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendenceTableAdapter = New HRM.HRMDataSetTableAdapters.AttendenceTableAdapter()
        Me.TableAdapterManager = New HRM.HRMDataSetTableAdapters.TableAdapterManager()
        Me.AttendenceBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AttendenceBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AttendenceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.EmployeeIdToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EmployeeIdToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.HRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendenceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttendenceBindingNavigator.SuspendLayout()
        CType(Me.AttendenceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(306, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 46)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "My Salary"
        '
        'HRMDataSet
        '
        Me.HRMDataSet.DataSetName = "HRMDataSet"
        Me.HRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendenceBindingSource
        '
        Me.AttendenceBindingSource.DataMember = "Attendence"
        Me.AttendenceBindingSource.DataSource = Me.HRMDataSet
        '
        'AttendenceTableAdapter
        '
        Me.AttendenceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AttendenceTableAdapter = Me.AttendenceTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HRM.HRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AttendenceBindingNavigator
        '
        Me.AttendenceBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AttendenceBindingNavigator.BindingSource = Me.AttendenceBindingSource
        Me.AttendenceBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AttendenceBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AttendenceBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AttendenceBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AttendenceBindingNavigatorSaveItem})
        Me.AttendenceBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AttendenceBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AttendenceBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AttendenceBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AttendenceBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AttendenceBindingNavigator.Name = "AttendenceBindingNavigator"
        Me.AttendenceBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AttendenceBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.AttendenceBindingNavigator.TabIndex = 16
        Me.AttendenceBindingNavigator.Text = "BindingNavigator1"
        Me.AttendenceBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'AttendenceBindingNavigatorSaveItem
        '
        Me.AttendenceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AttendenceBindingNavigatorSaveItem.Image = CType(resources.GetObject("AttendenceBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AttendenceBindingNavigatorSaveItem.Name = "AttendenceBindingNavigatorSaveItem"
        Me.AttendenceBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.AttendenceBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AttendenceDataGridView
        '
        Me.AttendenceDataGridView.AutoGenerateColumns = False
        Me.AttendenceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AttendenceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AttendenceDataGridView.DataSource = Me.AttendenceBindingSource
        Me.AttendenceDataGridView.Location = New System.Drawing.Point(47, 109)
        Me.AttendenceDataGridView.Name = "AttendenceDataGridView"
        Me.AttendenceDataGridView.RowHeadersWidth = 51
        Me.AttendenceDataGridView.RowTemplate.Height = 24
        Me.AttendenceDataGridView.Size = New System.Drawing.Size(727, 220)
        Me.AttendenceDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EmployeeId"
        Me.DataGridViewTextBoxColumn2.HeaderText = "EmployeeId"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeIdToolStripLabel, Me.EmployeeIdToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(800, 27)
        Me.FillByToolStrip.TabIndex = 17
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'EmployeeIdToolStripLabel
        '
        Me.EmployeeIdToolStripLabel.Name = "EmployeeIdToolStripLabel"
        Me.EmployeeIdToolStripLabel.Size = New System.Drawing.Size(91, 24)
        Me.EmployeeIdToolStripLabel.Text = "EmployeeId:"
        '
        'EmployeeIdToolStripTextBox
        '
        Me.EmployeeIdToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EmployeeIdToolStripTextBox.Name = "EmployeeIdToolStripTextBox"
        Me.EmployeeIdToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 24)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 429)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(367, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Developed by Himanka Dissanayake.All Rights Reserved"
        '
        'MyAttendence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.AttendenceDataGridView)
        Me.Controls.Add(Me.AttendenceBindingNavigator)
        Me.Controls.Add(Me.Label5)
        Me.Name = "MyAttendence"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyAttendence"
        CType(Me.HRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendenceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttendenceBindingNavigator.ResumeLayout(False)
        Me.AttendenceBindingNavigator.PerformLayout()
        CType(Me.AttendenceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents HRMDataSet As HRMDataSet
    Friend WithEvents AttendenceBindingSource As BindingSource
    Friend WithEvents AttendenceTableAdapter As HRMDataSetTableAdapters.AttendenceTableAdapter
    Friend WithEvents TableAdapterManager As HRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AttendenceBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AttendenceBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AttendenceDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents EmployeeIdToolStripLabel As ToolStripLabel
    Friend WithEvents EmployeeIdToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents Label4 As Label
End Class
