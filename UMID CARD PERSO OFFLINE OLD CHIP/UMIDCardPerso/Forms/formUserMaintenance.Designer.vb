<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUserMaintenance
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formUserMaintenance))
        Me.Label12 = New System.Windows.Forms.Label
        Me.combobox_UserType = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.textbox_FirstName = New System.Windows.Forms.TextBox
        Me.textbox_UserName = New System.Windows.Forms.TextBox
        Me.button_ResetPassword = New System.Windows.Forms.Button
        Me.ResetPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.listview_UserList = New System.Windows.Forms.ListView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ActivateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.button_DeActivate = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.combobox_Department = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.textbox_LastName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.textbox_MiddleName = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.combobox_UserFields = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.textbox_SearchValue = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.button_ClearUser = New System.Windows.Forms.Button
        Me.button_SaveUser = New System.Windows.Forms.Button
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 14)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "User Type"
        '
        'combobox_UserType
        '
        Me.combobox_UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_UserType.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_UserType.FormattingEnabled = True
        Me.combobox_UserType.Items.AddRange(New Object() {"ADMINISTRATOR", "USER"})
        Me.combobox_UserType.Location = New System.Drawing.Point(90, 157)
        Me.combobox_UserType.Name = "combobox_UserType"
        Me.combobox_UserType.Size = New System.Drawing.Size(374, 22)
        Me.combobox_UserType.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 14)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "First Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 14)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Username"
        '
        'textbox_FirstName
        '
        Me.textbox_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox_FirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textbox_FirstName.Location = New System.Drawing.Point(90, 46)
        Me.textbox_FirstName.MaxLength = 30
        Me.textbox_FirstName.Name = "textbox_FirstName"
        Me.textbox_FirstName.Size = New System.Drawing.Size(374, 20)
        Me.textbox_FirstName.TabIndex = 1
        '
        'textbox_UserName
        '
        Me.textbox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox_UserName.Location = New System.Drawing.Point(90, 19)
        Me.textbox_UserName.MaxLength = 10
        Me.textbox_UserName.Name = "textbox_UserName"
        Me.textbox_UserName.Size = New System.Drawing.Size(374, 20)
        Me.textbox_UserName.TabIndex = 0
        '
        'button_ResetPassword
        '
        Me.button_ResetPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_ResetPassword.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_ResetPassword.Image = CType(resources.GetObject("button_ResetPassword.Image"), System.Drawing.Image)
        Me.button_ResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_ResetPassword.Location = New System.Drawing.Point(374, 527)
        Me.button_ResetPassword.Name = "button_ResetPassword"
        Me.button_ResetPassword.Size = New System.Drawing.Size(102, 36)
        Me.button_ResetPassword.TabIndex = 9
        Me.button_ResetPassword.Text = "Reset Password"
        Me.button_ResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_ResetPassword.UseVisualStyleBackColor = True
        '
        'ResetPasswordToolStripMenuItem
        '
        Me.ResetPasswordToolStripMenuItem.Image = CType(resources.GetObject("ResetPasswordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResetPasswordToolStripMenuItem.Name = "ResetPasswordToolStripMenuItem"
        Me.ResetPasswordToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ResetPasswordToolStripMenuItem.Text = "Reset Password"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(152, 6)
        '
        'listview_UserList
        '
        Me.listview_UserList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listview_UserList.ContextMenuStrip = Me.ContextMenuStrip1
        Me.listview_UserList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listview_UserList.FullRowSelect = True
        Me.listview_UserList.Location = New System.Drawing.Point(6, 15)
        Me.listview_UserList.Name = "listview_UserList"
        Me.listview_UserList.Size = New System.Drawing.Size(458, 190)
        Me.listview_UserList.TabIndex = 66
        Me.listview_UserList.UseCompatibleStateImageBehavior = False
        Me.listview_UserList.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.ActivateToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.ResetPasswordToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(156, 104)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        'ActivateToolStripMenuItem
        '
        Me.ActivateToolStripMenuItem.Image = CType(resources.GetObject("ActivateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActivateToolStripMenuItem.Name = "ActivateToolStripMenuItem"
        Me.ActivateToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ActivateToolStripMenuItem.Text = "Activate"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DeleteToolStripMenuItem.Text = "Deactivate"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.listview_UserList)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(470, 211)
        Me.GroupBox5.TabIndex = 98
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "User List"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'button_DeActivate
        '
        Me.button_DeActivate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_DeActivate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_DeActivate.Image = CType(resources.GetObject("button_DeActivate.Image"), System.Drawing.Image)
        Me.button_DeActivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_DeActivate.Location = New System.Drawing.Point(266, 527)
        Me.button_DeActivate.Name = "button_DeActivate"
        Me.button_DeActivate.Size = New System.Drawing.Size(102, 36)
        Me.button_DeActivate.TabIndex = 8
        Me.button_DeActivate.Text = "Activate"
        Me.button_DeActivate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_DeActivate.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.combobox_Department)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.textbox_LastName)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.textbox_MiddleName)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.combobox_UserType)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.textbox_FirstName)
        Me.GroupBox6.Controls.Add(Me.textbox_UserName)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 334)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(470, 187)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "User Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Department"
        '
        'combobox_Department
        '
        Me.combobox_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_Department.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_Department.FormattingEnabled = True
        Me.combobox_Department.Items.AddRange(New Object() {"MIS", "PERSONALIZATION", "QUALITY CONTROL"})
        Me.combobox_Department.Location = New System.Drawing.Point(90, 129)
        Me.combobox_Department.Name = "combobox_Department"
        Me.combobox_Department.Size = New System.Drawing.Size(374, 22)
        Me.combobox_Department.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 14)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Last Name"
        '
        'textbox_LastName
        '
        Me.textbox_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox_LastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textbox_LastName.Location = New System.Drawing.Point(90, 103)
        Me.textbox_LastName.MaxLength = 30
        Me.textbox_LastName.Name = "textbox_LastName"
        Me.textbox_LastName.Size = New System.Drawing.Size(374, 20)
        Me.textbox_LastName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 14)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Middle Name"
        '
        'textbox_MiddleName
        '
        Me.textbox_MiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox_MiddleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textbox_MiddleName.Location = New System.Drawing.Point(90, 77)
        Me.textbox_MiddleName.MaxLength = 30
        Me.textbox_MiddleName.Name = "textbox_MiddleName"
        Me.textbox_MiddleName.Size = New System.Drawing.Size(374, 20)
        Me.textbox_MiddleName.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 59)
        Me.Panel1.TabIndex = 97
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(374, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 106
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combobox_UserFields)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.textbox_SearchValue)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 45)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lookup"
        '
        'combobox_UserFields
        '
        Me.combobox_UserFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_UserFields.FormattingEnabled = True
        Me.combobox_UserFields.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.combobox_UserFields.Location = New System.Drawing.Point(324, 15)
        Me.combobox_UserFields.Name = "combobox_UserFields"
        Me.combobox_UserFields.Size = New System.Drawing.Size(140, 22)
        Me.combobox_UserFields.TabIndex = 94
        Me.combobox_UserFields.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(289, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 14)
        Me.Label14.TabIndex = 93
        Me.Label14.Text = "Field"
        '
        'textbox_SearchValue
        '
        Me.textbox_SearchValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox_SearchValue.Location = New System.Drawing.Point(48, 16)
        Me.textbox_SearchValue.MaxLength = 30
        Me.textbox_SearchValue.Name = "textbox_SearchValue"
        Me.textbox_SearchValue.Size = New System.Drawing.Size(235, 20)
        Me.textbox_SearchValue.TabIndex = 92
        Me.textbox_SearchValue.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 14)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Value"
        '
        'button_ClearUser
        '
        Me.button_ClearUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_ClearUser.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_ClearUser.Image = CType(resources.GetObject("button_ClearUser.Image"), System.Drawing.Image)
        Me.button_ClearUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_ClearUser.Location = New System.Drawing.Point(50, 527)
        Me.button_ClearUser.Name = "button_ClearUser"
        Me.button_ClearUser.Size = New System.Drawing.Size(102, 36)
        Me.button_ClearUser.TabIndex = 6
        Me.button_ClearUser.Text = "Clear"
        Me.button_ClearUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_ClearUser.UseVisualStyleBackColor = True
        '
        'button_SaveUser
        '
        Me.button_SaveUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_SaveUser.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_SaveUser.Image = CType(resources.GetObject("button_SaveUser.Image"), System.Drawing.Image)
        Me.button_SaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_SaveUser.Location = New System.Drawing.Point(158, 527)
        Me.button_SaveUser.Name = "button_SaveUser"
        Me.button_SaveUser.Size = New System.Drawing.Size(102, 36)
        Me.button_SaveUser.TabIndex = 7
        Me.button_SaveUser.Text = "Save"
        Me.button_SaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_SaveUser.UseVisualStyleBackColor = True
        '
        'formUserMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 572)
        Me.Controls.Add(Me.button_ClearUser)
        Me.Controls.Add(Me.button_SaveUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.button_ResetPassword)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.button_DeActivate)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formUserMaintenance"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UMID Perso System - User Maintenance"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents combobox_UserType As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents textbox_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents textbox_UserName As System.Windows.Forms.TextBox
    Friend WithEvents button_ResetPassword As System.Windows.Forms.Button
    Friend WithEvents ResetPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents listview_UserList As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ActivateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents button_DeActivate As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents combobox_Department As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textbox_LastName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textbox_MiddleName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents combobox_UserFields As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents textbox_SearchValue As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents button_ClearUser As System.Windows.Forms.Button
    Friend WithEvents button_SaveUser As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
