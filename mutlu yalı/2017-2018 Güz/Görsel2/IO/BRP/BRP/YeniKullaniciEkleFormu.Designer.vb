<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YeniKullaniciEkleFormu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.TextBoxSifre = New System.Windows.Forms.TextBox()
        Me.TextBoxTekrar = New System.Windows.Forms.TextBox()
        Me.TextBoxSoru = New System.Windows.Forms.TextBox()
        Me.TextBoxCevap = New System.Windows.Forms.TextBox()
        Me.ComboBoxYetki = New System.Windows.Forms.ComboBox()
        Me.ErrorProviderBRP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBoxSifre = New System.Windows.Forms.PictureBox()
        Me.PictureBoxTekrar = New System.Windows.Forms.PictureBox()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProviderBRP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSifre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxTekrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 232)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(315, 41)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProviderHG.SetHelpKeyword(Me.OK_Button, "YeniKullaniciEkleFormu.htm#OK_Button")
        Me.HelpProviderHG.SetHelpNavigator(Me.OK_Button, System.Windows.Forms.HelpNavigator.Topic)
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.HelpProviderHG.SetShowHelp(Me.OK_Button, True)
        Me.OK_Button.Size = New System.Drawing.Size(151, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Yeni Kullanıcı Ekle"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProviderHG.SetHelpKeyword(Me.Cancel_Button, "YeniKullaniciEkleFormu.htm#Cancel_Button")
        Me.HelpProviderHG.SetHelpNavigator(Me.Cancel_Button, System.Windows.Forms.HelpNavigator.Topic)
        Me.Cancel_Button.Location = New System.Drawing.Point(160, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.HelpProviderHG.SetShowHelp(Me.Cancel_Button, True)
        Me.Cancel_Button.Size = New System.Drawing.Size(152, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Vazgeç"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kullanıcı Adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Şifresi:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Şifre Tekrarı:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Güvenlik Sorusu:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cevap:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Yetki:"
        '
        'TextBoxUserName
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxUserName, "YeniKullaniciEkleFormu.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxUserName, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxUserName.Location = New System.Drawing.Point(102, 33)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxUserName, True)
        Me.TextBoxUserName.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxUserName.TabIndex = 7
        '
        'TextBoxSifre
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxSifre, "YeniKullaniciEkleFormu.htm#Label2")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxSifre, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxSifre.Location = New System.Drawing.Point(102, 63)
        Me.TextBoxSifre.Name = "TextBoxSifre"
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxSifre, True)
        Me.TextBoxSifre.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxSifre.TabIndex = 8
        Me.TextBoxSifre.UseSystemPasswordChar = True
        '
        'TextBoxTekrar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxTekrar, "YeniKullaniciEkleFormu.htm#Label3")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxTekrar, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxTekrar.Location = New System.Drawing.Point(102, 93)
        Me.TextBoxTekrar.Name = "TextBoxTekrar"
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxTekrar, True)
        Me.TextBoxTekrar.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxTekrar.TabIndex = 9
        Me.TextBoxTekrar.UseSystemPasswordChar = True
        '
        'TextBoxSoru
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxSoru, "YeniKullaniciEkleFormu.htm#Label4")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxSoru, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxSoru.Location = New System.Drawing.Point(102, 123)
        Me.TextBoxSoru.Name = "TextBoxSoru"
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxSoru, True)
        Me.TextBoxSoru.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxSoru.TabIndex = 10
        '
        'TextBoxCevap
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxCevap, "YeniKullaniciEkleFormu.htm#Label5")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxCevap, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxCevap.Location = New System.Drawing.Point(102, 153)
        Me.TextBoxCevap.Name = "TextBoxCevap"
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxCevap, True)
        Me.TextBoxCevap.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxCevap.TabIndex = 11
        '
        'ComboBoxYetki
        '
        Me.ComboBoxYetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxYetki.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.ComboBoxYetki, "YeniKullaniciEkleFormu.htm#Label6")
        Me.HelpProviderHG.SetHelpNavigator(Me.ComboBoxYetki, System.Windows.Forms.HelpNavigator.Topic)
        Me.ComboBoxYetki.Items.AddRange(New Object() {"Standart Kullanıcı", "Yetkili Kullanıcı"})
        Me.ComboBoxYetki.Location = New System.Drawing.Point(102, 183)
        Me.ComboBoxYetki.Name = "ComboBoxYetki"
        Me.HelpProviderHG.SetShowHelp(Me.ComboBoxYetki, True)
        Me.ComboBoxYetki.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxYetki.TabIndex = 12
        '
        'ErrorProviderBRP
        '
        Me.ErrorProviderBRP.ContainerControl = Me
        '
        'PictureBoxSifre
        '
        Me.PictureBoxSifre.Image = Global.BRP.My.Resources.Resources.eye
        Me.PictureBoxSifre.Location = New System.Drawing.Point(289, 66)
        Me.PictureBoxSifre.Name = "PictureBoxSifre"
        Me.PictureBoxSifre.Size = New System.Drawing.Size(20, 15)
        Me.PictureBoxSifre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxSifre.TabIndex = 13
        Me.PictureBoxSifre.TabStop = False
        '
        'PictureBoxTekrar
        '
        Me.PictureBoxTekrar.Image = Global.BRP.My.Resources.Resources.eye
        Me.PictureBoxTekrar.Location = New System.Drawing.Point(290, 96)
        Me.PictureBoxTekrar.Name = "PictureBoxTekrar"
        Me.PictureBoxTekrar.Size = New System.Drawing.Size(20, 15)
        Me.PictureBoxTekrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxTekrar.TabIndex = 14
        Me.PictureBoxTekrar.TabStop = False
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Bip_Restoran_Programi.chm"
        '
        'YeniKullaniciEkleFormu
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(355, 285)
        Me.Controls.Add(Me.PictureBoxTekrar)
        Me.Controls.Add(Me.PictureBoxSifre)
        Me.Controls.Add(Me.ComboBoxYetki)
        Me.Controls.Add(Me.TextBoxCevap)
        Me.Controls.Add(Me.TextBoxSoru)
        Me.Controls.Add(Me.TextBoxTekrar)
        Me.Controls.Add(Me.TextBoxSifre)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpProviderHG.SetHelpKeyword(Me, "YeniKullaniciEkleFormu.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "YeniKullaniciEkleFormu"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Yeni Kullanıcı Ekle"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ErrorProviderBRP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSifre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxTekrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUserName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSifre As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTekrar As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSoru As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCevap As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxYetki As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProviderBRP As System.Windows.Forms.ErrorProvider
    Friend WithEvents PictureBoxTekrar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxSifre As System.Windows.Forms.PictureBox
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider

End Class
