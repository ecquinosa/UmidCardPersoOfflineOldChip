Imports UMIDCardPerso.Spooler
Imports System.Runtime.InteropServices

Public Class formMain

#Region "Evolis Printer Related Functions"

    Dim TrackWrite(0 To 2) As String
    Dim TrackRead(0 To 2) As String

    Dim CardNum As String = ""
    Dim Answers As String = ""

    Private EvoPrinter As New CPrinter
    Private AnswerCol As New Collection

    Private start As Boolean = False
    Private _drvPrt As New Hashtable

    Dim _coer As Char = "h"
    Dim ListViewInfo As New ListView
    Dim ListViewStat As New ListView
    Dim cmbPrinters As New ComboBox

    Public Function UMID_Creation() As Boolean

        Try

            Dim Barcode As String = ""
            Dim hRet As Boolean = False
            Dim Err As String = ""
            Dim NoError As Boolean = True

            ClearPreview()
            ClearCurrent()

            rtbDisplay.Text = ""

            ThrowCommand("Sic")

            If Answers = "FEEDER EMPTY" Then
                label_Status.Text = "FEEDER EMPTY!"
                MessageBox.Show("Feeder empty...", combobox_Evolis.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            Application.DoEvents()

            If rtbDisplay.Text.Trim = "" Then
                Barcode = ""
                label_Status.Text = "Failed to read barcode"
                ThrowCommand("Sfr")
                ThrowCommand("Ser")
                Return True
            Else
                Application.DoEvents()
                Console.WriteLine(rtbDisplay.Text.Trim)
                label_Status.Text = "Barcode detected: " + rtbDisplay.Text.Trim
                Barcode = rtbDisplay.Text.Trim
                rtbDisplay.Text = ""

                hRet = Perso_UMID(Barcode, False, Err, False)

                Application.DoEvents()
                System.Threading.Thread.Sleep(1)

                If hRet Then
                    If check_EncodeTracks.Checked Then
                        If Not label_UBP_Track1.Text.Trim = "" Then
                            ThrowCommand("Dm;1;" + label_UBP_Track1.Text.Trim)
                        End If
                        If Not label_UBP_Track2.Text.Trim = "" Then
                            ThrowCommand("Dm;2;" + label_UBP_Track2.Text.Trim)
                        End If
                    End If

                    If Answers.Contains("ERR") Then
                        NoError = False
                        ThrowCommand("Sfr")
                    End If
                Else
                    NoError = False
                    ThrowCommand("Sfr")
                End If

                ThrowCommand("Se")

            End If

            If NoError Then
                label_Status.Text = "Personalization Success..."
            Else
                label_Status.Text = "Personalization Failed..."
            End If

            Application.DoEvents()
            System.Threading.Thread.Sleep(1)
            Return True

        Catch ex As Exception
            label_Status.Text = "Personalization Failed..."
            Application.DoEvents()
            System.Threading.Thread.Sleep(1)
            Return False
        End Try

    End Function

    Sub InitializePrinters()

        Try

            combobox_Evolis.Items.Clear()

            For Each strPrinter As [String] In System.Drawing.Printing.PrinterSettings.InstalledPrinters
                If strPrinter.StartsWith("Evolis") Then
                    combobox_Evolis.Items.Add(strPrinter)
                End If
            Next

            If Not combobox_Evolis.Items.Count = 0 Then
                combobox_Evolis.SelectedIndex = 0
            End If

        Catch ex As Exception
            combobox_Evolis.Items.Clear()
        End Try

    End Sub

    Private Sub ThrowCommand(ByVal command As String)
        Dim bDo As Boolean = True
        If (Me.EvoPrinter.OpenEvoPrinter()) Then
            Me.EvoPrinter.doAction(Chr(27) & "Pem;2" & Chr(13), 4000, bDo)
            Me.EvoPrinter.setCde = Chr(27) & command & Chr(13)
            If (Me.EvoPrinter.WRPrinter(bDo)) Then
                Answers = Me.EvoPrinter.getLastAnswerError
            Else
                Answers = Me.EvoPrinter.analyzeAnswer
            End If
            Me.EvoPrinter.doAction(Chr(27) & "Pem;0" & Chr(13), 4000, bDo)
            Me.EvoPrinter.CloseEvoPrinter()
        End If
    End Sub

    Private Sub w8(ByVal pSeconds As Integer)
        Dim x As Integer = 1000 * pSeconds
        System.Threading.Thread.Sleep(x)
    End Sub

    Private Function WriteMags() As Boolean
        Me.EvoPrinter.mag.gsCoer = Me._coer
        Me.EvoPrinter.mag.SetDownloadData(TrackWrite(0), 1)
        Me.EvoPrinter.mag.SetDownloadData(TrackWrite(1), 2)
        Me.EvoPrinter.mag.SetDownloadData(TrackWrite(2), 3)
        If (Me.EvoPrinter.WriteTracks() = True) Then
            TrackRead(0) = Me.EvoPrinter.mag.gDataReadFromTrack(1)
            TrackRead(1) = Me.EvoPrinter.mag.gDataReadFromTrack(2)
            TrackRead(2) = Me.EvoPrinter.mag.gDataReadFromTrack(3)
            Return True
        Else
            TrackRead(0) = Me.EvoPrinter.mag.gDataReadFromTrack(1)
            TrackRead(1) = Me.EvoPrinter.mag.gDataReadFromTrack(2)
            TrackRead(2) = Me.EvoPrinter.mag.gDataReadFromTrack(3)
            Return False
        End If
    End Function

    Private Sub InitListStat()
        With Me.ListViewInfo
            .Clear()
            .Columns.Add("Info", CType(((Me.ListViewInfo.Width - 10) / 2), Integer), HorizontalAlignment.Left)
            .Columns.Add("Value", CType(((Me.ListViewInfo.Width - 10) / 2), Integer), HorizontalAlignment.Left)
        End With

        With Me.ListViewStat
            .Clear()
            .Columns.Add("Status", CType(((Me.ListViewStat.Width - 10) / 2), Integer), HorizontalAlignment.Left)
            .Columns.Add("Value", CType(((Me.ListViewStat.Width - 10) / 2), Integer), HorizontalAlignment.Left)
        End With
    End Sub

    Private Function InitPrinterList() As Boolean

        Dim pcbNeeded As Int32
        Dim pcbReturned As Int32
        Dim pPrinters As IntPtr
        Dim pcbProvided As Int32 = 0
        Dim zz As Integer

        If Not EnumPrinters2(EnumPrinterFlags.PRINTER_ENUM_LOCAL, String.Empty, 2, pPrinters, 0, pcbNeeded, pcbReturned) Then
            If pcbNeeded > 0 Then
                pPrinters = Marshal.AllocHGlobal(pcbNeeded)
                pcbProvided = pcbNeeded
                If Not EnumPrinters2(EnumPrinterFlags.PRINTER_ENUM_LOCAL, String.Empty, 2, pPrinters, pcbProvided, pcbNeeded, pcbReturned) Then

                End If
            End If
        End If

        Dim ptNext As IntPtr = pPrinters

        If pcbReturned > 0 Then
            While pcbReturned > 0
                Dim pi2 As New PRINTER_INFO_2
                Marshal.PtrToStructure(ptNext, pi2)
                If (pi2.pDriverName.StartsWith("Evolis") = True) Then
                    Me._drvPrt.Add(pi2.pPrinterName, pi2.pDriverName)
                    cmbPrinters.Items.Add(pi2.pPrinterName)
                End If
                zz = Marshal.SizeOf(pi2)
                ptNext = New IntPtr(ptNext.ToInt32 + 84)
                pcbReturned -= 1
            End While
        End If

    End Function

    Private Sub RefreshListStat()

        'Dim i As Integer, 
        Dim max As Integer
        'Dim lvi As ListViewItem
        'Dim enuId As IDictionaryEnumerator

        'InitListStat()
        If (Me.EvoPrinter.IDPrt() = True) Then
            max = Me.EvoPrinter.prtId.Count
            'If (max <> 0 And Me.Printer.csaValue.Count = max) Then
            'ListViewInfo.Items.Clear()
            'enuId = Me.Printer.prtId.GetEnumerator()
            'i = 1
            'While enuId.MoveNext
            'lvi = New ListViewItem
            'lvi.Text = enuId.Key
            'lvi.SubItems.Add(Me.Printer.csaValue(i - 1).ToString)
            'ListViewInfo.Items.Add(lvi)
            'i = i + 1
            'End While
            'End If
            If (Me.EvoPrinter.GetStatusPrt() = True) Then
                'max = Me.Printer.prtId.Count
                'If (max <> 0 And Me.Printer.csaValue.Count = max) Then
                'ListViewStat.Items.Clear()
                'enuId = Me.Printer.prtId.GetEnumerator()
                'i = 1
                'While enuId.MoveNext
                'lvi = New ListViewItem
                'lvi.Text = enuId.Key
                'lvi.SubItems.Add(Me.Printer.csaValue(i - 1).ToString)
                'ListViewStat.Items.Add(lvi)
                'i = i + 1
                'End While
                'End If
            End If
        End If
    End Sub

    Sub InitializePrinters(ByVal pPrinterName As String)

        Dim enuId As IDictionaryEnumerator

        Cursor = Cursors.WaitCursor

        enuId = Me._drvPrt.GetEnumerator()

        While enuId.MoveNext
            If (enuId.Key = pPrinterName.Trim) Then

                If ((Me.EvoPrinter Is Nothing) = False) Then
                    Me.EvoPrinter.Dispose()
                End If

                'Me.Printer.Dispose()

                If (enuId.Value.EndsWith("Dualys")) Then
                    Me.EvoPrinter = New CDualys
                ElseIf (enuId.Value.EndsWith("Pebble")) Then
                    Me.EvoPrinter = New CPebble
                ElseIf (enuId.Value.EndsWith("Tattoo")) Then
                    Me.EvoPrinter = New CTattoo
                ElseIf (enuId.Value.EndsWith("Quantum")) Then
                    Me.EvoPrinter = New CQuantum
                ElseIf (enuId.Value.EndsWith("Quantum2")) Then
                    Me.EvoPrinter = New CQuantum
                End If

                Me.EvoPrinter.gsDriverName = enuId.Value
                Me.EvoPrinter.gsPrinterName = enuId.Key
                'Me.Printer = New CPrinter
                RefreshListStat()
                Exit While

            End If
        End While

        Cursor = Cursors.Arrow

    End Sub

#End Region

#Region "Functions and Routines"

    Function Perso_UMID(ByVal CSN As String, ByVal UseCRN As Boolean, ByRef Err As String, ByVal IsManual As Boolean) As Boolean

        Try

            Dim UMID_Perso As New UMID_Card_Perso(My.Settings.SmartCardReader)
            Dim hRet As Boolean
            Dim CurrDir As String = ""
            Dim ErrMessage As String = ""
            Dim pTemp() As String
            Dim CheckSmartCardReader As Boolean = False
            Dim GSIS_Member As New ClassUMID(ConnectionString)

            Err = ""

            label_Current_Repository.Text = My.Settings.Repository
            label_Current_SmartCardReader.Text = My.Settings.SmartCardReader

            UMID_Perso.InitializeReaderList(listbox_PCSC_Log)

            If radio_CRN.Checked Then
                CSN = ConvertCSN(CSN)
                Application.DoEvents()
                System.Threading.Thread.Sleep(1)
            End If

            For i As Integer = 0 To UMID_Perso.SmartCardReaders.Length - 1
                Try
                    If My.Settings.SmartCardReader = UMID_Perso.SmartCardReaders(i) Then
                        CheckSmartCardReader = True
                        Exit For
                    End If
                Catch ex As Exception
                    Exit For
                End Try
            Next

            If Not CheckSmartCardReader Then
                label_Current_Status.Text = "IDLE"
                Err = My.Settings.SmartCardReader + " not connected..."
                UMID_Perso.Dispose()
                Return False
            End If

            label_Current_Status.Text = "PROCESSING"

            If check_PersoGSIS.Checked Then
                If GSIS_Member.Populate(CSN, False) Then
                    label_GSIS_Number.Text = GSIS_Member.GSIS_Number
                    label_GSIS_BP.Text = GSIS_Member.BP_Number
                    label_UBP_Track1.Text = GSIS_Member.Track1
                    label_UBP_Track2.Text = GSIS_Member.Track2
                    label_UBP_AcountNumber.Text = GSIS_Member.AccountNumber
                    label_UBP_CardNumber.Text = GSIS_Member.CardNumber
                    label_OCR.Text = GSIS_Member.Back_OCR
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(1)
                Else
                    Err = "Unable to locate GSIS Member"
                    GSIS_Member.Dispose()
                    Return False
                End If
            End If

            If check_PersoUMID.Checked Then

                If CSN.Trim = "" Then
                    Err = "NO CSN"
                    UMID_Perso.Dispose()
                    Return False
                End If

                label_Status.Text = "Locating Record: " + CSN
                Application.DoEvents()
                System.Threading.Thread.Sleep(1)

                CurrDir = LocateDirectory(CSN, My.Settings.CMSFileStruct, radio_CMS.Checked)

                If CurrDir.Trim = "Error" Then
                    label_Current_Status.Text = "IDLE"
                    Err = "Unable to locate record in PO repository..."
                    UMID_Perso.Dispose()
                    Return False
                End If

                If radio_CMS.Checked Then
                    hRet = UMID_Perso.GetXMLData(CurrDir + "\" + CSN + ".xml", ErrMessage)
                Else
                    hRet = UMID_Perso.GetDemographic(CurrDir + "\" + CSN + "_Demographic", ErrMessage)
                End If

                'hRet = UMID_Perso.GetBARON(CurrDir + "\" + CSN + ".xml", ErrMessage)
                'hRet = UMID_Perso.GetRICHARD(CurrDir + "\" + CSN + ".xml", ErrMessage)

                If Not hRet Then
                    UMID_Perso.Dispose()
                    Return False
                End If

                pTemp = CurrDir.Split("\")
                label_Current_PO.Text = pTemp(2)

                PreviewCard(UMID_Perso)
            Else
                label_Current_PO.Text = ""
            End If

            label_Current_ChipSN.Text = "Acquiring Chip Serial Number"
            label_Current_CSN.Text = CSN

            If IsManual Then

                Dim Options As String = "Initialization           : " + If(check_Initialize.Checked, "YES" + vbTab + "Strict          : " + If(check_Initialize.Checked, "YES", "NO"), "NO") + vbNewLine + _
                                "Load Applet           : " + If(check_LoadApplet.Checked, "YES", "NO") + vbNewLine + _
                                "Personalize UMID  : " + If(check_PersoUMID.Checked, "YES" + vbTab + "Format      : " + If(radio_CMS.Checked, "CMS", "DEMOGRAPHIC"), "NO") + vbNewLine + _
                                "Personalize GSIS    : " + If(check_PersoGSIS.Checked, "YES" + vbTab + "Activation : " + If(check_GSIS_Activate.Checked, "YES", "NO"), "NO") + vbNewLine + _
                                "Encode Tracks       : " + If(check_EncodeTracks.Checked, "YES", "NO")

                If Not Options.Contains("YES") Then
                    MessageBox.Show("Please pick atleast One Option...", "Options", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Err = "Cancelled"
                    Return False
                End If

                If MessageBox.Show("CSN: " + CSN + vbNewLine + Options, "Proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                    Err = "Cancelled"
                    Return False
                End If

            End If

            hRet = UMID_Perso.UMIDCardPerso(CSN, _
                                            CurrDir, _
                                            label_Status, _
                                            label_Current_ChipSN, _
                                            listbox_PCSC_Log, _
                                            progress_UMID, _
                                            richtext_AppletScript, _
                                            check_Initialize.Checked, _
                                            check_LoadApplet.Checked, _
                                            check_PersoUMID.Checked, _
                                            check_InitStrict.Checked)

            If check_PersoGSIS.Checked Then
                If hRet Then

                    hRet = UMID_Perso.GSISCardPerso(label_Status, _
                                                    listbox_PCSC_Log, _
                                                    progress_UMID, _
                                                    check_GSIS_Activate.Checked, _
                                                    GSIS_Member.GSIS_Number, _
                                                    GSIS_Member.BP_Number)


                    GSIS_Member.UpdatePersoStatus(hRet)

                    'TEST DATA
                    '========================================================
                    'hRet = UMID_Perso.GSISCardPerso(label_Status, _
                    '                                listbox_PCSC_Log, _
                    '                                progress_UMID, _
                    '                                check_GSIS_Activate.Checked, _
                    '                                "GSIS_NUMBER", _
                    '                                "BP_NUMBER")
                    '========================================================

                End If
            End If

            If Err.Trim = "" Then
                Err = label_Status.Text
            End If

            Dim PO As String = ""
            Dim tStr() As String

            If label_OCR.Text.Trim = "" Then
                PO = label_Current_PO.Text
            Else
                tStr = label_OCR.Text.Trim.Split(".")
                PO = tStr(0)
            End If

            WriteLog(PO, label_Current_ChipSN.Text.Trim, label_Current_CSN.Text.Trim, hRet)

            UMID_Perso.Dispose()
            GSIS_Member.Dispose()
            progress_UMID.Value = progress_UMID.Maximum
            Application.DoEvents()

            Return hRet

        Catch ex As Exception

            Return False

        End Try

    End Function

    Function TestConnection() As Boolean
        'Dim DataConnection As New DataConnection
        'DataConnection.ConnectionString = ConnectionString()
        'If Not DataConnection.OpenConnection Then
        '    MessageBox.Show("Unable to connect to database server...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    label_Status.Text = "Database connection cannot be established..."
        '    Return False
        'Else
        '    label_Status.Text = "Ready"
        '    DataConnection.CloseConnection()
        '    Return True
        'End If

        label_Status.Text = "Ready"
        Return True
    End Function

    Sub Lock(ByVal Locked As Boolean)
        group_Evolis.Enabled = Not Locked
        group_Manual.Enabled = Not Locked
        group_PersonalizationSettings.Enabled = Not Locked
    End Sub

    Function LocateDirectory(ByVal CSN As String, ByVal CMSStruct As Boolean, ByVal CMS As Boolean) As String

        If CSN.Trim = "" Then
            Return "Error"
        End If

        Dim Record As String = ""

        If CMSStruct Then
            Dim RepositoryDirectories As String() = IO.Directory.GetDirectories(My.Settings.Repository)
            Dim SubDirectoryCount As Integer = RepositoryDirectories.Length

            For i As Integer = 0 To SubDirectoryCount
                For Each SubDirectory As String In IO.Directory.GetDirectories(RepositoryDirectories(i))
                    If IO.Directory.Exists(SubDirectory + "\" + CSN) Then

                        If CMS Then
                            Record = SubDirectory + "\" + CSN + "\" + CSN + ".xml"
                        Else
                            Record = SubDirectory + "\" + CSN + "\" + CSN + "_Demographic"
                        End If

                        If IO.File.Exists(Record) Then
                            Return SubDirectory + "\" + CSN
                        End If

                    End If
                Next
            Next

        Else
            For Each Directory As String In IO.Directory.GetDirectories(My.Settings.Repository)
                If IO.Directory.Exists(Directory + "\" + CSN) Then

                    If CMS Then
                        Record = Directory + "\" + CSN + "\" + CSN + ".xml"
                    Else
                        Record = Directory + "\" + CSN + "\" + CSN + "_Demographic"
                    End If

                    If IO.File.Exists(Record) Then
                        Return Directory + "\" + CSN
                    End If

                End If
            Next
        End If



        Return "Error"

    End Function

    Function BuildAddress(ByVal pAddress() As String) As String

        Dim tAdd As String = ""

        For i As Integer = 0 To 8
            If pAddress(i).Trim = "" Then
                tAdd += pAddress(i)
            Else
                tAdd += pAddress(i) + " "
            End If
        Next

        Return tAdd

    End Function

    Sub PreviewCard(ByRef UMID_Card As UMID_Card_Perso)

        Dim Gender As String = UMID_Card.Gender.Trim
        Dim BirthDate As String = UMID_Card.BirthDate.Trim
        Dim CRN As String = UMID_Card.CRN.Trim
        Dim pAddress(8) As String

        If CRN.Length = 12 Then

            CRN = CRN.Substring(0, 3) + "-" + _
                  CRN.Substring(3, 4) + "-" + _
                  CRN.Substring(7, 4) + "-" + _
                  CRN.Substring(11, 1)

        End If

        Select Case Gender.Trim
            Case "F"
                Gender = "FEMALE"
            Case "M"
                Gender = "MALE"
            Case Else
                Gender = Gender
        End Select

        If BirthDate.Length = 8 Then
            BirthDate = BirthDate.Substring(0, 4) + "/" + BirthDate.Substring(4, 2) + "/" + BirthDate.Substring(6, 2)
        End If

        pAddress(0) = UMID_Card.Address_Room.Trim
        pAddress(1) = UMID_Card.Address_House.Trim
        pAddress(2) = UMID_Card.Address_StreetName.Trim
        pAddress(3) = UMID_Card.Address_Subdivision.Trim
        pAddress(4) = UMID_Card.Address_Barangay.Trim
        pAddress(5) = UMID_Card.Address_City.Trim
        pAddress(6) = UMID_Card.Address_Province.Trim
        pAddress(7) = UMID_Card.Address_CountryCode.Trim
        pAddress(8) = UMID_Card.Address_PostalCode.Trim

        label_Surname.Text = CStr(UMID_Card.LastName.Trim + " " + UMID_Card.Suffix.Trim).Trim
        label_GivenName.Text = UMID_Card.FirstName.Trim
        label_MiddleName.Text = UMID_Card.MiddleName.Trim
        label_Birthdate.Text = BirthDate
        label_Sex.Text = Gender

        label_CRN.Text = CRN

        label_Address.Text = BuildAddress(pAddress)

        If IO.File.Exists(UMID_Card.Photo) Then
            Dim photoStream As New IO.FileStream(UMID_Card.Photo, IO.FileMode.Open, IO.FileAccess.Read)
            pic_Photo.Image = Image.FromStream(photoStream)
            photoStream.Dispose()
        Else
            pic_Photo.Image = Nothing
        End If

        If IO.File.Exists(UMID_Card.Signature) Then
            Dim sigBitmap As Bitmap
            Dim signStream As New IO.FileStream(UMID_Card.Signature, IO.FileMode.Open, IO.FileAccess.Read)
            sigBitmap = Image.FromStream(signStream)
            sigBitmap.MakeTransparent(Color.White)
            pic_Signature.Image = sigBitmap
            signStream.Dispose()
        Else
            pic_Signature.Image = Nothing
        End If

    End Sub

    Sub ClearPreview()
        label_Surname.Text = "SURNAME"
        label_MiddleName.Text = "MIDDLE NAME"
        label_GivenName.Text = "GIVEN NAME"
        label_CRN.Text = "000-0000-0000-0"
        label_Address.Text = "ADDRESS"
        label_Birthdate.Text = "1999/99/99"
        label_Sex.Text = "SEX"
        pic_Photo.Image = Nothing
        pic_Signature.Image = Nothing
    End Sub

    Sub ClearCurrent()
        label_Current_Status.Text = "IDLE"
        label_Current_ChipSN.Text = ""
        label_Current_CSN.Text = ""
        label_Current_PO.Text = ""
        label_Current_Repository.Text = ""
        label_Current_SmartCardReader.Text = ""
        label_GSIS_BP.Text = "BP NUMBER"
        label_GSIS_Number.Text = "GSIS NUMBER"
        label_UBP_Track1.Text = "Track 1"
        label_UBP_Track2.Text = "Track 2"
        label_UBP_AcountNumber.Text = "ACCOUNT NUMBER"
        label_UBP_CardNumber.Text = "CARD NUMBER"
        label_OCR.Text = "BACK OCR"
        label_Status.Text = "Ready"
        progress_UMID.Value = 0
    End Sub

    Function ConvertCSN(ByVal CRN As String) As String
        Dim UMID_DB As New ClassUMID(ConnectionString)
        If UMID_DB.Populate(CRN, True) Then
            ConvertCSN = UMID_DB.CSN
        Else
            ConvertCSN = "Error"
        End If
        UMID_DB.Dispose()
    End Function

#End Region

    Private Sub formMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        listbox_PCSC_Log.Width = Me.Width - 1040
        rtbDisplay.Location = New Point(listbox_PCSC_Log.Location.X, rtbDisplay.Location.Y)
        rtbDisplay.Width = Me.Width - 1040
        rtbDisplay.Height = Me.Height - 710
    End Sub

    Private Sub check_PersoGSIS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_PersoGSIS.CheckedChanged
        group_GSIS.Visible = check_PersoGSIS.Checked
        group_UBP.Visible = check_PersoGSIS.Checked
        check_GSIS_Activate.Visible = check_PersoGSIS.Checked
        check_GSIS_Activate.Checked = check_GSIS_Activate.Visible
    End Sub

    Private Sub check_Initialize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_Initialize.CheckedChanged
        check_InitStrict.Visible = check_Initialize.Checked
        check_InitStrict.Checked = False
    End Sub

    Private Sub formMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not IO.Directory.Exists("CardFeedBack") Then
            IO.Directory.CreateDirectory("CardFeedBack")
        End If

        Me.Text = Me.Text + " [Station " + My.Settings.StationID.ToString + "]"

        label_Operator.Text += " " + sUser.FirstName
        label_UserType.Text += " " + sUser.UserType

        label_Status.Text = "Establishing database connection..."
        Application.DoEvents()
        Offline = Not TestConnection()

        If Not Offline Then
            textbox_CSN.Text = "ENTER CSN OR CRN"
        Else
            Me.Text += " OFFLINE MODE"
            radio_CRN.Visible = False
            check_PersoGSIS.Checked = False
            check_PersoGSIS.Visible = False
            check_EncodeTracks.Checked = False
            check_EncodeTracks.Visible = False
            textbox_CSN.Text = "ENTER CSN"
        End If

        'If InitPrinterList() Then
        '    RefreshListStat()
        'End If

        'textbox_CSN.Text = "01201004200000000001"
        ' textbox_CSN.Text = "02201005120383800001"


        textbox_CSN.Focus()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        If Not sUser.UserType = "ADMINISTRATOR" Then
            MessageBox.Show("Access Denied!", "User Control", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim LogFile As New RichTextBox
        LogFile.WordWrap = False

        For i As Integer = 0 To listbox_PCSC_Log.Items.Count - 1
            LogFile.AppendText(listbox_PCSC_Log.Items(i).ToString + vbNewLine)
        Next

        LogFile.SaveFile("PCSC_Log.txt", RichTextBoxStreamType.PlainText)
        LogFile.Dispose()

        Try
            If IO.File.Exists("PCSC_Log.txt") Then
                System.Diagnostics.Process.Start("PCSC_Log.txt")
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to view PCSC_Log...", "LOG", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        listbox_PCSC_Log.Items.Clear()
    End Sub

    Private Sub textbox_CSN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textbox_CSN.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            button_PersoCard.PerformClick()
        End If
    End Sub

    Private Sub ReaderSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReaderSettingsToolStripMenuItem.Click

        formSettings.ShowDialog()
        formSettings.Close()

        Dim BackOnline As Boolean = TestConnection()

        If Offline Then

            If BackOnline Then
                form_Login.Show()
                Me.Close()
                Exit Sub
            End If

            If Not Me.Text.Contains("OFFLINE MODE") Then
                Me.Text += " OFFLINE MODE"
            End If

            radio_CRN.Visible = False
            check_PersoGSIS.Checked = False
            check_PersoGSIS.Visible = False
            check_EncodeTracks.Checked = False
            check_EncodeTracks.Visible = False
            textbox_CSN.Text = "ENTER CSN"

        Else
            If Not BackOnline Then
                If Not Me.Text.Contains("OFFLINE MODE") Then
                    Me.Text += " OFFLINE MODE"
                End If
                radio_CRN.Visible = False
                check_PersoGSIS.Checked = False
                check_PersoGSIS.Visible = False
                check_EncodeTracks.Checked = False
                check_EncodeTracks.Visible = False
                textbox_CSN.Text = "ENTER CSN"
            End If
        End If

        textbox_CSN.Focus()
        SendKeys.Send("{HOME}+{END}")

    End Sub

    Private Sub radio_CRN_CSN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio_CRN.CheckedChanged
        textbox_CSN.Focus()
        SendKeys.Send("{HOME}+{END}")
    End Sub

    Private Sub button_StartEvolis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_StartEvolis.Click

        If combobox_Evolis.Text = "" Then
            MessageBox.Show("Please select printer...", "Evolis", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            InitializePrinters(combobox_Evolis.Text.Trim)
            label_Status.Text = "Connected with " + combobox_Evolis.Text.Trim
        Catch ex As Exception
            MessageBox.Show("Evolis Printer not found...", "Contact System Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            label_Status.Text = "Unable to initialize Evolis Card Printer..."
            Exit Sub
        End Try

        Dim Options As String = "Initialization           : " + If(check_Initialize.Checked, "YES" + vbTab + "Strict          : " + If(check_Initialize.Checked, "YES", "NO"), "NO") + vbNewLine + _
                                "Load Applet           : " + If(check_LoadApplet.Checked, "YES", "NO") + vbNewLine + _
                                "Personalize UMID  : " + If(check_PersoUMID.Checked, "YES" + vbTab + "Format      : " + If(radio_CMS.Checked, "CMS", "DEMOGRAPHIC"), "NO") + vbNewLine + _
                                "Personalize GSIS    : " + If(check_PersoGSIS.Checked, "YES" + vbTab + "Activation : " + If(check_GSIS_Activate.Checked, "YES", "NO"), "NO") + vbNewLine + _
                                "Encode Tracks       : " + If(check_EncodeTracks.Checked, "YES", "NO")

        If Not Options.Contains("YES") Then
            MessageBox.Show("Please pick atleast One Option...", "Options", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Options Selected" + vbNewLine + vbNewLine + Options, "Do you want to proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If


        Lock(True)

        OpenPort(rtbDisplay)

        Dim Con As Boolean = True

        Do While Con
            Con = UMID_Creation()
            Application.DoEvents()
        Loop

        ClosePort()

        Lock(False)

    End Sub

    Private Sub LogoffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoffToolStripMenuItem.Click
        form_Login.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Do you want to exit the application?", "UMID PERSO SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub UserSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserSettingsToolStripMenuItem.Click

        If Not sUser.UserType = "ADMINISTRATOR" Then
            MessageBox.Show("Access Denied!", "User Control", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Offline Then
            MessageBox.Show("System is currently in offline mode...", "USER MAINTENANCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        formUserMaintenance.ShowDialog()
        formUserMaintenance.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_APDU.Click
        showThread.RunWorkerAsync()
    End Sub

    Private Sub showThread_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles showThread.DoWork
        showThread.ReportProgress(100)
    End Sub

    Private Sub showThread_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles showThread.ProgressChanged
        listbox_PCSC_Log.Visible = CBool(button_APDU.Text = "SHOW APDU")
        rtbDisplay.Visible = CBool(button_APDU.Text = "SHOW APDU")

        If button_APDU.Text = "HIDE APDU" Then
            button_APDU.Text = "SHOW APDU"
        Else
            button_APDU.Text = "HIDE APDU"
        End If
    End Sub

    Private Sub button_PersoCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_PersoCard.Click

        Dim TimeStart As Date = Now
        Dim TimeEnd As Date = Now
        Dim ElapsedTime As TimeSpan
        Dim hRet As Boolean
        Dim Err As String = ""

        Lock(True)

        ClearPreview()
        ClearCurrent()


        hRet = Perso_UMID(textbox_CSN.Text, radio_CRN.Checked, Err, True)

        TimeEnd = Now
        ElapsedTime = TimeEnd.Subtract(TimeStart)

        Dim Elapsed As String = ElapsedTime.Minutes.ToString + " Minute(s) " + _
                                ElapsedTime.Seconds.ToString + "." + ElapsedTime.Milliseconds.ToString + " Second(s)"

        label_Status.Text += " [Elapsed Time:" + Elapsed + "]"

        If hRet Then
            label_Current_Status.Text = "SUCCESS"
            MessageBox.Show("Personalization Success...", "UMID", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            label_Current_Status.Text = "FAILED"
            MessageBox.Show(Err, "Personalization Failed...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

ESCAPE:

        ClearPreview()
        ClearCurrent()

        Lock(False)

        textbox_CSN.Focus()
        SendKeys.Send("{HOME}+{END}")
    End Sub
    
End Class
