Public Class form_Login


    Function TestConnection() As Boolean
        'Dim DataConnection As New DataConnection
        'DataConnection.ConnectionString = ConnectionString()
        'If Not DataConnection.OpenConnection Then
        '    MessageBox.Show("Unable to connect to database server...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return False
        'Else
        '    DataConnection.CloseConnection()
        '    Return True
        'End If

        Return True
    End Function

    Sub OfflineLogIn()
        If textbox_UserName.Text = "operator" And textbox_Password.Text = "umidoffline" Then
            sUser = New ClassUser("")
            sUser.UserName = "OPERATOR"
            sUser.FirstName = "OPERATOR OFFLINE"
            sUser.Department = "OFFLINE"
            sUser.UserType = "USER"
            formMain.Show()
            Me.Close()
        ElseIf textbox_UserName.Text.Trim = "admin" And textbox_Password.Text.Trim = "allcardtech" Then
            sUser = New ClassUser("")
            sUser.UserName = "ADMIN"
            sUser.FirstName = "ADMIN OFFLINE"
            sUser.Department = "MIS"
            sUser.UserType = "ADMINISTRATOR"
            formMain.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid Offline Credentials...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub UsualLogin()

        If sUser.Login(textbox_UserName.Text.Trim) Then

            If Not sUser.UserActive Then
                MessageBox.Show("User is currently deactivated...", "Contact System Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Not sUser.Password = textbox_Password.Text.Trim Then
                MessageBox.Show("Invalid password...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If sUser.UserName = sUser.Password Then
                MessageBox.Show("Please change your password now...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                form_ChangePassword.ShowDialog()
                form_ChangePassword.Close()
                Exit Sub
            End If
            formMain.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid username...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub button_LogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_LogIn.Click
        'If Offline Then
        OfflineLogIn()
        'Else
        'UsualLogin()
        'End If
    End Sub

    Private Sub textbox_UserName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles textbox_UserName.GotFocus, textbox_Password.GotFocus
        SendKeys.Send("{HOME}+{END}")
    End Sub

    Private Sub textbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles textbox_UserName.KeyPress, textbox_Password.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            button_LogIn.PerformClick()
        End If
    End Sub

    Private Sub link_ChangePassword_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_ChangePassword.LinkClicked

        If Offline Then
            MessageBox.Show("You are currently using the offline version of this application.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If sUser.Login(textbox_UserName.Text.Trim) Then

            If Not sUser.UserActive Then
                MessageBox.Show("User is currently deactivated...", "Contact System Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Not sUser.Password = textbox_Password.Text.Trim Then
                MessageBox.Show("Invalid password...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            form_ChangePassword.Show()
            Me.Close()

        Else
            MessageBox.Show("Invalid username...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub form_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Offline = Not TestConnection()
        If Not Offline Then
            sUser = New ClassUser(ConnectionString)
        End If
    End Sub

    Private Sub button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_Close.Click
        Me.Close()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class