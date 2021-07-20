<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.panel_Banner = New System.Windows.Forms.Panel
        Me.label_UserType = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.label_Operator = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.statstrip_Main = New System.Windows.Forms.StatusStrip
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.ReaderSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.LogoffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.label_Status = New System.Windows.Forms.ToolStripStatusLabel
        Me.panel_Preview = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.label_OCR = New System.Windows.Forms.Label
        Me.pic_Signature = New System.Windows.Forms.PictureBox
        Me.pic_Photo = New System.Windows.Forms.PictureBox
        Me.label_CRN = New System.Windows.Forms.Label
        Me.label_Address = New System.Windows.Forms.Label
        Me.label_Birthdate = New System.Windows.Forms.Label
        Me.label_Sex = New System.Windows.Forms.Label
        Me.label_MiddleName = New System.Windows.Forms.Label
        Me.label_GivenName = New System.Windows.Forms.Label
        Me.label_Surname = New System.Windows.Forms.Label
        Me.progress_UMID = New System.Windows.Forms.ProgressBar
        Me.group_GSIS = New System.Windows.Forms.GroupBox
        Me.label_GSIS_BP = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.label_GSIS_Number = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.group_Evolis = New System.Windows.Forms.GroupBox
        Me.button_StartEvolis = New System.Windows.Forms.Button
        Me.combobox_Evolis = New System.Windows.Forms.ComboBox
        Me.group_Manual = New System.Windows.Forms.GroupBox
        Me.button_PersoCard = New System.Windows.Forms.Button
        Me.textbox_CSN = New System.Windows.Forms.TextBox
        Me.radio_CRN = New System.Windows.Forms.RadioButton
        Me.radio_CSN = New System.Windows.Forms.RadioButton
        Me.group_PersonalizationSettings = New System.Windows.Forms.GroupBox
        Me.check_InitStrict = New System.Windows.Forms.CheckBox
        Me.check_GSIS_Activate = New System.Windows.Forms.CheckBox
        Me.radio_CMS = New System.Windows.Forms.RadioButton
        Me.radio_Demographic = New System.Windows.Forms.RadioButton
        Me.check_EncodeTracks = New System.Windows.Forms.CheckBox
        Me.check_PersoGSIS = New System.Windows.Forms.CheckBox
        Me.check_PersoUMID = New System.Windows.Forms.CheckBox
        Me.check_LoadApplet = New System.Windows.Forms.CheckBox
        Me.check_Initialize = New System.Windows.Forms.CheckBox
        Me.group_UBP = New System.Windows.Forms.GroupBox
        Me.label_UBP_CardNumber = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.label_UBP_AcountNumber = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.label_UBP_Track2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.label_UBP_Track1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.group_Current = New System.Windows.Forms.GroupBox
        Me.label_Current_SmartCardReader = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.label_Current_Repository = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.label_Current_Status = New System.Windows.Forms.Label
        Me.label_Current_PO = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.label_Current_ChipSN = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.label_Current_CSN = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.listbox_PCSC_Log = New System.Windows.Forms.ListBox
        Me.panel_Filler = New System.Windows.Forms.Panel
        Me.richtext_AppletScript = New System.Windows.Forms.RichTextBox
        Me.rtbDisplay = New System.Windows.Forms.RichTextBox
        Me.button_APDU = New System.Windows.Forms.Button
        Me.showThread = New System.ComponentModel.BackgroundWorker
        Me.panel_Banner.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statstrip_Main.SuspendLayout()
        Me.panel_Preview.SuspendLayout()
        CType(Me.pic_Signature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_GSIS.SuspendLayout()
        Me.group_Evolis.SuspendLayout()
        Me.group_Manual.SuspendLayout()
        Me.group_PersonalizationSettings.SuspendLayout()
        Me.group_UBP.SuspendLayout()
        Me.group_Current.SuspendLayout()
        Me.panel_Filler.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_Banner
        '
        Me.panel_Banner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_Banner.BackColor = System.Drawing.Color.White
        Me.panel_Banner.Controls.Add(Me.label_UserType)
        Me.panel_Banner.Controls.Add(Me.PictureBox2)
        Me.panel_Banner.Controls.Add(Me.label_Operator)
        Me.panel_Banner.Controls.Add(Me.PictureBox1)
        Me.panel_Banner.Location = New System.Drawing.Point(0, 0)
        Me.panel_Banner.Name = "panel_Banner"
        Me.panel_Banner.Size = New System.Drawing.Size(1018, 45)
        Me.panel_Banner.TabIndex = 47
        Me.panel_Banner.TabStop = True
        '
        'label_UserType
        '
        Me.label_UserType.AutoSize = True
        Me.label_UserType.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_UserType.Location = New System.Drawing.Point(65, 25)
        Me.label_UserType.Name = "label_UserType"
        Me.label_UserType.Size = New System.Drawing.Size(129, 17)
        Me.label_UserType.TabIndex = 72
        Me.label_UserType.Text = "USER TYPE: "
        Me.label_UserType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'label_Operator
        '
        Me.label_Operator.AutoSize = True
        Me.label_Operator.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Operator.Location = New System.Drawing.Point(64, 5)
        Me.label_Operator.Name = "label_Operator"
        Me.label_Operator.Size = New System.Drawing.Size(129, 17)
        Me.label_Operator.TabIndex = 71
        Me.label_Operator.Text = "OPERATOR : "
        Me.label_Operator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(898, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'statstrip_Main
        '
        Me.statstrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.label_Status})
        Me.statstrip_Main.Location = New System.Drawing.Point(0, 650)
        Me.statstrip_Main.Name = "statstrip_Main"
        Me.statstrip_Main.Size = New System.Drawing.Size(1018, 22)
        Me.statstrip_Main.TabIndex = 48
        Me.statstrip_Main.Text = "StatusStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReaderSettingsToolStripMenuItem, Me.UserSettingsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.LogoffToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'ReaderSettingsToolStripMenuItem
        '
        Me.ReaderSettingsToolStripMenuItem.Image = CType(resources.GetObject("ReaderSettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReaderSettingsToolStripMenuItem.Name = "ReaderSettingsToolStripMenuItem"
        Me.ReaderSettingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ReaderSettingsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ReaderSettingsToolStripMenuItem.Text = "System Settings"
        '
        'UserSettingsToolStripMenuItem
        '
        Me.UserSettingsToolStripMenuItem.Image = CType(resources.GetObject("UserSettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserSettingsToolStripMenuItem.Name = "UserSettingsToolStripMenuItem"
        Me.UserSettingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.UserSettingsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.UserSettingsToolStripMenuItem.Text = "User Settings"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem1.Text = "PCSC Log"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Image = CType(resources.GetObject("ClearToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        'LogoffToolStripMenuItem
        '
        Me.LogoffToolStripMenuItem.Image = CType(resources.GetObject("LogoffToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoffToolStripMenuItem.Name = "LogoffToolStripMenuItem"
        Me.LogoffToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.LogoffToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LogoffToolStripMenuItem.Text = "Logoff"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'label_Status
        '
        Me.label_Status.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Status.Name = "label_Status"
        Me.label_Status.Size = New System.Drawing.Size(41, 17)
        Me.label_Status.Text = "Ready"
        '
        'panel_Preview
        '
        Me.panel_Preview.BackgroundImage = CType(resources.GetObject("panel_Preview.BackgroundImage"), System.Drawing.Image)
        Me.panel_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_Preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_Preview.Controls.Add(Me.Label10)
        Me.panel_Preview.Controls.Add(Me.label_OCR)
        Me.panel_Preview.Controls.Add(Me.pic_Signature)
        Me.panel_Preview.Controls.Add(Me.pic_Photo)
        Me.panel_Preview.Controls.Add(Me.label_CRN)
        Me.panel_Preview.Controls.Add(Me.label_Address)
        Me.panel_Preview.Controls.Add(Me.label_Birthdate)
        Me.panel_Preview.Controls.Add(Me.label_Sex)
        Me.panel_Preview.Controls.Add(Me.label_MiddleName)
        Me.panel_Preview.Controls.Add(Me.label_GivenName)
        Me.panel_Preview.Controls.Add(Me.label_Surname)
        Me.panel_Preview.Location = New System.Drawing.Point(12, 51)
        Me.panel_Preview.Name = "panel_Preview"
        Me.panel_Preview.Size = New System.Drawing.Size(626, 395)
        Me.panel_Preview.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(414, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 14)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "OCR"
        '
        'label_OCR
        '
        Me.label_OCR.AutoSize = True
        Me.label_OCR.BackColor = System.Drawing.Color.Transparent
        Me.label_OCR.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_OCR.Location = New System.Drawing.Point(450, 367)
        Me.label_OCR.Name = "label_OCR"
        Me.label_OCR.Size = New System.Drawing.Size(96, 17)
        Me.label_OCR.TabIndex = 68
        Me.label_OCR.Text = "BACK OCR"
        '
        'pic_Signature
        '
        Me.pic_Signature.BackColor = System.Drawing.Color.Transparent
        Me.pic_Signature.Location = New System.Drawing.Point(260, 249)
        Me.pic_Signature.Name = "pic_Signature"
        Me.pic_Signature.Size = New System.Drawing.Size(151, 59)
        Me.pic_Signature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Signature.TabIndex = 67
        Me.pic_Signature.TabStop = False
        '
        'pic_Photo
        '
        Me.pic_Photo.BackColor = System.Drawing.Color.White
        Me.pic_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Photo.Location = New System.Drawing.Point(417, 134)
        Me.pic_Photo.Name = "pic_Photo"
        Me.pic_Photo.Size = New System.Drawing.Size(175, 227)
        Me.pic_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Photo.TabIndex = 66
        Me.pic_Photo.TabStop = False
        '
        'label_CRN
        '
        Me.label_CRN.BackColor = System.Drawing.Color.Transparent
        Me.label_CRN.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_CRN.Location = New System.Drawing.Point(400, 109)
        Me.label_CRN.Name = "label_CRN"
        Me.label_CRN.Size = New System.Drawing.Size(196, 20)
        Me.label_CRN.TabIndex = 65
        Me.label_CRN.Text = "000-0000-0000-0"
        '
        'label_Address
        '
        Me.label_Address.BackColor = System.Drawing.Color.Transparent
        Me.label_Address.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Address.Location = New System.Drawing.Point(30, 315)
        Me.label_Address.Name = "label_Address"
        Me.label_Address.Size = New System.Drawing.Size(381, 69)
        Me.label_Address.TabIndex = 64
        Me.label_Address.Text = "Address"
        '
        'label_Birthdate
        '
        Me.label_Birthdate.BackColor = System.Drawing.Color.Transparent
        Me.label_Birthdate.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Birthdate.Location = New System.Drawing.Point(118, 271)
        Me.label_Birthdate.Name = "label_Birthdate"
        Me.label_Birthdate.Size = New System.Drawing.Size(136, 20)
        Me.label_Birthdate.TabIndex = 63
        Me.label_Birthdate.Text = "1999/99/99"
        '
        'label_Sex
        '
        Me.label_Sex.BackColor = System.Drawing.Color.Transparent
        Me.label_Sex.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Sex.Location = New System.Drawing.Point(118, 249)
        Me.label_Sex.Name = "label_Sex"
        Me.label_Sex.Size = New System.Drawing.Size(138, 20)
        Me.label_Sex.TabIndex = 62
        Me.label_Sex.Text = "SEX"
        '
        'label_MiddleName
        '
        Me.label_MiddleName.BackColor = System.Drawing.Color.Transparent
        Me.label_MiddleName.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_MiddleName.Location = New System.Drawing.Point(118, 213)
        Me.label_MiddleName.Name = "label_MiddleName"
        Me.label_MiddleName.Size = New System.Drawing.Size(293, 20)
        Me.label_MiddleName.TabIndex = 61
        Me.label_MiddleName.Text = "MIDDLE NAME"
        '
        'label_GivenName
        '
        Me.label_GivenName.BackColor = System.Drawing.Color.Transparent
        Me.label_GivenName.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_GivenName.Location = New System.Drawing.Point(118, 173)
        Me.label_GivenName.Name = "label_GivenName"
        Me.label_GivenName.Size = New System.Drawing.Size(293, 20)
        Me.label_GivenName.TabIndex = 60
        Me.label_GivenName.Text = "GIVEN NAME"
        '
        'label_Surname
        '
        Me.label_Surname.BackColor = System.Drawing.Color.Transparent
        Me.label_Surname.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Surname.Location = New System.Drawing.Point(118, 134)
        Me.label_Surname.Name = "label_Surname"
        Me.label_Surname.Size = New System.Drawing.Size(293, 20)
        Me.label_Surname.TabIndex = 59
        Me.label_Surname.Text = "SURNAME"
        '
        'progress_UMID
        '
        Me.progress_UMID.Location = New System.Drawing.Point(12, 452)
        Me.progress_UMID.Maximum = 200
        Me.progress_UMID.Name = "progress_UMID"
        Me.progress_UMID.Size = New System.Drawing.Size(626, 23)
        Me.progress_UMID.TabIndex = 50
        '
        'group_GSIS
        '
        Me.group_GSIS.Controls.Add(Me.label_GSIS_BP)
        Me.group_GSIS.Controls.Add(Me.Label4)
        Me.group_GSIS.Controls.Add(Me.label_GSIS_Number)
        Me.group_GSIS.Controls.Add(Me.Label1)
        Me.group_GSIS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_GSIS.Location = New System.Drawing.Point(12, 481)
        Me.group_GSIS.Name = "group_GSIS"
        Me.group_GSIS.Size = New System.Drawing.Size(175, 166)
        Me.group_GSIS.TabIndex = 52
        Me.group_GSIS.TabStop = False
        Me.group_GSIS.Text = "GSIS Data"
        '
        'label_GSIS_BP
        '
        Me.label_GSIS_BP.AutoSize = True
        Me.label_GSIS_BP.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_GSIS_BP.Location = New System.Drawing.Point(6, 113)
        Me.label_GSIS_BP.Name = "label_GSIS_BP"
        Me.label_GSIS_BP.Size = New System.Drawing.Size(117, 20)
        Me.label_GSIS_BP.TabIndex = 60
        Me.label_GSIS_BP.Text = "BP Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "BP Number"
        '
        'label_GSIS_Number
        '
        Me.label_GSIS_Number.AutoSize = True
        Me.label_GSIS_Number.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_GSIS_Number.Location = New System.Drawing.Point(6, 44)
        Me.label_GSIS_Number.Name = "label_GSIS_Number"
        Me.label_GSIS_Number.Size = New System.Drawing.Size(141, 20)
        Me.label_GSIS_Number.TabIndex = 58
        Me.label_GSIS_Number.Text = "GSIS Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "GSIS Number"
        '
        'group_Evolis
        '
        Me.group_Evolis.Controls.Add(Me.button_StartEvolis)
        Me.group_Evolis.Controls.Add(Me.combobox_Evolis)
        Me.group_Evolis.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Evolis.Location = New System.Drawing.Point(644, 219)
        Me.group_Evolis.Name = "group_Evolis"
        Me.group_Evolis.Size = New System.Drawing.Size(362, 99)
        Me.group_Evolis.TabIndex = 53
        Me.group_Evolis.TabStop = False
        Me.group_Evolis.Text = "Use Evolis Printer"
        '
        'button_StartEvolis
        '
        Me.button_StartEvolis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_StartEvolis.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_StartEvolis.Location = New System.Drawing.Point(6, 47)
        Me.button_StartEvolis.Name = "button_StartEvolis"
        Me.button_StartEvolis.Size = New System.Drawing.Size(350, 47)
        Me.button_StartEvolis.TabIndex = 55
        Me.button_StartEvolis.TabStop = False
        Me.button_StartEvolis.Text = "Start Personalization"
        Me.button_StartEvolis.UseVisualStyleBackColor = True
        '
        'combobox_Evolis
        '
        Me.combobox_Evolis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_Evolis.FormattingEnabled = True
        Me.combobox_Evolis.Location = New System.Drawing.Point(6, 19)
        Me.combobox_Evolis.Name = "combobox_Evolis"
        Me.combobox_Evolis.Size = New System.Drawing.Size(350, 22)
        Me.combobox_Evolis.TabIndex = 55
        Me.combobox_Evolis.TabStop = False
        '
        'group_Manual
        '
        Me.group_Manual.Controls.Add(Me.button_PersoCard)
        Me.group_Manual.Controls.Add(Me.textbox_CSN)
        Me.group_Manual.Controls.Add(Me.radio_CRN)
        Me.group_Manual.Controls.Add(Me.radio_CSN)
        Me.group_Manual.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Manual.Location = New System.Drawing.Point(644, 319)
        Me.group_Manual.Name = "group_Manual"
        Me.group_Manual.Size = New System.Drawing.Size(362, 156)
        Me.group_Manual.TabIndex = 54
        Me.group_Manual.TabStop = False
        Me.group_Manual.Text = "Manual Personalization"
        '
        'button_PersoCard
        '
        Me.button_PersoCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_PersoCard.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_PersoCard.Location = New System.Drawing.Point(6, 79)
        Me.button_PersoCard.Name = "button_PersoCard"
        Me.button_PersoCard.Size = New System.Drawing.Size(350, 71)
        Me.button_PersoCard.TabIndex = 58
        Me.button_PersoCard.TabStop = False
        Me.button_PersoCard.Text = "Personalize"
        Me.button_PersoCard.UseVisualStyleBackColor = True
        '
        'textbox_CSN
        '
        Me.textbox_CSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox_CSN.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_CSN.Location = New System.Drawing.Point(6, 43)
        Me.textbox_CSN.Name = "textbox_CSN"
        Me.textbox_CSN.Size = New System.Drawing.Size(350, 30)
        Me.textbox_CSN.TabIndex = 56
        '
        'radio_CRN
        '
        Me.radio_CRN.AutoSize = True
        Me.radio_CRN.Location = New System.Drawing.Point(59, 19)
        Me.radio_CRN.Name = "radio_CRN"
        Me.radio_CRN.Size = New System.Drawing.Size(47, 18)
        Me.radio_CRN.TabIndex = 57
        Me.radio_CRN.Text = "CRN"
        Me.radio_CRN.UseVisualStyleBackColor = True
        '
        'radio_CSN
        '
        Me.radio_CSN.AutoSize = True
        Me.radio_CSN.Checked = True
        Me.radio_CSN.Location = New System.Drawing.Point(6, 19)
        Me.radio_CSN.Name = "radio_CSN"
        Me.radio_CSN.Size = New System.Drawing.Size(47, 18)
        Me.radio_CSN.TabIndex = 56
        Me.radio_CSN.TabStop = True
        Me.radio_CSN.Text = "CSN"
        Me.radio_CSN.UseVisualStyleBackColor = True
        '
        'group_PersonalizationSettings
        '
        Me.group_PersonalizationSettings.Controls.Add(Me.check_InitStrict)
        Me.group_PersonalizationSettings.Controls.Add(Me.check_GSIS_Activate)
        Me.group_PersonalizationSettings.Controls.Add(Me.radio_CMS)
        Me.group_PersonalizationSettings.Controls.Add(Me.radio_Demographic)
        Me.group_PersonalizationSettings.Controls.Add(Me.check_EncodeTracks)
        Me.group_PersonalizationSettings.Controls.Add(Me.check_PersoGSIS)
        Me.group_PersonalizationSettings.Controls.Add(Me.check_PersoUMID)
        Me.group_PersonalizationSettings.Controls.Add(Me.check_LoadApplet)
        Me.group_PersonalizationSettings.Controls.Add(Me.check_Initialize)
        Me.group_PersonalizationSettings.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_PersonalizationSettings.Location = New System.Drawing.Point(644, 51)
        Me.group_PersonalizationSettings.Name = "group_PersonalizationSettings"
        Me.group_PersonalizationSettings.Size = New System.Drawing.Size(362, 162)
        Me.group_PersonalizationSettings.TabIndex = 55
        Me.group_PersonalizationSettings.TabStop = False
        Me.group_PersonalizationSettings.Text = "Personalization Settings"
        '
        'check_InitStrict
        '
        Me.check_InitStrict.AutoSize = True
        Me.check_InitStrict.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_InitStrict.Location = New System.Drawing.Point(187, 19)
        Me.check_InitStrict.Name = "check_InitStrict"
        Me.check_InitStrict.Size = New System.Drawing.Size(68, 23)
        Me.check_InitStrict.TabIndex = 63
        Me.check_InitStrict.TabStop = False
        Me.check_InitStrict.Text = "Strict"
        Me.check_InitStrict.UseVisualStyleBackColor = True
        '
        'check_GSIS_Activate
        '
        Me.check_GSIS_Activate.AutoSize = True
        Me.check_GSIS_Activate.Checked = True
        Me.check_GSIS_Activate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.check_GSIS_Activate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_GSIS_Activate.Location = New System.Drawing.Point(187, 106)
        Me.check_GSIS_Activate.Name = "check_GSIS_Activate"
        Me.check_GSIS_Activate.Size = New System.Drawing.Size(89, 23)
        Me.check_GSIS_Activate.TabIndex = 62
        Me.check_GSIS_Activate.TabStop = False
        Me.check_GSIS_Activate.Text = "Activate"
        Me.check_GSIS_Activate.UseVisualStyleBackColor = True
        '
        'radio_CMS
        '
        Me.radio_CMS.AutoSize = True
        Me.radio_CMS.Checked = True
        Me.radio_CMS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_CMS.Location = New System.Drawing.Point(187, 77)
        Me.radio_CMS.Name = "radio_CMS"
        Me.radio_CMS.Size = New System.Drawing.Size(50, 18)
        Me.radio_CMS.TabIndex = 61
        Me.radio_CMS.TabStop = True
        Me.radio_CMS.Text = "CMS"
        Me.radio_CMS.UseVisualStyleBackColor = True
        '
        'radio_Demographic
        '
        Me.radio_Demographic.AutoSize = True
        Me.radio_Demographic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_Demographic.Location = New System.Drawing.Point(254, 77)
        Me.radio_Demographic.Name = "radio_Demographic"
        Me.radio_Demographic.Size = New System.Drawing.Size(98, 18)
        Me.radio_Demographic.TabIndex = 56
        Me.radio_Demographic.Text = "Demographic"
        Me.radio_Demographic.UseVisualStyleBackColor = True
        '
        'check_EncodeTracks
        '
        Me.check_EncodeTracks.AutoSize = True
        Me.check_EncodeTracks.Checked = True
        Me.check_EncodeTracks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.check_EncodeTracks.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_EncodeTracks.Location = New System.Drawing.Point(6, 135)
        Me.check_EncodeTracks.Name = "check_EncodeTracks"
        Me.check_EncodeTracks.Size = New System.Drawing.Size(142, 23)
        Me.check_EncodeTracks.TabIndex = 60
        Me.check_EncodeTracks.TabStop = False
        Me.check_EncodeTracks.Text = "Encode Tracks"
        Me.check_EncodeTracks.UseVisualStyleBackColor = True
        '
        'check_PersoGSIS
        '
        Me.check_PersoGSIS.AutoSize = True
        Me.check_PersoGSIS.Checked = True
        Me.check_PersoGSIS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.check_PersoGSIS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_PersoGSIS.Location = New System.Drawing.Point(6, 106)
        Me.check_PersoGSIS.Name = "check_PersoGSIS"
        Me.check_PersoGSIS.Size = New System.Drawing.Size(160, 23)
        Me.check_PersoGSIS.TabIndex = 59
        Me.check_PersoGSIS.TabStop = False
        Me.check_PersoGSIS.Text = "Personalize GSIS"
        Me.check_PersoGSIS.UseVisualStyleBackColor = True
        '
        'check_PersoUMID
        '
        Me.check_PersoUMID.AutoSize = True
        Me.check_PersoUMID.Checked = True
        Me.check_PersoUMID.CheckState = System.Windows.Forms.CheckState.Checked
        Me.check_PersoUMID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_PersoUMID.Location = New System.Drawing.Point(6, 77)
        Me.check_PersoUMID.Name = "check_PersoUMID"
        Me.check_PersoUMID.Size = New System.Drawing.Size(163, 23)
        Me.check_PersoUMID.TabIndex = 58
        Me.check_PersoUMID.TabStop = False
        Me.check_PersoUMID.Text = "Personalize UMID"
        Me.check_PersoUMID.UseVisualStyleBackColor = True
        '
        'check_LoadApplet
        '
        Me.check_LoadApplet.AutoSize = True
        Me.check_LoadApplet.Checked = True
        Me.check_LoadApplet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.check_LoadApplet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_LoadApplet.Location = New System.Drawing.Point(6, 48)
        Me.check_LoadApplet.Name = "check_LoadApplet"
        Me.check_LoadApplet.Size = New System.Drawing.Size(119, 23)
        Me.check_LoadApplet.TabIndex = 57
        Me.check_LoadApplet.TabStop = False
        Me.check_LoadApplet.Text = "Load Applet"
        Me.check_LoadApplet.UseVisualStyleBackColor = True
        '
        'check_Initialize
        '
        Me.check_Initialize.AutoSize = True
        Me.check_Initialize.Checked = True
        Me.check_Initialize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.check_Initialize.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_Initialize.Location = New System.Drawing.Point(6, 19)
        Me.check_Initialize.Name = "check_Initialize"
        Me.check_Initialize.Size = New System.Drawing.Size(164, 23)
        Me.check_Initialize.TabIndex = 56
        Me.check_Initialize.TabStop = False
        Me.check_Initialize.Text = "UMID Initialization"
        Me.check_Initialize.UseVisualStyleBackColor = True
        '
        'group_UBP
        '
        Me.group_UBP.Controls.Add(Me.label_UBP_CardNumber)
        Me.group_UBP.Controls.Add(Me.Label14)
        Me.group_UBP.Controls.Add(Me.label_UBP_AcountNumber)
        Me.group_UBP.Controls.Add(Me.Label5)
        Me.group_UBP.Controls.Add(Me.label_UBP_Track2)
        Me.group_UBP.Controls.Add(Me.Label6)
        Me.group_UBP.Controls.Add(Me.label_UBP_Track1)
        Me.group_UBP.Controls.Add(Me.Label8)
        Me.group_UBP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_UBP.Location = New System.Drawing.Point(193, 481)
        Me.group_UBP.Name = "group_UBP"
        Me.group_UBP.Size = New System.Drawing.Size(445, 166)
        Me.group_UBP.TabIndex = 56
        Me.group_UBP.TabStop = False
        Me.group_UBP.Text = "Unionbank Data"
        '
        'label_UBP_CardNumber
        '
        Me.label_UBP_CardNumber.AutoSize = True
        Me.label_UBP_CardNumber.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_UBP_CardNumber.Location = New System.Drawing.Point(8, 143)
        Me.label_UBP_CardNumber.Name = "label_UBP_CardNumber"
        Me.label_UBP_CardNumber.Size = New System.Drawing.Size(129, 17)
        Me.label_UBP_CardNumber.TabIndex = 68
        Me.label_UBP_CardNumber.Text = "CARD NUMBER"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Card Number"
        '
        'label_UBP_AcountNumber
        '
        Me.label_UBP_AcountNumber.AutoSize = True
        Me.label_UBP_AcountNumber.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_UBP_AcountNumber.Location = New System.Drawing.Point(7, 106)
        Me.label_UBP_AcountNumber.Name = "label_UBP_AcountNumber"
        Me.label_UBP_AcountNumber.Size = New System.Drawing.Size(162, 17)
        Me.label_UBP_AcountNumber.TabIndex = 66
        Me.label_UBP_AcountNumber.Text = "ACCOUNT NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Account Number"
        '
        'label_UBP_Track2
        '
        Me.label_UBP_Track2.AutoSize = True
        Me.label_UBP_Track2.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_UBP_Track2.Location = New System.Drawing.Point(6, 69)
        Me.label_UBP_Track2.Name = "label_UBP_Track2"
        Me.label_UBP_Track2.Size = New System.Drawing.Size(85, 17)
        Me.label_UBP_Track2.TabIndex = 64
        Me.label_UBP_Track2.Text = "TRACK 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Track 2"
        '
        'label_UBP_Track1
        '
        Me.label_UBP_Track1.AutoSize = True
        Me.label_UBP_Track1.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_UBP_Track1.Location = New System.Drawing.Point(5, 31)
        Me.label_UBP_Track1.Name = "label_UBP_Track1"
        Me.label_UBP_Track1.Size = New System.Drawing.Size(85, 17)
        Me.label_UBP_Track1.TabIndex = 62
        Me.label_UBP_Track1.Text = "TRACK 1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Track 1"
        '
        'group_Current
        '
        Me.group_Current.Controls.Add(Me.label_Current_SmartCardReader)
        Me.group_Current.Controls.Add(Me.Label7)
        Me.group_Current.Controls.Add(Me.label_Current_Repository)
        Me.group_Current.Controls.Add(Me.Label3)
        Me.group_Current.Controls.Add(Me.label_Current_Status)
        Me.group_Current.Controls.Add(Me.label_Current_PO)
        Me.group_Current.Controls.Add(Me.Label13)
        Me.group_Current.Controls.Add(Me.label_Current_ChipSN)
        Me.group_Current.Controls.Add(Me.Label11)
        Me.group_Current.Controls.Add(Me.label_Current_CSN)
        Me.group_Current.Controls.Add(Me.Label9)
        Me.group_Current.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Current.Location = New System.Drawing.Point(644, 481)
        Me.group_Current.Name = "group_Current"
        Me.group_Current.Size = New System.Drawing.Size(362, 166)
        Me.group_Current.TabIndex = 65
        Me.group_Current.TabStop = False
        Me.group_Current.Text = "Current Details"
        '
        'label_Current_SmartCardReader
        '
        Me.label_Current_SmartCardReader.AutoSize = True
        Me.label_Current_SmartCardReader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Current_SmartCardReader.ForeColor = System.Drawing.Color.Blue
        Me.label_Current_SmartCardReader.Location = New System.Drawing.Point(78, 113)
        Me.label_Current_SmartCardReader.Name = "label_Current_SmartCardReader"
        Me.label_Current_SmartCardReader.Size = New System.Drawing.Size(111, 14)
        Me.label_Current_SmartCardReader.TabIndex = 72
        Me.label_Current_SmartCardReader.Text = "Smart Card Reader"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 14)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "SC Reader"
        '
        'label_Current_Repository
        '
        Me.label_Current_Repository.AutoSize = True
        Me.label_Current_Repository.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Current_Repository.ForeColor = System.Drawing.Color.Blue
        Me.label_Current_Repository.Location = New System.Drawing.Point(78, 90)
        Me.label_Current_Repository.Name = "label_Current_Repository"
        Me.label_Current_Repository.Size = New System.Drawing.Size(67, 14)
        Me.label_Current_Repository.TabIndex = 70
        Me.label_Current_Repository.Text = "Repository"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Repository"
        '
        'label_Current_Status
        '
        Me.label_Current_Status.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Current_Status.Location = New System.Drawing.Point(6, 131)
        Me.label_Current_Status.Name = "label_Current_Status"
        Me.label_Current_Status.Size = New System.Drawing.Size(350, 32)
        Me.label_Current_Status.TabIndex = 68
        Me.label_Current_Status.Text = "IDLE"
        Me.label_Current_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_Current_PO
        '
        Me.label_Current_PO.AutoSize = True
        Me.label_Current_PO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Current_PO.ForeColor = System.Drawing.Color.Blue
        Me.label_Current_PO.Location = New System.Drawing.Point(78, 65)
        Me.label_Current_PO.Name = "label_Current_PO"
        Me.label_Current_PO.Size = New System.Drawing.Size(69, 14)
        Me.label_Current_PO.TabIndex = 67
        Me.label_Current_PO.Text = "PO Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 14)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "PO Number"
        '
        'label_Current_ChipSN
        '
        Me.label_Current_ChipSN.AutoSize = True
        Me.label_Current_ChipSN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Current_ChipSN.ForeColor = System.Drawing.Color.Blue
        Me.label_Current_ChipSN.Location = New System.Drawing.Point(78, 40)
        Me.label_Current_ChipSN.Name = "label_Current_ChipSN"
        Me.label_Current_ChipSN.Size = New System.Drawing.Size(73, 14)
        Me.label_Current_ChipSN.TabIndex = 65
        Me.label_Current_ChipSN.Text = "CHIP SERIAL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 14)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Chip Serial"
        '
        'label_Current_CSN
        '
        Me.label_Current_CSN.AutoSize = True
        Me.label_Current_CSN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Current_CSN.ForeColor = System.Drawing.Color.Blue
        Me.label_Current_CSN.Location = New System.Drawing.Point(78, 17)
        Me.label_Current_CSN.Name = "label_Current_CSN"
        Me.label_Current_CSN.Size = New System.Drawing.Size(29, 14)
        Me.label_Current_CSN.TabIndex = 63
        Me.label_Current_CSN.Text = "CSN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 14)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "CSN"
        '
        'listbox_PCSC_Log
        '
        Me.listbox_PCSC_Log.FormattingEnabled = True
        Me.listbox_PCSC_Log.ItemHeight = 14
        Me.listbox_PCSC_Log.Location = New System.Drawing.Point(1024, 100)
        Me.listbox_PCSC_Log.Name = "listbox_PCSC_Log"
        Me.listbox_PCSC_Log.Size = New System.Drawing.Size(152, 550)
        Me.listbox_PCSC_Log.TabIndex = 66
        '
        'panel_Filler
        '
        Me.panel_Filler.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_Filler.BackColor = System.Drawing.Color.White
        Me.panel_Filler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_Filler.Controls.Add(Me.richtext_AppletScript)
        Me.panel_Filler.Controls.Add(Me.rtbDisplay)
        Me.panel_Filler.Location = New System.Drawing.Point(0, 653)
        Me.panel_Filler.Name = "panel_Filler"
        Me.panel_Filler.Size = New System.Drawing.Size(1022, 7)
        Me.panel_Filler.TabIndex = 67
        '
        'richtext_AppletScript
        '
        Me.richtext_AppletScript.Location = New System.Drawing.Point(12, 119)
        Me.richtext_AppletScript.Name = "richtext_AppletScript"
        Me.richtext_AppletScript.ReadOnly = True
        Me.richtext_AppletScript.Size = New System.Drawing.Size(994, 74)
        Me.richtext_AppletScript.TabIndex = 43
        Me.richtext_AppletScript.Text = resources.GetString("richtext_AppletScript.Text")
        Me.richtext_AppletScript.Visible = False
        Me.richtext_AppletScript.WordWrap = False
        '
        'rtbDisplay
        '
        Me.rtbDisplay.Location = New System.Drawing.Point(1024, 3)
        Me.rtbDisplay.Name = "rtbDisplay"
        Me.rtbDisplay.ReadOnly = True
        Me.rtbDisplay.Size = New System.Drawing.Size(152, 91)
        Me.rtbDisplay.TabIndex = 42
        Me.rtbDisplay.TabStop = False
        Me.rtbDisplay.Text = ""
        '
        'button_APDU
        '
        Me.button_APDU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_APDU.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_APDU.Location = New System.Drawing.Point(1024, 58)
        Me.button_APDU.Name = "button_APDU"
        Me.button_APDU.Size = New System.Drawing.Size(152, 35)
        Me.button_APDU.TabIndex = 68
        Me.button_APDU.TabStop = False
        Me.button_APDU.Text = "HIDE APDU"
        Me.button_APDU.UseVisualStyleBackColor = True
        '
        'showThread
        '
        Me.showThread.WorkerReportsProgress = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 672)
        Me.Controls.Add(Me.button_APDU)
        Me.Controls.Add(Me.listbox_PCSC_Log)
        Me.Controls.Add(Me.group_Current)
        Me.Controls.Add(Me.group_UBP)
        Me.Controls.Add(Me.group_PersonalizationSettings)
        Me.Controls.Add(Me.group_Manual)
        Me.Controls.Add(Me.group_Evolis)
        Me.Controls.Add(Me.group_GSIS)
        Me.Controls.Add(Me.progress_UMID)
        Me.Controls.Add(Me.panel_Preview)
        Me.Controls.Add(Me.statstrip_Main)
        Me.Controls.Add(Me.panel_Banner)
        Me.Controls.Add(Me.panel_Filler)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allcard Tech - UMID Card Personalization"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_Banner.ResumeLayout(False)
        Me.panel_Banner.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statstrip_Main.ResumeLayout(False)
        Me.statstrip_Main.PerformLayout()
        Me.panel_Preview.ResumeLayout(False)
        Me.panel_Preview.PerformLayout()
        CType(Me.pic_Signature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_GSIS.ResumeLayout(False)
        Me.group_GSIS.PerformLayout()
        Me.group_Evolis.ResumeLayout(False)
        Me.group_Manual.ResumeLayout(False)
        Me.group_Manual.PerformLayout()
        Me.group_PersonalizationSettings.ResumeLayout(False)
        Me.group_PersonalizationSettings.PerformLayout()
        Me.group_UBP.ResumeLayout(False)
        Me.group_UBP.PerformLayout()
        Me.group_Current.ResumeLayout(False)
        Me.group_Current.PerformLayout()
        Me.panel_Filler.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_Banner As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents statstrip_Main As System.Windows.Forms.StatusStrip
    Friend WithEvents label_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ReaderSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panel_Preview As System.Windows.Forms.Panel
    Friend WithEvents progress_UMID As System.Windows.Forms.ProgressBar
    Friend WithEvents group_GSIS As System.Windows.Forms.GroupBox
    Friend WithEvents group_Evolis As System.Windows.Forms.GroupBox
    Friend WithEvents button_StartEvolis As System.Windows.Forms.Button
    Friend WithEvents combobox_Evolis As System.Windows.Forms.ComboBox
    Friend WithEvents group_Manual As System.Windows.Forms.GroupBox
    Friend WithEvents radio_CRN As System.Windows.Forms.RadioButton
    Friend WithEvents radio_CSN As System.Windows.Forms.RadioButton
    Friend WithEvents group_PersonalizationSettings As System.Windows.Forms.GroupBox
    Friend WithEvents button_PersoCard As System.Windows.Forms.Button
    Friend WithEvents textbox_CSN As System.Windows.Forms.TextBox
    Friend WithEvents check_EncodeTracks As System.Windows.Forms.CheckBox
    Friend WithEvents check_PersoGSIS As System.Windows.Forms.CheckBox
    Friend WithEvents check_PersoUMID As System.Windows.Forms.CheckBox
    Friend WithEvents check_LoadApplet As System.Windows.Forms.CheckBox
    Friend WithEvents check_Initialize As System.Windows.Forms.CheckBox
    Friend WithEvents label_GSIS_Number As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radio_CMS As System.Windows.Forms.RadioButton
    Friend WithEvents radio_Demographic As System.Windows.Forms.RadioButton
    Friend WithEvents group_UBP As System.Windows.Forms.GroupBox
    Friend WithEvents label_GSIS_BP As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents label_UBP_Track2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents label_UBP_Track1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents group_Current As System.Windows.Forms.GroupBox
    Friend WithEvents label_Current_PO As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents label_Current_ChipSN As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents label_Current_CSN As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents label_Current_Status As System.Windows.Forms.Label
    Friend WithEvents label_Sex As System.Windows.Forms.Label
    Friend WithEvents label_MiddleName As System.Windows.Forms.Label
    Friend WithEvents label_GivenName As System.Windows.Forms.Label
    Friend WithEvents label_Surname As System.Windows.Forms.Label
    Friend WithEvents pic_Signature As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Photo As System.Windows.Forms.PictureBox
    Friend WithEvents label_CRN As System.Windows.Forms.Label
    Friend WithEvents label_Address As System.Windows.Forms.Label
    Friend WithEvents label_Birthdate As System.Windows.Forms.Label
    Friend WithEvents listbox_PCSC_Log As System.Windows.Forms.ListBox
    Friend WithEvents label_Current_SmartCardReader As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents label_Current_Repository As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panel_Filler As System.Windows.Forms.Panel
    Friend WithEvents check_GSIS_Activate As System.Windows.Forms.CheckBox
    Private WithEvents rtbDisplay As System.Windows.Forms.RichTextBox
    Friend WithEvents richtext_AppletScript As System.Windows.Forms.RichTextBox
    Friend WithEvents check_InitStrict As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogoffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents label_OCR As System.Windows.Forms.Label
    Friend WithEvents label_UBP_CardNumber As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents label_UBP_AcountNumber As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents button_APDU As System.Windows.Forms.Button
    Friend WithEvents showThread As System.ComponentModel.BackgroundWorker
    Friend WithEvents label_UserType As System.Windows.Forms.Label
    Friend WithEvents label_Operator As System.Windows.Forms.Label

End Class
