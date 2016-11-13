Public Class Form1
    
    Dim a, b, hafıza As Decimal
    Dim işlem As Char
    Dim durum, durum2, sayı As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butlöıbfuı.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = 0
        b = 0
        TextBox1.Text = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If durum = True Then
            a = CDec(TextBox1.Text)
            TextBox1.Text = sender.text
            durum = False
            durum2 = True
        Else
            TextBox1.Text = TextBox1.Text + sender.text

        End If
        sayı = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If durum2 = True Then
            b = CDec(TextBox1.Text)

        End If

        If işlem = "+" Then TextBox1.Text = a + b
        If işlem = "-" Then TextBox1.Text = a - b
        If işlem = "*" Then TextBox1.Text = a * b
        If işlem = "/" Then TextBox1.Text = a / b

        işlem = "/"
        durum = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If durum2 = True Then
            b = CDec(TextBox1.Text)

        End If

        If işlem = "+" Then TextBox1.Text = a + b
        If işlem = "-" Then TextBox1.Text = a - b
        If işlem = "*" Then TextBox1.Text = a * b
        If işlem = "/" Then TextBox1.Text = a / b

        işlem = "*"
        durum = True
    End Sub
End Class
