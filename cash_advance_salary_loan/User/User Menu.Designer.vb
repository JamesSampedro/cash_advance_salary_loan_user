<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_userMenu
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
        Me.btn_salaryLoan = New System.Windows.Forms.Button()
        Me.btn_cashAdvance = New System.Windows.Forms.Button()
        Me.btn_profile = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_salaryLoan
        '
        Me.btn_salaryLoan.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_salaryLoan.Location = New System.Drawing.Point(85, 96)
        Me.btn_salaryLoan.Name = "btn_salaryLoan"
        Me.btn_salaryLoan.Size = New System.Drawing.Size(172, 50)
        Me.btn_salaryLoan.TabIndex = 0
        Me.btn_salaryLoan.Text = "Salary Loan"
        Me.btn_salaryLoan.UseVisualStyleBackColor = False
        '
        'btn_cashAdvance
        '
        Me.btn_cashAdvance.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_cashAdvance.Location = New System.Drawing.Point(292, 96)
        Me.btn_cashAdvance.Name = "btn_cashAdvance"
        Me.btn_cashAdvance.Size = New System.Drawing.Size(172, 50)
        Me.btn_cashAdvance.TabIndex = 1
        Me.btn_cashAdvance.Text = "Cash Advance"
        Me.btn_cashAdvance.UseVisualStyleBackColor = False
        '
        'btn_profile
        '
        Me.btn_profile.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_profile.Location = New System.Drawing.Point(85, 175)
        Me.btn_profile.Name = "btn_profile"
        Me.btn_profile.Size = New System.Drawing.Size(172, 50)
        Me.btn_profile.TabIndex = 2
        Me.btn_profile.Text = "Profile"
        Me.btn_profile.UseVisualStyleBackColor = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_logout.Location = New System.Drawing.Point(292, 175)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(172, 50)
        Me.btn_logout.TabIndex = 3
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'frm_userMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(541, 307)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_profile)
        Me.Controls.Add(Me.btn_cashAdvance)
        Me.Controls.Add(Me.btn_salaryLoan)
        Me.Name = "frm_userMenu"
        Me.Text = "User Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_salaryLoan As Button
    Friend WithEvents btn_cashAdvance As Button
    Friend WithEvents btn_profile As Button
    Friend WithEvents btn_logout As Button
End Class
