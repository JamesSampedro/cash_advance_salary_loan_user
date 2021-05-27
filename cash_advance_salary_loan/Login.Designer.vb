<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.lbl_employeeID = New System.Windows.Forms.Label()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_usertype = New System.Windows.Forms.Label()
        Me.chk_showPassword = New System.Windows.Forms.CheckBox()
        Me.cmb_userType = New System.Windows.Forms.ComboBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_employeeID
        '
        Me.lbl_employeeID.AutoSize = True
        Me.lbl_employeeID.Location = New System.Drawing.Point(62, 97)
        Me.lbl_employeeID.Name = "lbl_employeeID"
        Me.lbl_employeeID.Size = New System.Drawing.Size(91, 17)
        Me.lbl_employeeID.TabIndex = 0
        Me.lbl_employeeID.Text = "Employee ID:"
        '
        'txt_employeeID
        '
        Me.txt_employeeID.Location = New System.Drawing.Point(159, 94)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.Size = New System.Drawing.Size(96, 22)
        Me.txt_employeeID.TabIndex = 1
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(159, 122)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(186, 22)
        Me.txt_password.TabIndex = 3
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(80, 125)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(73, 17)
        Me.lbl_password.TabIndex = 2
        Me.lbl_password.Text = "Password:"
        '
        'lbl_usertype
        '
        Me.lbl_usertype.AutoSize = True
        Me.lbl_usertype.Location = New System.Drawing.Point(75, 179)
        Me.lbl_usertype.Name = "lbl_usertype"
        Me.lbl_usertype.Size = New System.Drawing.Size(78, 17)
        Me.lbl_usertype.TabIndex = 4
        Me.lbl_usertype.Text = "User Type:"
        '
        'chk_showPassword
        '
        Me.chk_showPassword.AutoSize = True
        Me.chk_showPassword.Location = New System.Drawing.Point(159, 150)
        Me.chk_showPassword.Name = "chk_showPassword"
        Me.chk_showPassword.Size = New System.Drawing.Size(129, 21)
        Me.chk_showPassword.TabIndex = 5
        Me.chk_showPassword.Text = "Show Password"
        Me.chk_showPassword.UseVisualStyleBackColor = True
        '
        'cmb_userType
        '
        Me.cmb_userType.FormattingEnabled = True
        Me.cmb_userType.Items.AddRange(New Object() {"Admin", "Authorizer", "User"})
        Me.cmb_userType.Location = New System.Drawing.Point(159, 176)
        Me.cmb_userType.Name = "cmb_userType"
        Me.cmb_userType.Size = New System.Drawing.Size(186, 24)
        Me.cmb_userType.TabIndex = 6
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_login.Location = New System.Drawing.Point(174, 219)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(143, 42)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(458, 362)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.cmb_userType)
        Me.Controls.Add(Me.chk_showPassword)
        Me.Controls.Add(Me.lbl_usertype)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.txt_employeeID)
        Me.Controls.Add(Me.lbl_employeeID)
        Me.Name = "frm_login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_employeeID As Label
    Friend WithEvents txt_employeeID As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_usertype As Label
    Friend WithEvents chk_showPassword As CheckBox
    Friend WithEvents cmb_userType As ComboBox
    Friend WithEvents btn_login As Button
End Class
