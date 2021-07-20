Public Class ClassUser

    Inherits DataConnection

    Private m_UserID As Integer
    Private m_UserName As String
    Private m_Password As String
    Private m_UserType As String
    Private m_UserActive As Boolean
    Private m_UserFirstName As String
    Private m_UserMiddleName As String
    Private m_UserLastName As String
    Private m_UserDepartment As String

    Public Sub New(ByVal ConnString As String)
        ConnectionString = ConnString
        Clear()
    End Sub

    Public Sub Dispose()
        GC.SuppressFinalize(Me)
    End Sub

    Public Sub Clear()
        UserID = 0
        UserName = ""
        Password = ""
        UserType = ""
        FirstName = ""
        MiddleName = ""
        LastName = ""
        Department = ""
        UserActive = False
    End Sub

    Public Property UserID() As Integer
        Get
            Return m_UserID
        End Get
        Set(ByVal value As Integer)
            m_UserID = value
        End Set
    End Property

    Public Property UserName() As String
        Get
            Return m_UserName
        End Get
        Set(ByVal value As String)
            m_UserName = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return m_UserFirstName
        End Get
        Set(ByVal value As String)
            m_UserFirstName = value
        End Set
    End Property

    Public Property MiddleName() As String
        Get
            Return m_UserMiddleName
        End Get
        Set(ByVal value As String)
            m_UserMiddleName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return m_UserLastName
        End Get
        Set(ByVal value As String)
            m_UserLastName = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return m_Password
        End Get
        Set(ByVal value As String)
            m_Password = value
        End Set
    End Property

    Public Property UserType() As String
        Get
            Return m_UserType
        End Get
        Set(ByVal value As String)
            m_UserType = value
        End Set
    End Property

    Public Property UserActive() As Boolean
        Get
            Return m_UserActive
        End Get
        Set(ByVal value As Boolean)
            m_UserActive = value
        End Set
    End Property

    Public Property Department() As String
        Get
            Return m_UserDepartment
        End Get
        Set(ByVal value As String)
            m_UserDepartment = value
        End Set
    End Property

    Public Function IsExists(ByVal pUserName As String)
        Return Seek("SELECT USER_USER_NAME FROM table_Users WHERE USER_USER_NAME = '" & pUserName & "'")
    End Function

    Public Function PopulateUsers(ByVal Value As String, ByVal Field As String) As DataTable
        If Field = "ALL" Then
            Return ExecuteDataTable("SELECT ID,USER_USER_NAME,USER_FIRST_NAME,USER_MIDDLE_NAME,USER_LAST_NAME,USER_DEPARTMENT,USER_TYPE,USER_ACTIVE FROM table_Users ORDER BY ID")
        Else
            Return ExecuteDataTable("SELECT ID,USER_USER_NAME,USER_FIRST_NAME,USER_MIDDLE_NAME,USER_LAST_NAME,USER_DEPARTMENT,USER_TYPE,USER_ACTIVE FROM table_Users WHERE " & Field & " like '%" & Value & "%' ORDER BY ID")
        End If
    End Function

    Public Sub Update()

        Dim Query As String = "UPDATE table_Users SET " & _
                              "USER_FIRST_NAME = '" & FirstName & "', " & _
                              "USER_MIDDLE_NAME = '" & MiddleName & "', " & _
                              "USER_LAST_NAME = '" & LastName & "', " & _
                              "USER_DEPARTMENT = '" & Department & "', " & _
                              "USER_TYPE = '" & UserType & "' " & _
                              "WHERE USER_USER_NAME = '" & UserName & "'"

        ExecuteCommand(Query)



    End Sub

    Public Sub ResetPassword(ByVal pUsername As String, ByVal pPassword As String)

        ExecuteCommand("UPDATE table_Users SET " & _
                       "USER_PASSWORD = '" & pPassword & "' " & _
                       "WHERE USER_USER_NAME = '" & pUsername & "'")

    End Sub

    Public Sub Activate(ByVal pUserName As String)
        ExecuteCommand("UPDATE table_Users SET USER_ACTIVE=1 WHERE USER_USER_NAME = '" & pUserName & "'")
    End Sub

    Public Sub Deactivate(ByVal pUserName As String)
        ExecuteCommand("UPDATE table_Users SET USER_ACTIVE=0 WHERE USER_USER_NAME = '" & pUserName & "'")
    End Sub

    Public Sub Insert()

        ExecuteCommand("INSERT INTO table_Users" & _
                       "(" & _
                       "USER_USER_NAME, " & _
                       "USER_PASSWORD, " & _
                       "USER_FIRST_NAME, " & _
                       "USER_MIDDLE_NAME, " & _
                       "USER_LAST_NAME, " & _
                       "USER_DEPARTMENT, " & _
                       "USER_TYPE " & _
                       ") " & _
                       "VALUES " & _
                       "(" & _
                       "'" & UserName & "', " & _
                       "'" & Password & "', " & _
                       "'" & FirstName & "', " & _
                       "'" & MiddleName & "', " & _
                       "'" & LastName & "', " & _
                       "'" & Department & "', " & _
                       "'" & UserType & "' " & _
                       ")")

    End Sub

    Public Sub GetDetails(ByVal pUsername As String)

        ExecuteDataReader("SELECT * FROM " & _
                          "table_Users " & _
                          "WHERE " & _
                          "USER_USER_NAME = '" & pUsername & "'")

        If DataAccess.DataReader.Read Then
            UserID = DataAccess.DataReader("ID")
            UserName = DataAccess.DataReader("USER_USER_NAME")
            Password = DataAccess.DataReader("USER_PASSWORD")
            FirstName = DataAccess.DataReader("USER_FIRST_NAME")
            MiddleName = DataAccess.DataReader("USER_MIDDLE_NAME")
            LastName = DataAccess.DataReader("USER_LAST_NAME")
            UserType = DataAccess.DataReader("USER_TYPE")
            UserActive = CBool(DataAccess.DataReader("USER_ACTIVE"))
            Department = DataAccess.DataReader("USER_DEPARTMENT")
        Else
            Clear()
        End If

    End Sub

    Public Function Login(ByVal pUsername As String) As Boolean
        If Seek("SELECT * FROM " & _
                "table_Users " & _
                "WHERE " & _
                "USER_USER_NAME = '" & pUsername & "'") Then

            GetDetails(pUsername)

            Return True

        Else
            Return False
        End If
    End Function

End Class
