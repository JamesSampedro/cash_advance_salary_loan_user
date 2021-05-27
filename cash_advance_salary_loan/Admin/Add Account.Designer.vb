<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accountManage
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
        Me.txt_middleInitial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.lbl_lastName = New System.Windows.Forms.Label()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.lbl_firstName = New System.Windows.Forms.Label()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.lbl_employeeID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_addUserType = New System.Windows.Forms.ComboBox()
        Me.lbl_addUsertype = New System.Windows.Forms.Label()
        Me.txt_addPassword = New System.Windows.Forms.TextBox()
        Me.lbl_addPassword = New System.Windows.Forms.Label()
        Me.dgv_employeeList = New System.Windows.Forms.DataGridView()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleinitialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cash_advance_salary_loanDataSet = New cash_advance_salary_loan.cash_advance_salary_loanDataSet()
        Me.EmployeeTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.employeeTableAdapter()
        Me.lbl_employeeList = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_modifyUserType = New System.Windows.Forms.ComboBox()
        Me.lbl_modifyUserType = New System.Windows.Forms.Label()
        Me.lbl_identity = New System.Windows.Forms.Label()
        Me.txt_identity = New System.Windows.Forms.TextBox()
        Me.lbl_modifyPassword = New System.Windows.Forms.Label()
        Me.txt_modifyPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_loginList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_employeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_loginList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_middleInitial
        '
        Me.txt_middleInitial.Location = New System.Drawing.Point(113, 110)
        Me.txt_middleInitial.Name = "txt_middleInitial"
        Me.txt_middleInitial.ReadOnly = True
        Me.txt_middleInitial.Size = New System.Drawing.Size(71, 22)
        Me.txt_middleInitial.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Middle Initial:"
        '
        'txt_lastName
        '
        Me.txt_lastName.Location = New System.Drawing.Point(113, 82)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.ReadOnly = True
        Me.txt_lastName.Size = New System.Drawing.Size(154, 22)
        Me.txt_lastName.TabIndex = 30
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(27, 87)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(80, 17)
        Me.lbl_lastName.TabIndex = 29
        Me.lbl_lastName.Text = "Last Name:"
        '
        'txt_firstName
        '
        Me.txt_firstName.Location = New System.Drawing.Point(113, 54)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.ReadOnly = True
        Me.txt_firstName.Size = New System.Drawing.Size(154, 22)
        Me.txt_firstName.TabIndex = 28
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(27, 59)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(80, 17)
        Me.lbl_firstName.TabIndex = 27
        Me.lbl_firstName.Text = "First Name:"
        '
        'txt_employeeID
        '
        Me.txt_employeeID.Location = New System.Drawing.Point(113, 27)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.Size = New System.Drawing.Size(71, 22)
        Me.txt_employeeID.TabIndex = 26
        '
        'lbl_employeeID
        '
        Me.lbl_employeeID.AutoSize = True
        Me.lbl_employeeID.Location = New System.Drawing.Point(16, 32)
        Me.lbl_employeeID.Name = "lbl_employeeID"
        Me.lbl_employeeID.Size = New System.Drawing.Size(91, 17)
        Me.lbl_employeeID.TabIndex = 25
        Me.lbl_employeeID.Text = "Employee ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Add)
        Me.GroupBox1.Controls.Add(Me.cmb_addUserType)
        Me.GroupBox1.Controls.Add(Me.lbl_addUsertype)
        Me.GroupBox1.Controls.Add(Me.txt_addPassword)
        Me.GroupBox1.Controls.Add(Me.lbl_addPassword)
        Me.GroupBox1.Controls.Add(Me.lbl_employeeID)
        Me.GroupBox1.Controls.Add(Me.txt_middleInitial)
        Me.GroupBox1.Controls.Add(Me.txt_employeeID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_firstName)
        Me.GroupBox1.Controls.Add(Me.txt_lastName)
        Me.GroupBox1.Controls.Add(Me.txt_firstName)
        Me.GroupBox1.Controls.Add(Me.lbl_lastName)
        Me.GroupBox1.Location = New System.Drawing.Point(581, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 252)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Employee to Login"
        '
        'cmb_addUserType
        '
        Me.cmb_addUserType.FormattingEnabled = True
        Me.cmb_addUserType.Items.AddRange(New Object() {"Admin", "Authorizer", "User"})
        Me.cmb_addUserType.Location = New System.Drawing.Point(113, 166)
        Me.cmb_addUserType.Name = "cmb_addUserType"
        Me.cmb_addUserType.Size = New System.Drawing.Size(154, 24)
        Me.cmb_addUserType.TabIndex = 36
        '
        'lbl_addUsertype
        '
        Me.lbl_addUsertype.AutoSize = True
        Me.lbl_addUsertype.Location = New System.Drawing.Point(29, 169)
        Me.lbl_addUsertype.Name = "lbl_addUsertype"
        Me.lbl_addUsertype.Size = New System.Drawing.Size(78, 17)
        Me.lbl_addUsertype.TabIndex = 35
        Me.lbl_addUsertype.Text = "User Type:"
        '
        'txt_addPassword
        '
        Me.txt_addPassword.Location = New System.Drawing.Point(113, 138)
        Me.txt_addPassword.Name = "txt_addPassword"
        Me.txt_addPassword.Size = New System.Drawing.Size(154, 22)
        Me.txt_addPassword.TabIndex = 34
        '
        'lbl_addPassword
        '
        Me.lbl_addPassword.AutoSize = True
        Me.lbl_addPassword.Location = New System.Drawing.Point(34, 143)
        Me.lbl_addPassword.Name = "lbl_addPassword"
        Me.lbl_addPassword.Size = New System.Drawing.Size(73, 17)
        Me.lbl_addPassword.TabIndex = 33
        Me.lbl_addPassword.Text = "Password:"
        '
        'dgv_employeeList
        '
        Me.dgv_employeeList.AutoGenerateColumns = False
        Me.dgv_employeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_employeeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeidDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.MiddleinitialDataGridViewTextBoxColumn})
        Me.dgv_employeeList.DataSource = Me.EmployeeBindingSource
        Me.dgv_employeeList.Location = New System.Drawing.Point(12, 43)
        Me.dgv_employeeList.Name = "dgv_employeeList"
        Me.dgv_employeeList.RowHeadersWidth = 51
        Me.dgv_employeeList.RowTemplate.Height = 24
        Me.dgv_employeeList.Size = New System.Drawing.Size(553, 252)
        Me.dgv_employeeList.TabIndex = 34
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.Width = 125
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.Width = 125
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.Width = 125
        '
        'MiddleinitialDataGridViewTextBoxColumn
        '
        Me.MiddleinitialDataGridViewTextBoxColumn.DataPropertyName = "middle_initial"
        Me.MiddleinitialDataGridViewTextBoxColumn.HeaderText = "Middle Initial"
        Me.MiddleinitialDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MiddleinitialDataGridViewTextBoxColumn.Name = "MiddleinitialDataGridViewTextBoxColumn"
        Me.MiddleinitialDataGridViewTextBoxColumn.Width = 125
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        '
        'Cash_advance_salary_loanDataSet
        '
        Me.Cash_advance_salary_loanDataSet.DataSetName = "cash_advance_salary_loanDataSet"
        Me.Cash_advance_salary_loanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'lbl_employeeList
        '
        Me.lbl_employeeList.AutoSize = True
        Me.lbl_employeeList.Location = New System.Drawing.Point(9, 12)
        Me.lbl_employeeList.Name = "lbl_employeeList"
        Me.lbl_employeeList.Size = New System.Drawing.Size(100, 17)
        Me.lbl_employeeList.TabIndex = 37
        Me.lbl_employeeList.Text = "Employee List:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_delete)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Controls.Add(Me.cmb_modifyUserType)
        Me.GroupBox2.Controls.Add(Me.lbl_modifyUserType)
        Me.GroupBox2.Controls.Add(Me.lbl_identity)
        Me.GroupBox2.Controls.Add(Me.txt_identity)
        Me.GroupBox2.Controls.Add(Me.lbl_modifyPassword)
        Me.GroupBox2.Controls.Add(Me.txt_modifyPassword)
        Me.GroupBox2.Location = New System.Drawing.Point(581, 344)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 180)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edit or Delete Account to Login"
        '
        'cmb_modifyUserType
        '
        Me.cmb_modifyUserType.FormattingEnabled = True
        Me.cmb_modifyUserType.Items.AddRange(New Object() {"Admin", "Authorizer", "User"})
        Me.cmb_modifyUserType.Location = New System.Drawing.Point(113, 82)
        Me.cmb_modifyUserType.Name = "cmb_modifyUserType"
        Me.cmb_modifyUserType.Size = New System.Drawing.Size(154, 24)
        Me.cmb_modifyUserType.TabIndex = 36
        '
        'lbl_modifyUserType
        '
        Me.lbl_modifyUserType.AutoSize = True
        Me.lbl_modifyUserType.Location = New System.Drawing.Point(29, 85)
        Me.lbl_modifyUserType.Name = "lbl_modifyUserType"
        Me.lbl_modifyUserType.Size = New System.Drawing.Size(78, 17)
        Me.lbl_modifyUserType.TabIndex = 35
        Me.lbl_modifyUserType.Text = "User Type:"
        '
        'lbl_identity
        '
        Me.lbl_identity.AutoSize = True
        Me.lbl_identity.Location = New System.Drawing.Point(33, 32)
        Me.lbl_identity.Name = "lbl_identity"
        Me.lbl_identity.Size = New System.Drawing.Size(74, 17)
        Me.lbl_identity.TabIndex = 25
        Me.lbl_identity.Text = "Identity ID:"
        '
        'txt_identity
        '
        Me.txt_identity.Location = New System.Drawing.Point(113, 27)
        Me.txt_identity.Name = "txt_identity"
        Me.txt_identity.ReadOnly = True
        Me.txt_identity.Size = New System.Drawing.Size(71, 22)
        Me.txt_identity.TabIndex = 26
        '
        'lbl_modifyPassword
        '
        Me.lbl_modifyPassword.AutoSize = True
        Me.lbl_modifyPassword.Location = New System.Drawing.Point(33, 59)
        Me.lbl_modifyPassword.Name = "lbl_modifyPassword"
        Me.lbl_modifyPassword.Size = New System.Drawing.Size(73, 17)
        Me.lbl_modifyPassword.TabIndex = 27
        Me.lbl_modifyPassword.Text = "Password:"
        '
        'txt_modifyPassword
        '
        Me.txt_modifyPassword.Location = New System.Drawing.Point(113, 54)
        Me.txt_modifyPassword.Name = "txt_modifyPassword"
        Me.txt_modifyPassword.ReadOnly = True
        Me.txt_modifyPassword.Size = New System.Drawing.Size(154, 22)
        Me.txt_modifyPassword.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Login List:"
        '
        'dgv_loginList
        '
        Me.dgv_loginList.AutoGenerateColumns = False
        Me.dgv_loginList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_loginList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgv_loginList.DataSource = Me.EmployeeBindingSource
        Me.dgv_loginList.Location = New System.Drawing.Point(12, 344)
        Me.dgv_loginList.Name = "dgv_loginList"
        Me.dgv_loginList.RowHeadersWidth = 51
        Me.dgv_loginList.RowTemplate.Height = 24
        Me.dgv_loginList.Size = New System.Drawing.Size(553, 252)
        Me.dgv_loginList.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "employee_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "first_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "last_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "middle_initial"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Middle Initial"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_Add.Location = New System.Drawing.Point(100, 201)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(96, 36)
        Me.btn_Add.TabIndex = 43
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_edit.Location = New System.Drawing.Point(32, 126)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(96, 36)
        Me.btn_edit.TabIndex = 44
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_delete.Location = New System.Drawing.Point(171, 126)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(96, 36)
        Me.btn_delete.TabIndex = 45
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'frm_accountManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(889, 613)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgv_loginList)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_employeeList)
        Me.Controls.Add(Me.dgv_employeeList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_accountManage"
        Me.Text = "Account Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_employeeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_loginList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_middleInitial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_lastName As TextBox
    Friend WithEvents lbl_lastName As Label
    Friend WithEvents txt_firstName As TextBox
    Friend WithEvents lbl_firstName As Label
    Friend WithEvents txt_employeeID As TextBox
    Friend WithEvents lbl_employeeID As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_addPassword As TextBox
    Friend WithEvents lbl_addPassword As Label
    Friend WithEvents cmb_addUserType As ComboBox
    Friend WithEvents lbl_addUsertype As Label
    Friend WithEvents dgv_employeeList As DataGridView
    Friend WithEvents Cash_advance_salary_loanDataSet As cash_advance_salary_loanDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As cash_advance_salary_loanDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleinitialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lbl_employeeList As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmb_modifyUserType As ComboBox
    Friend WithEvents lbl_modifyUserType As Label
    Friend WithEvents lbl_identity As Label
    Friend WithEvents txt_identity As TextBox
    Friend WithEvents lbl_modifyPassword As Label
    Friend WithEvents txt_modifyPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_loginList As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
End Class
