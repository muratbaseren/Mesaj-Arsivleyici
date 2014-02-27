Public Class MsjWindow

#Region "Local Variables"
    Private MsjVisible As Integer = 0
    Private MsjID As Integer
    Private Mode = "Update"
    Private SelectPrint As Boolean = False
#End Region

#Region "Methods"
    Private Sub SecretMsjVisibleInvisible()
        If Me.mnuInvisibleSecretMsj.Checked Then
            MsjVisible = 0
        ElseIf Me.mnuVisibleSecretMsj.Checked Then
            MsjVisible = 1
        End If
    End Sub

    Private Sub FillLswMsj()
        Me.lblUserName.Text = Module1.UserName
        Dim GTD As GrilToDatabase = New GrilToDatabase
        Dim Dt As DataTable = New DataTable

        Me.lswMsj.Items.Clear()

        If Me.dtpSelectDate.Checked = False Then
            Dt = GTD.ReadToMsj("exec sp_AllMsjNoDate " & Module1.UserID & "," & MsjVisible)
        Else 
            Dt = GTD.ReadToMsj("exec sp_AllMsjDate " & Module1.UserID & "," & MsjVisible & ",'" & Me.dtpSelectDate.Value.ToShortTimeString & "'")
        End If
        For i As Integer = 0 To Dt.Rows.Count - 1
            Me.lswMsj.Items.Add(Dt.Rows(i)(0).ToString)
            Me.lswMsj.Items(i).SubItems.Add(Dt.Rows(i)(1).ToString)
            Me.lswMsj.Items(i).SubItems.Add(Dt.Rows(i)(2).ToString)
            Me.lswMsj.Items(i).SubItems.Add(Dt.Rows(i)(3).ToString)
        Next
        Me.tssSelectMsjCount.Text = Me.lswMsj.CheckedItems.Count & " Adet Kayýt Seçilidir."
        Me.tssMsjCount.Text = Me.lswMsj.Items.Count & " Adet Mesaj Vardýr.."
    End Sub

    Private Sub MsjSendProcess(ByVal Query As String)
        Dim DGT As GrilToDatabase = New GrilToDatabase

        Dim QueryType As String = ""
        If Mode = "Update" Then
            QueryType = "Güncelleþtirme"
        ElseIf Mode = "Add" Then
            QueryType = "Kayýt Giriþi"
        ElseIf Mode = "Del" Then
            QueryType = "Kayýt Silme"
        End If

        If Not Query = "" Then
            If DGT.DataInsUpdDel(Query) = 0 Then
                MessageBox.Show(QueryType & " iþlemi gerçekleþtirilemedi.", QueryType, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(QueryType & " iþlemi gerçekleþtirildi.", QueryType, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub EnableDisableMnuItems()
        If Mode = "Add" Then
            Me.mnuAddMsj.Enabled = False
            Me.mnuDelMsj.Enabled = False
        ElseIf Mode = "Update" Then
            Me.mnuAddMsj.Enabled = True
            Me.mnuDelMsj.Enabled = True
        End If
    End Sub

    Private Sub ResetField()
        Me.dtpMsjSelectDate.Value = Now.ToShortDateString
        Me.txtMsjCaption.Text = ""
        Me.txtMsjText.Text = ""
    End Sub

    Private Function CreateDataTable() As DataTable
        Dim myDT As DataTable = New DataTable
        Dim DC As DataColumn
        Dim DR As DataRow

        For i As Integer = 0 To Me.lswMsj.Columns.Count - 1
            DC = New DataColumn
            DC.Caption = Me.lswMsj.Columns.Item(i).Text
            myDT.Columns.Add(DC)
        Next

        If SelectPrint = False Then
            For i As Integer = 0 To Me.lswMsj.Items.Count - 1
                DR = myDT.NewRow
                For j As Integer = 0 To Me.lswMsj.Columns.Count - 1
                    DR.Item(0) = Me.lswMsj.Items(i).SubItems(0).Text
                    DR.Item(1) = Me.lswMsj.Items(i).SubItems(1).Text
                    DR.Item(2) = Me.lswMsj.Items(i).SubItems(2).Text
                    DR.Item(3) = Me.lswMsj.Items(i).SubItems(3).Text
                Next
                myDT.Rows.Add(DR)
            Next
        Else
            For i As Integer = 0 To Me.lswMsj.CheckedItems.Count - 1
                DR = myDT.NewRow
                For j As Integer = 0 To Me.lswMsj.Columns.Count - 1
                    DR.Item(0) = Me.lswMsj.CheckedItems(i).SubItems(0).Text
                    DR.Item(1) = Me.lswMsj.CheckedItems(i).SubItems(1).Text
                    DR.Item(2) = Me.lswMsj.CheckedItems(i).SubItems(2).Text
                    DR.Item(3) = Me.lswMsj.CheckedItems(i).SubItems(3).Text
                Next
                myDT.Rows.Add(DR)
            Next
        End If
        Return myDT
    End Function
#End Region

#Region "Events"
    Private Sub MsjWindow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Module1.UserID = 0
        UserLogin.Visible = True
    End Sub

    Private Sub MsjWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillLswMsj()
        'Me.lblUserName.Text = Module1.UserName
    End Sub

    Private Sub mnuInvisibleSecretMsj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInvisibleSecretMsj.Click
        If Not mnuInvisibleSecretMsj.Checked = True Then
            Me.mnuVisibleSecretMsj.Checked = False
            Me.mnuInvisibleSecretMsj.Checked = True
            SecretMsjVisibleInvisible()
            FillLswMsj()
        End If
    End Sub

    Private Sub mnuVisibleSecretMsj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVisibleSecretMsj.Click
        Dim writePass As String = InputBox("Lütfen Ýkinci Seviye Þifresini Giriniz!!", "Þifre Giriþi")
        Dim Login As GrilToDatabase = New GrilToDatabase
        Dim Pass As String = Login.SecondLevelPasswordControl

        If writePass = Pass Then
            If Not mnuVisibleSecretMsj.Checked = True Then
                Me.mnuInvisibleSecretMsj.Checked = False
                Me.mnuVisibleSecretMsj.Checked = True
                SecretMsjVisibleInvisible()
                FillLswMsj()
            End If
        Else
            MessageBox.Show("Ýkinci Seviyeye Geçip, Gizli Mesajlarý Görüntüleyebilecek Yetkiye SahipBir Kullanýcý Deðilisiniz!!", "Geçersiz Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub dtpSelectDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpSelectDate.ValueChanged
        FillLswMsj()
    End Sub

    Private Sub lswMsj_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lswMsj.ItemChecked
        Me.tssSelectMsjCount.Text = Me.lswMsj.CheckedItems.Count & " Adet Kayýt Seçilidir."
    End Sub

    Private Sub lswMsj_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lswMsj.SelectedIndexChanged
        If Not Me.lswMsj.SelectedItems.Count = 0 Then
            Dim itm As ListViewItem = New ListViewItem
            itm = Me.lswMsj.SelectedItems(0)

            MsjID = CInt(itm.SubItems(0).Text)
            Me.dtpMsjSelectDate.Value = CType(itm.SubItems(1).Text, Date).ToShortDateString
            Me.txtMsjCaption.Text = itm.SubItems(2).Text
            Me.txtMsjText.Text = itm.SubItems(3).Text

            Me.txtMsjCaptionLength.Text = 50 - Len(Me.txtMsjCaption.Text)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Qry As String = ""
        Dim msjVis As Integer

        If Me.chkMsjSecret.Checked Then
            msjVis = 0
        Else
            msjVis = 1
        End If

        If Mode = "Update" Then
            'Update sorgusu oluþturulur..
            Qry = "UPDATE Msj SET  msj_User=" & Module1.UserID & ", msj_Date='" & Me.dtpMsjSelectDate.Value.ToShortDateString & "', msj_Caption='" & Me.txtMsjCaption.Text & "', msj_Text='" & Me.txtMsjText.Text & "', msj_Visible=" & msjVis & " WHERE msj_ID=" & MsjID

            'Sorgunun çalýþtýrýlmasý için genel sub a gönderilir.
            MsjSendProcess(Qry)
        ElseIf Mode = "Add" Then
            Qry = "INSERT INTO Msj(msj_User, msj_Date, msj_Caption, msj_Text, msj_Visible) VALUES (" & Module1.UserID & ",'" & Me.dtpMsjSelectDate.Value.ToShortDateString & "','" & Me.txtMsjCaption.Text & "','" & Me.txtMsjText.Text & "'," & msjVis & ")"

            'Sorgunun çalýþtýrýlmasý için genel sub a gönderilir.
            MsjSendProcess(Qry)
            ResetField()
        End If

        'Listenin yenilenmesi..
        FillLswMsj()
        Mode = "Update"
        EnableDisableMnuItems()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Mode = "Update"
        EnableDisableMnuItems()
        ResetField()
    End Sub

    Private Sub txtMsjText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMsjText.TextChanged
        Me.txtMsjTextLength.Text = 800 - Len(Me.txtMsjText.Text)
    End Sub

    Private Sub txtMsjCaption_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMsjCaption.TextChanged
        Me.txtMsjCaptionLength.Text = 50 - Len(Me.txtMsjCaption.Text)
    End Sub

    Private Sub mnuAddMsj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddMsj.Click
        Mode = "Add"
        EnableDisableMnuItems()
    End Sub

    Private Sub mnuSaveMsj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaveMsj.Click
        btnSave_Click(sender, e)
    End Sub

    Private Sub mnuCancelMsj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCancelMsj.Click
        btnCancel_Click(sender, e)
    End Sub

    Private Sub mnuDelMsj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelMsj.Click
        DialogResult = MessageBox.Show("Seçili Mesajý silmek istediðinize emin misiniz?", "Mesaj Silme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If DialogResult = Windows.Forms.DialogResult.Yes Then
            Mode = "Del"
            Dim Qry As String = ""

            'Delete sorgusu oluþturulur..
            Qry = "DELETE FROM Msj" & " WHERE msj_ID=" & MsjID

            'Sorgunun çalýþtýrýlmasý için genel sub a gönderilir.
            MsjSendProcess(Qry)
        End If

        Mode = "Update"
        FillLswMsj()
        ResetField()
    End Sub

    Private Sub mnuMsjBackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMsjBackUp.Click

        Me.SaveFileDialog1.Filter = "Yedekleme Dosyalarý(*.bac;*.bak)|*.bac;*.bak"
        Me.SaveFileDialog1.Title = "Mesaj Veritabaný Yedekleme"

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'MsgBox("exec sp_BackUp '" & Me.SaveFileDialog1.FileName.ToString & "'")
            Dim GTD As GrilToDatabase = New GrilToDatabase
            If GTD.DataInsUpdDel("exec sp_BackUp '" & Me.SaveFileDialog1.FileName.ToString & "'") = 0 Then
                MessageBox.Show("Mesaj Veritabaný Yedekleme Ýþlemi Baþarýyla Gerçekleþtirildi..", "Yedekleme Baþarýlý !", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show("Mesaj Veritabaný Yedekleme Ýþlemi Gerçekleþtirilemedi..", "Yedekleme Baþarýsýz !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        End If

    End Sub

    Private Sub mnuPrintWebPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintWebPage.Click
        Me.SaveFileDialog1.Filter = "HTML Web Sayfasý(*.html)|*.html"
        Me.SaveFileDialog1.Title = "HTML Dosya Kaydet"

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileCopy(Application.StartupPath & "\aaa.html", Me.SaveFileDialog1.FileName)

            Dim DT As DataTable = New DataTable
            DT = CreateDataTable()
            Dim printTable As FileWriter.FileWriting = New FileWriter.FileWriting
            printTable.CreateHTMLFile(DT, Me.SaveFileDialog1.FileName.ToString)

            DialogResult = MessageBox.Show("Kaydedilen dosyayý açmak istermisiniz?", "Kayýtlý Dosyayý Aç", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If DialogResult = Windows.Forms.DialogResult.Yes Then
                Shell("explorer.exe " & Me.SaveFileDialog1.FileName, AppWinStyle.MaximizedFocus)
            End If
        End If
        SelectPrint = False
    End Sub

    Private Sub mnuPrintTextFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintTextFile.Click
        Me.SaveFileDialog1.Filter = "Metin Belgesi(*.txt)|*.txt"
        Me.SaveFileDialog1.Title = "Metin Dosyasý Kaydet"

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim DT As DataTable = New DataTable
            DT = CreateDataTable()
            Dim printTable As FileWriter.FileWriting = New FileWriter.FileWriting
            printTable.CreateTEXTFile(DT, Me.SaveFileDialog1.FileName.ToString)

            DialogResult = MessageBox.Show("Kaydedilen dosyayý açmak istermisiniz?", "Kayýtlý Dosyayý Aç", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If DialogResult = Windows.Forms.DialogResult.Yes Then
                Shell("notepad.exe " & Me.SaveFileDialog1.FileName, AppWinStyle.MaximizedFocus)
            End If
        End If
        SelectPrint = False
    End Sub

    Private Sub mnuPrintSelectWebPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintSelectWebPage.Click
        Me.SelectPrint = True
        mnuPrintWebPage_Click(sender, e)
    End Sub

    Private Sub mnuPrintSelectTextFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintSelectTextFile.Click
        Me.SelectPrint = True
        mnuPrintTextFile_Click(sender, e)
    End Sub
#End Region

End Class