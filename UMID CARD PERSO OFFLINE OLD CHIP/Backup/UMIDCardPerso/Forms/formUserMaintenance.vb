Public Class formUserMaintenance

    Sub PopulateUsers(ByVal Value As String, ByVal Field As String)

        Dim UserDataTable As DataTable = sUser.PopulateUsers(Value, Field)

        DataTableToListview(listview_UserList, _
                            UserDataTable, _
                            True, True, True, Color.AliceBlue)

        UserDataTable.Dispose()

    End Sub

    Sub PopulateSearchFields()

        combobox_UserFields.Items.Clear()

        For i As Integer = 0 To listview_UserList.Columns.Count - 1
            combobox_UserFields.Items.Add(listview_UserList.Columns(i).Text)
        Next

    End Sub

    Sub PopulateListviewDetails(ByVal LstVwItem As ListViewItem)

        textbox_UserName.Text = LstVwItem.SubItems(1).Text
        textbox_FirstName.Text = LstVwItem.SubItems(2).Text
        textbox_MiddleName.Text = LstVwItem.SubItems(3).Text
        textbox_LastName.Text = LstVwItem.SubItems(4).Text
        combobox_Department.Text = LstVwItem.SubItems(5).Text
        combobox_UserType.Text = LstVwItem.SubItems(6).Text

    End Sub

    Function ValidateUserFields() As Boolean

        If textbox_FirstName.Text.Trim = "" Then
            MessageBox.Show("Please enter a valid First Name", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If textbox_MiddleName.Text.Trim = "" Then
            MessageBox.Show("Please enter a valid Middle Name", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If textbox_LastName.Text.Trim = "" Then
            MessageBox.Show("Please enter a valid Last Name", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If combobox_Department.Text.Trim = "" Then
            MessageBox.Show("Please enter a valid Department", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If textbox_UserName.Text.Trim = "" Then
            MessageBox.Show("Please enter a valid Username", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If combobox_UserType.Text.Trim = "" Then
            MessageBox.Show("Please select a valid User type", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If textbox_UserName.Text.Trim.Length < 6 Then
            MessageBox.Show("Minimum of 6 Characters is allowed for usernames.", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If


        Return True

    End Function

    Private Sub listview_UserList_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles listview_UserList.ColumnClick
        SortListView(listview_UserList, e, Color.AliceBlue)
    End Sub

    Private Sub listview_UserList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listview_UserList.SelectedIndexChanged

        PopulateListviewDetails(listview_UserList.FocusedItem)

        If CBool(listview_UserList.FocusedItem.SubItems(7).Text) Then
            button_DeActivate.Text = "Deactivate"
            DeleteToolStripMenuItem.Enabled = True
            ActivateToolStripMenuItem.Enabled = False
        Else
            button_DeActivate.Text = "Activate"
            DeleteToolStripMenuItem.Enabled = False
            ActivateToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub button_ClearUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_ClearUser.Click
        textbox_UserName.Text = ""
        textbox_FirstName.Text = ""
        combobox_UserType.Text = "USER"
        textbox_MiddleName.Text = ""
        textbox_LastName.Text = ""
        combobox_Department.Text = "PERSONALIZATION"
    End Sub

    Private Sub button_SaveUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_SaveUser.Click

        If Not ValidateUserFields() Then
            Exit Sub
        End If

        Dim currentUserName As String = textbox_UserName.Text.Trim
        Dim NewUser As New ClassUser(ConnectionString)

        NewUser.UserName = textbox_UserName.Text.Trim
        NewUser.UserType = combobox_UserType.Text.Trim
        NewUser.FirstName = textbox_FirstName.Text.Trim
        NewUser.MiddleName = textbox_MiddleName.Text.Trim
        NewUser.LastName = textbox_LastName.Text.Trim
        NewUser.Department = combobox_Department.Text.Trim

        If NewUser.IsExists(currentUserName) Then

            If MessageBox.Show("Do you want to update this record?", "Username: " + currentUserName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                NewUser.Update()

                If NewUser.State Then
                    MessageBox.Show("Update Success...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PopulateUsers("", "ALL")
                Else
                    MessageBox.Show("Update Failed...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If

        Else

            If MessageBox.Show("Do you want to add a new record?", "Username: " + currentUserName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                NewUser.Password = textbox_UserName.Text.Trim
                NewUser.Insert()
                If NewUser.State Then
                    MessageBox.Show("New Record Success...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PopulateUsers("", "ALL")
                Else
                    MessageBox.Show("New Record Failed...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        End If

        NewUser.Dispose()

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        PopulateUsers("", "ALL")
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click

        Try

            If Not CBool(listview_UserList.FocusedItem.SubItems(7).Text) Then
                MessageBox.Show("User already deactivated...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Not sUser.UserName = listview_UserList.FocusedItem.SubItems(1).Text.Trim Then

                If MessageBox.Show("Do you want to deactivate this user?", _
                                   "Username: " + listview_UserList.FocusedItem.SubItems(1).Text.Trim, _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If

                sUser.Deactivate(listview_UserList.FocusedItem.SubItems(1).Text.Trim)

                If sUser.State Then
                    MessageBox.Show("Deactivation Success...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PopulateUsers("", "ALL")
                Else
                    MessageBox.Show("Deactivation Failed...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("User currently in use...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Please select a record first...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ActivateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivateToolStripMenuItem.Click

        Try

            If CBool(listview_UserList.FocusedItem.SubItems(7).Text) Then
                MessageBox.Show("User already active...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Not sUser.UserName = listview_UserList.FocusedItem.SubItems(1).Text.Trim Then

                If MessageBox.Show("Do you want to activate this user?", _
                                   "Username: " + listview_UserList.FocusedItem.SubItems(1).Text.Trim, _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If

                sUser.Activate(listview_UserList.FocusedItem.SubItems(1).Text.Trim)

                If sUser.State Then
                    MessageBox.Show("Activation Success...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PopulateUsers("", "ALL")
                Else
                    MessageBox.Show("Activation Failed...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("User currently in use...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Please select a record first...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub textbox_SearchValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textbox_SearchValue.TextChanged
        If Not combobox_UserFields.Text.Trim = "" Then
            PopulateUsers(textbox_SearchValue.Text.Trim, combobox_UserFields.Text.Trim)
        End If
    End Sub

    Private Sub ResetPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetPasswordToolStripMenuItem.Click

        Try

            If Not sUser.UserName = listview_UserList.FocusedItem.SubItems(1).Text.Trim Then

                If MessageBox.Show("Do you want to reset this user's password?", _
                                   "Username: " + listview_UserList.FocusedItem.SubItems(1).Text.Trim, _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If


                sUser.ResetPassword(listview_UserList.FocusedItem.SubItems(1).Text.Trim, _
                                    listview_UserList.FocusedItem.SubItems(1).Text.Trim)

                If sUser.State Then

                    MessageBox.Show("Reset Password Success...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If Not CBool(listview_UserList.FocusedItem.SubItems(7).Text.Trim) Then
                        If MessageBox.Show("Do you want to activate this user as well?", "User Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            sUser.Activate(listview_UserList.FocusedItem.SubItems(1).Text.Trim)
                        End If
                    End If

                    PopulateUsers("", "ALL")

                Else
                    MessageBox.Show("Reset Password Failed...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("Unable to reset this user's password, User currently in use...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Please select a record first...", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub button_ResetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_ResetPassword.Click
        ResetPasswordToolStripMenuItem.PerformClick()
    End Sub

    Private Sub formUserMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateUsers("", "ALL")
        PopulateSearchFields()
    End Sub

    Private Sub button_DeActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_DeActivate.Click
        If button_DeActivate.Text = "Activate" Then
            ActivateToolStripMenuItem.PerformClick()
        Else
            DeleteToolStripMenuItem.PerformClick()
        End If
    End Sub
End Class