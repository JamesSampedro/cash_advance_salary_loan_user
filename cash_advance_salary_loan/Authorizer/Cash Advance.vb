Public Class frm_authorizerCashAdvance
    Private Sub frm_authorizerCashAdvance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.cash_advance' table. You can move, or remove it, as needed.
        Me.Cash_advanceTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.cash_advance)

    End Sub
End Class