Public Class frm_accountLogs
    Private Sub frm_accountLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.log' table. You can move, or remove it, as needed.
        Me.LogTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.log)

    End Sub
End Class