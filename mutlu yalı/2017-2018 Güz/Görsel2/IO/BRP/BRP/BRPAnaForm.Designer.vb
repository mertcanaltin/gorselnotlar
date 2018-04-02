<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BRPAnaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BRPAnaForm))
        Me.MenuStripBRP = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UygulamayıKapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KayıtlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuKayitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasaKayıtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdisyonKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyarlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ŞifreDeğiştirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeniKullanıcıEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RaporlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdisyonRaporuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripBRP = New System.Windows.Forms.ToolStrip()
        Me.MenuKayitButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.MenuStripBRP.SuspendLayout()
        Me.ToolStripBRP.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripBRP
        '
        Me.MenuStripBRP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.KayıtlarToolStripMenuItem, Me.AyarlarToolStripMenuItem, Me.RaporlarToolStripMenuItem})
        Me.MenuStripBRP.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripBRP.Name = "MenuStripBRP"
        Me.MenuStripBRP.Size = New System.Drawing.Size(1059, 24)
        Me.MenuStripBRP.TabIndex = 1
        Me.MenuStripBRP.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UygulamayıKapatToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "&Program"
        '
        'UygulamayıKapatToolStripMenuItem
        '
        Me.UygulamayıKapatToolStripMenuItem.Name = "UygulamayıKapatToolStripMenuItem"
        Me.UygulamayıKapatToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4"
        Me.UygulamayıKapatToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.UygulamayıKapatToolStripMenuItem.Text = "Uygulamayı &Kapat"
        '
        'KayıtlarToolStripMenuItem
        '
        Me.KayıtlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuKayitToolStripMenuItem, Me.MasaKayıtToolStripMenuItem, Me.AdisyonKaydıToolStripMenuItem})
        Me.KayıtlarToolStripMenuItem.Name = "KayıtlarToolStripMenuItem"
        Me.KayıtlarToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.KayıtlarToolStripMenuItem.Text = "&Kayıtlar"
        '
        'MenuKayitToolStripMenuItem
        '
        Me.MenuKayitToolStripMenuItem.Name = "MenuKayitToolStripMenuItem"
        Me.MenuKayitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MenuKayitToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.MenuKayitToolStripMenuItem.Text = "&Menu Kayıt"
        '
        'MasaKayıtToolStripMenuItem
        '
        Me.MasaKayıtToolStripMenuItem.Name = "MasaKayıtToolStripMenuItem"
        Me.MasaKayıtToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.MasaKayıtToolStripMenuItem.Text = "M&asa Kayıt"
        '
        'AdisyonKaydıToolStripMenuItem
        '
        Me.AdisyonKaydıToolStripMenuItem.Name = "AdisyonKaydıToolStripMenuItem"
        Me.AdisyonKaydıToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.AdisyonKaydıToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AdisyonKaydıToolStripMenuItem.Text = "&Adisyon Kaydı"
        '
        'AyarlarToolStripMenuItem
        '
        Me.AyarlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ŞifreDeğiştirToolStripMenuItem, Me.YeniKullanıcıEkleToolStripMenuItem})
        Me.AyarlarToolStripMenuItem.Name = "AyarlarToolStripMenuItem"
        Me.AyarlarToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AyarlarToolStripMenuItem.Text = "&Ayarlar"
        '
        'ŞifreDeğiştirToolStripMenuItem
        '
        Me.ŞifreDeğiştirToolStripMenuItem.Name = "ŞifreDeğiştirToolStripMenuItem"
        Me.ŞifreDeğiştirToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ŞifreDeğiştirToolStripMenuItem.Text = "Şifre &Değiştir"
        '
        'YeniKullanıcıEkleToolStripMenuItem
        '
        Me.YeniKullanıcıEkleToolStripMenuItem.Name = "YeniKullanıcıEkleToolStripMenuItem"
        Me.YeniKullanıcıEkleToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.YeniKullanıcıEkleToolStripMenuItem.Text = "&Yeni Kullanıcı Ekle"
        '
        'RaporlarToolStripMenuItem
        '
        Me.RaporlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdisyonRaporuToolStripMenuItem})
        Me.RaporlarToolStripMenuItem.Name = "RaporlarToolStripMenuItem"
        Me.RaporlarToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.RaporlarToolStripMenuItem.Text = "&Raporlar"
        '
        'AdisyonRaporuToolStripMenuItem
        '
        Me.AdisyonRaporuToolStripMenuItem.Name = "AdisyonRaporuToolStripMenuItem"
        Me.AdisyonRaporuToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.AdisyonRaporuToolStripMenuItem.Text = "&Adisyon Raporu"
        '
        'ToolStripBRP
        '
        Me.ToolStripBRP.AutoSize = False
        Me.ToolStripBRP.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStripBRP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuKayitButton, Me.ToolStripButton1})
        Me.ToolStripBRP.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripBRP.Name = "ToolStripBRP"
        Me.ToolStripBRP.Size = New System.Drawing.Size(1059, 50)
        Me.ToolStripBRP.TabIndex = 3
        Me.ToolStripBRP.Text = "ToolStrip1"
        '
        'MenuKayitButton
        '
        Me.MenuKayitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuKayitButton.Image = Global.BRP.My.Resources.Resources.menu1
        Me.MenuKayitButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuKayitButton.Name = "MenuKayitButton"
        Me.MenuKayitButton.Size = New System.Drawing.Size(52, 47)
        Me.MenuKayitButton.Text = "Menü"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 47)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Bip_Restoran_Programi.chm"
        '
        'BRPAnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 492)
        Me.Controls.Add(Me.ToolStripBRP)
        Me.Controls.Add(Me.MenuStripBRP)
        Me.HelpProviderHG.SetHelpKeyword(Me, "BRPAnaForm.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStripBRP
        Me.Name = "BRPAnaForm"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "BRP - Bip Restoran Programı"
        Me.MenuStripBRP.ResumeLayout(False)
        Me.MenuStripBRP.PerformLayout()
        Me.ToolStripBRP.ResumeLayout(False)
        Me.ToolStripBRP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripBRP As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UygulamayıKapatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KayıtlarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuKayitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripBRP As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuKayitButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents MasaKayıtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyarlarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ŞifreDeğiştirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YeniKullanıcıEkleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdisyonKaydıToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RaporlarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdisyonRaporuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider

End Class
