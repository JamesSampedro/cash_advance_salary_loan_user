<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adminMenu
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
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_accountLogs = New System.Windows.Forms.Button()
        Me.btn_manageAccounts = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_logout.Location = New System.Drawing.Point(263, 169)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(172, 50)
        Me.btn_logout.TabIndex = 6
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_accountLogs
        '
        Me.btn_accountLogs.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_accountLogs.Location = New System.Drawing.Point(263, 90)
        Me.btn_accountLogs.Name = "btn_accountLogs"
        Me.btn_accountLogs.Size = New System.Drawing.Size(172, 50)
        Me.btn_accountLogs.TabIndex = 5
        Me.btn_accountLogs.Text = "Account Logs"
        Me.btn_accountLogs.UseVisualStyleBackColor = False
        '
        'btn_manageAccounts
        '
        Me.btn_manageAccounts.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_manageAccounts.Location = New System.Drawing.Point(56, 90)
        Me.btn_manageAccounts.Name = "btn_manageAccounts"
        Me.btn_manageAccounts.Size = New System.Drawing.Size(172, 50)
        Me.btn_manageAccounts.TabIndex = 4
        Me.btn_manageAccounts.Text = "Manage Accounts"
        Me.btn_manageAccounts.UseVisualStyleBackColor = False
        '
        'frm_adminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(558, 310)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_accountLogs)
        Me.Controls.Add(Me.btn_manageAccounts)
        Me.Name = "frm_adminMenu"
        Me.Text = "Admin Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_accountLogs As Button
    Friend WithEvents btn_manageAccounts As Button
End Class
