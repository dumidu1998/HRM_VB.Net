<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeHome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.EmpDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRMDataSet = New HRM.HRMDataSet()
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
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.EmployeeIdToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EmployeeIdToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EmpDetailsTableAdapter = New HRM.HRMDataSetTableAdapters.EmpDetailsTableAdapter()
        Me.TableAdapterManager = New HRM.HRMDataSetTableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        EmployeeIdLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        MobileLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        DesignationLabel = New System.Windows.Forms.Label()
        AppDateLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UserTypeLabel = New System.Windows.Forms.Label()
        CType(Me.EmpDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpDetailsBindingNavigator.SuspendLayout()
        CType(Me.EmpDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeIdLabel
        '
        EmployeeIdLabel.AutoSize = True
        EmployeeIdLabel.Location = New System.Drawing.Point(361, 129)
        EmployeeIdLabel.Name = "EmployeeIdLabel"
        EmployeeIdLabel.Size = New System.Drawing.Size(89, 17)
        EmployeeIdLabel.TabIndex = 13
        EmployeeIdLabel.Text = "Employee Id:"
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(361, 157)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(75, 17)
        FullNameLabel.TabIndex = 15
        FullNameLabel.Text = "Full Name:"
        '
        'MobileLabel
        '
        MobileLabel.AutoSize = True
        MobileLabel.Location = New System.Drawing.Point(361, 185)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(53, 17)
        MobileLabel.TabIndex = 17
        MobileLabel.Text = "Mobile:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(361, 213)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(46, 17)
        EmailLabel.TabIndex = 19
        EmailLabel.Text = "Email:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(361, 241)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(86, 17)
        DepartmentLabel.TabIndex = 21
        DepartmentLabel.Text = "Department:"
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Location = New System.Drawing.Point(361, 269)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(87, 17)
        DesignationLabel.TabIndex = 23
        DesignationLabel.Text = "Designation:"
        '
        'AppDateLabel
        '
        AppDateLabel.AutoSize = True
        AppDateLabel.Location = New System.Drawing.Point(361, 298)
        AppDateLabel.Name = "AppDateLabel"
        AppDateLabel.Size = New System.Drawing.Size(71, 17)
        AppDateLabel.TabIndex = 25
        AppDateLabel.Text = "App Date:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(361, 325)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(73, 17)
        PasswordLabel.TabIndex = 27
        PasswordLabel.Text = "Password:"
        '
        'UserTypeLabel
        '
        UserTypeLabel.AutoSize = True
        UserTypeLabel.Location = New System.Drawing.Point(361, 353)
        UserTypeLabel.Name = "UserTypeLabel"
        UserTypeLabel.Size = New System.Drawing.Size(78, 17)
        UserTypeLabel.TabIndex = 29
        UserTypeLabel.Text = "User Type:"
        UserTypeLabel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(436, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "My Profile"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "View My Attendence"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(255, 38)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "View My Salary"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(576, 398)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 40)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Update Profile"
        Me.Button3.UseVisualStyleBackColor = True
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
        Me.EmpDetailsBindingNavigator.TabIndex = 13
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
        'EmpDetailsBindingSource
        '
        Me.EmpDetailsBindingSource.DataMember = "EmpDetails"
        Me.EmpDetailsBindingSource.DataSource = Me.HRMDataSet
        '
        'HRMDataSet
        '
        Me.HRMDataSet.DataSetName = "HRMDataSet"
        Me.HRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.EmployeeIdTextBox.Enabled = False
        Me.EmployeeIdTextBox.Location = New System.Drawing.Point(456, 126)
        Me.EmployeeIdTextBox.Name = "EmployeeIdTextBox"
        Me.EmployeeIdTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmployeeIdTextBox.TabIndex = 14
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "FullName", True))
        Me.FullNameTextBox.Enabled = False
        Me.FullNameTextBox.Location = New System.Drawing.Point(456, 154)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.FullNameTextBox.TabIndex = 16
        '
        'MobileTextBox
        '
        Me.MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "Mobile", True))
        Me.MobileTextBox.Location = New System.Drawing.Point(456, 182)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(200, 22)
        Me.MobileTextBox.TabIndex = 18
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(456, 210)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmailTextBox.TabIndex = 20
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "Department", True))
        Me.DepartmentTextBox.Enabled = False
        Me.DepartmentTextBox.Location = New System.Drawing.Point(456, 238)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DepartmentTextBox.TabIndex = 22
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "Designation", True))
        Me.DesignationTextBox.Enabled = False
        Me.DesignationTextBox.Location = New System.Drawing.Point(456, 266)
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DesignationTextBox.TabIndex = 24
        '
        'AppDateDateTimePicker
        '
        Me.AppDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpDetailsBindingSource, "AppDate", True))
        Me.AppDateDateTimePicker.Enabled = False
        Me.AppDateDateTimePicker.Location = New System.Drawing.Point(456, 294)
        Me.AppDateDateTimePicker.Name = "AppDateDateTimePicker"
        Me.AppDateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.AppDateDateTimePicker.TabIndex = 26
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(456, 322)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PasswordTextBox.TabIndex = 28
        '
        'UserTypeTextBox
        '
        Me.UserTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDetailsBindingSource, "UserType", True))
        Me.UserTypeTextBox.Location = New System.Drawing.Point(456, 350)
        Me.UserTypeTextBox.Name = "UserTypeTextBox"
        Me.UserTypeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.UserTypeTextBox.TabIndex = 30
        Me.UserTypeTextBox.Visible = False
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeIdToolStripLabel, Me.EmployeeIdToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(800, 27)
        Me.FillByToolStrip.TabIndex = 31
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 438)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(367, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Developed by Himanka Dissanayake.All Rights Reserved"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(704, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(84, 32)
        Me.Button6.TabIndex = 33
        Me.Button6.Text = "LogOut"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'EmployeeHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 458)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FillByToolStrip)
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
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmployeeHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeHome"
        CType(Me.EmpDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpDetailsBindingNavigator.ResumeLayout(False)
        Me.EmpDetailsBindingNavigator.PerformLayout()
        CType(Me.EmpDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
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
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents EmployeeIdToolStripLabel As ToolStripLabel
    Friend WithEvents EmployeeIdToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Button6 As Button
End Class
