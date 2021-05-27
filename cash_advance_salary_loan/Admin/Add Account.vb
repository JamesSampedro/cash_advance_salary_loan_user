Public Class frm_accountManage
    Private Sub frm_accountManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.employee)

    End Sub

End Class