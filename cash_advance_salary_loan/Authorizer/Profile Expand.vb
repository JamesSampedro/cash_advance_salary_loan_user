Public Class frm_profileExpand
    Private Sub frm_profileExpand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.cash_advance' table. You can move, or remove it, as needed.
        Me.Cash_advanceTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.cash_advance)
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.salary_loan' table. You can move, or remove it, as needed.
        Me.Salary_loanTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.salary_loan)

    End Sub
End Class