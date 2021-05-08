﻿Imports System.IO
Imports System.IO.Ports



Public Class Form1
    Dim value1 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Close()
        SerialPort1.PortName = "com5"
        SerialPort1.BaudRate = "9600"
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default
        SerialPort1.Open()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim s As String
        s = TextBox1.Text + "," + "," + "," + "," + "," + "," + ""

        Dim somestring() As String
        ' Split string based on comma
        somestring = s.Split(New Char() {","c})

        TextBox2.Text = somestring(0)
        TextBox3.Text = somestring(1)
        TextBox4.Text = somestring(2)
        TextBox5.Text = somestring(3)
        TextBox6.Text = somestring(4)
        TextBox7.Text = somestring(5)
        TextBox1.Text = ""

    End Sub

    Private Sub DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim mydata As String = ""
            mydata = SerialPort1.ReadExisting()

            If TextBox1.InvokeRequired Then
                TextBox1.Invoke(DirectCast(Sub() TextBox1.Text &= mydata, MethodInvoker))
            Else
                TextBox1.Text &= mydata
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If InStr(TextBox2.Text, "p1s1on") Then
            chkp1slot1.Checked = True


        End If

        If InStr(TextBox2.Text, "p1s1off") Then
            chkp1slot1.Checked = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        If InStr(TextBox3.Text, "p1s2on") Then
            chkp1slot2.Checked = True

        End If

        If InStr(TextBox3.Text, "p1s2off") Then
            chkp1slot2.Checked = False
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        If InStr(TextBox4.Text, "p1s3on") Then
            chkp1slot3.Checked = True

        End If

        If InStr(TextBox4.Text, "p1s3off") Then
            chkp1slot3.Checked = False
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged
        If InStr(TextBox5.Text, "p2s1on") Then
            chkp2slot1.Checked = True

        End If

        If InStr(TextBox5.Text, "p2s1off") Then
            chkp2slot1.Checked = False
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        If InStr(TextBox6.Text, "p2s2on") Then
            chkp2slot2.Checked = True

        End If

        If InStr(TextBox6.Text, "p2s2off") Then
            chkp2slot2.Checked = False
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged
        If InStr(TextBox7.Text, "p2s3on") Then
            chkp2slot3.Checked = True

        End If

        If InStr(TextBox7.Text, "p2s3off") Then
            chkp2slot3.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Report.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()


    End Sub

End Class

