Public Class butlöıbfuı

    Private Sub butlöıbfuı_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hbfkkhb.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = (TextBox1.Text) ^ (1 / 3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label1.Text = (TextBox1.Text)
    End Sub
    Dim sayilar(9) As Single
    Dim geoOrt, harOrt, carpim, sayac1, sayac2, payda As Single
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        carpim = 1
        For sayac1 = 0 To 9   'www.google.com
            sayilar(sayac1) = CSng(InputBox((sayac1 + 1) & ".Sayı giriniz "))
        Next
        For sayac2 = 0 To 9
            carpim = carpim * sayilar(sayac2)   'www.youtube.com
            payda = payda + (1 / sayilar(sayac2))
        Next
        geoOrt = Math.Pow(carpim, (1 / sayilar.Length))
        harOrt = sayilar.Length / payda   'www.facebook.com
        MessageBox.Show("Geometrik Ortalama = " & geoOrt & vbCrLf & "Harmonik Ortalama = " & harOrt)
    End Sub
End Class