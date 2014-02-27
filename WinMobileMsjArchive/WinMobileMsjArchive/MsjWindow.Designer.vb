<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsjWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MsjWindow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.grpSelectDate = New System.Windows.Forms.GroupBox()
        Me.dtpSelectDate = New System.Windows.Forms.DateTimePicker()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grpMsjView = New System.Windows.Forms.GroupBox()
        Me.lswMsj = New System.Windows.Forms.ListView()
        Me.clmMsjNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmMsjDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmMsjCaption = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmMsjText = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssMsjCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssSelectMsjCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.MenüToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInvisibleSecretMsj = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVisibleSecretMsj = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBackUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMsjBackUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintWebPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintTextFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrintSelectWebPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintSelectTextFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grpMsjProcess = New System.Windows.Forms.GroupBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpMsjDetail = New System.Windows.Forms.GroupBox()
        Me.txtMsjCaptionLength = New System.Windows.Forms.TextBox()
        Me.txtMsjCaption = New System.Windows.Forms.TextBox()
        Me.chkMsjSecret = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpMsjSelectDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpMsjText = New System.Windows.Forms.GroupBox()
        Me.txtMsjTextLength = New System.Windows.Forms.TextBox()
        Me.txtMsjText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.mnuMsjDetail = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddMsj = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSaveMsj = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCancelMsj = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDelMsj = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        Me.grpSelectDate.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpMsjView.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.mnuMenu.SuspendLayout()
        Me.grpMsjProcess.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.grpMsjDetail.SuspendLayout()
        Me.grpMsjText.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblUserName)
        Me.Panel1.Location = New System.Drawing.Point(603, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(109, 41)
        Me.Panel1.TabIndex = 0
        '
        'lblUserName
        '
        Me.lblUserName.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(3, 11)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(103, 19)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpSelectDate
        '
        Me.grpSelectDate.Controls.Add(Me.dtpSelectDate)
        Me.grpSelectDate.Location = New System.Drawing.Point(9, 12)
        Me.grpSelectDate.Name = "grpSelectDate"
        Me.grpSelectDate.Size = New System.Drawing.Size(250, 58)
        Me.grpSelectDate.TabIndex = 1
        Me.grpSelectDate.TabStop = False
        Me.grpSelectDate.Text = "Seçili Gün"
        '
        'dtpSelectDate
        '
        Me.dtpSelectDate.Checked = False
        Me.dtpSelectDate.Location = New System.Drawing.Point(6, 21)
        Me.dtpSelectDate.Name = "dtpSelectDate"
        Me.dtpSelectDate.ShowCheckBox = True
        Me.dtpSelectDate.Size = New System.Drawing.Size(236, 20)
        Me.dtpSelectDate.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 81)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpMsjView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpMsjProcess)
        Me.SplitContainer1.Size = New System.Drawing.Size(724, 455)
        Me.SplitContainer1.SplitterDistance = 228
        Me.SplitContainer1.TabIndex = 2
        '
        'grpMsjView
        '
        Me.grpMsjView.Controls.Add(Me.lswMsj)
        Me.grpMsjView.Controls.Add(Me.StatusStrip1)
        Me.grpMsjView.Controls.Add(Me.mnuMenu)
        Me.grpMsjView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpMsjView.Location = New System.Drawing.Point(0, 0)
        Me.grpMsjView.Name = "grpMsjView"
        Me.grpMsjView.Size = New System.Drawing.Size(724, 202)
        Me.grpMsjView.TabIndex = 3
        Me.grpMsjView.TabStop = False
        Me.grpMsjView.Text = "Mesajlar"
        '
        'lswMsj
        '
        Me.lswMsj.CheckBoxes = True
        Me.lswMsj.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmMsjNo, Me.clmMsjDate, Me.clmMsjCaption, Me.clmMsjText})
        Me.lswMsj.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lswMsj.FullRowSelect = True
        Me.lswMsj.Location = New System.Drawing.Point(3, 40)
        Me.lswMsj.Name = "lswMsj"
        Me.lswMsj.Size = New System.Drawing.Size(718, 137)
        Me.lswMsj.TabIndex = 2
        Me.lswMsj.UseCompatibleStateImageBehavior = False
        Me.lswMsj.View = System.Windows.Forms.View.Details
        '
        'clmMsjNo
        '
        Me.clmMsjNo.Text = "Msj No"
        '
        'clmMsjDate
        '
        Me.clmMsjDate.Text = "Msj Günü"
        Me.clmMsjDate.Width = 80
        '
        'clmMsjCaption
        '
        Me.clmMsjCaption.Text = "Msj Baþlýk"
        Me.clmMsjCaption.Width = 200
        '
        'clmMsjText
        '
        Me.clmMsjText.Text = "Mesaj"
        Me.clmMsjText.Width = 370
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssMsjCount, Me.tssSelectMsjCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 177)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssMsjCount
        '
        Me.tssMsjCount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssMsjCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tssMsjCount.Name = "tssMsjCount"
        Me.tssMsjCount.Size = New System.Drawing.Size(4, 17)
        '
        'tssSelectMsjCount
        '
        Me.tssSelectMsjCount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssSelectMsjCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tssSelectMsjCount.Name = "tssSelectMsjCount"
        Me.tssSelectMsjCount.Size = New System.Drawing.Size(4, 17)
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenüToolStripMenuItem, Me.mnuBackUp, Me.mnuPrint})
        Me.mnuMenu.Location = New System.Drawing.Point(3, 16)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(718, 24)
        Me.mnuMenu.TabIndex = 0
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'MenüToolStripMenuItem
        '
        Me.MenüToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInvisibleSecretMsj, Me.mnuVisibleSecretMsj})
        Me.MenüToolStripMenuItem.Name = "MenüToolStripMenuItem"
        Me.MenüToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenüToolStripMenuItem.Text = "Menü"
        '
        'mnuInvisibleSecretMsj
        '
        Me.mnuInvisibleSecretMsj.Checked = True
        Me.mnuInvisibleSecretMsj.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuInvisibleSecretMsj.Name = "mnuInvisibleSecretMsj"
        Me.mnuInvisibleSecretMsj.Size = New System.Drawing.Size(200, 22)
        Me.mnuInvisibleSecretMsj.Text = "Gizli Mesajlarý Gösterme"
        '
        'mnuVisibleSecretMsj
        '
        Me.mnuVisibleSecretMsj.Name = "mnuVisibleSecretMsj"
        Me.mnuVisibleSecretMsj.Size = New System.Drawing.Size(200, 22)
        Me.mnuVisibleSecretMsj.Text = "Gizli Mesajlarý Göster"
        '
        'mnuBackUp
        '
        Me.mnuBackUp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMsjBackUp})
        Me.mnuBackUp.Name = "mnuBackUp"
        Me.mnuBackUp.Size = New System.Drawing.Size(60, 20)
        Me.mnuBackUp.Text = "Yedekle"
        '
        'mnuMsjBackUp
        '
        Me.mnuMsjBackUp.Name = "mnuMsjBackUp"
        Me.mnuMsjBackUp.Size = New System.Drawing.Size(230, 22)
        Me.mnuMsjBackUp.Text = "Mesaj Veritabaný Yedeðini Al !"
        '
        'mnuPrint
        '
        Me.mnuPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrintWebPage, Me.mnuPrintTextFile, Me.ToolStripMenuItem3, Me.mnuPrintSelectWebPage, Me.mnuPrintSelectTextFile})
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(57, 20)
        Me.mnuPrint.Text = "Yazdýr !"
        '
        'mnuPrintWebPage
        '
        Me.mnuPrintWebPage.Name = "mnuPrintWebPage"
        Me.mnuPrintWebPage.Size = New System.Drawing.Size(284, 22)
        Me.mnuPrintWebPage.Text = "Web Sayfasý Oluþtur"
        '
        'mnuPrintTextFile
        '
        Me.mnuPrintTextFile.Name = "mnuPrintTextFile"
        Me.mnuPrintTextFile.Size = New System.Drawing.Size(284, 22)
        Me.mnuPrintTextFile.Text = "Metin Belgesi Oluþtur"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(281, 6)
        '
        'mnuPrintSelectWebPage
        '
        Me.mnuPrintSelectWebPage.Name = "mnuPrintSelectWebPage"
        Me.mnuPrintSelectWebPage.Size = New System.Drawing.Size(284, 22)
        Me.mnuPrintSelectWebPage.Text = "Seçili Mesajlardan Web Sayfasý Oluþtur"
        '
        'mnuPrintSelectTextFile
        '
        Me.mnuPrintSelectTextFile.Name = "mnuPrintSelectTextFile"
        Me.mnuPrintSelectTextFile.Size = New System.Drawing.Size(284, 22)
        Me.mnuPrintSelectTextFile.Text = "Seçili Mesajlardan Metin Belgesi Oluþtur"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 202)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 26)
        Me.Panel2.TabIndex = 0
        '
        'grpMsjProcess
        '
        Me.grpMsjProcess.Controls.Add(Me.SplitContainer2)
        Me.grpMsjProcess.Controls.Add(Me.MenuStrip2)
        Me.grpMsjProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpMsjProcess.Location = New System.Drawing.Point(0, 0)
        Me.grpMsjProcess.Name = "grpMsjProcess"
        Me.grpMsjProcess.Size = New System.Drawing.Size(724, 223)
        Me.grpMsjProcess.TabIndex = 4
        Me.grpMsjProcess.TabStop = False
        Me.grpMsjProcess.Text = "Mesaj Ekleme \ Düzenleme \ Silme"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 40)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnCancel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpMsjDetail)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnSave)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.grpMsjText)
        Me.SplitContainer2.Size = New System.Drawing.Size(718, 180)
        Me.SplitContainer2.SplitterDistance = 256
        Me.SplitContainer2.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(176, 154)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Ýp&tal"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpMsjDetail
        '
        Me.grpMsjDetail.Controls.Add(Me.txtMsjCaptionLength)
        Me.grpMsjDetail.Controls.Add(Me.txtMsjCaption)
        Me.grpMsjDetail.Controls.Add(Me.chkMsjSecret)
        Me.grpMsjDetail.Controls.Add(Me.Label2)
        Me.grpMsjDetail.Controls.Add(Me.dtpMsjSelectDate)
        Me.grpMsjDetail.Controls.Add(Me.Label1)
        Me.grpMsjDetail.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpMsjDetail.Location = New System.Drawing.Point(0, 0)
        Me.grpMsjDetail.Name = "grpMsjDetail"
        Me.grpMsjDetail.Size = New System.Drawing.Size(256, 149)
        Me.grpMsjDetail.TabIndex = 0
        Me.grpMsjDetail.TabStop = False
        Me.grpMsjDetail.Text = "Mesaj Detaylarý"
        '
        'txtMsjCaptionLength
        '
        Me.txtMsjCaptionLength.Location = New System.Drawing.Point(92, 123)
        Me.txtMsjCaptionLength.Name = "txtMsjCaptionLength"
        Me.txtMsjCaptionLength.ReadOnly = True
        Me.txtMsjCaptionLength.Size = New System.Drawing.Size(33, 20)
        Me.txtMsjCaptionLength.TabIndex = 5
        Me.txtMsjCaptionLength.Text = "50"
        '
        'txtMsjCaption
        '
        Me.txtMsjCaption.Location = New System.Drawing.Point(92, 55)
        Me.txtMsjCaption.MaxLength = 50
        Me.txtMsjCaption.Multiline = True
        Me.txtMsjCaption.Name = "txtMsjCaption"
        Me.txtMsjCaption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMsjCaption.Size = New System.Drawing.Size(159, 65)
        Me.txtMsjCaption.TabIndex = 3
        '
        'chkMsjSecret
        '
        Me.chkMsjSecret.AutoSize = True
        Me.chkMsjSecret.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.chkMsjSecret.Location = New System.Drawing.Point(169, 126)
        Me.chkMsjSecret.Name = "chkMsjSecret"
        Me.chkMsjSecret.Size = New System.Drawing.Size(82, 17)
        Me.chkMsjSecret.TabIndex = 4
        Me.chkMsjSecret.Text = "Mesajý Gizle"
        Me.chkMsjSecret.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mesaj Baþlýk"
        '
        'dtpMsjSelectDate
        '
        Me.dtpMsjSelectDate.Location = New System.Drawing.Point(92, 25)
        Me.dtpMsjSelectDate.Name = "dtpMsjSelectDate"
        Me.dtpMsjSelectDate.Size = New System.Drawing.Size(159, 20)
        Me.dtpMsjSelectDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mesaj Günü"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(92, 154)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "K&aydet"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grpMsjText
        '
        Me.grpMsjText.Controls.Add(Me.txtMsjTextLength)
        Me.grpMsjText.Controls.Add(Me.txtMsjText)
        Me.grpMsjText.Controls.Add(Me.Label3)
        Me.grpMsjText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpMsjText.Location = New System.Drawing.Point(0, 0)
        Me.grpMsjText.Name = "grpMsjText"
        Me.grpMsjText.Size = New System.Drawing.Size(458, 180)
        Me.grpMsjText.TabIndex = 0
        Me.grpMsjText.TabStop = False
        Me.grpMsjText.Text = "Mesaj Metni"
        '
        'txtMsjTextLength
        '
        Me.txtMsjTextLength.Location = New System.Drawing.Point(401, 29)
        Me.txtMsjTextLength.Name = "txtMsjTextLength"
        Me.txtMsjTextLength.ReadOnly = True
        Me.txtMsjTextLength.Size = New System.Drawing.Size(33, 20)
        Me.txtMsjTextLength.TabIndex = 5
        Me.txtMsjTextLength.Text = "800"
        Me.txtMsjTextLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMsjText
        '
        Me.txtMsjText.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtMsjText.Location = New System.Drawing.Point(3, 55)
        Me.txtMsjText.Multiline = True
        Me.txtMsjText.Name = "txtMsjText"
        Me.txtMsjText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMsjText.Size = New System.Drawing.Size(452, 122)
        Me.txtMsjText.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kalan Karakter Sayýsý"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMsjDetail})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(718, 24)
        Me.MenuStrip2.TabIndex = 0
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'mnuMsjDetail
        '
        Me.mnuMsjDetail.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddMsj, Me.ToolStripMenuItem1, Me.mnuSaveMsj, Me.mnuCancelMsj, Me.ToolStripMenuItem2, Me.mnuDelMsj})
        Me.mnuMsjDetail.Name = "mnuMsjDetail"
        Me.mnuMsjDetail.Size = New System.Drawing.Size(50, 20)
        Me.mnuMsjDetail.Text = "Menü"
        '
        'mnuAddMsj
        '
        Me.mnuAddMsj.Name = "mnuAddMsj"
        Me.mnuAddMsj.ShortcutKeyDisplayString = "Ctrl+Y"
        Me.mnuAddMsj.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mnuAddMsj.Size = New System.Drawing.Size(172, 22)
        Me.mnuAddMsj.Text = "Yeni Mesaj"
        Me.mnuAddMsj.ToolTipText = "Yeni Mesaj Eklemenizi Saðlar."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(169, 6)
        '
        'mnuSaveMsj
        '
        Me.mnuSaveMsj.Name = "mnuSaveMsj"
        Me.mnuSaveMsj.ShortcutKeyDisplayString = "Ctrl+K"
        Me.mnuSaveMsj.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.mnuSaveMsj.Size = New System.Drawing.Size(172, 22)
        Me.mnuSaveMsj.Text = "Kaydet"
        Me.mnuSaveMsj.ToolTipText = "Mesajlar Kýsmýndan Seçtiðiniz Mesaj ÜZerinde Yaptýðýnýz Deðiþiklikleri Kaydetmeni" & _
            "zi Saðlar."
        '
        'mnuCancelMsj
        '
        Me.mnuCancelMsj.Name = "mnuCancelMsj"
        Me.mnuCancelMsj.ShortcutKeyDisplayString = "Ctrl+P"
        Me.mnuCancelMsj.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuCancelMsj.Size = New System.Drawing.Size(172, 22)
        Me.mnuCancelMsj.Text = "Ýptal"
        Me.mnuCancelMsj.ToolTipText = "Yeni Mesaj Ekleme Veya Kaydetme Ýþlemini Þptal Etmenizi Saðlar."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(169, 6)
        '
        'mnuDelMsj
        '
        Me.mnuDelMsj.Name = "mnuDelMsj"
        Me.mnuDelMsj.ShortcutKeyDisplayString = "Ctrl+S"
        Me.mnuDelMsj.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuDelMsj.Size = New System.Drawing.Size(172, 22)
        Me.mnuDelMsj.Text = "Sil"
        Me.mnuDelMsj.ToolTipText = "Kayýtlý Bir Mesajý Siler."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MsjWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 536)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.grpSelectDate)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "MsjWindow"
        Me.Text = "Mobile Cihaz Mesaj Metni Görüntüleyici"
        Me.Panel1.ResumeLayout(False)
        Me.grpSelectDate.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpMsjView.ResumeLayout(False)
        Me.grpMsjView.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.grpMsjProcess.ResumeLayout(False)
        Me.grpMsjProcess.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.grpMsjDetail.ResumeLayout(False)
        Me.grpMsjDetail.PerformLayout()
        Me.grpMsjText.ResumeLayout(False)
        Me.grpMsjText.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents grpSelectDate As System.Windows.Forms.GroupBox
    Friend WithEvents dtpSelectDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grpMsjView As System.Windows.Forms.GroupBox
    Friend WithEvents grpMsjProcess As System.Windows.Forms.GroupBox
    Friend WithEvents lswMsj As System.Windows.Forms.ListView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents clmMsjNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmMsjDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmMsjCaption As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmMsjText As System.Windows.Forms.ColumnHeader
    Friend WithEvents tssMsjCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenüToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInvisibleSecretMsj As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVisibleSecretMsj As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents grpMsjDetail As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpMsjSelectDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpMsjText As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents chkMsjSecret As System.Windows.Forms.CheckBox
    Friend WithEvents txtMsjCaption As System.Windows.Forms.TextBox
    Friend WithEvents txtMsjText As System.Windows.Forms.TextBox
    Friend WithEvents txtMsjCaptionLength As System.Windows.Forms.TextBox
    Friend WithEvents mnuMsjDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAddMsj As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSaveMsj As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCancelMsj As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDelMsj As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtMsjTextLength As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tssSelectMsjCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuBackUp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMsjBackUp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrintWebPage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrintTextFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuPrintSelectWebPage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrintSelectTextFile As System.Windows.Forms.ToolStripMenuItem
End Class
