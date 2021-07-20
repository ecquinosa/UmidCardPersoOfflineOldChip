<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Login))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.textbox_Password = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.textbox_UserName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.button_Close = New System.Windows.Forms.Button
        Me.link_ChangePassword = New System.Windows.Forms.LinkLabel
        Me.button_LogIn = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(326, 52)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(267, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textbox_Password)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.textbox_UserName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("OCR A Extended", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 58)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(307, 86)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'textbox_Password
        '
        Me.textbox_Password.BackColor = System.Drawing.Color.White
        Me.textbox_Password.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_Password.Location = New System.Drawing.Point(84, 52)
        Me.textbox_Password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_Password.MaxLength = 15
        Me.textbox_Password.Name = "textbox_Password"
        Me.textbox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.textbox_Password.ReadOnly = True
        Me.textbox_Password.Size = New System.Drawing.Size(217, 27)
        Me.textbox_Password.TabIndex = 5
        Me.textbox_Password.Text = "allcardtech"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'textbox_UserName
        '
        Me.textbox_UserName.BackColor = System.Drawing.Color.White
        Me.textbox_UserName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_UserName.Location = New System.Drawing.Point(84, 21)
        Me.textbox_UserName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textbox_UserName.MaxLength = 10
        Me.textbox_UserName.Name = "textbox_UserName"
        Me.textbox_UserName.ReadOnly = True
        Me.textbox_UserName.Size = New System.Drawing.Size(217, 27)
        Me.textbox_UserName.TabIndex = 1
        Me.textbox_UserName.Text = "admin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Username"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.button_Close)
        Me.Panel2.Controls.Add(Me.link_ChangePassword)
        Me.Panel2.Controls.Add(Me.button_LogIn)
        Me.Panel2.Location = New System.Drawing.Point(-7, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(343, 100)
        Me.Panel2.TabIndex = 74
        '
        'button_Close
        '
        Me.button_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_Close.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Close.Image = CType(resources.GetObject("button_Close.Image"), System.Drawing.Image)
        Me.button_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_Close.Location = New System.Drawing.Point(135, 13)
        Me.button_Close.Name = "button_Close"
        Me.button_Close.Size = New System.Drawing.Size(75, 36)
        Me.button_Close.TabIndex = 76
        Me.button_Close.Text = "Cancel"
        Me.button_Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_Close.UseVisualStyleBackColor = True
        '
        'link_ChangePassword
        '
        Me.link_ChangePassword.AutoSize = True
        Me.link_ChangePassword.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_ChangePassword.Location = New System.Drawing.Point(17, 24)
        Me.link_ChangePassword.Name = "link_ChangePassword"
        Me.link_ChangePassword.Size = New System.Drawing.Size(108, 14)
        Me.link_ChangePassword.TabIndex = 75
        Me.link_ChangePassword.TabStop = True
        Me.link_ChangePassword.Text = "Change Password"
        '
        'button_LogIn
        '
        Me.button_LogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_LogIn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_LogIn.Image = CType(resources.GetObject("button_LogIn.Image"), System.Drawing.Image)
        Me.button_LogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_LogIn.Location = New System.Drawing.Point(216, 13)
        Me.button_LogIn.Name = "button_LogIn"
        Me.button_LogIn.Size = New System.Drawing.Size(95, 36)
        Me.button_LogIn.TabIndex = 74
        Me.button_LogIn.Text = "Log In"
        Me.button_LogIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_LogIn.UseVisualStyleBackColor = True
        '
        'form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 212)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UMID Personalization System"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents textbox_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textbox_UserName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents button_Close As System.Windows.Forms.Button
    Friend WithEvents link_ChangePassword As System.Windows.Forms.LinkLabel
    Friend WithEvents button_LogIn As System.Windows.Forms.Button
End Class
