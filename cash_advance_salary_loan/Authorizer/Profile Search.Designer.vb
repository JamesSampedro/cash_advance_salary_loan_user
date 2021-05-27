<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_profileSearch
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
        Me.CashadvdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_cashAdvanceSortLatest = New System.Windows.Forms.Button()
        Me.lbl_cashAdvance = New System.Windows.Forms.Label()
        Me.CashadvanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cash_advance_salary_loanDataSet = New cash_advance_salary_loan.cash_advance_salary_loanDataSet()
        Me.Cash_advanceTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.cash_advanceTableAdapter()
        Me.dgv_pendingCashAdvance = New System.Windows.Forms.DataGridView()
        Me.CashadvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SalaryloanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Salary_loanTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.salary_loanTableAdapter()
        Me.btn_salaryLoanSortLatest = New System.Windows.Forms.Button()
        Me.lbl_salaryLoan = New System.Windows.Forms.Label()
        Me.txt_monSalary = New System.Windows.Forms.TextBox()
        Me.lbl_monSalary = New System.Windows.Forms.Label()
        Me.txt_jobPos = New System.Windows.Forms.TextBox()
        Me.lbl_jobPos = New System.Windows.Forms.Label()
        Me.txt_department = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_middleInitial = New System.Windows.Forms.TextBox()
        Me.lbl_middleInitial = New System.Windows.Forms.Label()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.lbl_lastName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_firstName = New System.Windows.Forms.Label()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.lbl_employeeID = New System.Windows.Forms.Label()
        Me.lbl_notice = New System.Windows.Forms.Label()
        CType(Me.CashadvanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_pendingCashAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryloanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CashadvdateDataGridViewTextBoxColumn
        '
        Me.CashadvdateDataGridViewTextBoxColumn.DataPropertyName = "cash_adv_date"
        Me.CashadvdateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.CashadvdateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CashadvdateDataGridViewTextBoxColumn.Name = "CashadvdateDataGridViewTextBoxColumn"
        Me.CashadvdateDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "salary_loan_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Reference ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sal_loan_amount"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Loan Amount"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "comaker"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Comaker"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "months_to_pay"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Months to pay"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "monthly_pay_with_interest"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Monthly Balance"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "total_amount_to_pay"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Amount"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "sal_loan_date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "sal_loan_status"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'btn_cashAdvanceSortLatest
        '
        Me.btn_cashAdvanceSortLatest.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_cashAdvanceSortLatest.Location = New System.Drawing.Point(127, 415)
        Me.btn_cashAdvanceSortLatest.Name = "btn_cashAdvanceSortLatest"
        Me.btn_cashAdvanceSortLatest.Size = New System.Drawing.Size(135, 30)
        Me.btn_cashAdvanceSortLatest.TabIndex = 58
        Me.btn_cashAdvanceSortLatest.Text = "Sort Latest"
        Me.btn_cashAdvanceSortLatest.UseVisualStyleBackColor = False
        '
        'lbl_cashAdvance
        '
        Me.lbl_cashAdvance.AutoSize = True
        Me.lbl_cashAdvance.Location = New System.Drawing.Point(8, 422)
        Me.lbl_cashAdvance.Name = "lbl_cashAdvance"
        Me.lbl_cashAdvance.Size = New System.Drawing.Size(103, 17)
        Me.lbl_cashAdvance.TabIndex = 57
        Me.lbl_cashAdvance.Text = "Cash Advance:"
        '
        'CashadvanceBindingSource
        '
        Me.CashadvanceBindingSource.DataMember = "cash_advance"
        Me.CashadvanceBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        '
        'Cash_advance_salary_loanDataSet
        '
        Me.Cash_advance_salary_loanDataSet.DataSetName = "cash_advance_salary_loanDataSet"
        Me.Cash_advance_salary_loanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cash_advanceTableAdapter
        '
        Me.Cash_advanceTableAdapter.ClearBeforeFill = True
        '
        'dgv_pendingCashAdvance
        '
        Me.dgv_pendingCashAdvance.AutoGenerateColumns = False
        Me.dgv_pendingCashAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pendingCashAdvance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CashadvidDataGridViewTextBoxColumn, Me.CashadvamountDataGridViewTextBoxColumn, Me.CashadvdateDataGridViewTextBoxColumn, Me.CashadvstatusDataGridViewTextBoxColumn})
        Me.dgv_pendingCashAdvance.DataSource = Me.CashadvanceBindingSource
        Me.dgv_pendingCashAdvance.Location = New System.Drawing.Point(13, 451)
        Me.dgv_pendingCashAdvance.Name = "dgv_pendingCashAdvance"
        Me.dgv_pendingCashAdvance.RowHeadersWidth = 51
        Me.dgv_pendingCashAdvance.RowTemplate.Height = 24
        Me.dgv_pendingCashAdvance.Size = New System.Drawing.Size(554, 241)
        Me.dgv_pendingCashAdvance.TabIndex = 59
        '
        'CashadvidDataGridViewTextBoxColumn
        '
        Me.CashadvidDataGridViewTextBoxColumn.DataPropertyName = "cash_adv_id"
        Me.CashadvidDataGridViewTextBoxColumn.HeaderText = "Reference ID"
        Me.CashadvidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CashadvidDataGridViewTextBoxColumn.Name = "CashadvidDataGridViewTextBoxColumn"
        Me.CashadvidDataGridViewTextBoxColumn.Width = 125
        '
        'CashadvamountDataGridViewTextBoxColumn
        '
        Me.CashadvamountDataGridViewTextBoxColumn.DataPropertyName = "cash_adv_amount"
        Me.CashadvamountDataGridViewTextBoxColumn.HeaderText = "Loan Amount"
        Me.CashadvamountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CashadvamountDataGridViewTextBoxColumn.Name = "CashadvamountDataGridViewTextBoxColumn"
        Me.CashadvamountDataGridViewTextBoxColumn.Width = 125
        '
        'CashadvstatusDataGridViewTextBoxColumn
        '
        Me.CashadvstatusDataGridViewTextBoxColumn.DataPropertyName = "cash_adv_status"
        Me.CashadvstatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.CashadvstatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CashadvstatusDataGridViewTextBoxColumn.Name = "CashadvstatusDataGridViewTextBoxColumn"
        Me.CashadvstatusDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.DataSource = Me.SalaryloanBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1055, 241)
        Me.DataGridView1.TabIndex = 56
        '
        'SalaryloanBindingSource
        '
        Me.SalaryloanBindingSource.DataMember = "salary_loan"
        Me.SalaryloanBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        '
        'Salary_loanTableAdapter
        '
        Me.Salary_loanTableAdapter.ClearBeforeFill = True
        '
        'btn_salaryLoanSortLatest
        '
        Me.btn_salaryLoanSortLatest.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_salaryLoanSortLatest.Location = New System.Drawing.Point(127, 127)
        Me.btn_salaryLoanSortLatest.Name = "btn_salaryLoanSortLatest"
        Me.btn_salaryLoanSortLatest.Size = New System.Drawing.Size(135, 30)
        Me.btn_salaryLoanSortLatest.TabIndex = 55
        Me.btn_salaryLoanSortLatest.Text = "Sort Latest"
        Me.btn_salaryLoanSortLatest.UseVisualStyleBackColor = False
        '
        'lbl_salaryLoan
        '
        Me.lbl_salaryLoan.AutoSize = True
        Me.lbl_salaryLoan.Location = New System.Drawing.Point(13, 134)
        Me.lbl_salaryLoan.Name = "lbl_salaryLoan"
        Me.lbl_salaryLoan.Size = New System.Drawing.Size(88, 17)
        Me.lbl_salaryLoan.TabIndex = 54
        Me.lbl_salaryLoan.Text = "Salary Loan:"
        '
        'txt_monSalary
        '
        Me.txt_monSalary.Enabled = False
        Me.txt_monSalary.Location = New System.Drawing.Point(389, 91)
        Me.txt_monSalary.Name = "txt_monSalary"
        Me.txt_monSalary.ReadOnly = True
        Me.txt_monSalary.Size = New System.Drawing.Size(176, 22)
        Me.txt_monSalary.TabIndex = 53
        '
        'lbl_monSalary
        '
        Me.lbl_monSalary.AutoSize = True
        Me.lbl_monSalary.Location = New System.Drawing.Point(284, 94)
        Me.lbl_monSalary.Name = "lbl_monSalary"
        Me.lbl_monSalary.Size = New System.Drawing.Size(105, 17)
        Me.lbl_monSalary.TabIndex = 52
        Me.lbl_monSalary.Text = "Monthly Salary:"
        '
        'txt_jobPos
        '
        Me.txt_jobPos.Enabled = False
        Me.txt_jobPos.Location = New System.Drawing.Point(389, 63)
        Me.txt_jobPos.Name = "txt_jobPos"
        Me.txt_jobPos.ReadOnly = True
        Me.txt_jobPos.Size = New System.Drawing.Size(176, 22)
        Me.txt_jobPos.TabIndex = 51
        '
        'lbl_jobPos
        '
        Me.lbl_jobPos.AutoSize = True
        Me.lbl_jobPos.Location = New System.Drawing.Point(303, 66)
        Me.lbl_jobPos.Name = "lbl_jobPos"
        Me.lbl_jobPos.Size = New System.Drawing.Size(89, 17)
        Me.lbl_jobPos.TabIndex = 50
        Me.lbl_jobPos.Text = "Job Position:"
        '
        'txt_department
        '
        Me.txt_department.Enabled = False
        Me.txt_department.Location = New System.Drawing.Point(389, 32)
        Me.txt_department.Name = "txt_department"
        Me.txt_department.ReadOnly = True
        Me.txt_department.Size = New System.Drawing.Size(176, 22)
        Me.txt_department.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(303, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Department:"
        '
        'txt_middleInitial
        '
        Me.txt_middleInitial.Enabled = False
        Me.txt_middleInitial.Location = New System.Drawing.Point(109, 87)
        Me.txt_middleInitial.Name = "txt_middleInitial"
        Me.txt_middleInitial.ReadOnly = True
        Me.txt_middleInitial.Size = New System.Drawing.Size(77, 22)
        Me.txt_middleInitial.TabIndex = 47
        '
        'lbl_middleInitial
        '
        Me.lbl_middleInitial.AutoSize = True
        Me.lbl_middleInitial.Location = New System.Drawing.Point(12, 90)
        Me.lbl_middleInitial.Name = "lbl_middleInitial"
        Me.lbl_middleInitial.Size = New System.Drawing.Size(89, 17)
        Me.lbl_middleInitial.TabIndex = 46
        Me.lbl_middleInitial.Text = "Middle Initial:"
        '
        'txt_lastName
        '
        Me.txt_lastName.Enabled = False
        Me.txt_lastName.Location = New System.Drawing.Point(109, 60)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.ReadOnly = True
        Me.txt_lastName.Size = New System.Drawing.Size(176, 22)
        Me.txt_lastName.TabIndex = 45
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(23, 63)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(80, 17)
        Me.lbl_lastName.TabIndex = 44
        Me.lbl_lastName.Text = "Last Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(109, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(176, 22)
        Me.TextBox1.TabIndex = 43
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(23, 35)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(80, 17)
        Me.lbl_firstName.TabIndex = 42
        Me.lbl_firstName.Text = "First Name:"
        '
        'txt_employeeID
        '
        Me.txt_employeeID.Location = New System.Drawing.Point(109, 6)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.ReadOnly = True
        Me.txt_employeeID.Size = New System.Drawing.Size(77, 22)
        Me.txt_employeeID.TabIndex = 41
        '
        'lbl_employeeID
        '
        Me.lbl_employeeID.AutoSize = True
        Me.lbl_employeeID.Location = New System.Drawing.Point(12, 9)
        Me.lbl_employeeID.Name = "lbl_employeeID"
        Me.lbl_employeeID.Size = New System.Drawing.Size(91, 17)
        Me.lbl_employeeID.TabIndex = 40
        Me.lbl_employeeID.Text = "Employee ID:"
        '
        'lbl_notice
        '
        Me.lbl_notice.AutoSize = True
        Me.lbl_notice.Location = New System.Drawing.Point(192, 9)
        Me.lbl_notice.Name = "lbl_notice"
        Me.lbl_notice.Size = New System.Drawing.Size(238, 17)
        Me.lbl_notice.TabIndex = 60
        Me.lbl_notice.Text = "Note: Input a Employee ID to search!"
        '
        'frm_profileSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(1090, 711)
        Me.Controls.Add(Me.lbl_notice)
        Me.Controls.Add(Me.btn_cashAdvanceSortLatest)
        Me.Controls.Add(Me.lbl_cashAdvance)
        Me.Controls.Add(Me.dgv_pendingCashAdvance)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_salaryLoanSortLatest)
        Me.Controls.Add(Me.lbl_salaryLoan)
        Me.Controls.Add(Me.txt_monSalary)
        Me.Controls.Add(Me.lbl_monSalary)
        Me.Controls.Add(Me.txt_jobPos)
        Me.Controls.Add(Me.lbl_jobPos)
        Me.Controls.Add(Me.txt_department)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_middleInitial)
        Me.Controls.Add(Me.lbl_middleInitial)
        Me.Controls.Add(Me.txt_lastName)
        Me.Controls.Add(Me.lbl_lastName)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_firstName)
        Me.Controls.Add(Me.txt_employeeID)
        Me.Controls.Add(Me.lbl_employeeID)
        Me.Name = "frm_profileSearch"
        Me.Text = "Profile Search"
        CType(Me.CashadvanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_pendingCashAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryloanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CashadvdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents btn_cashAdvanceSortLatest As Button
    Friend WithEvents lbl_cashAdvance As Label
    Friend WithEvents CashadvanceBindingSource As BindingSource
    Friend WithEvents Cash_advance_salary_loanDataSet As cash_advance_salary_loanDataSet
    Friend WithEvents Cash_advanceTableAdapter As cash_advance_salary_loanDataSetTableAdapters.cash_advanceTableAdapter
    Friend WithEvents dgv_pendingCashAdvance As DataGridView
    Friend WithEvents CashadvidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashadvamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashadvstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SalaryloanBindingSource As BindingSource
    Friend WithEvents Salary_loanTableAdapter As cash_advance_salary_loanDataSetTableAdapters.salary_loanTableAdapter
    Friend WithEvents btn_salaryLoanSortLatest As Button
    Friend WithEvents lbl_salaryLoan As Label
    Friend WithEvents txt_monSalary As TextBox
    Friend WithEvents lbl_monSalary As Label
    Friend WithEvents txt_jobPos As TextBox
    Friend WithEvents lbl_jobPos As Label
    Friend WithEvents txt_department As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_middleInitial As TextBox
    Friend WithEvents lbl_middleInitial As Label
    Friend WithEvents txt_lastName As TextBox
    Friend WithEvents lbl_lastName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbl_firstName As Label
    Friend WithEvents txt_employeeID As TextBox
    Friend WithEvents lbl_employeeID As Label
    Friend WithEvents lbl_notice As Label
End Class
