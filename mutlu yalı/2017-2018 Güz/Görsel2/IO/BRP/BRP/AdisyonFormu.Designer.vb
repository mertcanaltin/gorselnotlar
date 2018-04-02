<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdisyonFormu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdisyonFormu))
        Me.SplitContainerBRP = New System.Windows.Forms.SplitContainer()
        Me.ButtonAdisyonKapat = New System.Windows.Forms.Button()
        Me.ButtonSiparisEkle = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Adisyon_Detay_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adisyon_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Menu_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fiyat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Toplam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aciklama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaskedTextBoxTarihSaat = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxTutar = New System.Windows.Forms.TextBox()
        Me.TextBoxKisiSayisi = New System.Windows.Forms.TextBox()
        Me.ComboBoxGarson = New System.Windows.Forms.ComboBox()
        Me.LabelMasa_No = New System.Windows.Forms.Label()
        Me.TextBoxAdisyon_No = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imageListBRP = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStripBRP = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AdisyonAçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MasaDeğiştirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RezervasyonYapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        CType(Me.SplitContainerBRP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerBRP.Panel1.SuspendLayout()
        Me.SplitContainerBRP.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripBRP.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerBRP
        '
        Me.SplitContainerBRP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerBRP.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.HelpProviderHG.SetHelpKeyword(Me.SplitContainerBRP, "AdisyonFormu.htm#SplitContainerBRP")
        Me.HelpProviderHG.SetHelpNavigator(Me.SplitContainerBRP, System.Windows.Forms.HelpNavigator.Topic)
        Me.SplitContainerBRP.IsSplitterFixed = True
        Me.SplitContainerBRP.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerBRP.Name = "SplitContainerBRP"
        '
        'SplitContainerBRP.Panel1
        '
        Me.SplitContainerBRP.Panel1.BackColor = System.Drawing.Color.Gray
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.ButtonAdisyonKapat)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.ButtonSiparisEkle)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.DataGridView1)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.MaskedTextBoxTarihSaat)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.TextBoxTutar)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.TextBoxKisiSayisi)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.ComboBoxGarson)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.LabelMasa_No)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.TextBoxAdisyon_No)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.Label1)
        Me.HelpProviderHG.SetShowHelp(Me.SplitContainerBRP, True)
        Me.SplitContainerBRP.Size = New System.Drawing.Size(1135, 456)
        Me.SplitContainerBRP.SplitterDistance = 300
        Me.SplitContainerBRP.TabIndex = 1
        '
        'ButtonAdisyonKapat
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.ButtonAdisyonKapat, "AdisyonFormu.htm#ButtonAdisyonKapat")
        Me.HelpProviderHG.SetHelpNavigator(Me.ButtonAdisyonKapat, System.Windows.Forms.HelpNavigator.Topic)
        Me.ButtonAdisyonKapat.Location = New System.Drawing.Point(152, 392)
        Me.ButtonAdisyonKapat.Name = "ButtonAdisyonKapat"
        Me.HelpProviderHG.SetShowHelp(Me.ButtonAdisyonKapat, True)
        Me.ButtonAdisyonKapat.Size = New System.Drawing.Size(141, 35)
        Me.ButtonAdisyonKapat.TabIndex = 15
        Me.ButtonAdisyonKapat.Text = "Adisyonu Kapat"
        Me.ButtonAdisyonKapat.UseVisualStyleBackColor = True
        '
        'ButtonSiparisEkle
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.ButtonSiparisEkle, "AdisyonFormu.htm#ButtonSiparisEkle")
        Me.HelpProviderHG.SetHelpNavigator(Me.ButtonSiparisEkle, System.Windows.Forms.HelpNavigator.Topic)
        Me.ButtonSiparisEkle.Location = New System.Drawing.Point(3, 392)
        Me.ButtonSiparisEkle.Name = "ButtonSiparisEkle"
        Me.HelpProviderHG.SetShowHelp(Me.ButtonSiparisEkle, True)
        Me.ButtonSiparisEkle.Size = New System.Drawing.Size(141, 35)
        Me.ButtonSiparisEkle.TabIndex = 14
        Me.ButtonSiparisEkle.Text = "Sipariş Ekle"
        Me.ButtonSiparisEkle.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Adisyon_Detay_No, Me.Adisyon_No, Me.Menu_No, Me.Adet, Me.Fiyat, Me.Toplam, Me.Aciklama})
        Me.HelpProviderHG.SetHelpKeyword(Me.DataGridView1, "AdisyonFormu.htm#DataGridView1")
        Me.HelpProviderHG.SetHelpNavigator(Me.DataGridView1, System.Windows.Forms.HelpNavigator.Topic)
        Me.DataGridView1.Location = New System.Drawing.Point(3, 205)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.HelpProviderHG.SetShowHelp(Me.DataGridView1, True)
        Me.DataGridView1.Size = New System.Drawing.Size(290, 181)
        Me.DataGridView1.TabIndex = 13
        '
        'Adisyon_Detay_No
        '
        Me.Adisyon_Detay_No.DataPropertyName = "Adisyon_Detay_No"
        Me.Adisyon_Detay_No.HeaderText = "Adisyon Detay No"
        Me.Adisyon_Detay_No.Name = "Adisyon_Detay_No"
        Me.Adisyon_Detay_No.Visible = False
        '
        'Adisyon_No
        '
        Me.Adisyon_No.DataPropertyName = "Adisyon_No"
        Me.Adisyon_No.HeaderText = "Adisyon No"
        Me.Adisyon_No.Name = "Adisyon_No"
        Me.Adisyon_No.Visible = False
        '
        'Menu_No
        '
        Me.Menu_No.DataPropertyName = "Menu_No"
        Me.Menu_No.HeaderText = "Menü Ürün"
        Me.Menu_No.Name = "Menu_No"
        Me.Menu_No.ReadOnly = True
        Me.Menu_No.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Menu_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Adet
        '
        Me.Adet.DataPropertyName = "Adet"
        Me.Adet.HeaderText = "Adet"
        Me.Adet.Name = "Adet"
        '
        'Fiyat
        '
        Me.Fiyat.DataPropertyName = "Fiyat"
        Me.Fiyat.HeaderText = "Fiyat"
        Me.Fiyat.Name = "Fiyat"
        Me.Fiyat.ReadOnly = True
        '
        'Toplam
        '
        Me.Toplam.DataPropertyName = "Toplam"
        Me.Toplam.HeaderText = "Toplam"
        Me.Toplam.Name = "Toplam"
        '
        'Aciklama
        '
        Me.Aciklama.DataPropertyName = "Aciklama"
        Me.Aciklama.HeaderText = "Açıklama"
        Me.Aciklama.Name = "Aciklama"
        '
        'MaskedTextBoxTarihSaat
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.MaskedTextBoxTarihSaat, "AdisyonFormu.htm#MaskedTextBoxTarihSaat")
        Me.HelpProviderHG.SetHelpNavigator(Me.MaskedTextBoxTarihSaat, System.Windows.Forms.HelpNavigator.Topic)
        Me.MaskedTextBoxTarihSaat.Location = New System.Drawing.Point(78, 141)
        Me.MaskedTextBoxTarihSaat.Mask = "00/00/0000 90:00"
        Me.MaskedTextBoxTarihSaat.Name = "MaskedTextBoxTarihSaat"
        Me.MaskedTextBoxTarihSaat.ReadOnly = True
        Me.HelpProviderHG.SetShowHelp(Me.MaskedTextBoxTarihSaat, True)
        Me.MaskedTextBoxTarihSaat.Size = New System.Drawing.Size(215, 20)
        Me.MaskedTextBoxTarihSaat.TabIndex = 12
        Me.MaskedTextBoxTarihSaat.Text = "081220172000"
        Me.MaskedTextBoxTarihSaat.ValidatingType = GetType(Date)
        '
        'TextBoxTutar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxTutar, "AdisyonFormu.htm#Label6")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxTutar, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxTutar.Location = New System.Drawing.Point(78, 170)
        Me.TextBoxTutar.Name = "TextBoxTutar"
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxTutar, True)
        Me.TextBoxTutar.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxTutar.TabIndex = 11
        '
        'TextBoxKisiSayisi
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxKisiSayisi, "AdisyonFormu.htm#Label4")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxKisiSayisi, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxKisiSayisi.Location = New System.Drawing.Point(78, 112)
        Me.TextBoxKisiSayisi.Name = "TextBoxKisiSayisi"
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxKisiSayisi, True)
        Me.TextBoxKisiSayisi.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxKisiSayisi.TabIndex = 9
        '
        'ComboBoxGarson
        '
        Me.ComboBoxGarson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGarson.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.ComboBoxGarson, "AdisyonFormu.htm#Label3")
        Me.HelpProviderHG.SetHelpNavigator(Me.ComboBoxGarson, System.Windows.Forms.HelpNavigator.Topic)
        Me.ComboBoxGarson.Location = New System.Drawing.Point(78, 83)
        Me.ComboBoxGarson.Name = "ComboBoxGarson"
        Me.HelpProviderHG.SetShowHelp(Me.ComboBoxGarson, True)
        Me.ComboBoxGarson.Size = New System.Drawing.Size(182, 21)
        Me.ComboBoxGarson.TabIndex = 8
        '
        'LabelMasa_No
        '
        Me.LabelMasa_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMasa_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMasa_No.ForeColor = System.Drawing.Color.White
        Me.LabelMasa_No.Location = New System.Drawing.Point(192, 25)
        Me.LabelMasa_No.Name = "LabelMasa_No"
        Me.LabelMasa_No.Size = New System.Drawing.Size(101, 55)
        Me.LabelMasa_No.TabIndex = 7
        Me.LabelMasa_No.Text = "0"
        Me.LabelMasa_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxAdisyon_No
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxAdisyon_No, "AdisyonFormu.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxAdisyon_No, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxAdisyon_No.Location = New System.Drawing.Point(78, 55)
        Me.TextBoxAdisyon_No.Name = "TextBoxAdisyon_No"
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxAdisyon_No, True)
        Me.TextBoxAdisyon_No.Size = New System.Drawing.Size(108, 20)
        Me.TextBoxAdisyon_No.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Toplam Tutar:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tarih Saat:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kişi Sayısı:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Garson:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Masa No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adisyon No:"
        '
        'imageListBRP
        '
        Me.imageListBRP.ImageStream = CType(resources.GetObject("imageListBRP.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListBRP.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListBRP.Images.SetKeyName(0, "bosmasa.png")
        Me.imageListBRP.Images.SetKeyName(1, "dolumasa.fw.png")
        Me.imageListBRP.Images.SetKeyName(2, "rezervemasa.fw.png")
        '
        'ContextMenuStripBRP
        '
        Me.ContextMenuStripBRP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdisyonAçToolStripMenuItem, Me.ToolStripMenuItem1, Me.MasaDeğiştirToolStripMenuItem, Me.RezervasyonYapToolStripMenuItem})
        Me.ContextMenuStripBRP.Name = "ContextMenuStripBRP"
        Me.ContextMenuStripBRP.Size = New System.Drawing.Size(163, 76)
        '
        'AdisyonAçToolStripMenuItem
        '
        Me.AdisyonAçToolStripMenuItem.Name = "AdisyonAçToolStripMenuItem"
        Me.AdisyonAçToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AdisyonAçToolStripMenuItem.Text = "Adisyon &Aç"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(159, 6)
        '
        'MasaDeğiştirToolStripMenuItem
        '
        Me.MasaDeğiştirToolStripMenuItem.Name = "MasaDeğiştirToolStripMenuItem"
        Me.MasaDeğiştirToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.MasaDeğiştirToolStripMenuItem.Text = "&Masa Değiştir"
        '
        'RezervasyonYapToolStripMenuItem
        '
        Me.RezervasyonYapToolStripMenuItem.Name = "RezervasyonYapToolStripMenuItem"
        Me.RezervasyonYapToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RezervasyonYapToolStripMenuItem.Text = "&Rezervasyon Yap"
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Bip_Restoran_Programi.chm"
        '
        'AdisyonFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 456)
        Me.Controls.Add(Me.SplitContainerBRP)
        Me.HelpProviderHG.SetHelpKeyword(Me, "AdisyonFormu.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Name = "AdisyonFormu"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "Adisyonlar"
        Me.SplitContainerBRP.Panel1.ResumeLayout(False)
        Me.SplitContainerBRP.Panel1.PerformLayout()
        CType(Me.SplitContainerBRP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerBRP.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripBRP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerBRP As System.Windows.Forms.SplitContainer
    Friend WithEvents imageListBRP As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStripBRP As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AdisyonAçToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MasaDeğiştirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RezervasyonYapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBoxTutar As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKisiSayisi As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxGarson As System.Windows.Forms.ComboBox
    Friend WithEvents LabelMasa_No As System.Windows.Forms.Label
    Friend WithEvents TextBoxAdisyon_No As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonAdisyonKapat As System.Windows.Forms.Button
    Friend WithEvents ButtonSiparisEkle As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MaskedTextBoxTarihSaat As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Adisyon_Detay_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adisyon_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Menu_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fiyat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Toplam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aciklama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
