Public Class ClassUMID

    Inherits DataConnection

    Private member_CSN As String
    Private member_CRN As String
    Private member_GSIS_Number As String
    Private member_BP_Number As String
    Private member_Track1 As String
    Private member_Track2 As String
    Private member_BackOCR As String
    Private member_AccountNumber As String
    Private member_CardNumber As String

    Public Sub New(ByVal CnString As String)
        Clear()
        ConnectionString = CnString
    End Sub

    Public Sub Dispose()
        GC.SuppressFinalize(Me)
    End Sub

    Public Sub Clear()
        member_CSN = ""
        member_CRN = ""
        member_GSIS_Number = ""
        member_BP_Number = ""
        member_Track1 = ""
        member_Track2 = ""
        member_AccountNumber = ""
        member_CardNumber = ""
    End Sub

    Public ReadOnly Property CSN() As String
        Get
            Return member_CSN
        End Get
    End Property

    Public ReadOnly Property CRN() As String
        Get
            Return member_CRN
        End Get
    End Property

    Public ReadOnly Property GSIS_Number() As String
        Get
            Return member_GSIS_Number
        End Get
    End Property

    Public ReadOnly Property BP_Number() As String
        Get
            Return member_BP_Number
        End Get
    End Property

    Public ReadOnly Property Track1() As String
        Get
            Return member_Track1
        End Get
    End Property

    Public ReadOnly Property Track2() As String
        Get
            Return member_Track2
        End Get
    End Property

    Public ReadOnly Property Back_OCR() As String
        Get
            Return member_BackOCR
        End Get
    End Property

    Public ReadOnly Property CardNumber() As String
        Get
            Return member_CardNumber
        End Get
    End Property

    Public ReadOnly Property AccountNumber() As String
        Get
            Return member_AccountNumber
        End Get
    End Property

    Public Function UpdatePersoStatus(ByVal gsisPerso As Boolean) As Boolean
        Return ExecuteCommand("UPDATE Extract_dtl SET isPerso=1,DatePerso=GETDATE() WHERE crn='" & CRN & "'")
    End Function

    Public Function UpdateTrackStatus(ByVal ubpEncoded As Boolean) As Boolean
        Return ExecuteCommand("UPDATE Extract_dtl SET isEncoded=1,DateEncoded=GETDATE() WHERE crn='" & CRN & "'")
    End Function

    Public Function Populate(ByVal Value As String, ByVal IsCRN As Boolean) As Boolean

        'Dim Query As String = ""

        'If IsCRN Then
        '    Query = "SELECT * FROM view_getData WHERE crn='" & Value & "'"
        'Else
        '    Query = "SELECT * FROM view_getData WHERE barcode = '" & Value & "'"
        'End If

        'If Not ExecuteDataReader(Query) Then
        '    Return False
        'End If

        'If DataAccess.DataReader.Read Then
        '    member_CRN = DataAccess.DataReader("crn").ToString
        '    member_CSN = DataAccess.DataReader("barcode").ToString
        '    member_GSIS_Number = DataAccess.DataReader("gsis_no").ToString
        '    member_BP_Number = DataAccess.DataReader("bp_no").ToString
        '    member_Track1 = DataAccess.DataReader("track1").ToString
        '    member_Track2 = DataAccess.DataReader("track2").ToString
        '    member_BackOCR = DataAccess.DataReader("back_ocr").ToString
        '    member_AccountNumber = DataAccess.DataReader("account_no").ToString
        '    member_CardNumber = DataAccess.DataReader("card_no").ToString
        'Else
        '    If Populate_Reprint(Value, IsCRN) Then
        '        Return True
        '    End If

        '    Return False
        'End If

        Return True

    End Function

    Private Function Populate_Reprint(ByVal Value As String, ByVal IsCRN As Boolean) As Boolean

        Dim Query As String = ""

        If IsCRN Then
            Query = "SELECT * FROM view_getData_reprint WHERE crn='" & Value & "'"
        Else
            Query = "SELECT * FROM view_getData_reprint WHERE barcode = '" & Value & "'"
        End If

        If Not ExecuteDataReader(Query) Then
            Return False
        End If

        If DataAccess.DataReader.Read Then
            member_CRN = DataAccess.DataReader("crn").ToString
            member_CSN = DataAccess.DataReader("barcode").ToString
            member_GSIS_Number = DataAccess.DataReader("gsis_no").ToString
            member_BP_Number = DataAccess.DataReader("bp_no").ToString
            member_Track1 = DataAccess.DataReader("track1").ToString
            member_Track2 = DataAccess.DataReader("track2").ToString
            member_BackOCR = DataAccess.DataReader("back_ocr").ToString
            member_AccountNumber = DataAccess.DataReader("account_no").ToString
            member_CardNumber = DataAccess.DataReader("card_no").ToString
        Else
            Return False
        End If

        Return True
    End Function

End Class
