Public Class formSettings

#Region "COM PORT"

    Private Sub cboPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPort.SelectedIndexChanged
        comm.PortName = cboPort.Text()
    End Sub

    ''' <summary>
    ''' Method to initialize serial port
    ''' values to standard defaults
    ''' </summary>
    Private Sub SetDefaults()
        cboPort.SelectedIndex = 0
        cboBaud.SelectedText = "9600"
        cboParity.SelectedIndex = 0
        cboStop.SelectedIndex = 1
        cboData.SelectedIndex = 1
    End Sub

    ''' <summary>
    ''' methos to load our serial
    ''' port option values
    ''' </summary>
    Private Sub LoadValues()
        comm.SetPortNameValues(cboPort)
        comm.SetParityValues(cboParity)
        comm.SetStopBitValues(cboStop)
    End Sub

    ''' <summary>
    ''' method to set the state of controls
    ''' when the form first loads
    ''' </summary>
    Private Sub SetControlState()
        rdoText.Checked = True
    End Sub

    Private Sub rdoHex_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoHex.CheckedChanged
        If rdoHex.Checked() Then
            comm.CurrentTransmissionType = UMIDCardPerso.CommManager.TransmissionType.Hex
        Else
            comm.CurrentTransmissionType = UMIDCardPerso.CommManager.TransmissionType.Text
        End If
    End Sub

    Private Sub cboBaud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBaud.SelectedIndexChanged
        comm.BaudRate = cboBaud.Text()
    End Sub

    Private Sub cboParity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboParity.SelectedIndexChanged
        comm.Parity = cboParity.Text()
    End Sub

    Private Sub cboStop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStop.SelectedIndexChanged
        comm.StopBits = cboStop.Text()
    End Sub

    Private Sub cboData_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboData.SelectedIndexChanged
        comm.StopBits = cboStop.Text()
    End Sub

    Sub LoadReaders()
        Dim tLstBoxLog As New ListBox
        Dim Card_Readers As New UMID_Card_Perso(My.Settings.SmartCardReader)
        Card_Readers.InitializeReaderList(tLstBoxLog)
        Dim ReaderList As String() = Card_Readers.SmartCardReaders

        combobox_Contactless.Items.Clear()

        On Error Resume Next
        For i As Integer = 0 To ReaderList.Length
            If Not ReaderList(i).Trim = "" Then
                combobox_Contactless.Items.Add(ReaderList(i))
            End If
        Next

        If combobox_Contactless.Items.Count = 0 Then
            MessageBox.Show("No Readers were detected...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            combobox_Contactless.Items.Clear()
        End If
    End Sub

    Sub LoadSettings()

        On Error Resume Next

        My.Settings.Reload()

        combobox_Contactless.Text = My.Settings.SmartCardReader
        check_CMSStruct.Checked = My.Settings.CMSFileStruct
        textbox_Repository.Text = My.Settings.Repository
        num_StationID.Value = My.Settings.StationID

        cboData.Text = My.Settings.DataBits
        cboParity.Text = My.Settings.Parity
        cboPort.Text = My.Settings.Port
        cboStop.Text = My.Settings.StopBits
        cboBaud.Text = My.Settings.BaudRate

        textbox_Server.Text = My.Settings.Server
        textbox_Database.Text = My.Settings.Database
        textbox_DBPassword.Text = My.Settings.Password
        textbox_DBUID.Text = My.Settings.Username

    End Sub

#End Region

    Private Sub button_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_Cancel.Click
        Me.Close()
    End Sub

    Private Sub formSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not sUser.UserType = "ADMINISTRATOR" Then
            GroupBox1.Enabled = False
            GroupBox6.Enabled = False
        Else
            GroupBox1.Enabled = True
            GroupBox6.Enabled = True
        End If

        LoadValues()
        SetDefaults()
        SetControlState()
        LoadReaders()
        LoadSettings()
    End Sub

    Private Sub button_BrowseRepository_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_BrowseRepository.Click

        Dim FolderBrowse As New FolderBrowserDialog
        FolderBrowse.Description = "UMID Purchase Order Repository"

        If FolderBrowse.ShowDialog = Windows.Forms.DialogResult.OK Then
            textbox_Repository.Text = FolderBrowse.SelectedPath
        End If

        FolderBrowse.Dispose()

    End Sub

    Private Sub button_SaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_SaveSettings.Click

        My.Settings.SmartCardReader = combobox_Contactless.Text
        My.Settings.StationID = num_StationID.Value
        My.Settings.Repository = textbox_Repository.Text.Trim
        My.Settings.CMSFileStruct = check_CMSStruct.Checked
        My.Settings.BaudRate = cboBaud.Text
        My.Settings.DataBits = cboData.Text
        My.Settings.Parity = cboParity.Text
        My.Settings.Port = cboPort.Text
        My.Settings.StopBits = cboStop.Text

        My.Settings.Password = textbox_DBPassword.Text
        My.Settings.Username = textbox_DBUID.Text
        My.Settings.Database = textbox_Database.Text
        My.Settings.Server = textbox_Server.Text

        My.Settings.Save()
        My.Settings.Reload()

        MessageBox.Show("Settings Saved...", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub link_TestConnection_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_TestConnection.LinkClicked

        Dim TestConnectionString As String = "Provider=SQLNCLI10;Server=" & _
                                             textbox_Server.Text.Trim & ";Database=" & _
                                             textbox_Database.Text.Trim & ";Uid=" & _
                                             textbox_DBUID.Text.Trim & "; Pwd=" & _
                                             textbox_DBPassword.Text.Trim

        Dim DataConnection As New DataConnection
        DataConnection.ConnectionString = TestConnectionString

        If Not DataConnection.OpenConnection Then
            MessageBox.Show("Unable to connect to database server...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Connection Successful", "DB Server", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataConnection.CloseConnection()
        End If


    End Sub
End Class