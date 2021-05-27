Public Class frm_authorizerSalaryLoan
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_employeeID.Click

    End Sub

    Private Sub frm_authorizerSalaryLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.salary_loan' table. You can move, or remove it, as needed.
        Me.Salary_loanTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.salary_loan)

    End Sub
End Class