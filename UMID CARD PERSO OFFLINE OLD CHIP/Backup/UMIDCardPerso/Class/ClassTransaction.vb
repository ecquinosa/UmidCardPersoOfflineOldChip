Public Class ClassTransaction

    Inherits DataConnection

    Private member_Trans_ID As Integer
    Private member_Trans_User_Name As String
    Private member_Trans_Type As String
    Private member_Trans_CSN As String
    Private member_Trans_CHIP_SN As String
    Private member_Trans_Date_Time As Date
    Private member_Trans_Status As String
    Private member_Trans_Description As String

    Public Sub New(ByVal ConnString As String)
        ConnectionString = ConnString
        Clear()
    End Sub

    Public Sub Dispose()
        GC.SuppressFinalize(Me)
    End Sub

    Public Sub Clear()
        member_Trans_ID = 0
        member_Trans_User_Name = ""
        member_Trans_Type = ""
        member_Trans_CSN = ""
        member_Trans_CHIP_SN = ""
        member_Trans_Date_Time = Now
        member_Trans_Status = ""
        member_Trans_Description = ""
    End Sub


    Public ReadOnly Property Transaction_ID() As Integer
        Get
            Return member_Trans_ID
        End Get
    End Property

    Public Property User_Name() As String
        Get
            Return member_Trans_User_Name
        End Get
        Set(ByVal value As String)
            member_Trans_User_Name = value
        End Set
    End Property

    Public Property Type() As String
        Get
            Return member_Trans_Type
        End Get
        Set(ByVal value As String)
            member_Trans_Type = value
        End Set
    End Property

    Public Property CSN() As String
        Get
            Return member_Trans_CSN
        End Get
        Set(ByVal value As String)
            member_Trans_CSN = value
        End Set
    End Property

    Public Property Chip_SN() As String
        Get
            Return member_Trans_CHIP_SN
        End Get
        Set(ByVal value As String)
            member_Trans_CHIP_SN = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return member_Trans_Status
        End Get
        Set(ByVal value As String)
            member_Trans_Status = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return member_Trans_Description
        End Get
        Set(ByVal value As String)
            member_Trans_Description = value
        End Set
    End Property

    Public Property Transaction_Date() As Date
        Get
            Return member_Trans_Date_Time
        End Get
        Set(ByVal value As Date)
            member_Trans_Date_Time = value
        End Set
    End Property

    Public Function AddTransaction() As Boolean
        Dim Query As String = _
           "INSERT INTO table_Transactions " + _
           "([TRANS_TYPE],[TRANS_CSN],[TRANS_CHIP_SN],[TRANS_DATE_TIME],[TRANS_STATUS],[TRANS_DESCRIPTION],[TRANS_USER_NAME]) " + _
           "VALUES(" + _
           "'" & Type & "'," + _
           "'" & CSN & "'," + _
           "'" & Chip_SN & "'," + _
           "'" & Transaction_Date.ToString & "'," + _
           "'" & Status & "'," + _
           "'" & Description & "'," + _
           "'" & User_Name & "'," + _
           ")"
        Return ExecuteCommand(Query)
    End Function

End Class
