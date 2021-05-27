<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accountLogs
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
        Me.lbl_employeeID = New System.Windows.Forms.Label()
        Me.txt_middleInitial = New System.Windows.Forms.TextBox()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_firstName = New System.Windows.Forms.Label()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.lbl_lastName = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdentityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cash_advance_salary_loanDataSet = New cash_advance_salary_loan.cash_advance_salary_loanDataSet()
        Me.lbl_accountLogs = New System.Windows.Forms.Label()
        Me.btn_sortLatest = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.IdentityTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.identityTableAdapter()
        Me.LogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.logTableAdapter()
        Me.log_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timestamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usertype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdentityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_employeeID
        '
        Me.lbl_employeeID.AutoSize = True
        Me.lbl_employeeID.Location = New System.Drawing.Point(12, 21)
        Me.lbl_employeeID.Name = "lbl_employeeID"
        Me.lbl_employeeID.Size = New System.Drawing.Size(91, 17)
        Me.lbl_employeeID.TabIndex = 33
        Me.lbl_employeeID.Text = "Employee ID:"
        '
        'txt_middleInitial
        '
        Me.txt_middleInitial.Enabled = False
        Me.txt_middleInitial.Location = New System.Drawing.Point(368, 44)
        Me.txt_middleInitial.Name = "txt_middleInitial"
        Me.txt_middleInitial.ReadOnly = True
        Me.txt_middleInitial.Size = New System.Drawing.Size(71, 22)
        Me.txt_middleInitial.TabIndex = 40
        '
        'txt_employeeID
        '
        Me.txt_employeeID.Enabled = False
        Me.txt_employeeID.Location = New System.Drawing.Point(109, 16)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.ReadOnly = True
        Me.txt_employeeID.Size = New System.Drawing.Size(71, 22)
        Me.txt_employeeID.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Middle Initial:"
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(23, 48)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(80, 17)
        Me.lbl_firstName.TabIndex = 35
        Me.lbl_firstName.Text = "First Name:"
        '
        'txt_lastName
        '
        Me.txt_lastName.Enabled = False
        Me.txt_lastName.Location = New System.Drawing.Point(368, 16)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.ReadOnly = True
        Me.txt_lastName.Size = New System.Drawing.Size(154, 22)
        Me.txt_lastName.TabIndex = 38
        '
        'txt_firstName
        '
        Me.txt_firstName.Enabled = False
        Me.txt_firstName.Location = New System.Drawing.Point(109, 43)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.ReadOnly = True
        Me.txt_firstName.Size = New System.Drawing.Size(154, 22)
        Me.txt_firstName.TabIndex = 36
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(282, 21)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(80, 17)
        Me.lbl_lastName.TabIndex = 37
        Me.lbl_lastName.Text = "Last Name:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.log_id, Me.employee_id, Me.timestamp, Me.usertype, Me.activity})
        Me.DataGridView1.DataSource = Me.LogBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(679, 262)
        Me.DataGridView1.TabIndex = 41
        '
        'IdentityBindingSource
        '
        Me.IdentityBindingSource.DataMember = "identity"
        Me.IdentityBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        '
        'Cash_advance_salary_loanDataSet
        '
        Me.Cash_advance_salary_loanDataSet.DataSetName = "cash_advance_salary_loanDataSet"
        Me.Cash_advance_salary_loanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_accountLogs
        '
        Me.lbl_accountLogs.AutoSize = True
        Me.lbl_accountLogs.Location = New System.Drawing.Point(12, 90)
        Me.lbl_accountLogs.Name = "lbl_accountLogs"
        Me.lbl_accountLogs.Size = New System.Drawing.Size(98, 17)
        Me.lbl_accountLogs.TabIndex = 42
        Me.lbl_accountLogs.Text = "Account Logs:"
        '
        'btn_sortLatest
        '
        Me.btn_sortLatest.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_sortLatest.Location = New System.Drawing.Point(116, 83)
        Me.btn_sortLatest.Name = "btn_sortLatest"
        Me.btn_sortLatest.Size = New System.Drawing.Size(135, 30)
        Me.btn_sortLatest.TabIndex = 43
        Me.btn_sortLatest.Text = "Sort Latest"
        Me.btn_sortLatest.UseVisualStyleBackColor = False
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_refresh.Location = New System.Drawing.Point(266, 83)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(135, 30)
        Me.btn_refresh.TabIndex = 44
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'IdentityTableAdapter
        '
        Me.IdentityTableAdapter.ClearBeforeFill = True
        '
        'LogBindingSource
        '
        Me.LogBindingSource.DataMember = "log"
        Me.LogBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        '
        'LogTableAdapter
        '
        Me.LogTableAdapter.ClearBeforeFill = True
        '
        'log_id
        '
        Me.log_id.DataPropertyName = "log_id"
        Me.log_id.HeaderText = "Log ID"
        Me.log_id.MinimumWidth = 6
        Me.log_id.Name = "log_id"
        Me.log_id.Width = 125
        '
        'employee_id
        '
        Me.employee_id.DataPropertyName = "employee_id"
        Me.employee_id.HeaderText = "Employee ID"
        Me.employee_id.MinimumWidth = 6
        Me.employee_id.Name = "employee_id"
        Me.employee_id.Width = 125
        '
        'timestamp
        '
        Me.timestamp.DataPropertyName = "timestamp"
        Me.timestamp.HeaderText = "Timestamp"
        Me.timestamp.MinimumWidth = 6
        Me.timestamp.Name = "timestamp"
        Me.timestamp.Width = 125
        '
        'usertype
        '
        Me.usertype.DataPropertyName = "usertype"
        Me.usertype.HeaderText = "User Type"
        Me.usertype.MinimumWidth = 6
        Me.usertype.Name = "usertype"
        Me.usertype.Width = 125
        '
        'activity
        '
        Me.activity.DataPropertyName = "activity"
        Me.activity.HeaderText = "Activity"
        Me.activity.MinimumWidth = 6
        Me.activity.Name = "activity"
        Me.activity.Width = 125
        '
        'frm_accountLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(715, 399)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_sortLatest)
        Me.Controls.Add(Me.lbl_accountLogs)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_employeeID)
        Me.Controls.Add(Me.txt_middleInitial)
        Me.Controls.Add(Me.txt_employeeID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_firstName)
        Me.Controls.Add(Me.txt_lastName)
        Me.Controls.Add(Me.txt_firstName)
        Me.Controls.Add(Me.lbl_lastName)
        Me.Name = "frm_accountLogs"
        Me.Text = "Account Logs"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdentityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_employeeID As Label
    Friend WithEvents txt_middleInitial As TextBox
    Friend WithEvents txt_employeeID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_firstName As Label
    Friend WithEvents txt_lastName As TextBox
    Friend WithEvents txt_firstName As TextBox
    Friend WithEvents lbl_lastName As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_accountLogs As Label
    Friend WithEvents btn_sortLatest As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Cash_advance_salary_loanDataSet As cash_advance_salary_loanDataSet
    Friend WithEvents IdentityBindingSource As BindingSource
    Friend WithEvents IdentityTableAdapter As cash_advance_salary_loanDataSetTableAdapters.identityTableAdapter
    Friend WithEvents LogBindingSource As BindingSource
    Friend WithEvents LogTableAdapter As cash_advance_salary_loanDataSetTableAdapters.logTableAdapter
    Friend WithEvents log_id As DataGridViewTextBoxColumn
    Friend WithEvents employee_id As DataGridViewTextBoxColumn
    Friend WithEvents timestamp As DataGridViewTextBoxColumn
    Friend WithEvents usertype As DataGridViewTextBoxColumn
    Friend WithEvents activity As DataGridViewTextBoxColumn
End Class
