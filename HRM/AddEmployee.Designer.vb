<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee
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
        Dim EmployeeIdLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim MobileLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim DesignationLabel As System.Windows.Forms.Label
        Dim AppDateLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UserTypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEmployee))
        Me.HRMDataSet = New HRM.HRMDataSet()
        Me.EmpDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpDetailsTableAdapter = New HRM.HRMDataSetTableAdapters.EmpDetailsTableAdapter()
        Me.TableAdapterManager = New HRM.HRMDataSetTableAdapters.TableAdapterManager()
        Me.EmpDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmpDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EmployeeIdTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.MobileTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.AppDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserTypeTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        EmployeeIdLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        MobileLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        DesignationLabel = New System.Windows.Forms.Label()
        AppDateLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UserTypeLabel = New System.Windows.Forms.Label()
        CType(Me.HRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpDetailsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeIdLabel
        '
        EmployeeIdLabel.AutoSize = True
        EmployeeIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeIdLabel.Location = New System.Drawing.Point(234, 125)
        EmployeeIdLabel.Name = "EmployeeIdLabel"
        EmployeeIdLabel.Size = New System.Drawing.Size(133, 24)
        EmployeeIdLabel.TabIndex = 1
        EmployeeIdLabel.Text = "Employee Id:"
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FullNameLabel.Location = New System.Drawing.Point(234, 153)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(112, 24)
        FullNameLabel.TabIndex = 3
        FullNameLabel.Text = "Full Name:"
        '
        'MobileLabel
        '
        MobileLabel.AutoSize = True
        MobileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MobileLabel.Location = New System.Drawing.Point(234, 181)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(79, 24)
        MobileLabel.TabIndex = 5
        MobileLabel.Text = "Mobile:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(234, 209)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(68, 24)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "Email:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(234, 237)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(123, 24)
        DepartmentLabel.TabIndex = 9
        DepartmentLabel.Text = "Department:"
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesignationLabel.Location = New System.Drawing.Point(234, 265)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(126, 24)
        DesignationLabel.TabIndex = 11
        DesignationLabel.Text = "Designation:"
        '
        'AppDateLabel
        '
        AppDateLabel.AutoSize = True
        AppDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AppDateLabel.Location = New System.Drawing.Point(234, 294)
        AppDateLabel.Name = "AppDateLabel"
        AppDateLabel.Size = New System.Drawing.Size(102, 24)
        AppDateLabel.TabIndex = 13
        AppDateLabel.Text = "App Date:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(234, 321)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(106, 24)
        PasswordLabel.TabIndex = 15
        PasswordLabel.Text = "Password:"
        '
        'UserTypeLabel
        '
        UserTypeLabel.AutoSize = True
        UserTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserTypeLabel.Location = New System.Drawing.Point(234, 349)
        UserTypeLabel.Name = "UserTypeLabel"
        UserTypeLabel.Size = New System.Drawing.Size(112, 24)
        UserTypeLabel.TabIndex = 17
        UserTypeLabel.Text = "User Type:"
        UserTypeLabel.Visible = False
        '
        'HRMDataSet
        '
        Me.HRMDataSet.DataSetName = "HRMDataSet"
        Me.HRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpDetailsBindingSource
        '
        Me.EmpDetailsBindingSource.DataMember = "EmpDetails"
        Me.EmpDetailsBindingSource.DataSource = Me.HRMDataSet
        '
        'EmpDetailsTableAdapter
        '
        Me.EmpDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AttendenceTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpDetailsTableAdapter = Me.EmpDetailsTableAdapter
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HRM.HRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpDetailsBindingNavigator
        '
        Me.EmpDetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpDetailsBindingNavigator.BindingSource = Me.EmpDetailsBindingSource
        Me.EmpDetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpDetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpDetailsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EmpDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpDetailsBindingNavigatorSaveItem})
        Me.EmpDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpDetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpDetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpDetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpDetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpDetailsBindingNavigator.Name = "EmpDetailsBindingNavigator"
        Me.EmpDetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpDetailsBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.EmpDetailsBindingNavigator.TabIndex = 0
        Me.EmpDetailsBindingNavigator.Text = "BindingNavigator1"
        Me.EmpDetailsBindingNavigator.Visible = False
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
        'EmpDetailsBindingNavigatorSaveItem
        '
        Me.EmpDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpDetailsBindingNavigatorSaveItem.Name = "EmpDetailsBindingNavigatorSaveItem"
        Me.EmpDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.EmpDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EmployeeIdTextBox
        '
        Me.EmployeeIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "EmployeeId", True))
        Me.EmployeeIdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIdTextBox.Location = New System.Drawing.Point(381, 122)
        Me.EmployeeIdTextBox.Name = "EmployeeIdTextBox"
        Me.EmployeeIdTextBox.Size = New System.Drawing.Size(200, 28)
        Me.EmployeeIdTextBox.TabIndex = 2
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "FullName", True))
        Me.FullNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullNameTextBox.Location = New System.Drawing.Point(381, 150)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(200, 28)
        Me.FullNameTextBox.TabIndex = 4
        '
        'MobileTextBox
        '
        Me.MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "Mobile", True))
        Me.MobileTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileTextBox.Location = New System.Drawing.Point(381, 178)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(200, 28)
        Me.MobileTextBox.TabIndex = 6
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(381, 206)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 28)
        Me.EmailTextBox.TabIndex = 8
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "Department", True))
        Me.DepartmentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(381, 234)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(200, 28)
        Me.DepartmentTextBox.TabIndex = 10
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "Designation", True))
        Me.DesignationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesignationTextBox.Location = New System.Drawing.Point(381, 262)
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(200, 28)
        Me.DesignationTextBox.TabIndex = 12
        '
        'AppDateDateTimePicker
        '
        Me.AppDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpDetailsBindingSource, "AppDate", True))
        Me.AppDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppDateDateTimePicker.Location = New System.Drawing.Point(381, 290)
        Me.AppDateDateTimePicker.Name = "AppDateDateTimePicker"
        Me.AppDateDateTimePicker.Size = New System.Drawing.Size(200, 28)
        Me.AppDateDateTimePicker.TabIndex = 14
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "Password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(381, 318)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 28)
        Me.PasswordTextBox.TabIndex = 16
        '
        'UserTypeTextBox
        '
        Me.UserTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "UserType", True))
        Me.UserTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTypeTextBox.Location = New System.Drawing.Point(381, 346)
        Me.UserTypeTextBox.Name = "UserTypeTextBox"
        Me.UserTypeTextBox.Size = New System.Drawing.Size(200, 28)
        Me.UserTypeTextBox.TabIndex = 18
        Me.UserTypeTextBox.Text = "0"
        Me.UserTypeTextBox.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(311, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 31)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Add Employee"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 29)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Add New Employee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 454)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Developed by Himanka Dissanayake.All Rights Reserved"
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 473)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(EmployeeIdLabel)
        Me.Controls.Add(Me.EmployeeIdTextBox)
        Me.Controls.Add(FullNameLabel)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(MobileLabel)
        Me.Controls.Add(Me.MobileTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(DesignationLabel)
        Me.Controls.Add(Me.DesignationTextBox)
        Me.Controls.Add(AppDateLabel)
        Me.Controls.Add(Me.AppDateDateTimePicker)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UserTypeLabel)
        Me.Controls.Add(Me.UserTypeTextBox)
        Me.Controls.Add(Me.EmpDetailsBindingNavigator)
        Me.Name = "AddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddEmployee"
        CType(Me.HRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpDetailsBindingNavigator.ResumeLayout(False)
        Me.EmpDetailsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HRMDataSet As HRMDataSet
    Friend WithEvents EmpDetailsBindingSource As BindingSource
    Friend WithEvents EmpDetailsTableAdapter As HRMDataSetTableAdapters.EmpDetailsTableAdapter
    Friend WithEvents TableAdapterManager As HRMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpDetailsBindingNavigator As BindingNavigator
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
    Friend WithEvents EmpDetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EmployeeIdTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents MobileTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents DesignationTextBox As TextBox
    Friend WithEvents AppDateDateTimePicker As DateTimePicker
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UserTypeTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
