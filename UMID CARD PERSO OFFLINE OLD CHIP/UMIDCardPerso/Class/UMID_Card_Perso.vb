Imports System.Xml

Public Class UMID_Card_Perso

    Private SmartCardReader As String = ""
    Public SmartCardReaders(9) As String

    Const ENCRYPTION As Integer = 0
    Const DECRYPTION As Integer = 1

    Private ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=" & Application.StartupPath & "\Keys_Set.mdb;Persist Security Info=False;Jet OLEDB:Database Password=allcardtech2010"

#Region "Membmers"

    Private m_CRN As String = ""
    Private m_FirstName As String = ""
    Private m_MiddleName As String = ""
    Private m_LastName As String = ""
    Private m_Suffix As String = ""
    Private m_Gender As String = ""
    Private m_CivilStatus As String = ""
    Private m_Height As String = ""
    Private m_Weight As String = ""
    Private m_BirthDate As String = ""
    Private m_BirthCity As String = ""
    Private m_BirthProvince As String = ""
    Private m_BirthCountry As String = ""
    Private m_Features As String = ""
    Private m_CardCreationDate As String = ""
    Private m_Father_FirstName As String = ""
    Private m_Father_MiddleName As String = ""
    Private m_Father_LastName As String = ""
    Private m_Father_Suffix As String = ""
    Private m_Mother_FirstName As String = ""
    Private m_Mother_MiddleName As String = ""
    Private m_Mother_LastName As String = ""
    Private m_Mother_Suffix As String = ""
    Private m_Room As String = ""
    Private m_House As String = ""
    Private m_StreetName As String = ""
    Private m_Subdivision As String = ""
    Private m_Barangay As String = ""
    Private m_City As String = ""
    Private m_Province As String = ""
    Private m_PostalCode As String = ""
    Private m_CountryCode As String = ""
    Private m_TIN As String = ""

    Private m_FingerCode_LeftPrimary As String = ""
    Private m_FingerCode_LeftBackup As String = ""
    Private m_FingerCode_RightPrimary As String = ""
    Private m_FingerCode_RightBackup As String = ""

    Private m_Photo As String = ""
    Private m_Signature As String = ""
    Private m_Biometric_LeftPrimary As String = ""
    Private m_Biometric_LeftBackup As String = ""
    Private m_Biometric_RightPrimary As String = ""
    Private m_Biometric_RightBackup As String = ""

#End Region

#Region "Properties"

    Public Property FingerCode_LeftPrimary() As String
        Get
            Return m_FingerCode_LeftPrimary
        End Get
        Set(ByVal value As String)
            m_FingerCode_LeftPrimary = value
        End Set
    End Property

    Public Property FingerCode_RightPrimary() As String
        Get
            Return m_FingerCode_RightPrimary
        End Get
        Set(ByVal value As String)
            m_FingerCode_RightPrimary = value
        End Set
    End Property

    Public Property FingerCode_LeftBackup() As String
        Get
            Return m_FingerCode_LeftBackup
        End Get
        Set(ByVal value As String)
            m_FingerCode_LeftBackup = value
        End Set
    End Property

    Public Property FingerCode_RightBackup() As String
        Get
            Return m_FingerCode_RightBackup
        End Get
        Set(ByVal value As String)
            m_FingerCode_RightBackup = value
        End Set
    End Property

    Public Property Biometric_LeftPrimary() As String
        Get
            Return m_Biometric_LeftPrimary
        End Get
        Set(ByVal value As String)
            m_Biometric_LeftPrimary = value
        End Set
    End Property

    Public Property Biometric_LeftBackup() As String
        Get
            Return m_Biometric_LeftBackup
        End Get
        Set(ByVal value As String)
            m_Biometric_LeftBackup = value
        End Set
    End Property

    Public Property Biometric_RightPrimary() As String
        Get
            Return m_Biometric_RightPrimary
        End Get
        Set(ByVal value As String)
            m_Biometric_RightPrimary = value
        End Set
    End Property

    Public Property Biometric_RightBackup() As String
        Get
            Return m_Biometric_RightBackup
        End Get
        Set(ByVal value As String)
            m_Biometric_RightBackup = value
        End Set
    End Property

    Public Property TIN() As String
        Get
            Return m_TIN
        End Get
        Set(ByVal value As String)
            m_TIN = value
        End Set
    End Property


    Public Property CRN() As String
        Get
            Return m_CRN
        End Get
        Set(ByVal value As String)
            m_CRN = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return m_FirstName
        End Get
        Set(ByVal value As String)
            m_FirstName = value
        End Set
    End Property

    Public Property MiddleName() As String
        Get
            Return m_MiddleName
        End Get
        Set(ByVal value As String)
            m_MiddleName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return m_LastName
        End Get
        Set(ByVal value As String)
            m_LastName = value
        End Set
    End Property

    Public Property Suffix() As String
        Get
            Return m_Suffix
        End Get
        Set(ByVal value As String)
            m_Suffix = value
        End Set
    End Property

    Public Property Father_FirstName() As String
        Get
            Return m_Father_FirstName
        End Get
        Set(ByVal value As String)
            m_Father_FirstName = value
        End Set
    End Property

    Public Property Father_MiddleName() As String
        Get
            Return m_Father_MiddleName
        End Get
        Set(ByVal value As String)
            m_Father_MiddleName = value
        End Set
    End Property

    Public Property Father_LastName() As String
        Get
            Return m_Father_LastName
        End Get
        Set(ByVal value As String)
            m_Father_LastName = value
        End Set
    End Property

    Public Property Father_Suffix() As String
        Get
            Return m_Father_Suffix
        End Get
        Set(ByVal value As String)
            m_Father_Suffix = value
        End Set
    End Property

    Public Property Mother_FirstName() As String
        Get
            Return m_Mother_FirstName
        End Get
        Set(ByVal value As String)
            m_Mother_FirstName = value
        End Set
    End Property

    Public Property Mother_MiddleName() As String
        Get
            Return m_Mother_MiddleName
        End Get
        Set(ByVal value As String)
            m_Mother_MiddleName = value
        End Set
    End Property

    Public Property Mother_LastName() As String
        Get
            Return m_Mother_LastName
        End Get
        Set(ByVal value As String)
            m_Mother_LastName = value
        End Set
    End Property

    Public Property Mother_Suffix() As String
        Get
            Return m_Mother_Suffix
        End Get
        Set(ByVal value As String)
            m_Mother_Suffix = value
        End Set
    End Property

    Public Property Gender() As String
        Get
            Return m_Gender
        End Get
        Set(ByVal value As String)
            m_Gender = value
        End Set
    End Property

    Public Property CivilStatus() As String
        Get
            Return m_CivilStatus
        End Get
        Set(ByVal value As String)
            m_CivilStatus = value
        End Set
    End Property

    Public Property Height() As String
        Get
            Return m_Height
        End Get
        Set(ByVal value As String)
            m_Height = value
        End Set
    End Property

    Public Property Weight() As String
        Get
            Return m_Weight
        End Get
        Set(ByVal value As String)
            m_Weight = value
        End Set
    End Property

    Public Property BirthDate() As String
        Get
            Return m_BirthDate
        End Get
        Set(ByVal value As String)
            m_BirthDate = value
        End Set
    End Property

    Public Property BirthCity() As String
        Get
            Return m_BirthCity
        End Get
        Set(ByVal value As String)
            m_BirthCity = value
        End Set
    End Property

    Public Property BirthProvince() As String
        Get
            Return m_BirthProvince
        End Get
        Set(ByVal value As String)
            m_BirthProvince = value
        End Set
    End Property

    Public Property BirthCountry() As String
        Get
            Return m_BirthCountry
        End Get
        Set(ByVal value As String)
            m_BirthCountry = value
        End Set
    End Property

    Public Property DistinguishingFeatures() As String
        Get
            Return m_Features
        End Get
        Set(ByVal value As String)
            m_Features = value
        End Set
    End Property

    Public Property CardCreationDate() As String
        Get
            Return m_CardCreationDate
        End Get
        Set(ByVal value As String)
            m_CardCreationDate = value
        End Set
    End Property

    Public Property Address_Room() As String
        Get
            Return m_Room
        End Get
        Set(ByVal value As String)
            m_Room = value
        End Set
    End Property

    Public Property Address_House() As String
        Get
            Return m_House
        End Get
        Set(ByVal value As String)
            m_House = value
        End Set
    End Property

    Public Property Address_StreetName() As String
        Get
            Return m_StreetName
        End Get
        Set(ByVal value As String)
            m_StreetName = value
        End Set
    End Property

    Public Property Address_Subdivision() As String
        Get
            Return m_Subdivision
        End Get
        Set(ByVal value As String)
            m_Subdivision = value
        End Set
    End Property

    Public Property Address_Barangay() As String
        Get
            Return m_Barangay
        End Get
        Set(ByVal value As String)
            m_Barangay = value
        End Set
    End Property

    Public Property Address_City() As String
        Get
            Return m_City
        End Get
        Set(ByVal value As String)
            m_City = value
        End Set
    End Property

    Public Property Address_Province() As String
        Get
            Return m_Province
        End Get
        Set(ByVal value As String)
            m_Province = value
        End Set
    End Property

    Public Property Address_PostalCode() As String
        Get
            Return m_PostalCode
        End Get
        Set(ByVal value As String)
            m_PostalCode = value
        End Set
    End Property

    Public Property Address_CountryCode() As String
        Get
            Return m_CountryCode
        End Get
        Set(ByVal value As String)
            m_CountryCode = value
        End Set
    End Property

    Public Property Photo() As String
        Get
            Return m_Photo
        End Get
        Set(ByVal value As String)
            m_Photo = value
        End Set
    End Property

    Public Property Signature() As String
        Get
            Return m_Signature
        End Get
        Set(ByVal value As String)
            m_Signature = value
        End Set
    End Property

    Private Function SeekKey(ByVal Key As String, ByRef KeyDataTable As DataTable) As String

        Dim dt As DataTable = KeyDataTable

        SeekKey = "ERROR"

        Try
            For i As Integer = 0 To dt.Rows.Count - 1
                If Key = dt.Rows(i)(1).ToString Then
                    SeekKey = dt.Rows(i)(3).ToString
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
            SeekKey = "ERROR"
        Finally
            dt.Dispose()
        End Try



    End Function

    Private Function SeekKey(ByVal Key As String) As String
        Dim Keys_Set As New DataConnection
        Dim dKey As DataTable
        Keys_Set.ConnectionString = ConnectionString
        dKey = Keys_Set.ExecuteDataTable("SELECT * FROM Key_Sets WHERE KeyName='" & Key & "'")
        If dKey.Rows.Count = 0 Then
            Return "ERROR"
        Else
            Return dKey(0)("KeyValue").ToString
        End If
        dKey.Dispose()
    End Function

    Public Function GetRICHARD(ByVal pFilePath As String, ByRef Err As String) As Boolean

        Try

            If Not IO.File.Exists(pFilePath) Then
                Return "Error: " + pFilePath
            End If


            CRN = "006011873327"
            FirstName = "RICHARD"
            MiddleName = "DATINGUINOO"
            LastName = "MATINING"
            Suffix = ""

            Address_PostalCode = "4118"
            Address_CountryCode = "PHL"
            Address_Province = "CAVITE"
            Address_City = "SILANG"
            Address_Barangay = "TUBUAN 3"
            Address_Subdivision = "JAURIGUE SUBD."
            Address_StreetName = "KAPT. PEPE ST."
            Address_House = ""
            Address_Room = ""

            Gender = "M"

            BirthDate = "19720922"
            BirthCity = "MANILA"
            BirthProvince = ""
            BirthCountry = "PHL"

            CivilStatus = "M"

            Father_FirstName = "ROGELIO"
            Father_MiddleName = "HALOS"
            Father_LastName = "MATINING"
            Father_Suffix = ""

            Mother_FirstName = "GLORIA"
            Mother_MiddleName = "UMALI"
            Mother_LastName = "DATINGUINOO"
            Mother_Suffix = ""

            Height = "165"
            Weight = "62"

            DistinguishingFeatures = ""

            TIN = "132178423"

            FingerCode_LeftPrimary = "i"
            FingerCode_RightPrimary = "i"
            FingerCode_LeftBackup = "t"
            FingerCode_RightBackup = "t"

            Photo = pFilePath.Replace(".xml", "_Photo.jpg")
            Signature = pFilePath.Replace(".xml", "_Signature.tiff")

            Biometric_LeftPrimary = pFilePath.Replace(".xml", "_Lprimary.ansi-fmr")
            Biometric_RightPrimary = pFilePath.Replace(".xml", "_Rprimary.ansi-fmr")
            Biometric_LeftBackup = pFilePath.Replace(".xml", "_Lbackup.ansi-fmr")
            Biometric_RightBackup = pFilePath.Replace(".xml", "_Rbackup.ansi-fmr")

            If Not IO.File.Exists(Photo) Then
                Err = "No Photo"
                Return False
            End If

            If Not IO.File.Exists(Signature) Then
                Err = "No Signature"
                Return False
            End If

            If Not IO.File.Exists(Biometric_LeftPrimary) Then
                Err = "No Left Primary ANSI"
                Return False
            End If

            If Not IO.File.Exists(Biometric_RightPrimary) Then
                Err = "No Right Primary ANSI"
                Return False
            End If

            If Not IO.File.Exists(Biometric_LeftBackup) Then
                Err = "No Left Backup ANSI"
                Return False
            End If

            If Not IO.File.Exists(Biometric_RightBackup) Then
                Err = "No Right Backup ANSI"
                Return False
            End If

        Catch ex As Exception
            Err = ex.ToString
            Return False
        End Try

        Return True

    End Function


    Public Function GetBARON(ByVal pFilePath As String, ByRef Err As String) As Boolean

        Try

            If Not IO.File.Exists(pFilePath) Then
                Return "Error: " + pFilePath
            End If


            CRN = "006000004398"
            FirstName = "BARON PATRICK"
            MiddleName = "TABLAN"
            LastName = "PAREDES"
            Suffix = ""

            Address_PostalCode = "1550"
            Address_CountryCode = "PHL"
            Address_Province = ""
            Address_City = "MANDALUYONG"
            Address_Barangay = "BRGY PLAINVIEW"
            Address_Subdivision = ""
            Address_StreetName = "MALAYA STREET"
            Address_House = "37"
            Address_Room = ""

            Gender = "M"

            BirthDate = "19860901"
            BirthCity = "MANDALUYONG"
            BirthProvince = ""
            BirthCountry = "PHL"

            CivilStatus = "M"

            Father_FirstName = "SISINIO ARIEL"
            Father_MiddleName = "GIRON"
            Father_LastName = "PAREDES"
            Father_Suffix = ""

            Mother_FirstName = "SANDRA LOURDES"
            Mother_MiddleName = "DE JESUS"
            Mother_LastName = "TABLAN"
            Mother_Suffix = ""

            Height = "167"
            Weight = "85"

            DistinguishingFeatures = ""

            TIN = "264284305"

            FingerCode_LeftPrimary = "i"
            FingerCode_RightPrimary = "i"
            FingerCode_LeftBackup = "t"
            FingerCode_RightBackup = "t"

            Photo = pFilePath.Replace(".xml", "_Photo.jpg")
            Signature = pFilePath.Replace(".xml", "_Signature.tiff")

            Biometric_LeftPrimary = pFilePath.Replace(".xml", "_Lprimary.ansi-fmr")
            Biometric_RightPrimary = pFilePath.Replace(".xml", "_Rprimary.ansi-fmr")
            Biometric_LeftBackup = pFilePath.Replace(".xml", "_Lbackup.ansi-fmr")
            Biometric_RightBackup = pFilePath.Replace(".xml", "_Rbackup.ansi-fmr")

            If Not IO.File.Exists(Photo) Then
                Err = "No Photo"
                Return False
            End If

            If Not IO.File.Exists(Signature) Then
                Err = "No Signature"
                Return False
            End If

            If Not IO.File.Exists(Biometric_LeftPrimary) Then
                Err = "No Left Primary ANSI"
                Return False
            End If

            If Not IO.File.Exists(Biometric_RightPrimary) Then
                Err = "No Right Primary ANSI"
                Return False
            End If

            If Not IO.File.Exists(Biometric_LeftBackup) Then
                Err = "No Left Backup ANSI"
                Return False
            End If

            If Not IO.File.Exists(Biometric_RightBackup) Then
                Err = "No Right Backup ANSI"
                Return False
            End If

        Catch ex As Exception
            Err = ex.ToString
            Return False
        End Try

        Return True

    End Function

    Public Function GetXMLData(ByVal pFilePath As String, ByRef Err As String) As Boolean

        Try

            If Not IO.File.Exists(pFilePath) Then
                Return "Error: " + pFilePath
            End If

            Dim UMID_XML As New XmlDocument
            UMID_XML.Load(pFilePath)

            CRN = UMID_XML.GetElementsByTagName("_10")(0).InnerText
            FirstName = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_11")(0).InnerText)).Replace("?", "Ñ")
            MiddleName = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_12")(0).InnerText)).Replace("?", "Ñ")
            LastName = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_13")(0).InnerText)).Replace("?", "Ñ")
            Suffix = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_14")(0).InnerText)).Replace("?", "Ñ")

            Address_PostalCode = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_15")(0).InnerText)).Replace("?", "Ñ")
            Address_CountryCode = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_16")(0).InnerText)).Replace("?", "Ñ")
            Address_Province = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_17")(0).InnerText)).Replace("?", "Ñ")
            Address_City = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_18")(0).InnerText)).Replace("?", "Ñ")
            Address_Barangay = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_19")(0).InnerText)).Replace("?", "Ñ")
            Address_Subdivision = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_1A")(0).InnerText)).Replace("?", "Ñ")
            Address_StreetName = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_1B")(0).InnerText)).Replace("?", "Ñ")
            Address_House = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_1C")(0).InnerText)).Replace("?", "Ñ")
            Address_Room = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_1D")(0).InnerText)).Replace("?", "Ñ")

            Gender = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_1F")(0).InnerText))

            BirthDate = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_20")(0).InnerText))
            BirthCity = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_21")(0).InnerText)).Replace("?", "Ñ")
            BirthProvince = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_22")(0).InnerText)).Replace("?", "Ñ")
            BirthCountry = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_2D")(0).InnerText)).Replace("?", "Ñ")

            CivilStatus = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_23")(0).InnerText))

            Father_FirstName = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_30")(0).InnerText)).Replace("?", "Ñ")
            Father_MiddleName = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_31")(0).InnerText)).Replace("?", "Ñ")
            Father_LastName = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_32")(0).InnerText)).Replace("?", "Ñ")
            Father_Suffix = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_33")(0).InnerText)).Replace("?", "Ñ")

            Mother_FirstName = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_40")(0).InnerText)).Replace("?", "Ñ")
            Mother_MiddleName = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_41")(0).InnerText)).Replace("?", "Ñ")
            Mother_LastName = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_42")(0).InnerText)).Replace("?", "Ñ")
            Mother_Suffix = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_43")(0).InnerText)).Replace("?", "Ñ")

            Height = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_24")(0).InnerText))
            Weight = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_25")(0).InnerText))

            DistinguishingFeatures = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_26")(0).InnerText)).Replace("?", "Ñ")

            TIN = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_27")(0).InnerText))

            FingerCode_LeftPrimary = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_50")(0).InnerText))
            FingerCode_RightPrimary = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_51")(0).InnerText))
            FingerCode_LeftBackup = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_52")(0).InnerText))
            FingerCode_RightBackup = Base64ToASCII(Convert.FromBase64String(UMID_XML.GetElementsByTagName("_53")(0).InnerText))

            Photo = pFilePath.Replace(".xml", "_Photo.jpg")
            Signature = pFilePath.Replace(".xml", "_Signature.tiff")

            Biometric_LeftPrimary = pFilePath.Replace(".xml", "_Lprimary.ansi-fmr")
            Biometric_RightPrimary = pFilePath.Replace(".xml", "_Rprimary.ansi-fmr")
            Biometric_LeftBackup = pFilePath.Replace(".xml", "_Lbackup.ansi-fmr")
            Biometric_RightBackup = pFilePath.Replace(".xml", "_Rbackup.ansi-fmr")

            If Not IO.File.Exists(Photo) Then
                Err = "No Photo"
                Return False
            End If

            If Not IO.File.Exists(Signature) Then
                Err = "No Signature"
                Return False
            End If

            If Not IO.File.Exists(Biometric_LeftPrimary) Then
                Err = "No Left Primary ANSI"
                Return False
            End If

            If Not IO.File.Exists(Biometric_RightPrimary) Then
                Err = "No Right Primary ANSI"
                Return False
            End If

            If Not IO.File.Exists(Biometric_LeftBackup) Then
                Err = "No Left Backup ANSI"
                Return False
            End If

            If Not IO.File.Exists(Biometric_RightBackup) Then
                Err = "No Right Backup ANSI"
                Return False
            End If

        Catch ex As Exception
            Err = ex.ToString
            Return False
        End Try

        Return True

    End Function

    Public Function GetDemographic(ByVal pFilePath As String, ByVal Err As String) As Boolean

        Try

            If Not IO.File.Exists(pFilePath) Then
                Return "Error: " + pFilePath
            End If

            Dim Demographic As String = GetRecordFromFile(pFilePath)

            CRN = Demographic.Substring(20, 12).Trim
            FirstName = Demographic.Substring(32, 40).Trim.Replace("?", "Ñ")
            MiddleName = Demographic.Substring(72, 40).Trim.Replace("?", "Ñ")
            LastName = Demographic.Substring(112, 40).Trim.Replace("?", "Ñ")
            Suffix = Demographic.Substring(152, 10).Trim.Replace("?", "Ñ")
            Address_PostalCode = Demographic.Substring(162, 6).Trim
            Address_CountryCode = Demographic.Substring(168, 3).Trim
            Address_Province = Demographic.Substring(171, 30).Trim.Replace("?", "Ñ")
            Address_City = Demographic.Substring(201, 30).Trim.Replace("?", "Ñ")
            Address_Barangay = Demographic.Substring(231, 30).Trim.Replace("?", "Ñ")
            Address_Subdivision = Demographic.Substring(261, 40).Trim.Replace("?", "Ñ")
            Address_StreetName = Demographic.Substring(301, 40).Trim.Replace("?", "Ñ")
            Address_House = Demographic.Substring(341, 15).Trim.Replace("?", "Ñ")
            Address_Room = Demographic.Substring(356, 40).Trim.Replace("?", "Ñ")
            Gender = Demographic.Substring(396, 1).Trim
            BirthDate = Demographic.Substring(397, 8).Trim
            BirthCity = Demographic.Substring(405, 30).Trim.Replace("?", "Ñ")
            BirthProvince = Demographic.Substring(435, 30).Trim.Replace("?", "Ñ")
            BirthCountry = Demographic.Substring(465, 3).Trim.Replace("?", "Ñ")
            CardCreationDate = ""
            CivilStatus = Demographic.Substring(468, 1).Trim
            Father_FirstName = Demographic.Substring(469, 40).Trim.Replace("?", "Ñ")
            Father_MiddleName = Demographic.Substring(509, 40).Trim.Replace("?", "Ñ")
            Father_LastName = Demographic.Substring(549, 40).Trim.Replace("?", "Ñ")
            Father_Suffix = Demographic.Substring(589, 10).Trim.Replace("?", "Ñ")
            Mother_FirstName = Demographic.Substring(599, 40).Trim.Replace("?", "Ñ")
            Mother_MiddleName = Demographic.Substring(639, 40).Trim.Replace("?", "Ñ")
            Mother_LastName = Demographic.Substring(679, 40).Trim.Replace("?", "Ñ")
            Mother_Suffix = Demographic.Substring(719, 10).Trim.Replace("?", "Ñ")
            Height = Demographic.Substring(733, 3).Trim
            Weight = Demographic.Substring(736, 3).Trim
            DistinguishingFeatures = Demographic.Substring(739, 70).Trim.Replace("?", "Ñ")
            TIN = Demographic.Substring(815, 10).Trim
            FingerCode_LeftPrimary = Demographic.Substring(729, 1).Trim
            FingerCode_RightPrimary = Demographic.Substring(730, 1).Trim
            FingerCode_LeftBackup = Demographic.Substring(731, 1).Trim
            FingerCode_LeftBackup = Demographic.Substring(732, 1).Trim

            Photo = pFilePath.Replace("_Demographic", "_Photo.jpg")
            Signature = pFilePath.Replace("_Demographic", "_Signature.tiff")

            Biometric_LeftPrimary = pFilePath.Replace("_Demographic", "_Lprimary.ansi-fmr")
            Biometric_RightPrimary = pFilePath.Replace("_Demographic", "_Rprimary.ansi-fmr")
            Biometric_LeftBackup = pFilePath.Replace("_Demographic", "_Lbackup.ansi-fmr")
            Biometric_RightBackup = pFilePath.Replace("_Demographic", "_Rbackup.ansi-fmr")

            If Not IO.File.Exists(Photo) Then
                Err = "No Photo"
                Return False
            End If

            If Not IO.File.Exists(Signature) Then
                Err = "No Signature"
                Return False
            End If

            If Not IO.File.Exists(Biometric_LeftPrimary) Then
                Err = "No Left Primary ANSI"
                Return False
            End If

            If Not IO.File.Exists(Biometric_RightPrimary) Then
                Err = "No Right Primary ANSI"
                Return False
            End If

            If Not IO.File.Exists(Biometric_LeftBackup) Then
                Err = "No Left Backup ANSI"
                Return False
            End If

            If Not IO.File.Exists(Biometric_RightBackup) Then
                Err = "No Right Backup ANSI"
                Return False
            End If

            Return True

        Catch ex As Exception
            Err = ex.ToString
            Return False
        End Try

    End Function

    Function GetRecordFromFile(ByVal pFilePath As String) As String

        Try
            Dim CurrentRecord As String = pFilePath
            IO.File.Copy(CurrentRecord, "temp.txt", True)
            GetRecordFromFile = IO.File.ReadAllText("temp.txt").Replace("�", "Ñ")
            System.Threading.Thread.Sleep(1)
            IO.File.Delete("temp.txt")
        Catch ex As Exception
            GetRecordFromFile = "Error"
        End Try

        Console.WriteLine(GetRecordFromFile)

    End Function

#End Region

#Region "PCSC"

    Sub InitializeReaderList(ByRef lstBoxLog As ListBox)

        Dim sReaderList As String = ""
        Dim ReaderCount As Integer
        Dim ctr As Integer

        For ctr = 0 To 255
            sReaderList = sReaderList + vbNullChar
        Next

        ReaderCount = 255

        retCode = ModWinsCard.SCardEstablishContext(ModWinsCard.SCARD_SCOPE_USER, 0, 0, hContext)

        If retCode <> ModWinsCard.SCARD_S_SUCCESS Then
            displayOut(1, retCode, "", lstBoxLog)
            Exit Sub
        End If

        retCode = ModWinsCard.SCardListReaders(hContext, "", sReaderList, ReaderCount)

        If retCode <> ModWinsCard.SCARD_S_SUCCESS Then
            displayOut(1, retCode, "", lstBoxLog)
            Exit Sub

        End If

        LoadListToControl(SmartCardReaders, sReaderList)

    End Sub

    Sub DisconnectCard(ByVal ReaderName As String)

        If connActive Then
            retCode = ModWinsCard.SCardDisconnect(hCard, ModWinsCard.SCARD_UNPOWER_CARD)
        End If

        connActive = False

    End Sub

    Sub ConnectToCard(ByVal ReaderName As String, ByRef lstBoxLog As ListBox)

        If connActive Then
            retCode = ModWinsCard.SCardDisconnect(hCard, ModWinsCard.SCARD_UNPOWER_CARD)
        End If

        retCode = ModWinsCard.SCardConnect(hContext, ReaderName, ModWinsCard.SCARD_SHARE_SHARED, ModWinsCard.SCARD_PROTOCOL_T0 Or ModWinsCard.SCARD_PROTOCOL_T1, hCard, Protocol)

        If retCode <> ModWinsCard.SCARD_S_SUCCESS Then

            If InStr(ReaderName, "ACR128U SAM") > 0 Then
                retCode = ModWinsCard.SCardConnect(hContext, ReaderName, ModWinsCard.SCARD_SHARE_DIRECT, 0, hCard, Protocol)
                If retCode <> ModWinsCard.SCARD_S_SUCCESS Then
                    displayOut(1, retCode, "", lstBoxLog)
                    connActive = False
                    Exit Sub
                Else
                    displayOut(0, 0, "Successful connection to " & ReaderName, lstBoxLog)
                End If
            Else
                displayOut(1, retCode, "", lstBoxLog)
                connActive = False
                Exit Sub
            End If
        Else
            displayOut(0, 0, "Successful connection to " & ReaderName, lstBoxLog)
        End If

        connActive = True
    End Sub

#End Region

    Public Sub New(ByVal ReaderName As String)
        SmartCardReader = ReaderName
    End Sub

    Public Sub Dispose()
        GC.SuppressFinalize(Me)
    End Sub

    Public Sub Clear()

        m_CRN = ""
        m_FirstName = ""
        m_MiddleName = ""
        m_LastName = ""
        m_Suffix = ""
        m_Gender = ""
        m_CivilStatus = ""
        m_Height = ""
        m_Weight = ""
        m_BirthDate = ""
        m_BirthCity = ""
        m_BirthProvince = ""
        m_BirthCountry = ""
        m_Features = ""
        m_CardCreationDate = ""
        m_Father_FirstName = ""
        m_Father_MiddleName = ""
        m_Father_LastName = ""
        m_Father_Suffix = ""
        m_Mother_FirstName = ""
        m_Mother_MiddleName = ""
        m_Mother_LastName = ""
        m_Mother_Suffix = ""
        m_Room = ""
        m_House = ""
        m_StreetName = ""
        m_Subdivision = ""
        m_Barangay = ""
        m_City = ""
        m_Province = ""
        m_PostalCode = ""
        m_CountryCode = ""
        m_TIN = ""

        m_FingerCode_LeftPrimary = ""
        m_FingerCode_LeftBackup = ""
        m_FingerCode_RightPrimary = ""
        m_FingerCode_RightBackup = ""

        m_Photo = ""
        m_Signature = ""

        m_Biometric_LeftPrimary = ""
        m_Biometric_LeftBackup = ""
        m_Biometric_RightPrimary = ""
        m_Biometric_RightBackup = ""

    End Sub

    Private Sub GP_PackData(ByVal baSBuf As String, ByVal uiLen As UInteger, ByRef baTBuf() As Byte)
        Dim tBuff(uiLen - 1) As Byte
        HexStringToByteArray(baSBuf, tBuff)
        Array.Copy(tBuff, baTBuf, tBuff.Length)
    End Sub

    Private Sub GP_UnpackData(ByVal baSBuf() As Byte, ByVal uiLen As UInteger, ByRef baTBuf As String, ByVal bSpace As Boolean)
        Dim i As UInteger
        Dim cMe As New String(New Char(4) {})
        baTBuf = ""

        For i = 0 To uiLen - 1
            If i = (uiLen - 1) Then
                cMe = String.Format("{0:X2}", baSBuf(i))
            Else
                If bSpace = True Then
                    cMe = String.Format("{0:X2} ", baSBuf(i))
                Else
                    cMe = String.Format("{0:X2}", baSBuf(i))
                End If
            End If
            baTBuf &= cMe
        Next i

    End Sub

    Private Sub Des3_16(ByVal E_D As Integer, ByVal ucKey As Byte(), ByVal ucData As Byte(), ByRef ucResult As Byte())

        Dim ucTemp(7) As Byte
        Dim ucKey1(7) As Byte
        Dim ucKey2(7) As Byte

        Array.Copy(ucKey, ucKey1, 8)
        Array.Copy(ucKey, 8, ucKey2, 0, 8)

        If E_D = 0 Then
            dotNetGlobalPlatform.GlobalPlatform.MyDES(ENCRYPTION, ucKey1, ucData, ucResult)
            Array.Copy(ucResult, ucTemp, 8)
            dotNetGlobalPlatform.GlobalPlatform.MyDES(DECRYPTION, ucKey2, ucTemp, ucResult)
            Array.Copy(ucResult, ucTemp, 8)
            dotNetGlobalPlatform.GlobalPlatform.MyDES(ENCRYPTION, ucKey1, ucTemp, ucResult)
        Else
            dotNetGlobalPlatform.GlobalPlatform.MyDES(DECRYPTION, ucKey1, ucData, ucResult)
            Array.Copy(ucResult, ucTemp, 8)
            dotNetGlobalPlatform.GlobalPlatform.MyDES(ENCRYPTION, ucKey2, ucTemp, ucResult)
            Array.Copy(ucResult, ucTemp, 8)
            dotNetGlobalPlatform.GlobalPlatform.MyDES(DECRYPTION, ucKey1, ucTemp, ucResult)
        End If

    End Sub

    Private Sub Des3_16_ECB_2(ByVal E_D As Integer, ByRef ucKey() As Byte, ByVal ucData() As Byte, ByVal DataInLength As Integer, ByVal ucResult() As Byte)

        Dim ucTempData(7) As Byte
        Dim ucTemp(7) As Byte
        Dim int_i As Integer

        For int_i = 0 To (DataInLength \ 8) - 1
            Array.Copy(ucData, 8 * int_i, ucTempData, 0, 8)
            Des3_16(E_D, ucKey, ucTempData, ucTemp)
            Array.Copy(ucTemp, 0, ucResult, 8 * int_i, 8)
        Next int_i

    End Sub

    Private Sub ChangeStatus(ByRef Status As ToolStripLabel, ByVal Message As String, ByRef progress As ProgressBar, ByVal Increment As Integer)
        Status.Text = Message
        progress.Value += Increment
        Application.DoEvents()
        System.Threading.Thread.Sleep(1)
    End Sub

    Private Function InitScript(ByRef lstBoxLog As ListBox, ByVal IsStrict As Boolean) As Boolean

        SendAPDU("E4DA00D00E00D0022A040046417C51ABB0729E", lstBoxLog)
        SendAPDU("E4DA9F690C40929334AE2B07517437655C", lstBoxLog)
        SendAPDU("E4DA9F680C000000991088064EB6EC3AED", lstBoxLog)
        SendAPDU("E4DA00D71800400980000E20D0004009D0000820D0EE074DFE9CEF0A3D", lstBoxLog)
        SendAPDU("E4D800001F0080106C70C446CF50A7BFA5E3E2D275BDFE9B038FD094F904D667FBD2EBC1", lstBoxLog)
        SendAPDU("E4F0800108D2189B2275576C2E", lstBoxLog)

        If Not IsStrict Then
            Return True
        Else
            If Not SmartCardErrorCode() = "Success" Then
                Return False
            Else
                Return True
            End If
        End If

    End Function

    Private Function WriteData(ByVal DataID As Integer, ByVal offSet As Integer, ByVal baSBuf() As Byte, ByVal InLen As Integer, ByRef lsBoxLog As ListBox) As Boolean

        Dim APDU_Cmd As String = ""
        Dim baTemp1 As String = ""

        APDU_Cmd = "80D2" + String.Format("{0:X2}", DataID) + "00" + String.Format("{0:X2}", InLen + 2) + String.Format("{0:X4}", offSet)
        GP_UnpackData(baSBuf, InLen, baTemp1, False)
        APDU_Cmd += baTemp1

        SendAPDU(APDU_Cmd, lsBoxLog)
        If Not SmartCardErrorCode.Trim = "Success" Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Function WriteKey(ByVal KeyID As Integer, ByVal baSBuf() As Byte, ByVal InLen As Integer, ByRef lstBoxLog As ListBox) As Boolean

        Dim APDU_Cmd As String = ""
        Dim baTemp1 As String = ""

        If KeyID = 1 Then
            APDU_Cmd = "80D4" + String.Format("{0:X2}", KeyID) + "0012"
        Else
            APDU_Cmd = "80D4" + String.Format("{0:X2}", KeyID) + "0512"
        End If

        GP_UnpackData(baSBuf, InLen, baTemp1, False)
        APDU_Cmd += baTemp1

        SendAPDU(APDU_Cmd, lstBoxLog)
        If SmartCardErrorCode() = "Success" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function WriteSectoryKey(ByVal KeyGroup As Integer, ByVal StartKeyID As Integer, ByVal baSBuf() As Byte, ByVal InLen As Integer, ByRef lstboxLog As ListBox) As Boolean

        Dim APDU_Cmd As String = ""
        Dim baTemp1 As String = ""

        APDU_Cmd = "80D8" + String.Format("{0:X2}", KeyGroup) + String.Format("{0:X2}", StartKeyID) + String.Format("{0:X2}", InLen)

        GP_UnpackData(baSBuf, InLen, baTemp1, False)
        APDU_Cmd += baTemp1

        SendAPDU(APDU_Cmd, lstboxLog)
        If SmartCardErrorCode() = "Success" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function WriteSectorKeyGroup00(ByVal iStartKID As Integer, ByVal KeyDataGroup As String, _
                                   ByRef lstBoxLog As ListBox, ByRef SessionKeys As Byte(), ByRef CSN_AP() As Byte) As Boolean

        Dim iKeyNum As Integer
        Dim iBlock As Integer
        Dim int_i As Integer
        Dim KeyValue As String
        Dim AnsiTemp As String
        Dim baTemp1(1023) As Byte
        Dim baSectorKeyBlock(511) As Byte
        Dim baDivData(23) As Byte
        Dim baDivSectorKey(23) As Byte
        Dim baICV(7) As Byte
        Dim hRet As Boolean
        Dim baSBuf(1023) As Byte
        Dim baRBuf(1023) As Byte

        AnsiTemp = KeyDataGroup
        iKeyNum = AnsiTemp.Length / 32
        iBlock = 0

        For int_i = 0 To iKeyNum - 1
            'KeyValue = AnsiTemp.Substring((32 * int_i) + 1, 32)
            KeyValue = AnsiTemp.Substring(32 * int_i, 32)

            GP_PackData(KeyValue, KeyValue.Length() / 2, baTemp1)
            Array.Copy(baTemp1, baDivData, 16)

            baDivSectorKey(0) = &HEC
            baDivSectorKey(1) = &H4C
            baDivSectorKey(2) = &HE5
            baDivSectorKey(3) = &H8F
            baDivSectorKey(4) = &H92
            baDivSectorKey(5) = &HB9
            baDivSectorKey(6) = &H68
            baDivSectorKey(7) = &H4
            baDivSectorKey(8) = &H4C
            baDivSectorKey(9) = &H2A
            baDivSectorKey(10) = &H25
            baDivSectorKey(11) = &H15
            baDivSectorKey(12) = &H64
            baDivSectorKey(13) = &HCB
            baDivSectorKey(14) = &H67
            baDivSectorKey(15) = &H76

            Des3_16_ECB_2(DECRYPTION, baDivSectorKey, baDivData, 16, baTemp1)
            Array.Copy(baTemp1, baDivSectorKey, 16)

            Array.Copy(CSN_AP, baDivData, 16)
            Array.Clear(baICV, 0, 8)
            dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, baICV, baDivSectorKey, baDivData, 16, baTemp1)
            Array.Copy(baTemp1, baDivSectorKey, 16)

            Des3_16_ECB_2(DECRYPTION, SessionKeys, baDivSectorKey, 16, baTemp1)
            Array.Copy(baTemp1, 0, baSectorKeyBlock, iBlock, 16)
            iBlock += 16
            Array.Clear(baICV, 0, 8)
            Des3_16_ECB_2(ENCRYPTION, baDivSectorKey, baICV, 8, baTemp1)
            Array.Copy(baTemp1, 0, baSectorKeyBlock, iBlock, 2)
            iBlock += 2

        Next int_i

        hRet = WriteSectoryKey(0, iStartKID, baSectorKeyBlock, iBlock, lstBoxLog)

        Return hRet


    End Function

    Private Function WriteSectorKeyGroup01(ByVal iStartKID As Integer, ByVal KeyDataGroup As String, _
                                   ByRef lstBoxLog As ListBox, ByRef SessionKeys As Byte(), ByRef CSN_AP() As Byte) As Boolean

        Dim iKeyNum As Integer
        Dim iBlock As Integer
        Dim int_i As Integer
        Dim KeyValue As String
        Dim AnsiTemp As String
        Dim baTemp1(1023) As Byte
        Dim baSectorKeyBlock(511) As Byte
        Dim baDivData(23) As Byte
        Dim baDivSectorKey(23) As Byte
        Dim baICV(7) As Byte
        Dim hRet As Boolean
        Dim baSBuf(1023) As Byte
        Dim baRBuf(1023) As Byte

        AnsiTemp = KeyDataGroup
        iKeyNum = AnsiTemp.Length / 32
        iBlock = 0

        For int_i = 0 To iKeyNum - 1
            KeyValue = AnsiTemp.Substring(32 * int_i, 32)

            GP_PackData(KeyValue, KeyValue.Length() / 2, baTemp1)
            Array.Copy(baTemp1, baDivData, 16)

            baDivSectorKey(0) = &HEC
            baDivSectorKey(1) = &H4C
            baDivSectorKey(2) = &HE5
            baDivSectorKey(3) = &H8F
            baDivSectorKey(4) = &H92
            baDivSectorKey(5) = &HB9
            baDivSectorKey(6) = &H68
            baDivSectorKey(7) = &H4
            baDivSectorKey(8) = &H4C
            baDivSectorKey(9) = &H2A
            baDivSectorKey(10) = &H25
            baDivSectorKey(11) = &H15
            baDivSectorKey(12) = &H64
            baDivSectorKey(13) = &HCB
            baDivSectorKey(14) = &H67
            baDivSectorKey(15) = &H76

            Des3_16_ECB_2(DECRYPTION, baDivSectorKey, baDivData, 16, baTemp1)
            Array.Copy(baTemp1, baDivSectorKey, 16)

            Array.Copy(CSN_AP, baDivData, 16)
            Array.Clear(baICV, 0, 8)
            dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, baICV, baDivSectorKey, baDivData, 16, baTemp1)
            Array.Copy(baTemp1, baDivSectorKey, 16)

            Des3_16_ECB_2(DECRYPTION, SessionKeys, baDivSectorKey, 16, baTemp1)
            Array.Copy(baTemp1, 0, baSectorKeyBlock, iBlock, 16)
            iBlock += 16
            Array.Clear(baICV, 0, 8)
            Des3_16_ECB_2(ENCRYPTION, baDivSectorKey, baICV, 8, baTemp1)
            Array.Copy(baTemp1, 0, baSectorKeyBlock, iBlock, 2)
            iBlock += 2

        Next int_i

        hRet = WriteSectoryKey(1, iStartKID, baSectorKeyBlock, iBlock, lstBoxLog)

        Return hRet


    End Function

    Private Function WriteIAK(ByVal IAK As String, ByRef SessionKey As Byte(), ByRef CSN_AP As Byte(), ByRef lstBoxLog As ListBox) As Boolean

        Dim KeyValue As String
        Dim baTemp1(1023) As Byte
        Dim baTemp2(1023) As Byte
        Dim baDivData(23) As Byte
        Dim baDivCPK(23) As Byte
        Dim baICV(7) As Byte
        Dim hRet As Boolean
        Dim baSBuf(1023) As Byte
        Dim baRBuf(1023) As Byte
        Dim baDivIAK(23) As Byte
        Dim Key As String = ""

        'GP_PackData("A06AF0FA6B34D198503DCFF4A3993A22", 16, SessionKey)
        'GP_PackData("A0A1A2A3A4A5A6A7A8A9AAABACADAEAF", 16, CSN_AP)

        KeyValue = IAK.Replace(" ", "")
        GP_PackData(KeyValue, KeyValue.Length / 2, baTemp1)
        Array.Copy(baTemp1, baDivData, 16)

        GP_UnpackData(CSN_AP, 16, Key, False)
        Console.WriteLine("CSN: " + Key)

        GP_UnpackData(SessionKey, 16, Key, False)
        Console.WriteLine("SESSION KEY: " + Key)

        Console.WriteLine("IAK: " + KeyValue)

        baDivIAK(0) = &HEC
        baDivIAK(1) = &H4C
        baDivIAK(2) = &HE5
        baDivIAK(3) = &H8F
        baDivIAK(4) = &H92
        baDivIAK(5) = &HB9
        baDivIAK(6) = &H68
        baDivIAK(7) = &H4
        baDivIAK(8) = &H4C
        baDivIAK(9) = &H2A
        baDivIAK(10) = &H25
        baDivIAK(11) = &H15
        baDivIAK(12) = &H64
        baDivIAK(13) = &HCB
        baDivIAK(14) = &H67
        baDivIAK(15) = &H76

        GP_UnpackData(baDivIAK, 16, Key, False)
        Console.WriteLine("RAW IAK: " + Key)

        Des3_16_ECB_2(DECRYPTION, baDivIAK, baDivData, 16, baTemp1)
        Array.Copy(baTemp1, baDivIAK, 16)

        GP_UnpackData(baDivIAK, 16, Key, False)
        Console.WriteLine("Diversified IAK: " + Key)

        Array.Copy(CSN_AP, baDivData, 16)

        Array.Clear(baICV, 0, 8)
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, baICV, baDivIAK, baDivData, 16, baTemp1)
        Array.Copy(baTemp1, baDivIAK, 16)

        GP_UnpackData(baDivIAK, 16, Key, False)
        Console.WriteLine("baCSN_AP Encrypted Div IAK: " + Key)

        Des3_16_ECB_2(DECRYPTION, SessionKey, baDivIAK, 16, baTemp1)
        Array.Copy(baTemp1, baTemp2, 16)
        Array.Clear(baICV, 0, 8)
        Des3_16_ECB_2(ENCRYPTION, baDivIAK, baICV, 8, baTemp1)
        Array.Copy(baTemp1, 0, baTemp2, 16, 2)

        GP_UnpackData(baTemp2, 16, Key, False)
        Console.WriteLine("Write IAK: " + Key)

        hRet = WriteKey(0, baTemp2, 18, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteCAK(ByVal CAK As String, ByRef SessionKey As Byte(), ByRef CSN_AP As Byte(), ByRef lstBoxLog As ListBox)

        Dim KeyValue As String
        Dim baTemp1(1023) As Byte
        Dim baTemp2(1023) As Byte
        Dim baDivData(23) As Byte
        Dim baDivCPK(23) As Byte
        Dim baICV(7) As Byte
        Dim hRet As Boolean
        Dim baSBuf(1023) As Byte
        Dim baRBuf(1023) As Byte
        Dim baDivCAK(23) As Byte
        Dim Key As String = ""

        'GP_PackData("A06AF0FA6B34D198503DCFF4A3993A22", 16, SessionKey)
        'GP_PackData("A0A1A2A3A4A5A6A7A8A9AAABACADAEAF", 16, CSN_AP)

        KeyValue = CAK.Replace(" ", "")
        GP_PackData(KeyValue, KeyValue.Length / 2, baTemp1)
        Array.Copy(baTemp1, baDivData, 16)

        GP_UnpackData(CSN_AP, 16, Key, False)
        Console.WriteLine("CSN: " + Key)

        GP_UnpackData(SessionKey, 16, Key, False)
        Console.WriteLine("SESSION KEY: " + Key)

        Console.WriteLine("CAK: " + KeyValue)

        baDivCAK(0) = &HEC
        baDivCAK(1) = &H4C
        baDivCAK(2) = &HE5
        baDivCAK(3) = &H8F
        baDivCAK(4) = &H92
        baDivCAK(5) = &HB9
        baDivCAK(6) = &H68
        baDivCAK(7) = &H4
        baDivCAK(8) = &H4C
        baDivCAK(9) = &H2A
        baDivCAK(10) = &H25
        baDivCAK(11) = &H15
        baDivCAK(12) = &H64
        baDivCAK(13) = &HCB
        baDivCAK(14) = &H67
        baDivCAK(15) = &H76

        GP_UnpackData(baDivCAK, 16, Key, False)
        Console.WriteLine("RAW CAK: " + Key)

        Des3_16_ECB_2(DECRYPTION, baDivCAK, baDivData, 16, baTemp1)
        Array.Copy(baTemp1, baDivCAK, 16)

        GP_UnpackData(baDivCAK, 16, Key, False)
        Console.WriteLine("Diversified CAK: " + Key)

        Array.Copy(CSN_AP, baDivData, 16)
        Array.Clear(baICV, 0, 8)
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, baICV, baDivCAK, baDivData, 16, baTemp1)
        Array.Copy(baTemp1, baDivCAK, 16)

        GP_UnpackData(baDivCAK, 16, Key, False)
        Console.WriteLine("baCSN_AP Encrypted Div CAK: " + Key)

        Des3_16_ECB_2(DECRYPTION, SessionKey, baDivCAK, 16, baTemp1)
        Array.Copy(baTemp1, baTemp2, 16)
        Array.Clear(baICV, 0, 8)
        Des3_16_ECB_2(ENCRYPTION, baDivCAK, baICV, 8, baTemp1)
        Array.Copy(baTemp1, 0, baTemp2, 16, 2)

        GP_UnpackData(baTemp2, 16, Key, False)
        Console.WriteLine("Write CAK: " + Key)

        hRet = WriteKey(1, baTemp2, 18, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteAMK(ByVal AMK As String, ByRef SessionKey As Byte(), ByRef CSN_AP As Byte(), ByRef lstBoxLog As ListBox)

        Dim KeyValue As String
        Dim baTemp1(1023) As Byte
        Dim baTemp2(1023) As Byte
        Dim baDivData(23) As Byte
        Dim baDivCPK(23) As Byte
        Dim baICV(7) As Byte
        Dim hRet As Boolean
        Dim baSBuf(1023) As Byte
        Dim baRBuf(1023) As Byte
        Dim baDivAMK(23) As Byte
        Dim Key As String = ""

        KeyValue = AMK.Replace(" ", "")
        GP_PackData(KeyValue, KeyValue.Length / 2, baTemp1)
        Array.Copy(baTemp1, baDivData, 16)

        GP_UnpackData(CSN_AP, 16, Key, False)
        Console.WriteLine("CSN: " + Key)

        GP_UnpackData(SessionKey, 16, Key, False)
        Console.WriteLine("SESSION KEY: " + Key)

        Console.WriteLine("AMK: " + KeyValue)

        baDivAMK(0) = &HEC
        baDivAMK(1) = &H4C
        baDivAMK(2) = &HE5
        baDivAMK(3) = &H8F
        baDivAMK(4) = &H92
        baDivAMK(5) = &HB9
        baDivAMK(6) = &H68
        baDivAMK(7) = &H4
        baDivAMK(8) = &H4C
        baDivAMK(9) = &H2A
        baDivAMK(10) = &H25
        baDivAMK(11) = &H15
        baDivAMK(12) = &H64
        baDivAMK(13) = &HCB
        baDivAMK(14) = &H67
        baDivAMK(15) = &H76

        GP_UnpackData(baDivAMK, 16, Key, False)
        Console.WriteLine("RAW AMK: " + Key)

        Des3_16_ECB_2(DECRYPTION, baDivAMK, baDivData, 16, baTemp1)
        Array.Copy(baTemp1, baDivAMK, 16)

        GP_UnpackData(baDivAMK, 16, Key, False)
        Console.WriteLine("Diversified AMK: " + Key)

        Array.Copy(CSN_AP, baDivData, 16)
        Array.Clear(baICV, 0, 8)
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, baICV, baDivAMK, baDivData, 16, baTemp1)
        Array.Copy(baTemp1, baDivAMK, 16)

        GP_UnpackData(baDivAMK, 16, Key, False)
        Console.WriteLine("baCSN_AP Encrypted Div AMK: " + Key)

        Des3_16_ECB_2(DECRYPTION, SessionKey, baDivAMK, 16, baTemp1)
        Array.Copy(baTemp1, baTemp2, 16)
        Array.Clear(baICV, 0, 8)
        Des3_16_ECB_2(ENCRYPTION, baDivAMK, baICV, 8, baTemp1)
        Array.Copy(baTemp1, 0, baTemp2, 16, 2)

        GP_UnpackData(baTemp2, 16, Key, False)
        Console.WriteLine("Write AMK: " + Key)

        hRet = WriteKey(2, baTemp2, 18, lstBoxLog)

        Return hRet

    End Function

    Private Sub ParseKey(ByVal dKey As String, ByVal baCSN_AP As Byte(), ByVal baSK As Byte(), ByRef rKey As Byte())

        Dim baTemp1(1023) As Byte
        Dim baTemp2(1023) As Byte
        Dim baDivData(23) As Byte
        Dim baDivCPK(23) As Byte
        Dim baICV(7) As Byte
        Dim baSBuf(1023) As Byte
        Dim baRBuf(1023) As Byte
        'Dim baDivAMK(23) As Byte
        Dim KeyValue As String = ""
        Dim Key As String = ""

        KeyValue = dKey.Replace(" ", "")
        GP_PackData(KeyValue, KeyValue.Length / 2, baTemp1)
        Array.Copy(baTemp1, baDivData, 16)

        GP_UnpackData(baCSN_AP, 16, Key, False)
        Console.WriteLine("CSN: " + Key)

        GP_UnpackData(baSK, 16, Key, False)
        Console.WriteLine("SESSION KEY: " + Key)

        Console.WriteLine("KEY: " + KeyValue)

        baDivCPK(0) = &HEC
        baDivCPK(1) = &H4C
        baDivCPK(2) = &HE5
        baDivCPK(3) = &H8F
        baDivCPK(4) = &H92
        baDivCPK(5) = &HB9
        baDivCPK(6) = &H68
        baDivCPK(7) = &H4
        baDivCPK(8) = &H4C
        baDivCPK(9) = &H2A
        baDivCPK(10) = &H25
        baDivCPK(11) = &H15
        baDivCPK(12) = &H64
        baDivCPK(13) = &HCB
        baDivCPK(14) = &H67
        baDivCPK(15) = &H76

        GP_UnpackData(baDivCPK, 16, Key, False)
        Console.WriteLine("RAW KEY: " + Key)

        Des3_16_ECB_2(DECRYPTION, baDivCPK, baDivData, 16, baTemp1)
        Array.Copy(baTemp1, baDivCPK, 16)

        GP_UnpackData(baDivCPK, 16, Key, False)
        Console.WriteLine("Diversified AMK: " + Key)

        Array.Copy(baCSN_AP, baDivData, 16)
        Array.Clear(baICV, 0, 8)
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, baICV, baDivCPK, baDivData, 16, baTemp1)
        Array.Copy(baTemp1, baDivCPK, 16)

        GP_UnpackData(baDivCPK, 16, Key, False)
        Console.WriteLine("baCSN_AP Encrypted Div AMK: " + Key)

        Des3_16_ECB_2(DECRYPTION, baSK, baDivCPK, 16, baTemp1)
        Array.Copy(baTemp1, baTemp2, 16)
        Array.Clear(baICV, 0, 8)
        Des3_16_ECB_2(ENCRYPTION, baDivCPK, baICV, 8, baTemp1)
        Array.Copy(baTemp1, 0, baTemp2, 16, 2)

        GP_UnpackData(baTemp2, 16, Key, False)
        Console.WriteLine("KEY: " + Key)

        Array.Copy(baTemp1, rKey, 16)

    End Sub

    Private Function WriteDataGroup00(ByVal TID_10 As String, ByVal DataLen As Integer, ByRef baCSN_AP As Byte(), ByRef lstBoxLog As ListBox) As Boolean

        Dim hRet As Boolean = False
        Dim dataGroup As String = TID_10
        Dim dataBuf() As Byte = New Byte(dataGroup.Length - 1) {}

        dataGroup = Str2Hex(dataGroup).Replace(" ", "")

        GP_PackData(dataGroup, dataGroup.Length / 2, dataBuf)

        Array.Copy(dataBuf, baCSN_AP, DataLen)

        hRet = WriteData(0, 0, dataBuf, dataBuf.Length, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteDataGroup01(ByVal TID_11 As String, _
                              ByVal TID_12 As String, _
                              ByVal TID_13 As String, _
                              ByVal TID_14 As String, _
                              ByVal TID_1F As String, _
                              ByVal TID_20 As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim hRet As Boolean = False
        Dim dataGroup As String = ""

        dataGroup = Spacer(TID_11, 40) + _
                    Spacer(TID_12, 40) + _
                    Spacer(TID_13, 40) + _
                    Spacer(TID_14, 10) + _
                    Spacer(TID_1F, 1) + _
                    Spacer(TID_20, 8)

        Dim dataBuf() As Byte = New Byte(dataGroup.Length - 1) {}

        dataGroup = Str2Hex(dataGroup).Replace(" ", "")

        GP_PackData(dataGroup, dataGroup.Length / 2, dataBuf)

        hRet = WriteData(1, 0, dataBuf, dataBuf.Length, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteDataGroup02(ByVal TID_15 As String, _
                              ByVal TID_16 As String, _
                              ByVal TID_17 As String, _
                              ByVal TID_18 As String, _
                              ByVal TID_19 As String, _
                              ByVal TID_1A As String, _
                              ByVal TID_1B As String, _
                              ByVal TID_1C As String, _
                              ByVal TID_1D As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim hRet As Boolean = False
        Dim dataGroup As String = ""

        dataGroup = Spacer(TID_15, 6) + _
                    Spacer(TID_16, 3) + _
                    Spacer(TID_17, 30) + _
                    Spacer(TID_18, 30) + _
                    Spacer(TID_19, 30) + _
                    Spacer(TID_1A, 40) + _
                    Spacer(TID_1B, 40) + _
                    Spacer(TID_1C, 15) + _
                    Spacer(TID_1D, 40)

        Dim dataBuf() As Byte = New Byte(dataGroup.Length - 1) {}

        dataGroup = Str2Hex(dataGroup).Replace(" ", "")

        GP_PackData(dataGroup, dataGroup.Length / 2, dataBuf)

        hRet = WriteData(2, 0, dataBuf, dataBuf.Length, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteDataGroup03(ByVal TID_21 As String, _
                              ByVal TID_22 As String, _
                              ByVal TID_2D As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim hRet As Boolean = False
        Dim dataGroup As String = ""

        dataGroup = Spacer(TID_21, 30) + _
                    Spacer(TID_22, 30) + _
                    Spacer(TID_2D, 3)

        Dim dataBuf() As Byte = New Byte(dataGroup.Length - 1) {}

        dataGroup = Str2Hex(dataGroup).Replace(" ", "")

        GP_PackData(dataGroup, dataGroup.Length / 2, dataBuf)

        hRet = WriteData(3, 0, dataBuf, dataBuf.Length, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteDataGroup04(ByVal TID_23 As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim hRet As Boolean = False
        Dim dataGroup As String = ""

        dataGroup = Spacer(TID_23, 1)

        Dim dataBuf() As Byte = New Byte(dataGroup.Length - 1) {}

        dataGroup = Str2Hex(dataGroup).Replace(" ", "")

        GP_PackData(dataGroup, dataGroup.Length / 2, dataBuf)

        hRet = WriteData(4, 0, dataBuf, dataBuf.Length, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteDataGroup05(ByVal TID_30 As String, _
                              ByVal TID_31 As String, _
                              ByVal TID_32 As String, _
                              ByVal TID_33 As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim hRet As Boolean = False
        Dim dataGroup As String = ""

        dataGroup = Spacer(TID_30, 40) + _
                    Spacer(TID_31, 40) + _
                    Spacer(TID_32, 40) + _
                    Spacer(TID_33, 10)

        Dim dataBuf() As Byte = New Byte(dataGroup.Length - 1) {}

        dataGroup = Str2Hex(dataGroup).Replace(" ", "")

        GP_PackData(dataGroup, dataGroup.Length / 2, dataBuf)

        hRet = WriteData(5, 0, dataBuf, dataBuf.Length, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteDataGroup06(ByVal TID_40 As String, _
                              ByVal TID_41 As String, _
                              ByVal TID_42 As String, _
                              ByVal TID_43 As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim hRet As Boolean = False
        Dim dataGroup As String = ""
        Dim temp As String = ""

        dataGroup = Spacer(TID_40, 40) + _
                    Spacer(TID_41, 40) + _
                    Spacer(TID_42, 40) + _
                    Spacer(TID_43, 10)

        Dim dataBuf() As Byte = New Byte(dataGroup.Length - 1) {}

        dataGroup = Str2Hex(dataGroup).Replace(" ", "")

        GP_PackData(dataGroup, dataGroup.Length / 2, dataBuf)

        hRet = WriteData(6, 0, dataBuf, dataBuf.Length, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteDataGroup07(ByVal TID_24 As String, _
                              ByVal TID_25 As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim hRet As Boolean = False
        Dim dataGroup As String = ""

        dataGroup = Spacer(TID_24, 3) + _
                    Spacer(TID_25, 3)

        Dim dataBuf() As Byte = New Byte(dataGroup.Length - 1) {}

        dataGroup = Str2Hex(dataGroup).Replace(" ", "")

        GP_PackData(dataGroup, dataGroup.Length / 2, dataBuf)

        hRet = WriteData(7, 0, dataBuf, dataBuf.Length, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteDataGroup08(ByVal TID_26 As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim hRet As Boolean = False
        Dim dataGroup As String = ""

        dataGroup = Spacer(TID_26, 70)

        Dim dataBuf() As Byte = New Byte(dataGroup.Length - 1) {}

        dataGroup = Str2Hex(dataGroup).Replace(" ", "")

        GP_PackData(dataGroup, dataGroup.Length / 2, dataBuf)

        hRet = WriteData(8, 0, dataBuf, dataBuf.Length, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteDataGroup09(ByVal TID_27 As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim hRet As Boolean = False
        Dim dataGroup As String = ""

        dataGroup = Spacer(TID_27, 10)

        Dim dataBuf() As Byte = New Byte(dataGroup.Length - 1) {}

        dataGroup = Str2Hex(dataGroup).Replace(" ", "")

        GP_PackData(dataGroup, dataGroup.Length / 2, dataBuf)

        hRet = WriteData(9, 0, dataBuf, dataBuf.Length, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteDataGroup0A(ByVal TID_50 As String, _
                              ByVal TID_51 As String, _
                              ByVal TID_52 As String, _
                              ByVal TID_53 As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim hRet As Boolean = False
        Dim dataGroup As String = ""

        dataGroup = Spacer(TID_50, 1) + _
                    Spacer(TID_51, 1) + _
                    Spacer(TID_52, 1) + _
                    Spacer(TID_53, 1)

        Dim dataBuf() As Byte = New Byte(dataGroup.Length - 1) {}

        dataGroup = Str2Hex(dataGroup).Replace(" ", "")

        GP_PackData(dataGroup, dataGroup.Length / 2, dataBuf)

        hRet = WriteData(10, 0, dataBuf, dataBuf.Length, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteDataGroup0C(ByVal CardCreationDate As String, _
                              ByRef lstBoxLog As ListBox, ByRef CSN_AP() As Byte) As Boolean

        Dim hRet As Boolean = False
        Dim dataGroup As String = ""

        dataGroup = Spacer(CardCreationDate, 8)

        Dim dataBuf() As Byte = New Byte(dataGroup.Length - 1) {}

        dataGroup = Str2Hex(dataGroup).Replace(" ", "")

        GP_PackData(dataGroup, dataGroup.Length / 2, dataBuf)

        CSN_AP(12) = Long.Parse(CardCreationDate.Substring(0, 2), Globalization.NumberStyles.HexNumber)
        Console.WriteLine(CardCreationDate.Substring(0, 2))
        CSN_AP(13) = Long.Parse(CardCreationDate.Substring(2, 2), Globalization.NumberStyles.HexNumber)
        Console.WriteLine(CardCreationDate.Substring(2, 2))
        CSN_AP(14) = Long.Parse(CardCreationDate.Substring(4, 2), Globalization.NumberStyles.HexNumber)
        Console.WriteLine(CardCreationDate.Substring(4, 2))
        CSN_AP(15) = Long.Parse(CardCreationDate.Substring(6, 2), Globalization.NumberStyles.HexNumber)
        Console.WriteLine(CardCreationDate.Substring(6, 2))
        hRet = WriteData(12, 0, dataBuf, dataBuf.Length, lstBoxLog)

        Return hRet

    End Function

    Private Function WriteDataGroup0D(ByVal pathFinger_LeftPrimary As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim buffer(247) As Byte
        Dim fileBuffer(1023) As Byte
        Dim iOffSet As Integer = 0
        Dim iBlock As Integer = 0
        Dim hRet As Boolean = False

        If Not IO.File.Exists(pathFinger_LeftPrimary) Then
            Return False
        End If

        Dim fileStream As New IO.FileStream(pathFinger_LeftPrimary, IO.FileMode.Open, IO.FileAccess.Read)
        If fileStream.Length > 1024 Then
            fileStream.Dispose()
            Return False
        End If

        fileStream.Read(fileBuffer, 0, fileStream.Length)
        fileStream.Close()
        fileStream.Dispose()

        For i As Integer = 0 To 4

            If i = 4 Then
                iBlock = 32
            Else
                iBlock = 248
            End If

            Array.Copy(fileBuffer, iOffSet, buffer, 0, iBlock)
            hRet = WriteData(13, iOffSet, buffer, iBlock, lstBoxLog)

            If Not hRet Then
                Return False
            End If

            iOffSet += iBlock

        Next

        'For i As Integer = 0 To CInt(fileBuffer.Length / 128) - 1
        '    Array.Copy(fileBuffer, iOffSet, buffer, 0, 128)
        '    hRet = WriteData(13, iOffSet, buffer, 128, lstBoxLog)
        '    If Not hRet Then
        '        Return False
        '    End If
        '    iOffSet += 128
        'Next

        Return True

    End Function

    Private Function WriteDataGroup0E(ByVal pathFinger_RightPrimary As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim buffer(247) As Byte
        Dim fileBuffer(1023) As Byte
        Dim iOffSet As Integer = 0
        Dim iBlock As Integer = 0
        Dim iFileLength As Integer = 0
        Dim hRet As Boolean = False

        If Not IO.File.Exists(pathFinger_RightPrimary) Then
            Return False
        End If

        Dim fileStream As New IO.FileStream(pathFinger_RightPrimary, IO.FileMode.Open, IO.FileAccess.Read)
        If fileStream.Length > 1024 Then
            fileStream.Dispose()
            Return False
        End If

        fileStream.Read(fileBuffer, 0, fileStream.Length)
        fileStream.Close()
        fileStream.Dispose()

        For i As Integer = 0 To 4

            If i = 4 Then
                iBlock = 32
            Else
                iBlock = 248
            End If

            Array.Copy(fileBuffer, iOffSet, buffer, 0, iBlock)
            hRet = WriteData(14, iOffSet, buffer, iBlock, lstBoxLog)

            If Not hRet Then
                Return False
            End If

            iOffSet += iBlock

        Next


        'For i As Integer = 0 To CInt(fileBuffer.Length / 128) - 1
        '    Array.Copy(fileBuffer, iOffSet, buffer, 0, 128)
        '    hRet = WriteData(14, iOffSet, buffer, 128, lstBoxLog)
        '    If Not hRet Then
        '        Return False
        '    End If
        '    iOffSet += 128
        'Next



        Return True

    End Function

    Private Function WriteDataGroup0F(ByVal pathFinger_LeftBackup As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim buffer(247) As Byte
        Dim fileBuffer(1023) As Byte
        Dim iOffSet As Integer = 0
        Dim iBlock As Integer = 0
        Dim hRet As Boolean = False


        If Not IO.File.Exists(pathFinger_LeftBackup) Then
            Return False
        End If

        Dim fileStream As New IO.FileStream(pathFinger_LeftBackup, IO.FileMode.Open, IO.FileAccess.Read)
        If fileStream.Length > 1024 Then
            fileStream.Dispose()
            Return False
        End If

        fileStream.Read(fileBuffer, 0, fileStream.Length)
        fileStream.Close()
        fileStream.Dispose()

        For i As Integer = 0 To 4

            If i = 4 Then
                iBlock = 32
            Else
                iBlock = 248
            End If

            Array.Copy(fileBuffer, iOffSet, buffer, 0, iBlock)
            hRet = WriteData(15, iOffSet, buffer, iBlock, lstBoxLog)

            If Not hRet Then
                Return False
            End If

            iOffSet += iBlock

        Next

        'For i As Integer = 0 To CInt(fileBuffer.Length / 128) - 1
        '    Array.Copy(fileBuffer, iOffSet, buffer, 0, 128)
        '    hRet = WriteData(15, iOffSet, buffer, 128, lstBoxLog)
        '    If Not hRet Then
        '        Return False
        '    End If
        '    iOffSet += 128
        'Next

        Return True

    End Function

    Private Function WriteDataGroup10(ByVal pathFinger_RightBackup As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim buffer(247) As Byte
        Dim fileBuffer(1023) As Byte
        Dim iOffSet As Integer = 0
        Dim iBlock As Integer = 0
        Dim hRet As Boolean = False


        If Not IO.File.Exists(pathFinger_RightBackup) Then
            Return False
        End If

        Dim fileStream As New IO.FileStream(pathFinger_RightBackup, IO.FileMode.Open, IO.FileAccess.Read)
        If fileStream.Length > 1024 Then
            fileStream.Dispose()
            Return False
        End If

        fileStream.Read(fileBuffer, 0, fileStream.Length)
        fileStream.Close()
        fileStream.Dispose()

        For i As Integer = 0 To 4

            If i = 4 Then
                iBlock = 32
            Else
                iBlock = 248
            End If

            Array.Copy(fileBuffer, iOffSet, buffer, 0, iBlock)
            hRet = WriteData(16, iOffSet, buffer, iBlock, lstBoxLog)

            If Not hRet Then
                Return False
            End If

            iOffSet += iBlock

        Next

        'For i As Integer = 0 To CInt(fileBuffer.Length / 128) - 1
        '    Array.Copy(fileBuffer, iOffSet, buffer, 0, 128)
        '    hRet = WriteData(16, iOffSet, buffer, 128, lstBoxLog)
        '    If Not hRet Then
        '        Return False
        '    End If
        '    iOffSet += 128
        'Next

        Return True

    End Function

    Private Function WriteDataGroup11(ByVal pathPhoto As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim buffer(247) As Byte
        Dim fileBuffer(15359) As Byte
        Dim iOffSet As Integer = 0
        Dim iBlock As Integer = 0
        Dim hRet As Boolean = False


        If Not IO.File.Exists(pathPhoto) Then
            Return False
        End If

        Dim fileStream As New IO.FileStream(pathPhoto, IO.FileMode.Open, IO.FileAccess.Read)
        If fileStream.Length > 15360 Then
            fileStream.Dispose()
            Return False
        End If

        fileStream.Read(fileBuffer, 0, fileStream.Length)
        fileStream.Close()
        fileStream.Dispose()

        For i As Integer = 0 To 61

            If i = 4 Then
                iBlock = 232
            Else
                iBlock = 248
            End If

            Array.Copy(fileBuffer, iOffSet, buffer, 0, iBlock)
            hRet = WriteData(17, iOffSet, buffer, iBlock, lstBoxLog)

            If Not hRet Then
                Return False
            End If

            iOffSet += iBlock

        Next

        'For i As Integer = 0 To CInt(fileBuffer.Length / 128) - 1
        '    Array.Copy(fileBuffer, iOffSet, buffer, 0, 128)
        '    hRet = WriteData(17, iOffSet, buffer, 128, lstBoxLog)
        '    If Not hRet Then
        '        Return False
        '    End If
        '    iOffSet += 128
        'Next

        Return True

    End Function

    Private Function WriteDataGroup12(ByVal pathSignature As String, _
                              ByRef lstBoxLog As ListBox) As Boolean

        Dim buffer(247) As Byte
        Dim fileBuffer(1535) As Byte
        Dim iOffSet As Integer = 0
        Dim iBlock As Integer = 0
        Dim hRet As Boolean = False


        If Not IO.File.Exists(pathSignature) Then
            Return False
        End If

        Dim fileStream As New IO.FileStream(pathSignature, IO.FileMode.Open, IO.FileAccess.Read)
        If fileStream.Length > 1536 Then
            fileStream.Dispose()
            Return False
        End If

        fileStream.Read(fileBuffer, 0, fileStream.Length)
        fileStream.Close()
        fileStream.Dispose()

        For i As Integer = 0 To 6

            If i = 4 Then
                iBlock = 48
            Else
                iBlock = 248
            End If

            Array.Copy(fileBuffer, iOffSet, buffer, 0, iBlock)
            hRet = WriteData(18, iOffSet, buffer, iBlock, lstBoxLog)

            If Not hRet Then
                Return False
            End If

            iOffSet += iBlock

        Next

        'For i As Integer = 0 To CInt(fileBuffer.Length / 128) - 1
        '    Array.Copy(fileBuffer, iOffSet, buffer, 0, 128)
        '    hRet = WriteData(18, iOffSet, buffer, 128, lstBoxLog)
        '    If Not hRet Then
        '        Return False
        '    End If
        '    iOffSet += 128
        'Next

        Return True

    End Function

    Private Function SelectUMIDCard(ByRef Status As ToolStripLabel, ByRef lstBoxLog As ListBox, ByRef progress As ProgressBar) As Boolean

        ChangeStatus(Status, "Select UMID Applet...", progress, 1)
        SendAPDU("00A4040007A082273911020100", lstBoxLog)

        If Not SmartCardErrorCode() = "Success" Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Function GP_Authentication(ByRef Status As ToolStripLabel, ByRef lstBoxLog As ListBox, ByRef progress As ProgressBar) As Boolean

        Dim card_cryptograms(127) As Byte
        Dim crypto_data(127) As Byte
        Dim baTT(1023) As Byte
        Dim baTmp(1023) As Byte
        Dim KDCenc(49) As Byte
        Dim KSCenc(49) As Byte
        Dim KSCkek(49) As Byte
        Dim mycard_cryptograms(127) As Byte
        Dim KDCmac(49) As Byte
        Dim KSCmac(49) As Byte
        Dim KDCkek(49) As Byte
        Dim host_cryptograms(127) As Byte
        Dim host_mac(127) As Byte
        Dim KMC(15) As Byte
        Dim CMK(15) As Byte
        Dim divdata(49) As Byte
        Dim ucResult(49) As Byte
        Dim i As Integer
        Dim j As Integer
        Dim m As Integer
        Dim kk As Integer
        Dim APDU_Cmd As String
        Dim uiSLen As UInteger
        Dim baSBuf(1023) As Byte
        Dim baRBuf(1023) As Byte


        'SELECT CARD MANAGER
        '=============================================
        ChangeStatus(Status, "Selecting Card Manager...", progress, 1)
        APDU_Cmd = "00A4040007A000000003000000"
        SendAPDU(APDU_Cmd, lstBoxLog)
        If Not SmartCardErrorCode() = "Success" Then
            Return False
        End If
        '=============================================

        'INITIALIZE UPDATE
        '=============================================
        ChangeStatus(Status, "Initialize Update...", progress, 1)
        APDU_Cmd = "8050000008202122232425262700"
        SendAPDU(APDU_Cmd, lstBoxLog)
        If Not SmartCardErrorCode() = "Success" Then
            Return False
        End If
        '=============================================

        'DETERMINE CMK
        '=============================================
        Array.Clear(baRBuf, 0, baRBuf.Length)
        Array.Copy(RecvBuff, baRBuf, RecvBuff.Length)

        If baRBuf(10) = &HFF Then
            KMC(0) = &H40
            KMC(1) = &H41
            KMC(2) = &H42
            KMC(3) = &H43
            KMC(4) = &H44
            KMC(5) = &H45
            KMC(6) = &H46
            KMC(7) = &H47
            KMC(8) = &H48
            KMC(9) = &H49
            KMC(10) = &H4A
            KMC(11) = &H4B
            KMC(12) = &H4C
            KMC(13) = &H4D
            KMC(14) = &H4E
            KMC(15) = &H4F
        Else
            KMC(0) = &HAD
            KMC(1) = &HA1
            KMC(2) = &HD3
            KMC(3) = &H49
            KMC(4) = &HF7
            KMC(5) = &HD5
            KMC(6) = &H2F
            KMC(7) = &H2
            KMC(8) = &H2C
            KMC(9) = &HE9
            KMC(10) = &H13
            KMC(11) = &HBF
            KMC(12) = &HA4
            KMC(13) = &H2A
            KMC(14) = &H6D
            KMC(15) = &H54
        End If
        '=============================================

        'CONVERT KMC to Odd Parity
        '=============================================
        For kk = 0 To 15
            Dim c As Integer = 0
            For l As Integer = 0 To 7
                If KMC(kk) And (&H1 << l) Then
                    c += 1
                End If
            Next
            If (c Mod 2) = 0 Then
                KMC(kk) = KMC(kk) Xor &H1
            End If
        Next
        Array.Copy(baRBuf, 20, card_cryptograms, 0, 8)
        '=============================================

        '==================================================================
        ' div-data for Get SKUenc
        '==================================================================
        Array.Clear(baTT, 0, 16)
        baTT(0) = &H1
        baTT(1) = &H82
        Array.Copy(baRBuf, 12, baTT, 2, 2)
        '==================================================================

        '==================================================================
        ' Calculate SKUenc
        '==================================================================
        Array.Copy(KMC, KDCenc, 16)
        Array.Clear(ucResult, 0, 8) 'IV
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, ucResult, KDCenc, baTT, 16, baTmp)
        Array.Copy(baTmp, KSCenc, 16)
        '==================================================================

        '==================================================================
        ' div-data for Get SKUMac
        '==================================================================
        Array.Clear(baTT, 0, 16)
        baTT(0) = &H1
        baTT(1) = &H1
        Array.Copy(baRBuf, 12, baTT, 2, 2)
        '==================================================================

        '==================================================================
        ' Calculate SKUmac
        '==================================================================
        Array.Copy(KMC, KDCmac, 16)
        Array.Clear(ucResult, 0, 8)
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, ucResult, KDCmac, baTT, 16, baTmp)
        Array.Copy(baTmp, KSCmac, 16)
        '==================================================================


        '==================================================================
        ' Calculate Card's Cryptography
        '==================================================================
        baTT(0) = &H20
        baTT(1) = &H21
        baTT(2) = &H22
        baTT(3) = &H23
        baTT(4) = &H24
        baTT(5) = &H25
        baTT(6) = &H26
        baTT(7) = &H27

        Array.Copy(baRBuf, 12, baTT, 8, 8)

        baTT(16) = &H80
        baTT(17) = &H0
        baTT(18) = &H0
        baTT(19) = &H0
        baTT(20) = &H0
        baTT(21) = &H0
        baTT(22) = &H0
        baTT(23) = &H0

        j = 24
        For i = 0 To (j / 8) - 1
            If i = 0 Then
                Array.Clear(baTmp, 0, 8)
                For m = 0 To 7
                    baTmp(m) = baTmp(m) Xor baTT(8 * (i) + m)
                Next
                Array.Copy(baTmp, mycard_cryptograms, 8)
            Else
                Des3_16(ENCRYPTION, KSCenc, mycard_cryptograms, baTmp)
                For m = 0 To 7
                    baTmp(m) = baTmp(m) Xor baTT(8 * (i) + m)
                Next
                Array.Copy(baTmp, mycard_cryptograms, 8)
            End If
        Next

        Des3_16(ENCRYPTION, KSCenc, mycard_cryptograms, baTmp)
        Array.Copy(baTmp, mycard_cryptograms, 8)

        '==================================================================
        'Compare Card's Cryptograms with Cryptograms calucated above
        '==================================================================
        For iCmp As Integer = 0 To 7
            If Not card_cryptograms(i) = mycard_cryptograms(i) Then
                Return False
            End If
        Next
        '==================================================================


        '==================================================================
        'Calcuate Cryptograms for External Authentication
        '==================================================================
        Array.Clear(baTT, 0, baTT.Length)
        Array.Copy(baRBuf, 12, baTT, 0, 8)
        baTT(8) = &H20
        baTT(9) = &H21
        baTT(10) = &H22
        baTT(11) = &H23
        baTT(12) = &H24
        baTT(13) = &H25
        baTT(14) = &H26
        baTT(15) = &H27
        baTT(16) = &H80
        baTT(17) = &H0
        baTT(18) = &H0
        baTT(19) = &H0
        baTT(20) = &H0
        baTT(21) = &H0
        baTT(22) = &H0
        baTT(23) = &H0

        j = 24
        For i = 0 To (j / 8) - 1
            If i = 0 Then
                Array.Clear(baTmp, 0, 8)
                For m = 0 To 7
                    baTmp(m) = baTmp(m) Xor baTT(8 * (i) + m)
                Next
                Array.Copy(baTmp, host_cryptograms, 8)
            Else
                Des3_16(ENCRYPTION, KSCenc, host_cryptograms, baTmp)
                For m = 0 To 7
                    baTmp(m) = baTmp(m) Xor baTT(8 * (i) + m)
                Next
                Array.Copy(baTmp, host_cryptograms, 8)
            End If
        Next
        Des3_16(ENCRYPTION, KSCenc, host_cryptograms, baTmp)
        Array.Copy(baTmp, host_cryptograms, 8)
        '==================================================================

        '==================================================================
        'Preparate to Issue External Authenticaton Command to Card
        'Because Class is 0x84 , So We Calucate MAC using KSCmac.
        '==================================================================
        baSBuf(0) = &H84
        baSBuf(1) = &H82
        baSBuf(2) = &H0
        baSBuf(3) = &H0
        baSBuf(4) = &H10
        Array.Copy(host_cryptograms, 0, baSBuf, 5, 8)
        baSBuf(13) = &H80
        baSBuf(14) = &H0
        baSBuf(15) = &H0

        Array.Clear(ucResult, 0, 8)

        For m = 0 To 7
            ucResult(m) = ucResult(m) Xor baSBuf(m)
        Next
        Array.Copy(ucResult, host_mac, 8)

        dotNetGlobalPlatform.GlobalPlatform.MyDES(ENCRYPTION, KSCmac, host_mac, ucResult)
        For m = 0 To 7
            ucResult(m) = ucResult(m) Xor baSBuf(8 + m)
        Next
        Array.Copy(ucResult, host_mac, 8)

        Dim ucKey1(7) As Byte
        Dim ucKey2(7) As Byte

        Array.Copy(KSCmac, ucKey1, 8)
        Array.Copy(KSCmac, 8, ucKey2, 0, 8)

        dotNetGlobalPlatform.GlobalPlatform.MyDES(ENCRYPTION, ucKey1, host_mac, ucResult)
        Array.Copy(ucResult, host_mac, 8)

        dotNetGlobalPlatform.GlobalPlatform.MyDES(DECRYPTION, ucKey2, host_mac, ucResult)
        Array.Copy(ucResult, host_mac, 8)

        dotNetGlobalPlatform.GlobalPlatform.MyDES(ENCRYPTION, ucKey1, host_mac, ucResult)
        Array.Copy(ucResult, host_mac, 8)

        Array.Copy(host_cryptograms, 0, baSBuf, 5, 8)
        Array.Copy(host_mac, 0, baSBuf, 13, 8)

        baSBuf(21) = &H0
        uiSLen = 22

        GP_UnpackData(baSBuf, uiSLen, APDU_Cmd, False)
        SendAPDU(APDU_Cmd, lstBoxLog)
        If Not SmartCardErrorCode() = "Success" Then
            Return False
        End If
        ChangeStatus(Status, "GP Authentication Success...", progress, 10)
        '==================================================================


        Return True

    End Function

    Private Function LoadApplet(ByRef Status As ToolStripLabel, ByRef lstBoxLog As ListBox, ByRef progress As ProgressBar, ByRef LoadAppletScript As RichTextBox)

        Dim APDU_Cmd As String = ""

        LoadApplet = True

        ChangeStatus(Status, "Deleteng UMID Applet...", progress, 1)

        APDU_Cmd = "80E400800A4F08A08227391102010000"
        SendAPDU(APDU_Cmd, lstBoxLog)

        ChangeStatus(Status, "Loading UMID Applet...", progress, 1)
        Application.DoEvents()

        Dim Max As Integer = LoadAppletScript.Lines.Length - 1
        Dim ctr As Integer = 0

        For Each Line As String In LoadAppletScript.Lines

            If Not Line.Trim = "" Then

                ctr += 1

                APDU_Cmd = Line.Replace(" ", "")

                SendAPDU(APDU_Cmd, lstBoxLog)
                If Not SmartCardErrorCode() = "Success" Then
                    Return False
                End If

                ChangeStatus(Status, "Loading UMID Applet Script " + ctr.ToString + " of " + Max.ToString, progress, 1)

            End If

        Next

        ChangeStatus(Status, "UMID Applet Load Success...", progress, 1)

    End Function

    Private Function InitialforMutualAuth(ByVal RND() As Byte, ByRef lstBoxLog As ListBox) As Boolean

        Dim APDU_Cmd As String = ""

        GP_UnpackData(RND, 16, APDU_Cmd, False)

        APDU_Cmd = "8086000010" + APDU_Cmd + "30"

        SendAPDU(APDU_Cmd, lstBoxLog)
        If SmartCardErrorCode() = "Success" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function MutualAuthentication(ByVal baSBuf() As Byte, ByRef lstboxLog As ListBox) As Boolean

        Dim APDU_Cmd As String = ""

        GP_UnpackData(baSBuf, 16, APDU_Cmd, False)

        APDU_Cmd = "808A000010" + APDU_Cmd

        SendAPDU(APDU_Cmd, lstboxLog)
        If SmartCardErrorCode() = "Success" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function UMID_Authentication(ByRef Status As ToolStripLabel, ByRef lstBoxLog As ListBox, ByRef progress As ProgressBar, ByRef Chip_SN As Label, ByRef SessionKey() As Byte, ByRef CSN_AP() As Byte) As Boolean

        Dim hRet As Boolean = False
        Dim baIFDRND As Byte() = New Byte(15) {}
        Dim baICCRND As Byte() = New Byte(15) {}
        Dim baCSN As Byte() = New Byte(19) {}
        Dim baAuthCode As Byte() = New Byte(15) {}
        Dim uiSLen As Long = 0
        Dim uiRLen As Long = 0
        Dim baSBuf As Byte() = New Byte(1023) {}
        Dim baRBuf As Byte() = New Byte(1023) {}
        Dim baTemp1 As Byte() = New Byte(1023) {}
        Dim baDivData As Byte() = New Byte(23) {}
        Dim baDivCPK As Byte() = New Byte(23) {}
        Dim baICV As Byte() = New Byte(7) {}
        Dim ChipSN As String = ""
        Dim Rnd As New Random

        Array.Clear(SessionKey, 0, SessionKey.Length)

        For i As Integer = 0 To 15
            baIFDRND(i) = Rnd.Next(0, 255)
        Next

        ChangeStatus(Status, "Preparing Mutual Authentication...", progress, 1)
        hRet = InitialforMutualAuth(baIFDRND, lstBoxLog)
        If Not hRet Then
            Return False
        End If
        Array.Copy(RecvBuff, baRBuf, RecvBuff.Length)

        Array.Copy(baRBuf, 0, baCSN, 0, 16)
        Array.Copy(baRBuf, 16, baICCRND, 0, 16)
        Array.Copy(baRBuf, 32, baAuthCode, 0, 16)

        GP_UnpackData(baCSN, 16, ChipSN, False)
        Chip_SN.Text = ChipSN

        baDivCPK(0) = &HAD
        baDivCPK(1) = &HA1
        baDivCPK(2) = &HD3
        baDivCPK(3) = &H49
        baDivCPK(4) = &HF7
        baDivCPK(5) = &HD5
        baDivCPK(6) = &H2F
        baDivCPK(7) = &H2
        baDivCPK(8) = &H2C
        baDivCPK(9) = &HE9
        baDivCPK(10) = &H13
        baDivCPK(11) = &HBF
        baDivCPK(12) = &HA4
        baDivCPK(13) = &H2A
        baDivCPK(14) = &H6D
        baDivCPK(15) = &H54

        'CREATE Div CPK
        '======================================================
        Array.Copy(baCSN, baDivData, 16)
        Array.Clear(baICV, 0, 8)
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, baICV, baDivCPK, baDivData, 16, baTemp1)
        Array.Copy(baTemp1, baDivCPK, 16)
        Des3_16_ECB_2(ENCRYPTION, baDivCPK, baIFDRND, 16, baTemp1)

        For i As Integer = 0 To 15
            If Not baTemp1(i) = baAuthCode(i) Then
                Return False
            End If
        Next
        '======================================================

        'Mutual Authentication
        '======================================================
        ChangeStatus(Status, "Mutual Authentication...", progress, 1)
        Des3_16_ECB_2(ENCRYPTION, baDivCPK, baICCRND, 16, baTemp1)
        Array.Copy(baTemp1, baAuthCode, 16)

        hRet = MutualAuthentication(baAuthCode, lstBoxLog)
        If Not hRet Then
            Return False
        End If
        '======================================================

        'CREATE SESSION KEY
        '======================================================
        Array.Copy(baICCRND, 0, baDivData, 0, 2)
        Array.Copy(baICCRND, 4, baDivData, 2, 2)
        Array.Copy(baICCRND, 8, baDivData, 4, 2)
        Array.Copy(baICCRND, 12, baDivData, 6, 2)
        Array.Copy(baIFDRND, 0, baDivData, 8, 2)
        Array.Copy(baIFDRND, 4, baDivData, 10, 2)
        Array.Copy(baIFDRND, 8, baDivData, 12, 2)
        Array.Copy(baIFDRND, 12, baDivData, 14, 2)

        Array.Clear(baICV, 0, 8)
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, baICV, baDivCPK, baDivData, 16, baTemp1)

        Array.Copy(baTemp1, SessionKey, 16)
        '======================================================

        Return True

    End Function

    Private Function EndPerso(ByRef lstBoxLog As ListBox) As Boolean

        SendAPDU("808C0000", lstBoxLog)
        If SmartCardErrorCode() = "Success" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function ChangeCMK(ByRef Status As ToolStripLabel, ByRef lstBoxLog As ListBox, ByRef progress As ProgressBar) As Boolean

        Dim bool_CMK As Boolean = False
        Dim bool_flag As Boolean = False
        Dim card_cryptograms As Byte() = New Byte(127) {}
        Dim crypto_data As Byte() = New Byte(127) {}
        Dim baTT As Byte() = New Byte(1023) {}
        Dim baTmp As Byte() = New Byte(1023) {}
        Dim KDCenc As Byte() = New Byte(49) {}
        Dim KSCenc As Byte() = New Byte(49) {}
        Dim KSCkek As Byte() = New Byte(49) {}
        Dim mycard_cryptograms As Byte() = New Byte(127) {}
        Dim KDCmac As Byte() = New Byte(49) {}
        Dim KSCmac As Byte() = New Byte(49) {}
        Dim KDCkek As Byte() = New Byte(49) {}
        Dim host_cryptograms As Byte() = New Byte(127) {}
        Dim host_mac As Byte() = New Byte(127) {}
        Dim KMC As Byte() = New Byte(15) {}
        Dim CMK As Byte() = New Byte(15) {}
        Dim divdata As Byte() = New Byte(49) {}
        Dim ucResult As Byte() = New Byte(49) {}
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim m As Integer = 0
        Dim kk As Integer = 0
        Dim APDU_Cmd As String = ""
        Dim uiSLen As UInteger
        Dim baSBuf As Byte() = New Byte(1023) {}
        Dim baRBuf As Byte() = New Byte(1023) {}

        'SELECT CARD MANAGER
        '=============================================
        ChangeStatus(Status, "Selecting Card Manager...", progress, 1)
        APDU_Cmd = "00A4040007A000000003000000"
        SendAPDU(APDU_Cmd, lstBoxLog)
        If Not SmartCardErrorCode() = "Success" Then
            Return False
        End If
        '=============================================

        'INITIALIZE UPDATE
        '=============================================
        ChangeStatus(Status, "Initialize Update...", progress, 1)
        APDU_Cmd = "8050000008202122232425262700"
        SendAPDU(APDU_Cmd, lstBoxLog)
        If Not SmartCardErrorCode() = "Success" Then
            Return False
        End If
        '=============================================

        'DETERMINE CMK
        '=============================================
        Array.Clear(baRBuf, 0, baRBuf.Length)
        Array.Copy(RecvBuff, baRBuf, RecvBuff.Length)

        If baRBuf(10) = &HFF Then
            KMC(0) = &H40
            KMC(1) = &H41
            KMC(2) = &H42
            KMC(3) = &H43
            KMC(4) = &H44
            KMC(5) = &H45
            KMC(6) = &H46
            KMC(7) = &H47
            KMC(8) = &H48
            KMC(9) = &H49
            KMC(10) = &H4A
            KMC(11) = &H4B
            KMC(12) = &H4C
            KMC(13) = &H4D
            KMC(14) = &H4E
            KMC(15) = &H4F
        Else
            KMC(0) = &HAD
            KMC(1) = &HA1
            KMC(2) = &HD3
            KMC(3) = &H49
            KMC(4) = &HF7
            KMC(5) = &HD5
            KMC(6) = &H2F
            KMC(7) = &H2
            KMC(8) = &H2C
            KMC(9) = &HE9
            KMC(10) = &H13
            KMC(11) = &HBF
            KMC(12) = &HA4
            KMC(13) = &H2A
            KMC(14) = &H6D
            KMC(15) = &H54
            bool_CMK = True
        End If
        '=============================================

        'CONVERT KMC to Odd Parity
        '=============================================
        For kk = 0 To 15
            Dim c As Integer = 0
            For l As Integer = 0 To 7
                If KMC(kk) And (&H1 << l) Then
                    c += 1
                End If
            Next
            If (c Mod 2) = 0 Then
                KMC(kk) = KMC(kk) Xor &H1
            End If
        Next
        Array.Copy(baRBuf, 20, card_cryptograms, 0, 8)
        '=============================================

        'CMK
        '=============================================
        CMK(0) = &HAD
        CMK(1) = &HA1
        CMK(2) = &HD3
        CMK(3) = &H49
        CMK(4) = &HF7
        CMK(5) = &HD5
        CMK(6) = &H2F
        CMK(7) = &H2
        CMK(8) = &H2C
        CMK(9) = &HE9
        CMK(10) = &H13
        CMK(11) = &HBF
        CMK(12) = &HA4
        CMK(13) = &H2A
        CMK(14) = &H6D
        CMK(15) = &H54
        '=============================================

        'CONVERT CMK to Odd Parity
        '=============================================
        For kk = 0 To 15
            Dim c As Integer = 0
            For l As Integer = 0 To 7
                If CMK(kk) And (&H1 << l) Then
                    c += 1
                End If
            Next l
            If (c Mod 2) = 0 Then
                CMK(kk) = CMK(kk) Xor &H1
            End If
        Next kk
        '=============================================

        '==================================================================
        ' div-data for Get SKUenc
        '==================================================================
        Array.Clear(baTT, 0, 16)
        baTT(0) = &H1
        baTT(1) = &H82
        Array.Copy(baRBuf, 12, baTT, 2, 2)
        '==================================================================

        '==================================================================
        ' Calculate SKUenc
        '==================================================================
        Array.Copy(KMC, KDCenc, 16)
        Array.Clear(ucResult, 0, 8) 'IV
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, ucResult, KDCenc, baTT, 16, baTmp)
        Array.Copy(baTmp, KSCenc, 16)
        '==================================================================

        '==================================================================
        ' div-data for Get SKUMac
        '==================================================================
        Array.Clear(baTT, 0, 16)
        baTT(0) = &H1
        baTT(1) = &H1
        Array.Copy(baRBuf, 12, baTT, 2, 2)
        '==================================================================

        '==================================================================
        ' Calculate SKUmac
        '==================================================================
        Array.Copy(KMC, KDCmac, 16)
        Array.Clear(ucResult, 0, 8)
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, ucResult, KDCmac, baTT, 16, baTmp)
        Array.Copy(baTmp, KSCmac, 16)
        '==================================================================

        '==================================================================
        ' div-data for Get SKUkek
        '==================================================================
        Array.Clear(baTT, 0, 16)
        baTT(0) = &H1
        baTT(1) = &H81
        Array.Copy(baRBuf, 12, baTT, 2, 2)
        '==================================================================


        '==================================================================
        ' Calucate SKUkek
        '==================================================================
        Array.Copy(KMC, KDCkek, 16)
        Array.Clear(ucResult, 0, 8)
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, ucResult, KDCkek, baTT, 16, baTmp)
        Array.Copy(baTmp, KSCkek, 16)
        '==================================================================

        '==================================================================
        ' Calculate Card's Cryptography
        '==================================================================
        baTT(0) = &H20
        baTT(1) = &H21
        baTT(2) = &H22
        baTT(3) = &H23
        baTT(4) = &H24
        baTT(5) = &H25
        baTT(6) = &H26
        baTT(7) = &H27

        Array.Copy(baRBuf, 12, baTT, 8, 8)

        baTT(16) = &H80
        baTT(17) = &H0
        baTT(18) = &H0
        baTT(19) = &H0
        baTT(20) = &H0
        baTT(21) = &H0
        baTT(22) = &H0
        baTT(23) = &H0

        j = 24
        For i = 0 To (j / 8) - 1
            If i = 0 Then
                Array.Clear(baTmp, 0, 8)
                For m = 0 To 7
                    baTmp(m) = baTmp(m) Xor baTT(8 * (i) + m)
                Next
                Array.Copy(baTmp, mycard_cryptograms, 8)
            Else
                Des3_16(ENCRYPTION, KSCenc, mycard_cryptograms, baTmp)
                For m = 0 To 7
                    baTmp(m) = baTmp(m) Xor baTT(8 * (i) + m)
                Next
                Array.Copy(baTmp, mycard_cryptograms, 8)
            End If
        Next

        Des3_16(ENCRYPTION, KSCenc, mycard_cryptograms, baTmp)
        Array.Copy(baTmp, mycard_cryptograms, 8)

        '==================================================================
        'Compare Card's Cryptograms with Cryptograms calucated above
        '==================================================================
        For iCmp As Integer = 0 To 7
            If Not card_cryptograms(i) = mycard_cryptograms(i) Then
                Return False
            End If
        Next
        '==================================================================


        '==================================================================
        'Calcuate Cryptograms for External Authentication
        '==================================================================
        Array.Clear(baTT, 0, baTT.Length)
        Array.Copy(baRBuf, 12, baTT, 0, 8)
        baTT(8) = &H20
        baTT(9) = &H21
        baTT(10) = &H22
        baTT(11) = &H23
        baTT(12) = &H24
        baTT(13) = &H25
        baTT(14) = &H26
        baTT(15) = &H27
        baTT(16) = &H80
        baTT(17) = &H0
        baTT(18) = &H0
        baTT(19) = &H0
        baTT(20) = &H0
        baTT(21) = &H0
        baTT(22) = &H0
        baTT(23) = &H0

        j = 24
        For i = 0 To (j / 8) - 1
            If i = 0 Then
                Array.Clear(baTmp, 0, 8)
                For m = 0 To 7
                    baTmp(m) = baTmp(m) Xor baTT(8 * (i) + m)
                Next
                Array.Copy(baTmp, host_cryptograms, 8)
            Else
                Des3_16(ENCRYPTION, KSCenc, host_cryptograms, baTmp)
                For m = 0 To 7
                    baTmp(m) = baTmp(m) Xor baTT(8 * (i) + m)
                Next
                Array.Copy(baTmp, host_cryptograms, 8)
            End If
        Next
        Des3_16(ENCRYPTION, KSCenc, host_cryptograms, baTmp)
        Array.Copy(baTmp, host_cryptograms, 8)
        '==================================================================

        '==================================================================
        'Preparate to Issue External Authenticaton Command to Card
        'Because Class is 0x84 , So We Calucate MAC using KSCmac.
        '==================================================================
        baSBuf(0) = &H84
        baSBuf(1) = &H82
        baSBuf(2) = &H0
        baSBuf(3) = &H0
        baSBuf(4) = &H10
        Array.Copy(host_cryptograms, 0, baSBuf, 5, 8)
        baSBuf(13) = &H80
        baSBuf(14) = &H0
        baSBuf(15) = &H0

        Array.Clear(ucResult, 0, 8)

        For m = 0 To 7
            ucResult(m) = ucResult(m) Xor baSBuf(m)
        Next
        Array.Copy(ucResult, host_mac, 8)

        dotNetGlobalPlatform.GlobalPlatform.MyDES(ENCRYPTION, KSCmac, host_mac, ucResult)
        For m = 0 To 7
            ucResult(m) = ucResult(m) Xor baSBuf(8 + m)
        Next
        Array.Copy(ucResult, host_mac, 8)

        Dim ucKey1(7) As Byte
        Dim ucKey2(7) As Byte

        Array.Copy(KSCmac, ucKey1, 8)
        Array.Copy(KSCmac, 8, ucKey2, 0, 8)

        dotNetGlobalPlatform.GlobalPlatform.MyDES(ENCRYPTION, ucKey1, host_mac, ucResult)
        Array.Copy(ucResult, host_mac, 8)

        dotNetGlobalPlatform.GlobalPlatform.MyDES(DECRYPTION, ucKey2, host_mac, ucResult)
        Array.Copy(ucResult, host_mac, 8)

        dotNetGlobalPlatform.GlobalPlatform.MyDES(ENCRYPTION, ucKey1, host_mac, ucResult)
        Array.Copy(ucResult, host_mac, 8)

        Array.Copy(host_cryptograms, 0, baSBuf, 5, 8)
        Array.Copy(host_mac, 0, baSBuf, 13, 8)

        baSBuf(21) = &H0
        uiSLen = 22

        GP_UnpackData(baSBuf, uiSLen, APDU_Cmd, False)
        SendAPDU(APDU_Cmd, lstBoxLog)
        If Not SmartCardErrorCode() = "Success" Then
            Return False
        End If
        ChangeStatus(Status, "GP Authentication Success...", progress, 10)
        '==================================================================

        '==================================================================
        'Set OP Status
        '==================================================================
        ChangeStatus(Status, "Setting OP Status...", progress, 1)
        APDU_Cmd = "80F0800708A000000003000000"
        SendAPDU(APDU_Cmd, lstBoxLog)
        '==================================================================

        '==================================================================
        'KMC -> CMK Replace Key
        '==================================================================
        ChangeStatus(Status, "ChangeCMK...", progress, 1)
        If bool_CMK Then
            APDU_Cmd = "80D8018143018010C6143AFEB07649E665D142E372E554630332007780103DB2F0F98E07DA625C0D7456800A260203D339C880108E5FD2DCBD5C1186E04CD75FD9E7A956037ABA1300"
        Else
            APDU_Cmd = "80D8008143018010C6143AFEB07649E665D142E372E554630332007780103DB2F0F98E07DA625C0D7456800A260203D339C880108E5FD2DCBD5C1186E04CD75FD9E7A956037ABA1300"
        End If

        uiSLen = APDU_Cmd.Length / 2
        GP_PackData(APDU_Cmd, uiSLen * 2, baSBuf)

        j = 16

        'KDCenc
        Dim divDataTemp(7) As Byte
        Array.Copy(CMK, divdata, 16)
        Array.Clear(crypto_data, 0, 128)

        'KDCenc ecnrypted by KDCkek
        For i = 0 To CInt(j / 8) - 1
            Array.Copy(divdata, 8 * i, divDataTemp, 0, 8)
            Des3_16(ENCRYPTION, KSCkek, divDataTemp, baTmp)
            Array.Copy(baTmp, 0, crypto_data, 8 * i, 8)
        Next

        'Check Value
        Array.Clear(divdata, 0, 8)
        Des3_16(ENCRYPTION, CMK, divdata, baTmp)
        Array.Copy(crypto_data, 0, baSBuf, 8, 16)
        Array.Copy(baTmp, 0, baSBuf, 25, 3)

        'KDCmac
        Array.Copy(CMK, divdata, 16)
        Array.Clear(divDataTemp, 0, 8)
        Array.Clear(crypto_data, 0, 128)

        'KDCmac encrypted by KDCkek
        For i = 0 To CInt(j / 8) - 1
            Array.Copy(divdata, 8 * i, divDataTemp, 0, 8)
            Des3_16(ENCRYPTION, KSCkek, divDataTemp, baTmp)
            Array.Copy(baTmp, 0, crypto_data, 8 * i, 8)
        Next

        'Check Value
        Array.Clear(divdata, 0, 8)
        Des3_16(ENCRYPTION, CMK, divdata, baTmp)
        Array.Copy(crypto_data, 0, baSBuf, 30, 16)
        Array.Copy(baTmp, 0, baSBuf, 47, 3)

        'KDCkek
        Array.Copy(CMK, divdata, 16)
        Array.Clear(divDataTemp, 0, 8)
        Array.Clear(crypto_data, 0, 128)

        'KDCenc encrypted by KDCkek
        For i = 0 To CInt(j / 8) - 1
            Array.Copy(divdata, 8 * i, divDataTemp, 0, 8)
            Des3_16(ENCRYPTION, KSCkek, divDataTemp, baTmp)
            Array.Copy(baTmp, 0, crypto_data, 8 * i, 8)
        Next

        'Check Value
        Array.Clear(divdata, 0, 8)
        Des3_16(ENCRYPTION, CMK, divdata, baTmp)
        Array.Copy(crypto_data, 0, baSBuf, 52, 16)
        Array.Copy(baTmp, 0, baSBuf, 69, 3)


        GP_UnpackData(baSBuf, uiSLen, APDU_Cmd, False)
        SendAPDU(APDU_Cmd.Replace(" ", ""), lstBoxLog)
        If Not SmartCardErrorCode() = "Success" Then
            Return False
        End If
        '==================================================================

        Return True


    End Function

    Private Function ActivateCard(ByRef lstBoxLog As ListBox) As Boolean
        SendAPDU("80AC050008313233343536FFFF", lstBoxLog)
        If SmartCardErrorCode() = "Success" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function ExternalAuthenticationAMK(ByVal KeyID As Integer, ByRef DataIn() As Byte, ByVal InLen As Integer, ByRef lstBoxLog As ListBox) As Boolean

        Dim tString As String = ""
        Dim APDU_Cmd As String
        Dim baTemp(1023) As Byte

        tString = String.Format("{0:X2}", KeyID)
        APDU_Cmd = "8082" & tString & "0018"

        GP_UnpackData(DataIn, InLen, tString, False)

        APDU_Cmd = APDU_Cmd + tString
        SendAPDU(APDU_Cmd, lstBoxLog)
        If SmartCardErrorCode() = "Success" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function AuthenticateSectorKey(ByVal KeyType As Integer, ByVal SectorID As Integer, ByVal DataIn() As Byte, ByVal InLen As Integer, ByRef lstBoxLog As ListBox) As Boolean

        Dim kID As String = ""
        Dim sID As String = ""
        Dim APDU_Cmd As String
        Dim baTemp(1023) As Byte
        Dim Data As String = ""

        kID = String.Format("{0:X2}", KeyType)
        sID = String.Format("{0:X2}", SectorID)
        APDU_Cmd = "808E" + kID + sID + "18"

        GP_UnpackData(DataIn, InLen, Data, False)

        APDU_Cmd = APDU_Cmd + Data
        SendAPDU(APDU_Cmd, lstBoxLog)
        If SmartCardErrorCode() = "Success" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function WriteSectorData(ByVal KeyValue As String, ByVal SectorID As Integer, ByVal iOffSet As Integer, ByVal InLen As UInteger, ByRef DataIn() As Byte, _
                                     ByRef lstboxLog As ListBox, ByRef Status As ToolStripLabel, ByRef progress As ProgressBar) As Boolean

        'Dim APDU_Cmd As String
        'Dim sID As String = ""
        'Dim offSet As String = ""
        'Dim Data As String = ""
        'Dim baCSN_AP As Byte() = New Byte(15) {}
        'Dim baSK As Byte() = New Byte(15) {}
        'Dim baICCRND As Byte() = New Byte(15) {}
        'Dim baIFDRND As Byte() = New Byte(15) {}
        'Dim Rnd As New Random
        'Dim baTemp1 As Byte() = New Byte(1023) {}
        'Dim baDivKey As Byte() = New Byte(15) {}
        'Dim baDivData As Byte() = New Byte(15) {}
        'Dim baICV As Byte() = New Byte(7) {}
        'Dim baAuthCode As Byte() = New Byte(7) {}

        'GP_PackData(KeyValue, 16, baDivKey)

        'ChangeStatus(Status, "Inquiring CSN Key...", progress, 1)
        'If Not GetCSN(lstboxLog) Then
        '    ChangeStatus(Status, "CSN Key Failed...", progress, 1)
        '    Return False
        'End If
        'Array.Copy(RecvBuff, baCSN_AP, 16)

        'ChangeStatus(Status, "Get Challenge...", progress, 1)
        'If Not GetChallenge(lstboxLog) Then
        '    ChangeStatus(Status, "Get Challenge...", progress, 1)
        '    Return False
        'End If
        'Array.Copy(RecvBuff, baICCRND, 16)

        'For i As Integer = 0 To 15
        '    baIFDRND(i) = Rnd.Next(0, 255)
        'Next

        ''GENERATE KEY
        ''=====================================================
        'Array.Copy(baDivKey, baDivData, 16)

        'baDivKey(0) = &HEC
        'baDivKey(1) = &H4C
        'baDivKey(2) = &HE5
        'baDivKey(3) = &H8F
        'baDivKey(4) = &H92
        'baDivKey(5) = &HB9
        'baDivKey(6) = &H68
        'baDivKey(7) = &H4
        'baDivKey(8) = &H4C
        'baDivKey(9) = &H2A
        'baDivKey(10) = &H25
        'baDivKey(11) = &H15
        'baDivKey(12) = &H64
        'baDivKey(13) = &HCB
        'baDivKey(14) = &H67
        'baDivKey(15) = &H76

        'Des3_16_ECB_2(DECRYPTION, baDivKey, baDivData, 16, baTemp1)
        'Array.Copy(baTemp1, baDivKey, 16)
        ''=====================================================

        'Array.Clear(baICV, 0, 8)
        'dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, baICV, baDivKey, baCSN_AP, 16, baTemp1)
        'Array.Copy(baTemp1, baDivKey, 16)

        'Array.Copy(baICCRND, 0, baDivData, 0, 2)
        'Array.Copy(baICCRND, 4, baDivData, 2, 2)
        'Array.Copy(baICCRND, 8, baDivData, 4, 2)
        'Array.Copy(baICCRND, 12, baDivData, 6, 2)
        'Array.Copy(baIFDRND, 0, baDivData, 8, 2)
        'Array.Copy(baIFDRND, 4, baDivData, 10, 2)
        'Array.Copy(baIFDRND, 8, baDivData, 12, 2)
        'Array.Copy(baIFDRND, 12, baDivData, 14, 2)

        'Array.Clear(baICV, 0, 8)
        'dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, baICV, baDivKey, baDivData, 16, baTemp1)

        'Array.Copy(baTemp1, baSK, 16)
        ''=====================================

        'Array.Clear(baICV, 0, 8)
        'Des3_16_ECB_2(ENCRYPTION, baSK, baICV, 8, baAuthCode)

        'Array.Copy(baIFDRND, 0, baTemp1, 0, 16)
        'Array.Copy(baAuthCode, 0, baTemp1, 16, 8)
        'ChangeStatus(Status, "Authenticating Sector Data...", progress, 1)
        'If Not AuthenticateSectorKey(1, SectorID, baTemp1, 24, lstboxLog) Then
        '    ChangeStatus(Status, "Authenticating Sector Data Failed...", progress, 1)
        '    Return False
        'End If

        'sID = String.Format("{0:X2}", SectorID)
        'APDU_Cmd = "80DC" + sID + "00"

        'offSet = String.Format("{0:X2}{1:X4}", InLen + 2, iOffSet)
        'APDU_Cmd = APDU_Cmd + offSet

        'GP_UnpackData(DataIn, InLen, Data, False)
        'APDU_Cmd = APDU_Cmd + Data

        'SendAPDU(APDU_Cmd, lstboxLog)
        'If SmartCardErrorCode() = "Success" Then
        '    Return True
        'Else
        '    Return False
        'End If

        Return True

    End Function

    Private Function GetCSN(ByRef lstBoxLog As ListBox) As Boolean

        SendAPDU("80B0000011", lstBoxLog)
        If SmartCardErrorCode() = "Success" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function GetChallenge(ByVal lstBoxLog As ListBox) As Boolean

        SendAPDU("8084000010", lstBoxLog)
        If SmartCardErrorCode() = "Success" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function InternalAuthentication(ByVal RND As Byte(), ByRef lstBoxLog As ListBox) As Boolean

        Dim RandomNum As String = ""

        GP_UnpackData(RND, 16, RandomNum, False)

        SendAPDU("8088000010" + RandomNum + "18", lstBoxLog)
        If SmartCardErrorCode() = "Success" Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function GSISCardPerso(ByRef Status As ToolStripLabel, ByRef lstBoxLog As ListBox, ByRef progress As ProgressBar, _
                                  ByVal Activate As Boolean, ByVal GSIS_Num As String, ByVal BP_Num As String) As Boolean

        On Error GoTo ErrCatch

        Dim DataOut As Byte() = New Byte(1023) {}
        Dim baTemp1 As Byte() = New Byte(1023) {}
        Dim baDivData As Byte() = New Byte(15) {}
        Dim baICV As Byte() = New Byte(7) {}
        Dim barBuf As Byte() = New Byte(1023) {}

        Dim baCSN_AP As Byte() = New Byte(19) {}
        Dim baSK As Byte() = New Byte(15) {}
        Dim baIFDRND As Byte() = New Byte(19) {}
        Dim baICCRND As Byte() = New Byte(19) {}
        Dim baAuthCode As Byte() = New Byte(19) {}

        Dim baDivAMK As Byte() = New Byte(15) {}

        Dim baGSIS() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes(GSIS_Num)
        Dim baBP() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes(BP_Num)

        Dim Rnd As New Random

        GP_PackData(SeekKey("AMK").Replace(" ", ""), 16, baDivAMK)

        ChangeStatus(Status, "Preparing Sector Personalization...", progress, 1)
        InitializeReaderList(lstBoxLog)
        ConnectToCard(SmartCardReader, lstBoxLog)

        If Not connActive Then
            ChangeStatus(Status, "Unable to detect smart card...", progress, 1)
            Return False
        Else
            ChangeStatus(Status, "Smart Card Present...", progress, 1)
        End If

        ChangeStatus(Status, "Selecting UMID Applet...", progress, 1)
        If Not SelectUMIDCard(Status, lstBoxLog, progress) Then
            ChangeStatus(Status, "Select Applet Failed...", progress, 1)
            DisconnectCard(SmartCardReader)
            Return False
        End If

        ChangeStatus(Status, "Inquiring CSN Key...", progress, 1)
        If Not GetCSN(lstBoxLog) Then
            ChangeStatus(Status, "CSN Key Failed...", progress, 1)
            DisconnectCard(SmartCardReader)
            Return False
        End If
        Array.Copy(RecvBuff, baCSN_AP, 16)

        ChangeStatus(Status, "Get Challenge...", progress, 1)
        If Not GetChallenge(lstBoxLog) Then
            ChangeStatus(Status, "Get Challenge...", progress, 1)
            DisconnectCard(SmartCardReader)
            Return False
        End If
        Array.Copy(RecvBuff, baICCRND, 16)

        For i As Integer = 0 To 15
            baIFDRND(i) = Rnd.Next(0, 255)
        Next

        'TEST Get ExAuth Code
        '=====================================
        'GP_PackData("8F8E8D8C8B8A89888786858483828180", 16, baDivAMK)
        'GP_PackData("4A9011B9CE6DF8BE35C261B420100222", 16, baCSN_AP)
        'GP_PackData("00000000000000000000000000000000", 16, baICCRND)
        'GP_PackData("11111111111111111111111111111111", 16, baIFDRND)
        '======================================

        'GENERATE AMK
        '=====================================================
        Array.Copy(baDivAMK, baDivData, 16)

        baDivAMK(0) = &HEC
        baDivAMK(1) = &H4C
        baDivAMK(2) = &HE5
        baDivAMK(3) = &H8F
        baDivAMK(4) = &H92
        baDivAMK(5) = &HB9
        baDivAMK(6) = &H68
        baDivAMK(7) = &H4
        baDivAMK(8) = &H4C
        baDivAMK(9) = &H2A
        baDivAMK(10) = &H25
        baDivAMK(11) = &H15
        baDivAMK(12) = &H64
        baDivAMK(13) = &HCB
        baDivAMK(14) = &H67
        baDivAMK(15) = &H76

        Des3_16_ECB_2(DECRYPTION, baDivAMK, baDivData, 16, baTemp1)
        Array.Copy(baTemp1, baDivAMK, 16)
        '=====================================================

        Array.Clear(baICV, 0, 8)
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, baICV, baDivAMK, baCSN_AP, 16, baTemp1)
        Array.Copy(baTemp1, baDivAMK, 16)

        Array.Copy(baICCRND, 0, baDivData, 0, 2)
        Array.Copy(baICCRND, 4, baDivData, 2, 2)
        Array.Copy(baICCRND, 8, baDivData, 4, 2)
        Array.Copy(baICCRND, 12, baDivData, 6, 2)
        Array.Copy(baIFDRND, 0, baDivData, 8, 2)
        Array.Copy(baIFDRND, 4, baDivData, 10, 2)
        Array.Copy(baIFDRND, 8, baDivData, 12, 2)
        Array.Copy(baIFDRND, 12, baDivData, 14, 2)

        Array.Clear(baICV, 0, 8)
        dotNetGlobalPlatform.GlobalPlatform.Des3_16_CBC(ENCRYPTION, baICV, baDivAMK, baDivData, 16, baTemp1)

        Array.Copy(baTemp1, baSK, 16)
        '=====================================

        Array.Clear(baICV, 0, 8)
        Des3_16_ECB_2(ENCRYPTION, baSK, baICV, 8, baAuthCode)

        Array.Copy(baIFDRND, 0, baTemp1, 0, 16)
        Array.Copy(baAuthCode, 0, baTemp1, 16, 8)

        ChangeStatus(Status, "Authenticating AMK...", progress, 1)
        If Not ExternalAuthenticationAMK(1, baTemp1, 24, lstBoxLog) Then
            ChangeStatus(Status, "Authenticating AMK Failed...", progress, 1)
            DisconnectCard(SmartCardReader)
            Return False
        End If

        If Activate Then
            ChangeStatus(Status, "Activating GSIS Card...", progress, 1)
            If Not ActivateCard(lstBoxLog) Then
                ChangeStatus(Status, "Activation Failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If
        Else
            ChangeStatus(Status, "Skipping Activation Process...", progress, 1)
        End If

        ChangeStatus(Status, "Writing Sector " + CInt(&H46).ToString + " Data...", progress, 1)
        If Not WriteSectorData(SeekKey("235 WRITE KEY").Replace(" ", ""), &H46, 0, BP_Num.Length, baBP, lstBoxLog, Status, progress) Then
            ChangeStatus(Status, "Writing Sector " + CInt(&H46).ToString + " Data Failed...", progress, 1)
            DisconnectCard(SmartCardReader)
            Return False
        End If

        ChangeStatus(Status, "Writing Sector " + CInt(&H47).ToString + " Data...", progress, 1)
        If Not WriteSectorData(SeekKey("236 WRITE KEY").Replace(" ", ""), &H47, 0, GSIS_Num.Length, baGSIS, lstBoxLog, Status, progress) Then
            ChangeStatus(Status, "Writing Sector " + CInt(&H47).ToString + " Data Failed...", progress, 1)
            DisconnectCard(SmartCardReader)
            Return False
        End If

        ChangeStatus(Status, "GSIS Perso Done...", progress, 1)

        DisconnectCard(SmartCardReader)

        Return True

ErrCatch:
        Return False

    End Function

    Private Function DetermineTransactions(ByVal Init As Boolean, _
                                           ByVal Load As Boolean, _
                                           ByVal UMID As Boolean, _
                                           ByVal GSIS As Boolean) As String
        Dim TransType As String = ""

        Const Trans_Init As String = "01"
        Const Trans_Load As String = "02"
        Const Trans_UMID As String = "03"
        Const Trans_GSIS As String = "04"

        If Init Then
            TransType += Trans_Init
        End If

        If Load Then
            TransType += Trans_Load
        End If

        If UMID Then
            TransType += Trans_UMID
        End If

        If GSIS Then
            TransType += Trans_GSIS
        End If

        Return TransType

    End Function

    Public Function UMIDCardPerso(ByVal CSNz As String, _
                                  ByVal pRecordDirectory As String, _
                                  ByRef Status As ToolStripLabel, _
                                  ByRef Chip_SN As Label, _
                                  ByRef lstBoxLog As ListBox, _
                                  ByRef progress As ProgressBar, _
                                  ByRef AppletScript As RichTextBox, _
                                  ByVal Init As Boolean, _
                                  ByVal LoadApp As Boolean, _
                                  ByVal PersoUMID As Boolean, _
                                  ByVal InitStrict As Boolean, _
                                  Optional ByRef Transaction_Type As String = "", _
                                  Optional ByRef Transaction_Status As String = "") As Boolean

        On Error GoTo ErrCatch

        Dim bool_CMK As Boolean = False
        Dim card_cryptograms(127) As Byte
        Dim crypto_data(127) As Byte
        Dim baTT(1023) As Byte
        Dim baTmp(1023) As Byte
        Dim KDCenc(49) As Byte
        Dim KSCenc(49) As Byte
        Dim KSCkek(49) As Byte
        Dim mycard_cryptograms(127) As Byte
        Dim KDCmac(49) As Byte
        Dim KSCmac(49) As Byte
        Dim KDCkek(49) As Byte
        Dim host_cryptograms(127) As Byte
        Dim host_mac(127) As Byte
        Dim KMC(15) As Byte
        Dim CMK(15) As Byte
        Dim divdata(49) As Byte
        Dim ucResult(49) As Byte
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim m As Integer = 0
        Dim kk As Integer = 0
        Dim APDU_Cmd As String = ""
        Dim bool_flag As Boolean = False
        Dim uiSLen As UInteger = 0
        Dim uiRLen As UInteger = 0
        Dim baSBuf(1023) As Byte
        Dim baRBuf(1023) As Byte

        Dim baSK(23) As Byte
        Dim baCSN_AP(19) As Byte

        Dim YYYY As String = Now.Year.ToString
        Dim MM As String = Now.Month.ToString
        Dim DD As String = Now.Day.ToString

        Dim Keys_Set As New DataConnection
        Dim dKey As DataTable

        Keys_Set.ConnectionString = ConnectionString

        dKey = Keys_Set.ExecuteDataTable("SELECT * FROM Key_Sets")

        If MM.Length = 1 Then
            MM = "0" + MM
        End If

        If DD.Length = 1 Then
            DD = "0" + DD
        End If

        Dim CardCreationDate As String = YYYY + MM + DD

        lstBoxLog.Items.Clear()

        progress.Value = 0

        Transaction_Type = DetermineTransactions(Init, LoadApp, PersoUMID, False)

        InitializeReaderList(lstBoxLog)
        ConnectToCard(SmartCardReader, lstBoxLog)

        If Not connActive Then
            ChangeStatus(Status, "Unable to detect smart card...", progress, 1)
            Chip_SN.Text = "NA"
            Return False
        Else
            ChangeStatus(Status, "Smart Card Present...", progress, 1)
        End If

        If Init Then
            If Not InitScript(lstBoxLog, InitStrict) Then
                ChangeStatus(Status, "Failed to Initialize UMID Card...", progress, 1)
                Chip_SN.Text = "NA"
                Return False
            Else
                DisconnectCard(SmartCardReader)
                ChangeStatus(Status, "Initialization Success...", progress, 5)
                System.Threading.Thread.Sleep(1000)
                ConnectToCard(SmartCardReader, lstBoxLog)
            End If
        Else
            ChangeStatus(Status, "Skipping Initialization Process...", progress, 5)
        End If

        If LoadApp Then
            If Not GP_Authentication(Status, lstBoxLog, progress) Then
                ChangeStatus(Status, "Unable to Authenticate Global Platform...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            If Not LoadApplet(Status, lstBoxLog, progress, AppletScript) Then
                ChangeStatus(Status, "Load Applet Failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If
        Else
            ChangeStatus(Status, "Skipping Load Applet Process...", progress, 40)
        End If


        If PersoUMID Then

            If Not SelectUMIDCard(Status, lstBoxLog, progress) Then
                ChangeStatus(Status, "Select Applet Failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            If Not UMID_Authentication(Status, lstBoxLog, progress, Chip_SN, baSK, baCSN_AP) Then
                ChangeStatus(Status, "UMID Authentication Failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 00", progress, 1)
            If Not WriteDataGroup00(Spacer(CRN, 12), CRN.Length, baCSN_AP, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 00 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 01", progress, 1)
            If Not WriteDataGroup01(FirstName, MiddleName, LastName, Suffix, Gender, BirthDate, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 01 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 02", progress, 1)
            If Not WriteDataGroup02(Address_PostalCode, Address_CountryCode, Address_Province, _
                                    Address_City, Address_Barangay, Address_Subdivision, Address_StreetName, _
                                    Address_House, Address_Room, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 02 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 03", progress, 1)
            If Not WriteDataGroup03(BirthCity, BirthProvince, BirthCountry, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 03 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 04", progress, 1)
            If Not WriteDataGroup04(CivilStatus, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 04 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 05", progress, 1)
            If Not WriteDataGroup05(Father_FirstName, Father_MiddleName, Father_LastName, Father_Suffix, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 05 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 06", progress, 1)
            If Not WriteDataGroup06(Mother_FirstName, Mother_MiddleName, Mother_LastName, Mother_Suffix, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 06 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 07", progress, 1)
            If Not WriteDataGroup07(Height, Weight, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 07 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 08", progress, 1)
            If Not WriteDataGroup08(DistinguishingFeatures, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 08 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 09", progress, 1)
            If Not WriteDataGroup09(TIN, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 09 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 0A", progress, 1)
            If Not WriteDataGroup0A(FingerCode_LeftPrimary, FingerCode_RightPrimary, FingerCode_LeftBackup, FingerCode_RightBackup, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 0A failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 0C", progress, 1)
            If Not WriteDataGroup0C(CardCreationDate, lstBoxLog, baCSN_AP) Then
                ChangeStatus(Status, "Write Datagroup 0C failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 0D", progress, 1)
            If Not WriteDataGroup0D(Biometric_LeftPrimary, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 0D failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 0E", progress, 1)
            If Not WriteDataGroup0E(Biometric_RightPrimary, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 0E failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 0F", progress, 1)
            If Not WriteDataGroup0F(Biometric_LeftBackup, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 0F failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 10", progress, 1)
            If Not WriteDataGroup10(Biometric_RightBackup, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 10 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 11", progress, 1)
            If Not WriteDataGroup11(Photo, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 11 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing DataGroup 12", progress, 1)
            If Not WriteDataGroup12(Signature, lstBoxLog) Then
                ChangeStatus(Status, "Write Datagroup 12 failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing IAK", progress, 1)
            Dim IAK As String = SeekKey("IAK", dKey)
            If IAK.Trim = "ERROR" Then
                ChangeStatus(Status, "IAK Not Found...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            If Not WriteIAK(IAK, baSK, baCSN_AP, lstBoxLog) Then
                ChangeStatus(Status, "Write IAK Failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing CAK", progress, 1)
            Dim CAK As String = SeekKey("CAK", dKey)
            If CAK.Trim = "ERROR" Then
                ChangeStatus(Status, "CAK Not Found...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            If Not WriteCAK(CAK, baSK, baCSN_AP, lstBoxLog) Then
                ChangeStatus(Status, "Write CAK Failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Writing AMK", progress, 1)
            Dim AMK As String = SeekKey("AMK", dKey)
            If AMK.Trim = "ERROR" Then
                ChangeStatus(Status, "AMK Not Found...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            If Not WriteAMK(AMK, baSK, baCSN_AP, lstBoxLog) Then
                ChangeStatus(Status, "Write AMK Failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            Dim caSectorKeyName As String = ""
            Dim iStartKID As Integer
            Dim KeyDataGroup As String = ""
            Dim KeyValue As String = ""
            Dim sPart As Integer = 0

            iStartKID = 0
            KeyDataGroup = ""
            KeyValue = ""
            ChangeStatus(Status, "Writing Sector Read Keys...", progress, 1)
            For iKID = 0 To 143

                If iKID < 36 Then
                    caSectorKeyName = String.Format("1{0:D2} READ KEY", (iKID Mod 36) + 1)
                ElseIf iKID > 35 AndAlso iKID < 72 Then
                    caSectorKeyName = String.Format("2{0:D2} READ KEY", (iKID Mod 36) + 1)
                ElseIf iKID > 71 AndAlso iKID < 108 Then
                    caSectorKeyName = String.Format("3{0:D2} READ KEY", (iKID Mod 36) + 1)
                ElseIf iKID > 107 AndAlso iKID < 144 Then
                    caSectorKeyName = String.Format("4{0:D2} READ KEY", (iKID Mod 36) + 1)
                End If

                KeyValue = SeekKey(caSectorKeyName, dKey)
                If KeyValue.Trim = "ERROR" Then
                    ChangeStatus(Status, "Failed to get " & caSectorKeyName & "...", progress, 1)
                    DisconnectCard(SmartCardReader)
                    Return False
                End If

                KeyDataGroup = KeyDataGroup + KeyValue.Replace(" ", "")

                If iKID <> 0 Then

                    If (iKID + 1) Mod 14 = 0 OrElse (iKID + 1) = 144 Then

                        bool_flag = WriteSectorKeyGroup00(iStartKID, KeyDataGroup, lstBoxLog, baSK, baCSN_AP)
                        sPart += 1
                        If bool_flag = False Then
                            ChangeStatus(Status, "Failed to WriteSectorKeyGroup00 Part " & sPart.ToString & " of 10", progress, 1)
                            DisconnectCard(SmartCardReader)
                            Return False
                        End If

                        iStartKID += 14
                        KeyDataGroup = ""

                        If Not iStartKID > 144 Then
                            ChangeStatus(Status, "WriteSectorKeyGroup00 Read Key: " & CInt(iKID - 12).ToString & " to " & iStartKID.ToString, progress, 2)
                        Else
                            ChangeStatus(Status, "WriteSectorKeyGroup00 Read Key: 141 to 144", progress, 2)
                        End If

                    End If

                End If

            Next iKID

            System.Threading.Thread.Sleep(1)

            caSectorKeyName = ""
            iStartKID = 0
            KeyDataGroup = ""
            KeyValue = ""
            sPart = 0

            iStartKID = 0
            KeyDataGroup = ""
            KeyValue = ""
            ChangeStatus(Status, "Writing Sector Write Keys...", progress, 1)
            For iKID = 0 To 143

                If iKID < 36 Then
                    caSectorKeyName = String.Format("1{0:D2} WRITE KEY", (iKID Mod 36) + 1)
                ElseIf iKID > 35 AndAlso iKID < 72 Then
                    caSectorKeyName = String.Format("2{0:D2} WRITE KEY", (iKID Mod 36) + 1)
                ElseIf iKID > 71 AndAlso iKID < 108 Then
                    caSectorKeyName = String.Format("3{0:D2} WRITE KEY", (iKID Mod 36) + 1)
                ElseIf iKID > 107 AndAlso iKID < 144 Then
                    caSectorKeyName = String.Format("4{0:D2} WRITE KEY", (iKID Mod 36) + 1)
                End If

                KeyValue = SeekKey(caSectorKeyName, dKey)
                If KeyValue.Trim = "ERROR" Then
                    ChangeStatus(Status, "Failed to get " & caSectorKeyName & "...", progress, 1)
                    DisconnectCard(SmartCardReader)
                    Return False
                End If

                KeyDataGroup = KeyDataGroup + KeyValue.Replace(" ", "")

                If iKID <> 0 Then

                    If (iKID + 1) Mod 14 = 0 OrElse (iKID + 1) = 144 Then

                        bool_flag = WriteSectorKeyGroup01(iStartKID, KeyDataGroup, lstBoxLog, baSK, baCSN_AP)
                        sPart += 1
                        If bool_flag = False Then
                            ChangeStatus(Status, "Failed to WriteSectorKeyGroup01 Part " & sPart.ToString & " of 10", progress, 1)
                            DisconnectCard(SmartCardReader)
                            Return False
                        End If

                        iStartKID += 14
                        KeyDataGroup = ""

                        If Not iStartKID > 144 Then
                            ChangeStatus(Status, "WriteSectorKeyGroup01 Write Key: " & CInt(iKID - 12).ToString & " to " & iStartKID.ToString, progress, 2)
                        Else
                            ChangeStatus(Status, "WriteSectorKeyGroup01 Write Key: 141 to 144", progress, 2)
                        End If

                    End If

                End If

            Next iKID

            ChangeStatus(Status, "Preparing UMID for Utilization Stage, Ending Personalization...", progress, 2)
            If Not EndPerso(lstBoxLog) Then
                ChangeStatus(Status, "Failed to set UMID card in Utilization Stage...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

            ChangeStatus(Status, "Securing UMID Card, ChangeCMK...", progress, 2)
            If Not ChangeCMK(Status, lstBoxLog, progress) Then
                ChangeStatus(Status, "ChangeCMK Failed...", progress, 1)
                DisconnectCard(SmartCardReader)
                Return False
            End If

        Else
            ChangeStatus(Status, "Skipping UMID Personalization Process...", progress, 30)
        End If


        ChangeStatus(Status, "UMID Perso Done...", progress, 1)

        DisconnectCard(SmartCardReader)

        dKey.Dispose()

        Return True

ErrCatch:
        Return False

    End Function

End Class
