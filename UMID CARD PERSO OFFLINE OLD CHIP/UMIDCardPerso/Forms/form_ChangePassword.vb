Public Class form_ChangePassword

    Function ValidateFields() As Boolean

        If textbox_Password.Text.Trim = "" Then
            MessageBox.Show("Please enter old password...", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If textbox_NewPassword.Text.Trim = "" Then
            MessageBox.Show("Please enter new password...", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If textbox_ConfirmPassword.Text.Trim = "" Then
            MessageBox.Show("Please enter confirm password...", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If textbox_NewPassword.Text.Trim.Length < 6 Then
            MessageBox.Show("Minimum of 6 Characters is allowed when creating a new password.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If sUser.Password <> textbox_Password.Text.Trim Then
            MessageBox.Show("Invalid Old Password...", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If textbox_NewPassword.Text.Trim <> textbox_ConfirmPassword.Text.Trim Then
            MessageBox.Show("Please confirm new password...", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If textbox_NewPassword.Text.Trim = textbox_Password.Text.Trim Then
            MessageBox.Show("New password must be different from the old password...", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Return True

    End Function

    Private Sub form_ChangePassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        form_Login.Show()
    End Sub

    Private Sub form_ChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        textbox_UserName.Text = sUser.UserName
        textbox_Password.Text = ""
        textbox_NewPassword.Text = ""
        textbox_ConfirmPassword.Text = ""

    End Sub

    Private Sub button_ChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_ChangePassword.Click

        If Not ValidateFields() Then
            Exit Sub
        End If

        If MessageBox.Show("Do you want to change password now?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        sUser.ResetPassword(textbox_UserName.Text.Trim, textbox_NewPassword.Text.Trim)

        If sUser.State Then
            MessageBox.Show("Change password success...", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Unable to change user password.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_Close.Click
        Me.Close()
    End Sub
End Class