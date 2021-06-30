<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarkAttendence
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim EmployeeIdLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MarkAttendence))
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIdTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        EmployeeIdLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.HRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendenceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttendenceBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(254, 7)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 30
        IDLabel.Text = "ID:"
        IDLabel.Visible = False
        '
        'EmployeeIdLabel
        '
        EmployeeIdLabel.AutoSize = True
        EmployeeIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeIdLabel.Location = New System.Drawing.Point(165, 94)
        EmployeeIdLabel.Name = "EmployeeIdLabel"
        EmployeeIdLabel.Size = New System.Drawing.Size(166, 29)
        EmployeeIdLabel.TabIndex = 32
        EmployeeIdLabel.Text = "Employee Id:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(165, 159)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(74, 29)
        DateLabel.TabIndex = 34
        DateLabel.Text = "Date:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(165, 230)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(92, 29)
        StatusLabel.TabIndex = 36
        StatusLabel.Text = "Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 29)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Mark Attendence"
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
        Me.AttendenceBindingNavigator.TabIndex = 22
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(356, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 36)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Mark"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AttendenceBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(349, 4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IDTextBox.TabIndex = 31
        Me.IDTextBox.Visible = False
        '
        'EmployeeIdTextBox
        '
        Me.EmployeeIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AttendenceBindingSource, "EmployeeId", True))
        Me.EmployeeIdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIdTextBox.Location = New System.Drawing.Point(349, 91)
        Me.EmployeeIdTextBox.Name = "EmployeeIdTextBox"
        Me.EmployeeIdTextBox.Size = New System.Drawing.Size(256, 34)
        Me.EmployeeIdTextBox.TabIndex = 33
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AttendenceBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(349, 155)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(256, 34)
        Me.DateDateTimePicker.TabIndex = 35
        '
        'StatusComboBox
        '
        Me.StatusComboBox.AllowDrop = True
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AttendenceBindingSource, "Status", True))
        Me.StatusComboBox.DisplayMember = "0,1"
        Me.StatusComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"1", "0"})
        Me.StatusComboBox.Location = New System.Drawing.Point(349, 227)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(256, 37)
        Me.StatusComboBox.TabIndex = 37
        Me.StatusComboBox.Text = "Present"
        Me.StatusComboBox.ValueMember = "0,1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Developed by Himanka Dissanayake.All Rights Reserved"
        '
        'MarkAttendence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(EmployeeIdLabel)
        Me.Controls.Add(Me.EmployeeIdTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AttendenceBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MarkAttendence"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarkAttendence"
        CType(Me.HRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendenceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttendenceBindingNavigator.ResumeLayout(False)
        Me.AttendenceBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents Button1 As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents EmployeeIdTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents Label2 As Label
End Class
