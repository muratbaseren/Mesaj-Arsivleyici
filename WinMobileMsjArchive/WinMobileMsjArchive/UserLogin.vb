Public Class UserLogin

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim Login As GrilToDatabase = New GrilToDatabase
        'UserID Public degiþkene yazýlýr..
        Module1.UserID = Login.LoginPasswordControl(Me.txtUserName.Text, Me.txtPassword.Text)
        'UserID<>0 dönerse girilen UserName geçerli bir UserName'dir..
        If Not Module1.UserID = 0 Then
            'Kullanýcý adý Publiv UserName adlý deðiþkene aktarýlarak saklanýr..
            Module1.UserName = Me.txtUserName.Text
            'Diðer form'a geçilir..
            Dim frm As MsjWindow = New MsjWindow
            frm.Show()
            'UserName ve Password alanlarý temizlenerek kullanýcý adý ve parola güvenliði saðlanýr..
            Me.txtPassword.Text = ""
            Me.txtUserName.Text = ""
            'Login formu görünmez yapýlýr..
            Me.Visible = False
        Else
            Module1.UserName = ""
            MessageBox.Show("Lütfen Geçerli Bir Kullanýcý Adý ve Þifre Giriniz!!", "Geçersiz Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class