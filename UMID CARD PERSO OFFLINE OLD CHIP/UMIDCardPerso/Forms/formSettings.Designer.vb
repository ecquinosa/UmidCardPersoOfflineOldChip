<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSettings))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.combobox_Contactless = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.num_StationID = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.check_CMSStruct = New System.Windows.Forms.CheckBox
        Me.button_BrowseRepository = New System.Windows.Forms.Button
        Me.textbox_Repository = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.label5 = New System.Windows.Forms.Label
        Me.cboData = New System.Windows.Forms.ComboBox
        Me.label4 = New System.Windows.Forms.Label
        Me.cboStop = New System.Windows.Forms.ComboBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdoText = New System.Windows.Forms.RadioButton
        Me.rdoHex = New System.Windows.Forms.RadioButton
        Me.label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboParity = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboBaud = New System.Windows.Forms.ComboBox
        Me.cboPort = New System.Windows.Forms.ComboBox
        Me.button_SaveSettings = New System.Windows.Forms.Button
        Me.button_Cancel = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.link_TestConnection = New System.Windows.Forms.LinkLabel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.textbox_DBPassword = New System.Windows.Forms.TextBox
        Me.textbox_DBUID = New System.Windows.Forms.TextBox
        Me.textbox_Database = New System.Windows.Forms.TextBox
        Me.textbox_Server = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.num_StationID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.combobox_Contactless)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 50)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Smart Card Reader Settings"
        '
        'combobox_Contactless
        '
        Me.combobox_Contactless.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_Contactless.FormattingEnabled = True
        Me.combobox_Contactless.Items.AddRange(New Object() {"SSS", "GSIS", "PAG-IBIG", "PHILHEALTH"})
        Me.combobox_Contactless.Location = New System.Drawing.Point(58, 19)
        Me.combobox_Contactless.Name = "combobox_Contactless"
        Me.combobox_Contactless.Size = New System.Drawing.Size(291, 22)
        Me.combobox_Contactless.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 14)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "PICC"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 45)
        Me.Panel1.TabIndex = 48
        Me.Panel1.TabStop = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(263, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.num_StationID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 49)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Station ID"
        '
        'num_StationID
        '
        Me.num_StationID.Location = New System.Drawing.Point(58, 19)
        Me.num_StationID.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.num_StationID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_StationID.Name = "num_StationID"
        Me.num_StationID.Size = New System.Drawing.Size(291, 20)
        Me.num_StationID.TabIndex = 50
        Me.num_StationID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.check_CMSStruct)
        Me.GroupBox3.Controls.Add(Me.button_BrowseRepository)
        Me.GroupBox3.Controls.Add(Me.textbox_Repository)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 162)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 72)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Purchase Order Repository"
        '
        'check_CMSStruct
        '
        Me.check_CMSStruct.AutoSize = True
        Me.check_CMSStruct.Location = New System.Drawing.Point(58, 45)
        Me.check_CMSStruct.Name = "check_CMSStruct"
        Me.check_CMSStruct.Size = New System.Drawing.Size(159, 18)
        Me.check_CMSStruct.TabIndex = 3
        Me.check_CMSStruct.Text = "CMS Directory Structure"
        Me.check_CMSStruct.UseVisualStyleBackColor = True
        '
        'button_BrowseRepository
        '
        Me.button_BrowseRepository.Location = New System.Drawing.Point(279, 18)
        Me.button_BrowseRepository.Name = "button_BrowseRepository"
        Me.button_BrowseRepository.Size = New System.Drawing.Size(75, 23)
        Me.button_BrowseRepository.TabIndex = 2
        Me.button_BrowseRepository.Text = "Browse"
        Me.button_BrowseRepository.UseVisualStyleBackColor = True
        '
        'textbox_Repository
        '
        Me.textbox_Repository.BackColor = System.Drawing.Color.White
        Me.textbox_Repository.Location = New System.Drawing.Point(58, 19)
        Me.textbox_Repository.Name = "textbox_Repository"
        Me.textbox_Repository.ReadOnly = True
        Me.textbox_Repository.Size = New System.Drawing.Size(215, 20)
        Me.textbox_Repository.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Path"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.label5)
        Me.GroupBox4.Controls.Add(Me.cboData)
        Me.GroupBox4.Controls.Add(Me.label4)
        Me.GroupBox4.Controls.Add(Me.cboStop)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.label3)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cboParity)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.cboBaud)
        Me.GroupBox4.Controls.Add(Me.cboPort)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 240)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(360, 122)
        Me.GroupBox4.TabIndex = 101
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Barcode Options"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(190, 19)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(54, 14)
        Me.label5.TabIndex = 19
        Me.label5.Text = "Data Bits"
        '
        'cboData
        '
        Me.cboData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboData.FormattingEnabled = True
        Me.cboData.Items.AddRange(New Object() {"7", "8", "9"})
        Me.cboData.Location = New System.Drawing.Point(193, 37)
        Me.cboData.Name = "cboData"
        Me.cboData.Size = New System.Drawing.Size(76, 22)
        Me.cboData.TabIndex = 14
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(97, 64)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 14)
        Me.label4.TabIndex = 18
        Me.label4.Text = "Stop Bits"
        '
        'cboStop
        '
        Me.cboStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStop.FormattingEnabled = True
        Me.cboStop.Location = New System.Drawing.Point(99, 81)
        Me.cboStop.Name = "cboStop"
        Me.cboStop.Size = New System.Drawing.Size(76, 22)
        Me.cboStop.TabIndex = 13
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdoText)
        Me.GroupBox5.Controls.Add(Me.rdoHex)
        Me.GroupBox5.Location = New System.Drawing.Point(193, 65)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(147, 40)
        Me.GroupBox5.TabIndex = 37
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Mode"
        '
        'rdoText
        '
        Me.rdoText.AutoSize = True
        Me.rdoText.Location = New System.Drawing.Point(95, 17)
        Me.rdoText.Name = "rdoText"
        Me.rdoText.Size = New System.Drawing.Size(48, 18)
        Me.rdoText.TabIndex = 1
        Me.rdoText.TabStop = True
        Me.rdoText.Text = "Text"
        Me.rdoText.UseVisualStyleBackColor = True
        '
        'rdoHex
        '
        Me.rdoHex.AutoSize = True
        Me.rdoHex.Location = New System.Drawing.Point(6, 17)
        Me.rdoHex.Name = "rdoHex"
        Me.rdoHex.Size = New System.Drawing.Size(45, 18)
        Me.rdoHex.TabIndex = 0
        Me.rdoHex.TabStop = True
        Me.rdoHex.Text = "Hex"
        Me.rdoHex.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(96, 19)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(38, 14)
        Me.label3.TabIndex = 17
        Me.label3.Text = "Parity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 14)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Baud Rate"
        '
        'cboParity
        '
        Me.cboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboParity.FormattingEnabled = True
        Me.cboParity.Location = New System.Drawing.Point(99, 37)
        Me.cboParity.Name = "cboParity"
        Me.cboParity.Size = New System.Drawing.Size(76, 22)
        Me.cboParity.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 14)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Port"
        '
        'cboBaud
        '
        Me.cboBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaud.FormattingEnabled = True
        Me.cboBaud.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "14400", "28800", "36000", "115000"})
        Me.cboBaud.Location = New System.Drawing.Point(9, 80)
        Me.cboBaud.Name = "cboBaud"
        Me.cboBaud.Size = New System.Drawing.Size(76, 22)
        Me.cboBaud.TabIndex = 11
        '
        'cboPort
        '
        Me.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPort.FormattingEnabled = True
        Me.cboPort.Location = New System.Drawing.Point(9, 37)
        Me.cboPort.Name = "cboPort"
        Me.cboPort.Size = New System.Drawing.Size(76, 22)
        Me.cboPort.TabIndex = 10
        '
        'button_SaveSettings
        '
        Me.button_SaveSettings.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_SaveSettings.Location = New System.Drawing.Point(147, 530)
        Me.button_SaveSettings.Name = "button_SaveSettings"
        Me.button_SaveSettings.Size = New System.Drawing.Size(103, 23)
        Me.button_SaveSettings.TabIndex = 103
        Me.button_SaveSettings.Text = "Save"
        Me.button_SaveSettings.UseVisualStyleBackColor = True
        '
        'button_Cancel
        '
        Me.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Cancel.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Cancel.Location = New System.Drawing.Point(263, 530)
        Me.button_Cancel.Name = "button_Cancel"
        Me.button_Cancel.Size = New System.Drawing.Size(103, 23)
        Me.button_Cancel.TabIndex = 102
        Me.button_Cancel.Text = "Close"
        Me.button_Cancel.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.link_TestConnection)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.textbox_DBPassword)
        Me.GroupBox6.Controls.Add(Me.textbox_DBUID)
        Me.GroupBox6.Controls.Add(Me.textbox_Database)
        Me.GroupBox6.Controls.Add(Me.textbox_Server)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 368)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(360, 156)
        Me.GroupBox6.TabIndex = 104
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Database Server"
        '
        'link_TestConnection
        '
        Me.link_TestConnection.AutoSize = True
        Me.link_TestConnection.Location = New System.Drawing.Point(199, 128)
        Me.link_TestConnection.Name = "link_TestConnection"
        Me.link_TestConnection.Size = New System.Drawing.Size(150, 14)
        Me.link_TestConnection.TabIndex = 22
        Me.link_TestConnection.TabStop = True
        Me.link_TestConnection.Text = "Test Database Connection"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 102)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 14)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Password"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 76)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 14)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "UID"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 50)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 14)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Database"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 24)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 14)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Server"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textbox_DBPassword
        '
        Me.textbox_DBPassword.Location = New System.Drawing.Point(81, 99)
        Me.textbox_DBPassword.Name = "textbox_DBPassword"
        Me.textbox_DBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.textbox_DBPassword.Size = New System.Drawing.Size(273, 20)
        Me.textbox_DBPassword.TabIndex = 17
        '
        'textbox_DBUID
        '
        Me.textbox_DBUID.Location = New System.Drawing.Point(81, 73)
        Me.textbox_DBUID.Name = "textbox_DBUID"
        Me.textbox_DBUID.Size = New System.Drawing.Size(273, 20)
        Me.textbox_DBUID.TabIndex = 16
        '
        'textbox_Database
        '
        Me.textbox_Database.Location = New System.Drawing.Point(81, 47)
        Me.textbox_Database.Name = "textbox_Database"
        Me.textbox_Database.Size = New System.Drawing.Size(273, 20)
        Me.textbox_Database.TabIndex = 15
        '
        'textbox_Server
        '
        Me.textbox_Server.Location = New System.Drawing.Point(81, 21)
        Me.textbox_Server.Name = "textbox_Server"
        Me.textbox_Server.Size = New System.Drawing.Size(273, 20)
        Me.textbox_Server.TabIndex = 14
        '
        'formSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.button_Cancel
        Me.ClientSize = New System.Drawing.Size(382, 561)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.button_SaveSettings)
        Me.Controls.Add(Me.button_Cancel)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UMID Perso System - Settings"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.num_StationID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents combobox_Contactless As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents num_StationID As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents check_CMSStruct As System.Windows.Forms.CheckBox
    Friend WithEvents button_BrowseRepository As System.Windows.Forms.Button
    Friend WithEvents textbox_Repository As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents cboData As System.Windows.Forms.ComboBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents cboStop As System.Windows.Forms.ComboBox
    Private WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents rdoText As System.Windows.Forms.RadioButton
    Private WithEvents rdoHex As System.Windows.Forms.RadioButton
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents cboParity As System.Windows.Forms.ComboBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents cboBaud As System.Windows.Forms.ComboBox
    Private WithEvents cboPort As System.Windows.Forms.ComboBox
    Friend WithEvents button_SaveSettings As System.Windows.Forms.Button
    Friend WithEvents button_Cancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents link_TestConnection As System.Windows.Forms.LinkLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents textbox_DBPassword As System.Windows.Forms.TextBox
    Friend WithEvents textbox_DBUID As System.Windows.Forms.TextBox
    Friend WithEvents textbox_Database As System.Windows.Forms.TextBox
    Friend WithEvents textbox_Server As System.Windows.Forms.TextBox
End Class
