<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_authorizerMenu
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
        Me.btn_searchProfile = New System.Windows.Forms.Button()
        Me.btn_cashAdvance = New System.Windows.Forms.Button()
        Me.btn_salaryLoan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_logout.Location = New System.Drawing.Point(247, 215)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(172, 50)
        Me.btn_logout.TabIndex = 7
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_searchProfile
        '
        Me.btn_searchProfile.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_searchProfile.Location = New System.Drawing.Point(40, 215)
        Me.btn_searchProfile.Name = "btn_searchProfile"
        Me.btn_searchProfile.Size = New System.Drawing.Size(172, 50)
        Me.btn_searchProfile.TabIndex = 6
        Me.btn_searchProfile.Text = "Search Profile"
        Me.btn_searchProfile.UseVisualStyleBackColor = False
        '
        'btn_cashAdvance
        '
        Me.btn_cashAdvance.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_cashAdvance.Location = New System.Drawing.Point(247, 136)
        Me.btn_cashAdvance.Name = "btn_cashAdvance"
        Me.btn_cashAdvance.Size = New System.Drawing.Size(172, 50)
        Me.btn_cashAdvance.TabIndex = 5
        Me.btn_cashAdvance.Text = "Cash Advance"
        Me.btn_cashAdvance.UseVisualStyleBackColor = False
        '
        'btn_salaryLoan
        '
        Me.btn_salaryLoan.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_salaryLoan.Location = New System.Drawing.Point(40, 136)
        Me.btn_salaryLoan.Name = "btn_salaryLoan"
        Me.btn_salaryLoan.Size = New System.Drawing.Size(172, 50)
        Me.btn_salaryLoan.TabIndex = 4
        Me.btn_salaryLoan.Text = "Salary Loan"
        Me.btn_salaryLoan.UseVisualStyleBackColor = False
        '
        'frm_authorizerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(556, 399)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_searchProfile)
        Me.Controls.Add(Me.btn_cashAdvance)
        Me.Controls.Add(Me.btn_salaryLoan)
        Me.Name = "frm_authorizerMenu"
        Me.Text = "Authorizer Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_searchProfile As Button
    Friend WithEvents btn_cashAdvance As Button
    Friend WithEvents btn_salaryLoan As Button
End Class
