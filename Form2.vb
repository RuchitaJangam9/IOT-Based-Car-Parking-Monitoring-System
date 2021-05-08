Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label8.Text = Format(Now, "dd/MM/yyyy")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label9.Text = Format(Now, "hh:mm:ss")


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Label10.Text = Format(DateTimePicker1.Value)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
                And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            TextBox1.Text = UCase$(TextBox1.Text)
            MessageBox.Show("you can only inuput letter!")

        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MessageBox.Show("you can only inuput letter!")

        End If

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then


            e.Handled = True
            MessageBox.Show("you can only inuput letter!")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim query As String
            Dim DataSet1 As New DataTable


            con.ConnectionString = " Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\sem6pro\sem6\test1\WindowsApplication1\WindowsApplication1\Database1.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd = New SqlCommand("INSERT INTO Table1 values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & Label8.Text & "','" & Label9.Text & "','" & RadioButton1.Text & "')", con)
            cmd.ExecuteNonQuery()
            If (TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" And Label8.Text = "" And Label9.Text = "") Then

                MessageBox.Show("Please Enter Details")

            Else

                MsgBox("Successfully Registered.", MsgBoxStyle.Information, "Success")
                Me.Hide()
                Form1.Show()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                Label8.Text = ""
                Label9.Text = ""
                Label10.Text = ""

            End If
            con.Close()
        Catch ex As Exception
            MsgBox("please Enter Correct Details")
        End Try


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        Label8.Text = ""
        Label9.Text = ""
        Label10.Text = ""
    End Sub
End Class