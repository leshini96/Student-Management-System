Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtuser.Text = ""
        pass.Text = ""
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtuser.Text = "" Or pass.Text = "" Then
            MsgBox("Enter UserName and Password..")
        ElseIf txtuser.Text = "Admin" And pass.Text = "Password" Then
            Dim obj = New StudentReg
            obj.Show()
            Me.Hide()
        Else
            MsgBox("wrong UserName or Password")
            txtuser.Text = ""
            pass.Text = ""
        End If
    End Sub
End Class