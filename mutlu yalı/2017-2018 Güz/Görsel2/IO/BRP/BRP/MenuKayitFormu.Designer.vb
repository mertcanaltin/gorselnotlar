<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuKayitFormu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainerBRP = New System.Windows.Forms.SplitContainer()
        Me.Fotograf_PBox = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Kategori_CBox = New System.Windows.Forms.ComboBox()
        Me.icerik_TBox = New System.Windows.Forms.TextBox()
        Me.Fiyat_TBox = New System.Windows.Forms.TextBox()
        Me.Menu_Urun_Adi_TBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripButonlar = New System.Windows.Forms.ToolStrip()
        Me.ilkKayitBtn = New System.Windows.Forms.ToolStripButton()
        Me.OncekiBtn = New System.Windows.Forms.ToolStripButton()
        Me.SonrakiBtn = New System.Windows.Forms.ToolStripButton()
        Me.SonKayitBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.YeniKayitBtn = New System.Windows.Forms.ToolStripButton()
        Me.KaydetBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DuzenleBtn = New System.Windows.Forms.ToolStripButton()
        Me.SilBtn = New System.Windows.Forms.ToolStripButton()
        Me.VazgecBtn = New System.Windows.Forms.ToolStripButton()
        Me.MenuDataGridView = New System.Windows.Forms.DataGridView()
        Me.Menu_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Menu_Urun_Adi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fiyat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.icerik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fotograf = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OpenFileDialogBRP = New System.Windows.Forms.OpenFileDialog()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        CType(Me.SplitContainerBRP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerBRP.Panel1.SuspendLayout()
        Me.SplitContainerBRP.Panel2.SuspendLayout()
        Me.SplitContainerBRP.SuspendLayout()
        CType(Me.Fotograf_PBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripButonlar.SuspendLayout()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerBRP
        '
        Me.SplitContainerBRP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerBRP.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.HelpProviderHG.SetHelpKeyword(Me.SplitContainerBRP, "MenuKayitFormu.htm#SplitContainerBRP")
        Me.HelpProviderHG.SetHelpNavigator(Me.SplitContainerBRP, System.Windows.Forms.HelpNavigator.Topic)
        Me.SplitContainerBRP.IsSplitterFixed = True
        Me.SplitContainerBRP.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerBRP.Name = "SplitContainerBRP"
        '
        'SplitContainerBRP.Panel1
        '
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Fotograf_PBox)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Kategori_CBox)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.icerik_TBox)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Fiyat_TBox)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Menu_Urun_Adi_TBox)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.ToolStripButonlar)
        '
        'SplitContainerBRP.Panel2
        '
        Me.SplitContainerBRP.Panel2.Controls.Add(Me.MenuDataGridView)
        Me.HelpProviderHG.SetShowHelp(Me.SplitContainerBRP, True)
        Me.SplitContainerBRP.Size = New System.Drawing.Size(912, 501)
        Me.SplitContainerBRP.SplitterDistance = 500
        Me.SplitContainerBRP.TabIndex = 0
        '
        'Fotograf_PBox
        '
        Me.Fotograf_PBox.BackColor = System.Drawing.Color.Gray
        Me.Fotograf_PBox.Location = New System.Drawing.Point(95, 253)
        Me.Fotograf_PBox.Name = "Fotograf_PBox"
        Me.Fotograf_PBox.Size = New System.Drawing.Size(250, 180)
        Me.Fotograf_PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Fotograf_PBox.TabIndex = 11
        Me.Fotograf_PBox.TabStop = False
        Me.Fotograf_PBox.Tag = "D"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Orange
        Me.Label6.Location = New System.Drawing.Point(351, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 43)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "* Fotoğraf eklemek veya değiştirmek için çift tıklayınız."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Ürün Fotoğrafı:"
        '
        'Kategori_CBox
        '
        Me.Kategori_CBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Kategori_CBox.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.Kategori_CBox, "MenuKayitFormu.htm#Label4")
        Me.HelpProviderHG.SetHelpNavigator(Me.Kategori_CBox, System.Windows.Forms.HelpNavigator.Topic)
        Me.Kategori_CBox.Location = New System.Drawing.Point(95, 216)
        Me.Kategori_CBox.Name = "Kategori_CBox"
        Me.HelpProviderHG.SetShowHelp(Me.Kategori_CBox, True)
        Me.Kategori_CBox.Size = New System.Drawing.Size(250, 21)
        Me.Kategori_CBox.TabIndex = 8
        Me.Kategori_CBox.Tag = "D"
        '
        'icerik_TBox
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.icerik_TBox, "MenuKayitFormu.htm#Label3")
        Me.HelpProviderHG.SetHelpNavigator(Me.icerik_TBox, System.Windows.Forms.HelpNavigator.Topic)
        Me.icerik_TBox.Location = New System.Drawing.Point(95, 112)
        Me.icerik_TBox.Multiline = True
        Me.icerik_TBox.Name = "icerik_TBox"
        Me.HelpProviderHG.SetShowHelp(Me.icerik_TBox, True)
        Me.icerik_TBox.Size = New System.Drawing.Size(387, 98)
        Me.icerik_TBox.TabIndex = 7
        Me.icerik_TBox.Tag = "D"
        '
        'Fiyat_TBox
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.Fiyat_TBox, "MenuKayitFormu.htm#Label2")
        Me.HelpProviderHG.SetHelpNavigator(Me.Fiyat_TBox, System.Windows.Forms.HelpNavigator.Topic)
        Me.Fiyat_TBox.Location = New System.Drawing.Point(95, 86)
        Me.Fiyat_TBox.Name = "Fiyat_TBox"
        Me.HelpProviderHG.SetShowHelp(Me.Fiyat_TBox, True)
        Me.Fiyat_TBox.Size = New System.Drawing.Size(100, 20)
        Me.Fiyat_TBox.TabIndex = 6
        Me.Fiyat_TBox.Tag = "D"
        '
        'Menu_Urun_Adi_TBox
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.Menu_Urun_Adi_TBox, "MenuKayitFormu.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.Menu_Urun_Adi_TBox, System.Windows.Forms.HelpNavigator.Topic)
        Me.Menu_Urun_Adi_TBox.Location = New System.Drawing.Point(95, 60)
        Me.Menu_Urun_Adi_TBox.Name = "Menu_Urun_Adi_TBox"
        Me.HelpProviderHG.SetShowHelp(Me.Menu_Urun_Adi_TBox, True)
        Me.Menu_Urun_Adi_TBox.Size = New System.Drawing.Size(387, 20)
        Me.Menu_Urun_Adi_TBox.TabIndex = 5
        Me.Menu_Urun_Adi_TBox.Tag = "D"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Kategorisi:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ürün İçeriği:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ürün Fiyatı:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ürün Adı:"
        '
        'ToolStripButonlar
        '
        Me.ToolStripButonlar.AutoSize = False
        Me.ToolStripButonlar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStripButonlar.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStripButonlar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ilkKayitBtn, Me.OncekiBtn, Me.SonrakiBtn, Me.SonKayitBtn, Me.ToolStripSeparator1, Me.YeniKayitBtn, Me.KaydetBtn, Me.ToolStripSeparator2, Me.DuzenleBtn, Me.SilBtn, Me.VazgecBtn})
        Me.ToolStripButonlar.Location = New System.Drawing.Point(0, 451)
        Me.ToolStripButonlar.Name = "ToolStripButonlar"
        Me.ToolStripButonlar.Size = New System.Drawing.Size(500, 50)
        Me.ToolStripButonlar.TabIndex = 0
        Me.ToolStripButonlar.Text = "ToolStrip1"
        '
        'ilkKayitBtn
        '
        Me.ilkKayitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ilkKayitBtn.Image = Global.BRP.My.Resources.Resources.ilk_kayit
        Me.ilkKayitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ilkKayitBtn.Name = "ilkKayitBtn"
        Me.ilkKayitBtn.Size = New System.Drawing.Size(52, 47)
        Me.ilkKayitBtn.Text = "İlk Kayıt"
        '
        'OncekiBtn
        '
        Me.OncekiBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OncekiBtn.Image = Global.BRP.My.Resources.Resources.onceki
        Me.OncekiBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OncekiBtn.Name = "OncekiBtn"
        Me.OncekiBtn.Size = New System.Drawing.Size(52, 47)
        Me.OncekiBtn.Text = "Önceki Kayıt"
        '
        'SonrakiBtn
        '
        Me.SonrakiBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SonrakiBtn.Image = Global.BRP.My.Resources.Resources.sonraki
        Me.SonrakiBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SonrakiBtn.Name = "SonrakiBtn"
        Me.SonrakiBtn.Size = New System.Drawing.Size(52, 47)
        Me.SonrakiBtn.Text = "Sonraki Kayıt"
        '
        'SonKayitBtn
        '
        Me.SonKayitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SonKayitBtn.Image = Global.BRP.My.Resources.Resources.son_kayit
        Me.SonKayitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SonKayitBtn.Name = "SonKayitBtn"
        Me.SonKayitBtn.Size = New System.Drawing.Size(52, 47)
        Me.SonKayitBtn.Text = "Son Kayıt"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'YeniKayitBtn
        '
        Me.YeniKayitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.YeniKayitBtn.Image = Global.BRP.My.Resources.Resources.yeni_kayit
        Me.YeniKayitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.YeniKayitBtn.Name = "YeniKayitBtn"
        Me.YeniKayitBtn.Size = New System.Drawing.Size(52, 47)
        Me.YeniKayitBtn.Text = "ToolStripButton5"
        '
        'KaydetBtn
        '
        Me.KaydetBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KaydetBtn.Image = Global.BRP.My.Resources.Resources.kaydet
        Me.KaydetBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(52, 47)
        Me.KaydetBtn.Text = "Değşiklikleri Kaydet"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 50)
        '
        'DuzenleBtn
        '
        Me.DuzenleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DuzenleBtn.Image = Global.BRP.My.Resources.Resources.duzenle
        Me.DuzenleBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DuzenleBtn.Name = "DuzenleBtn"
        Me.DuzenleBtn.Size = New System.Drawing.Size(52, 47)
        Me.DuzenleBtn.Text = "Mevcut Kaydı Düzenle"
        '
        'SilBtn
        '
        Me.SilBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SilBtn.Image = Global.BRP.My.Resources.Resources.sil
        Me.SilBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SilBtn.Name = "SilBtn"
        Me.SilBtn.Size = New System.Drawing.Size(52, 47)
        Me.SilBtn.Text = "Mevcut Kaydı Sil"
        '
        'VazgecBtn
        '
        Me.VazgecBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VazgecBtn.Image = Global.BRP.My.Resources.Resources.vazgec
        Me.VazgecBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.VazgecBtn.Name = "VazgecBtn"
        Me.VazgecBtn.Size = New System.Drawing.Size(52, 47)
        Me.VazgecBtn.Text = "İptal Et"
        '
        'MenuDataGridView
        '
        Me.MenuDataGridView.AllowUserToAddRows = False
        Me.MenuDataGridView.AllowUserToDeleteRows = False
        Me.MenuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Menu_No, Me.Menu_Urun_Adi, Me.Fiyat, Me.icerik, Me.Kategori, Me.Fotograf})
        Me.MenuDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProviderHG.SetHelpKeyword(Me.MenuDataGridView, "MenuKayitFormu.htm#MenuDataGridView")
        Me.HelpProviderHG.SetHelpNavigator(Me.MenuDataGridView, System.Windows.Forms.HelpNavigator.Topic)
        Me.MenuDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MenuDataGridView.Name = "MenuDataGridView"
        Me.MenuDataGridView.ReadOnly = True
        Me.HelpProviderHG.SetShowHelp(Me.MenuDataGridView, True)
        Me.MenuDataGridView.Size = New System.Drawing.Size(408, 501)
        Me.MenuDataGridView.TabIndex = 0
        '
        'Menu_No
        '
        Me.Menu_No.DataPropertyName = "Menu_No"
        Me.Menu_No.HeaderText = "Menü No"
        Me.Menu_No.Name = "Menu_No"
        Me.Menu_No.ReadOnly = True
        Me.Menu_No.Visible = False
        '
        'Menu_Urun_Adi
        '
        Me.Menu_Urun_Adi.DataPropertyName = "Menu_Urun_Adi"
        Me.Menu_Urun_Adi.HeaderText = "Ürün Adı"
        Me.Menu_Urun_Adi.Name = "Menu_Urun_Adi"
        Me.Menu_Urun_Adi.ReadOnly = True
        '
        'Fiyat
        '
        Me.Fiyat.DataPropertyName = "Fiyat"
        Me.Fiyat.HeaderText = "Fiyat"
        Me.Fiyat.Name = "Fiyat"
        Me.Fiyat.ReadOnly = True
        '
        'icerik
        '
        Me.icerik.DataPropertyName = "icerik"
        Me.icerik.HeaderText = "İçeriği"
        Me.icerik.Name = "icerik"
        Me.icerik.ReadOnly = True
        '
        'Kategori
        '
        Me.Kategori.DataPropertyName = "Kategori"
        Me.Kategori.HeaderText = "Kategori"
        Me.Kategori.Name = "Kategori"
        Me.Kategori.ReadOnly = True
        '
        'Fotograf
        '
        Me.Fotograf.DataPropertyName = "Fotograf"
        Me.Fotograf.HeaderText = "Fotoğraf"
        Me.Fotograf.Name = "Fotograf"
        Me.Fotograf.ReadOnly = True
        '
        'OpenFileDialogBRP
        '
        Me.OpenFileDialogBRP.Filter = "JPEG Resim Dosyaları|*.jpg;*.jpeg|PNG Resim Dosyaları|*.png|Desteklenen Tüm Resim" & _
    " Dosyaları|*.jpg;*.jpeg;*.png"
        Me.OpenFileDialogBRP.Title = "Fotoğraf Seç"
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Bip_Restoran_Programi.chm"
        '
        'MenuKayitFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 501)
        Me.Controls.Add(Me.SplitContainerBRP)
        Me.HelpProviderHG.SetHelpKeyword(Me, "MenuKayitFormu.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.MinimumSize = New System.Drawing.Size(900, 540)
        Me.Name = "MenuKayitFormu"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "Menü Kayıt"
        Me.SplitContainerBRP.Panel1.ResumeLayout(False)
        Me.SplitContainerBRP.Panel1.PerformLayout()
        Me.SplitContainerBRP.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerBRP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerBRP.ResumeLayout(False)
        CType(Me.Fotograf_PBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripButonlar.ResumeLayout(False)
        Me.ToolStripButonlar.PerformLayout()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerBRP As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripButonlar As System.Windows.Forms.ToolStrip
    Friend WithEvents ilkKayitBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents OncekiBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents SonrakiBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents SonKayitBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents YeniKayitBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents KaydetBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VazgecBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents SilBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents DuzenleBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Fotograf_PBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Kategori_CBox As System.Windows.Forms.ComboBox
    Friend WithEvents icerik_TBox As System.Windows.Forms.TextBox
    Friend WithEvents Fiyat_TBox As System.Windows.Forms.TextBox
    Friend WithEvents Menu_Urun_Adi_TBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialogBRP As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Menu_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Menu_Urun_Adi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fiyat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents icerik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kategori As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fotograf As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
