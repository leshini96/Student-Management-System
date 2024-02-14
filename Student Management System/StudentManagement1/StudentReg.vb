Imports System.Data.SqlClient
Public Class StudentReg
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\StudentRegistation.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Display()
        Con.Open()
        Dim query = "Select * from StudentTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd As New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        StdDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Clear()
        F_nameTb.Text = ""
        L_nameTb.Text = ""
        GenCb.SelectedIndex = 0
        EmailTb.Text = ""
        DepCb.SelectedIndex = 0
        phoneTb.Text = ""
        AddressTb.Text = ""
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If F_nameTb.Text = "" Or L_nameTb.Text = "" Or GenCb.SelectedIndex = -1 Or DepCb.SelectedIndex = -1 Or phoneTb.Text = "" Or EmailTb.Text = "" Or AddressTb.Text = "" Then
            MsgBox("Missing Information...")
        Else
            Try
                Con.Open()
                Dim query = "insert into StudentTbl values ('" & F_nameTb.Text & "','" & L_nameTb.Text & "','" & GenCb.SelectedItem.ToString() & "','" & StDOB.Value.Date & "','" & DepCb.SelectedItem.ToString() & "','" & phoneTb.Text & "','" & EmailTb.Text & "','" & AddressTb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Saved")
                Con.Close()
                Display()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub StudentReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub phoneTb_TextChanged(sender As Object, e As EventArgs) Handles phoneTb.TextChanged

    End Sub

    Private Sub phoneTb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phoneTb.KeyPress
        Dim allowednos As String = "1234567890"
        If Not allowednos.Contains(e.KeyChar.ToString) Then
            MessageBox.Show("Please enter a number..!")
            e.KeyChar = ChrW(0)
            e.Handled = True
            phoneTb.Text = ""
        End If

    End Sub

    Private Sub F_nameTb_TextChanged(sender As Object, e As EventArgs) Handles F_nameTb.TextChanged

    End Sub

    Private Sub F_nameTb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles F_nameTb.KeyPress
        Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
        If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
            MessageBox.Show("Please enter a character..!")
            e.KeyChar = ChrW(0)
            e.Handled = True

        End If
    End Sub

    Private Sub L_nameTb_TextChanged(sender As Object, e As EventArgs) Handles L_nameTb.TextChanged

    End Sub

    Private Sub L_nameTb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles L_nameTb.KeyPress
        Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
        If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
            MessageBox.Show("Please enter a Character..!")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If key = 0 Then
            MsgBox("Select The Student")
        Else
            Try
                Con.open()
                Dim query = "delete from StudentTbl where StId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Delete")
                Con.Close()
                Display()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Dim key = 0
    Private Sub StdDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StdDGV.CellContentClick
        Dim row As DataGridViewRow = StdDGV.Rows(e.RowIndex)
        F_nameTb.Text = row.Cells(1).Value.ToString
        L_nameTb.Text = row.Cells(2).Value.ToString
        GenCb.SelectedItem = row.Cells(3).Value.ToString
        StDOB.Text = row.Cells(4).Value.ToString
        DepCb.SelectedItem = row.Cells(5).Value.ToString
        phoneTb.Text = row.Cells(6).Value.ToString
        EmailTb.Text = row.Cells(7).Value.ToString
        AddressTb.Text = row.Cells(8).Value.ToString

        If F_nameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub EmailTb_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmailTb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmailTb.KeyPress
        Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
        Dim allowednos As String = "1234567890"
        Dim allowedsymbols As String = "@."
        If Not allowedchars.Contains(e.KeyChar.ToString.ToString) And Not allowednos.Contains(e.KeyChar.ToString) And Not allowedsymbols.Contains(e.KeyChar.ToString) Then
            MessageBox.Show("Please enter a valid Email Address..!")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If F_nameTb.Text = "" Or L_nameTb.Text = "" Or GenCb.SelectedIndex = -1 Or EmailTb.Text = "" Or DepCb.SelectedIndex = -1 Or phoneTb.Text = "" Or AddressTb.Text = "" Then
            MsgBox("Missing Information...")
        Else
            Try
                Con.Open()
                Dim query = "update StudentTbl set  F_Name = '" & F_nameTb.Text & "', L_Name = '" & L_nameTb.Text & "', StGender = '" & GenCb.SelectedItem.ToString() & "', StDOB = '" & StDOB.Value.Date & "', StDep = '" & DepCb.SelectedItem.ToString() & "', StPhone = '" & phoneTb.Text & "', StEmail = '" & EmailTb.Text & "', StAdd = '" & AddressTb.Text & "' where StId =" & key & " "
                Dim cmd As SqlCommand 
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Upadate")
                Con.Close()
                Display()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Dim teacher = New Teacher
        teacher.Show()
    End Sub
End Class