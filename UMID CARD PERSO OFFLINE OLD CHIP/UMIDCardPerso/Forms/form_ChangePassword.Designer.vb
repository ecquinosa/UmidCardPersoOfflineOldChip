<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_ChangePassword))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.button_ChangePassword = New System.Windows.Forms.Button
        Me.textbox_Password = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.textbox_UserName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.textbox_NewPassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.textbox_ConfirmPassword = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.button_Close = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 50)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(270, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'button_ChangePassword
        '
        Me.button_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_ChangePassword.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_ChangePassword.Image = CType(resources.GetObject("button_ChangePassword.Image"), System.Drawing.Image)
        Me.button_ChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_ChangePassword.Location = New System.Drawing.Point(201, 11)
        Me.button_ChangePassword.Name = "button_ChangePassword"
        Me.button_ChangePassword.Size = New System.Drawing.Size(118, 36)
        Me.button_ChangePassword.TabIndex = 73
        Me.button_ChangePassword.Text = "Change"
        Me.button_ChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_ChangePassword.UseVisualStyleBackColor = True
        '
        'textbox_Password
        '
        Me.textbox_Password.BackColor = System.Drawing.Color.White
        Me.textbox_Password.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_Password.Location = New System.Drawing.Point(101, 80)
        Me.textbox_Password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_Password.MaxLength = 10
        Me.textbox_Password.Name = "textbox_Password"
        Me.textbox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.textbox_Password.Size = New System.Drawing.Size(210, 20)
        Me.textbox_Password.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 14)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Old Password"
        '
        'textbox_UserName
        '
        Me.textbox_UserName.BackColor = System.Drawing.Color.White
        Me.textbox_UserName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_UserName.Location = New System.Drawing.Point(101, 56)
        Me.textbox_UserName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_UserName.Name = "textbox_UserName"
        Me.textbox_UserName.ReadOnly = True
        Me.textbox_UserName.Size = New System.Drawing.Size(210, 20)
        Me.textbox_UserName.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 14)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Username"
        '
        'textbox_NewPassword
        '
        Me.textbox_NewPassword.BackColor = System.Drawing.Color.White
        Me.textbox_NewPassword.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_NewPassword.Location = New System.Drawing.Point(101, 104)
        Me.textbox_NewPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_NewPassword.MaxLength = 10
        Me.textbox_NewPassword.Name = "textbox_NewPassword"
        Me.textbox_NewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.textbox_NewPassword.Size = New System.Drawing.Size(210, 20)
        Me.textbox_NewPassword.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 14)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "New Password"
        '
        'textbox_ConfirmPassword
        '
        Me.textbox_ConfirmPassword.BackColor = System.Drawing.Color.White
        Me.textbox_ConfirmPassword.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_ConfirmPassword.Location = New System.Drawing.Point(101, 128)
        Me.textbox_ConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_ConfirmPassword.MaxLength = 10
        Me.textbox_ConfirmPassword.Name = "textbox_ConfirmPassword"
        Me.textbox_ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.textbox_ConfirmPassword.Size = New System.Drawing.Size(210, 20)
        Me.textbox_ConfirmPassword.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 14)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Confirm"
        '
        'button_Close
        '
        Me.button_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_Close.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Close.Image = CType(resources.GetObject("button_Close.Image"), System.Drawing.Image)
        Me.button_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_Close.Location = New System.Drawing.Point(109, 11)
        Me.button_Close.Name = "button_Close"
        Me.button_Close.Size = New System.Drawing.Size(83, 36)
        Me.button_Close.TabIndex = 82
        Me.button_Close.Text = "Cancel"
        Me.button_Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_Close.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.button_ChangePassword)
        Me.Panel2.Controls.Add(Me.button_Close)
        Me.Panel2.Location = New System.Drawing.Point(-9, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(345, 100)
        Me.Panel2.TabIndex = 83
        '
        'form_ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 216)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.textbox_ConfirmPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textbox_NewPassword)
        Me.Controls.Add(Me.textbox_Password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textbox_UserName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_ChangePassword"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password Utility"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents button_ChangePassword As System.Windows.Forms.Button
    Friend WithEvents textbox_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textbox_UserName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents textbox_NewPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textbox_ConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents button_Close As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
