<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class KullaniciGirisFormu
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LinkLabelUnuttum = New System.Windows.Forms.LinkLabel()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(172, 8)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Kullanıcı Adı"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(172, 51)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Şifr&e"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.UsernameTextBox, "KullaniciGirisFormu.htm#UsernameLabel")
        Me.HelpProviderHG.SetHelpNavigator(Me.UsernameTextBox, System.Windows.Forms.HelpNavigator.Topic)
        Me.UsernameTextBox.Location = New System.Drawing.Point(174, 28)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.HelpProviderHG.SetShowHelp(Me.UsernameTextBox, True)
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.PasswordTextBox, "KullaniciGirisFormu.htm#PasswordLabel")
        Me.HelpProviderHG.SetHelpNavigator(Me.PasswordTextBox, System.Windows.Forms.HelpNavigator.Topic)
        Me.PasswordTextBox.Location = New System.Drawing.Point(174, 71)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.HelpProviderHG.SetShowHelp(Me.PasswordTextBox, True)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 3
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'OK
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.OK, "KullaniciGirisFormu.htm#OK")
        Me.HelpProviderHG.SetHelpNavigator(Me.OK, System.Windows.Forms.HelpNavigator.Topic)
        Me.OK.Location = New System.Drawing.Point(175, 111)
        Me.OK.Name = "OK"
        Me.HelpProviderHG.SetShowHelp(Me.OK, True)
        Me.OK.Size = New System.Drawing.Size(104, 32)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Giriş"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProviderHG.SetHelpKeyword(Me.Cancel, "KullaniciGirisFormu.htm#Cancel")
        Me.HelpProviderHG.SetHelpNavigator(Me.Cancel, System.Windows.Forms.HelpNavigator.Topic)
        Me.Cancel.Location = New System.Drawing.Point(290, 111)
        Me.Cancel.Name = "Cancel"
        Me.HelpProviderHG.SetShowHelp(Me.Cancel, True)
        Me.Cancel.Size = New System.Drawing.Size(104, 32)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Vazgeç"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.LogoPictureBox.Image = Global.BRP.My.Resources.Resources.login
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 149)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'LinkLabelUnuttum
        '
        Me.LinkLabelUnuttum.AutoSize = True
        Me.HelpProviderHG.SetHelpKeyword(Me.LinkLabelUnuttum, "KullaniciGirisFormu.htm#LinkLabelUnuttum")
        Me.HelpProviderHG.SetHelpNavigator(Me.LinkLabelUnuttum, System.Windows.Forms.HelpNavigator.Topic)
        Me.LinkLabelUnuttum.Location = New System.Drawing.Point(313, 95)
        Me.LinkLabelUnuttum.Name = "LinkLabelUnuttum"
        Me.HelpProviderHG.SetShowHelp(Me.LinkLabelUnuttum, True)
        Me.LinkLabelUnuttum.Size = New System.Drawing.Size(81, 13)
        Me.LinkLabelUnuttum.TabIndex = 6
        Me.LinkLabelUnuttum.TabStop = True
        Me.LinkLabelUnuttum.Text = "Şifremi Unuttum"
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Bip_Restoran_Programi.chm"
        '
        'KullaniciGirisFormu
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(401, 149)
        Me.Controls.Add(Me.LinkLabelUnuttum)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpProviderHG.SetHelpKeyword(Me, "KullaniciGirisFormu.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "KullaniciGirisFormu"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kullanıcı Girişi"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabelUnuttum As System.Windows.Forms.LinkLabel
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider

End Class
