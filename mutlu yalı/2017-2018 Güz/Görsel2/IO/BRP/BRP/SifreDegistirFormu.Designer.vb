<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SifreDegistirFormu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.TextBoxMevcut = New System.Windows.Forms.TextBox()
        Me.TextBoxYeni = New System.Windows.Forms.TextBox()
        Me.TextBoxTekrar = New System.Windows.Forms.TextBox()
        Me.CheckBoxGizle = New System.Windows.Forms.CheckBox()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 157)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(317, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProviderHG.SetHelpKeyword(Me.OK_Button, "SifreDegistirFormu.htm#OK_Button")
        Me.HelpProviderHG.SetHelpNavigator(Me.OK_Button, System.Windows.Forms.HelpNavigator.Topic)
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.HelpProviderHG.SetShowHelp(Me.OK_Button, True)
        Me.OK_Button.Size = New System.Drawing.Size(152, 39)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Şifremi Değiştir"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProviderHG.SetHelpKeyword(Me.Cancel_Button, "SifreDegistirFormu.htm#Cancel_Button")
        Me.HelpProviderHG.SetHelpNavigator(Me.Cancel_Button, System.Windows.Forms.HelpNavigator.Topic)
        Me.Cancel_Button.Location = New System.Drawing.Point(161, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.HelpProviderHG.SetShowHelp(Me.Cancel_Button, True)
        Me.Cancel_Button.Size = New System.Drawing.Size(153, 39)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Vazgeç"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kullanıcı Adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mevcut Şifreniz:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Yeni Şifreniz:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Yeni Şifre Tekrarı:"
        '
        'TextBoxUserName
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxUserName, "SifreDegistirFormu.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxUserName, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxUserName.Location = New System.Drawing.Point(117, 30)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.ReadOnly = True
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxUserName, True)
        Me.TextBoxUserName.Size = New System.Drawing.Size(173, 20)
        Me.TextBoxUserName.TabIndex = 5
        '
        'TextBoxMevcut
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxMevcut, "SifreDegistirFormu.htm#Label2")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxMevcut, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxMevcut.Location = New System.Drawing.Point(117, 56)
        Me.TextBoxMevcut.Name = "TextBoxMevcut"
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxMevcut, True)
        Me.TextBoxMevcut.Size = New System.Drawing.Size(173, 20)
        Me.TextBoxMevcut.TabIndex = 6
        Me.TextBoxMevcut.UseSystemPasswordChar = True
        '
        'TextBoxYeni
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxYeni, "SifreDegistirFormu.htm#Label3")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxYeni, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxYeni.Location = New System.Drawing.Point(117, 82)
        Me.TextBoxYeni.Name = "TextBoxYeni"
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxYeni, True)
        Me.TextBoxYeni.Size = New System.Drawing.Size(173, 20)
        Me.TextBoxYeni.TabIndex = 7
        Me.TextBoxYeni.UseSystemPasswordChar = True
        '
        'TextBoxTekrar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxTekrar, "SifreDegistirFormu.htm#Label4")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxTekrar, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxTekrar.Location = New System.Drawing.Point(117, 108)
        Me.TextBoxTekrar.Name = "TextBoxTekrar"
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxTekrar, True)
        Me.TextBoxTekrar.Size = New System.Drawing.Size(173, 20)
        Me.TextBoxTekrar.TabIndex = 8
        Me.TextBoxTekrar.UseSystemPasswordChar = True
        '
        'CheckBoxGizle
        '
        Me.CheckBoxGizle.AutoSize = True
        Me.CheckBoxGizle.Checked = True
        Me.CheckBoxGizle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HelpProviderHG.SetHelpKeyword(Me.CheckBoxGizle, "SifreDegistirFormu.htm#CheckBoxGizle")
        Me.HelpProviderHG.SetHelpNavigator(Me.CheckBoxGizle, System.Windows.Forms.HelpNavigator.Topic)
        Me.CheckBoxGizle.Location = New System.Drawing.Point(204, 134)
        Me.CheckBoxGizle.Name = "CheckBoxGizle"
        Me.HelpProviderHG.SetShowHelp(Me.CheckBoxGizle, True)
        Me.CheckBoxGizle.Size = New System.Drawing.Size(86, 17)
        Me.CheckBoxGizle.TabIndex = 9
        Me.CheckBoxGizle.Text = "Şifreleri Gizle"
        Me.CheckBoxGizle.UseVisualStyleBackColor = True
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Bip_Restoran_Programi.chm"
        '
        'SifreDegistirFormu
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(333, 214)
        Me.Controls.Add(Me.CheckBoxGizle)
        Me.Controls.Add(Me.TextBoxTekrar)
        Me.Controls.Add(Me.TextBoxYeni)
        Me.Controls.Add(Me.TextBoxMevcut)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpProviderHG.SetHelpKeyword(Me, "SifreDegistirFormu.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SifreDegistirFormu"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Şifre Değiştir"
        Me.TableLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents TextBoxUserName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMevcut As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxYeni As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTekrar As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxGizle As System.Windows.Forms.CheckBox
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider

End Class
