Imports System.Data.OleDb
Public Class frm_login
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Public employeeID As Integer = 0

    Public Class FetchEmpID
        'This is Imported to SalaryLoan Auto-fill data EmpID
        Public Shared SavedEmpID As String
    End Class
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim conn As New OleDbConnection(cs)
        Dim cmd As New OleDbCommand("SELECT * FROM login WHERE employee_id=@EmployeeID And password=@Password and usertype=@UserType", conn)

        cmd.Parameters.Add("@EmployeeID", OleDbType.VarChar).Value = txt_employeeID.Text
        cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = txt_password.Text
        cmd.Parameters.Add("@UserType", OleDbType.VarChar).Value = cmb_userType.Text

        'Fetches the EmployeeID to be filled automatically on request form on SalaryLoan Form
        FetchEmpID.SavedEmpID = txt_employeeID.Text

        'Data adapter to Fill the data coming from textbox, and check if its matched
        Dim submitlogin As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        submitlogin.Fill(table)

        'If condition for checking the proper data on UserType
        If table.Rows.Count <= 0 Then
            MsgBox("Error Login. Please check Username or Password.", MsgBoxStyle.Exclamation)

        ElseIf cmb_userType.Text = "Admin" Then
            MsgBox("Login Success!", MsgBoxStyle.Information)
            Me.Hide()
            frm_adminMenu.Show()

        ElseIf cmb_userType.Text = "Authorizer" Then
            MsgBox("Login Success!", MsgBoxStyle.Information)
            Me.Hide()
            frm_authorizerMenu.Show()

        ElseIf cmb_userType.Text = "User" Then
            MsgBox("Login Success!", MsgBoxStyle.Information)
            Me.Hide()
            frm_userMenu.Show()

        End If

    End Sub

    Private Sub chk_showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chk_showPassword.CheckedChanged
        If chk_showPassword.Checked = True Then
            txt_password.UseSystemPasswordChar = False

        Else
            txt_password.UseSystemPasswordChar = True

        End If
    End Sub

End Class