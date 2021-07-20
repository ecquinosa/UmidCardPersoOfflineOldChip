Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class ClassEncryption

    Dim strFileToEncrypt As String
    Dim strFileToDecrypt As String
    Dim strOutputEncrypt As String
    Dim strOutputDecrypt As String
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream

    ''' <summary>
    ''' Encrypts a text using TripleDES Encryption.
    ''' </summary>
    ''' <param name="strText">A Valid String Object.</param>
    ''' <returns>Encrypted Text</returns>
    ''' <remarks>Encryption Key is "baronpogi" without the quotes.</remarks>
    Public Function TripleDesEncryptText(ByVal strText As String) As String
        Return TripleDesEncrypt(strText, "baronpogi")
    End Function

    ''' <summary>
    ''' Decrypts a text using TripleDes Decryption.
    ''' </summary>
    ''' <param name="strText">A Valid String Object.</param>
    ''' <returns>Decrypted Text</returns>
    ''' <remarks>Decryption Key is "baronpogi" without the quotes.</remarks>
    Public Function TripleDesDecryptText(ByVal strText As String) As String
        Return TripleDesDecrypt(strText, "baronpogi")
    End Function

    ''' <summary>
    ''' Procedure for ecrypting text using TripleDes Encryption.
    ''' </summary>
    ''' <param name="strText">A Valid String Object.</param>
    ''' <param name="strEncrKey">A Valid Key for Encryption.</param>
    ''' <returns>Encrypted Text</returns>
    Private Function TripleDesEncrypt(ByVal strText As String, ByVal strEncrKey As String) As String

        Dim byKey() As Byte = {}
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}

        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(Left(strEncrKey, 8))

            Dim des As New DESCryptoServiceProvider()
            Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes(strText)
            Dim ms As New MemoryStream()
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())

        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    ''' <summary>
    ''' Procedure for decrypting text using TripleDes Dencryption.
    ''' </summary>
    ''' <param name="strText">A Valid String Object.</param>
    ''' <param name="sDecrKey">A Valid Key for Dencryption.</param>
    ''' <returns>Dencrypted Text</returns>
    Private Function TripleDesDecrypt(ByVal strText As String, ByVal sDecrKey As String) As String

        Dim byKey() As Byte = {}
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Dim inputByteArray(strText.Length) As Byte

        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(Left(sDecrKey, 8))
            Dim des As New DESCryptoServiceProvider()
            inputByteArray = Convert.FromBase64String(strText)
            Dim ms As New MemoryStream()
            Dim cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write)

            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8

            Return encoding.GetString(ms.ToArray())

        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    ''' <summary>
    ''' Encrypts a String using MD5 Encryption.
    ''' </summary>
    ''' <param name="StringToEncrypt">A Valid String Object.</param>
    ''' <returns>Encrypted Text.</returns>
    ''' <remarks>This code doesn't have a decryption procedure.</remarks>
    Public Function MD5Encrypt(ByVal StringToEncrypt As String) As String

        Dim md5 As MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strOutput As String = ""
        Dim i As Integer

        md5 = New MD5CryptoServiceProvider

        bytValue = System.Text.Encoding.UTF8.GetBytes(StringToEncrypt)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            strOutput &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        MD5Encrypt = strOutput

    End Function

    ''' <summary>
    ''' Procedure for Encrypting and Decrypting a simple text by changing the characters into a special character.
    ''' </summary>
    ''' <param name="StringToEnDecrypt">A Valid String Object.</param>
    ''' <returns>Encrypted or Decrypted text.</returns>
    ''' <remarks>Returns a decrypted text when the parameter is encrypted and vice versa.</remarks>
    Public Function EnDeCrypt(ByVal StringToEnDecrypt As String) As String
        Dim strTempChar As String = ""
        Dim i As Integer
        For i = 1 To Len(StringToEnDecrypt)
            If Asc(Mid$(StringToEnDecrypt, i, 1)) < 128 Then
                strTempChar = Asc(Mid$(StringToEnDecrypt, i, 1)) + 128
            ElseIf Asc(Mid$(StringToEnDecrypt, i, 1)) > 128 Then
                strTempChar = Asc(Mid$(StringToEnDecrypt, i, 1)) - 128
            End If
            Mid$(StringToEnDecrypt, i, 1) = Chr(strTempChar)
        Next i
        EnDeCrypt = StringToEnDecrypt
    End Function

End Class
