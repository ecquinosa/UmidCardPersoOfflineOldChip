Module GlobalScope


    Public Offline As Boolean = False
    Public sUser As ClassUser

    Public comm As New CommManager()

    Public lVwSorter As New ClassLstVwSorter

    Public Sub ClosePort()
        comm.ClosePort()
    End Sub

    Public Sub OpenPort(ByRef rtbDisplay As RichTextBox)
        comm.Parity = My.Settings.Parity
        comm.StopBits = My.Settings.StopBits
        comm.DataBits = My.Settings.DataBits
        comm.BaudRate = My.Settings.BaudRate
        comm.DisplayWindow = rtbDisplay
        comm.OpenPort()
    End Sub

    Public Function ConnectionString()
        My.Settings.Reload()
        'Return "Provider=SQLNCLI10;Server=" & My.Settings.Server & ";Database=" & My.Settings.Database & ";Uid=" & My.Settings.Username & "; Pwd=" & My.Settings.Password
        Return "Provider=SQLOLEDB;Server=" & My.Settings.Server & ";Database=" & My.Settings.Database & ";Uid=" & My.Settings.Username & "; Pwd=" & My.Settings.Password
        'Return "Server=" & My.Settings.Server & ";Database=" & My.Settings.Database & ";Uid=" & My.Settings.Username & "; Pwd=" & My.Settings.Password
    End Function

    Public Sub WriteLog(ByVal PurchaseOrderNumber As String, ByVal Chip_SN As String, ByVal CSN As String, ByVal Success As Boolean)

        On Error Resume Next

        Dim Log As New IO.StreamWriter("CardFeedBack\" + PurchaseOrderNumber + "_StationNo" + My.Settings.StationID.ToString + ".txt", True)
        Dim DR As New IO.StreamWriter("CardFeedBack\" + PurchaseOrderNumber + "_StationNo" + My.Settings.StationID.ToString + "_DR.txt", True)
        Dim QA As New IO.StreamWriter("CardFeedBack\" + PurchaseOrderNumber + "_StationNo" + My.Settings.StationID.ToString + "_QA.txt", True)

        Dim YYYY As String = Now.Year.ToString
        Dim MM As String = Now.Month.ToString
        Dim DD As String = Now.Day.ToString

        If MM.Length = 1 Then
            MM = "0" + MM
        End If

        If DD.Length = 1 Then
            DD = "0" + DD
        End If

        Dim CardCreationDate As String = YYYY + MM + DD

        If Not Chip_SN.Length = 32 Then
            Chip_SN = ""
        End If

        Log.WriteLine(Now.ToString + "," + CSN + "," + Chip_SN + "," + CardCreationDate + "," + IIf(Success, "ok", "fail"))

        If Chip_SN.Length = 32 Then
            If Success Then
                DR.WriteLine(CSN + "," + Chip_SN + "," + CardCreationDate)
                QA.WriteLine(CSN + ",1")
            Else
                QA.WriteLine(CSN + ",0")
            End If
        End If

        Log.Close()
        DR.Close()
        QA.Close()

    End Sub

    Public Sub ColorListview(ByRef lstView As ListView, ByVal AlternateColor As Drawing.Color)
        For i As Integer = 0 To lstView.Items.Count - 1
            If i Mod 2 = 0 Then
                lstView.Items(i).BackColor = AlternateColor
            Else
                lstView.Items(i).BackColor = Drawing.Color.White
            End If
        Next i
    End Sub

    Public Function DataTableToListview(ByRef LstView As ListView, _
                                        ByRef DTable As DataTable, _
                                        ByVal Header As Boolean, _
                                        ByVal AutoResize As Boolean, _
                                        Optional ByVal AlternateColor As Boolean = False, _
                                        Optional ByVal ListViewColor As Object = Nothing) As Boolean

        Dim lvwColumn As ColumnHeader = Nothing
        Dim itmListItem As ListViewItem = Nothing
        Dim cColor As Color = Nothing

        Try

            If Header = True Then

                LstView.Clear()

                For i As Integer = 0 To DTable.Columns.Count - 1

                    lvwColumn = New ColumnHeader()

                    lvwColumn.Text = DTable.Columns(i).ToString

                    LstView.Columns.Add(lvwColumn)

                Next

            Else

                LstView.Items.Clear()

            End If


            For i As Integer = 0 To DTable.Rows.Count - 1

                itmListItem = New ListViewItem
                itmListItem.Text = DTable.Rows(i)(0).ToString

                For index As Integer = 1 To DTable.Columns.Count - 1
                    itmListItem.SubItems.Add(DTable.Rows(i)(index).ToString)
                Next

                LstView.Items.Add(itmListItem)

            Next

            If AutoResize Then
                For ctr = 0 To LstView.Columns.Count - 1
                    LstView.Columns(ctr).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                Next
            End If

            If AlternateColor Then

                Try
                    cColor = CType(ListViewColor, Color)
                Catch ex As Exception
                    cColor = Color.White
                End Try

                For ctr = 0 To LstView.Items.Count - 1
                    If ctr Mod 2 = 0 Then
                        LstView.Items(ctr).BackColor = cColor
                    Else
                        LstView.Items(ctr).BackColor = Drawing.Color.White
                    End If
                Next

            End If

        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Public Sub SortListView(ByRef lstVw As ListView, ByRef e As Object, ByVal aColor As Color)

        lstVw.ListViewItemSorter = lVwSorter
        lVwSorter.SortListview(e, lVwSorter, lstVw)

        ColorListview(lstVw, aColor)

    End Sub

End Module
