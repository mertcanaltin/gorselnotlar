<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SifremiUnuttumFormu
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
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.TextBoxSoru = New System.Windows.Forms.TextBox()
        Me.TextBoxCevap = New System.Windows.Forms.TextBox()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(100, 102)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(306, 43)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProviderHG.SetHelpKeyword(Me.OK_Button, "SifremiUnuttumFormu.htm#OK_Button")
        Me.HelpProviderHG.SetHelpNavigator(Me.OK_Button, System.Windows.Forms.HelpNavigator.Topic)
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.HelpProviderHG.SetShowHelp(Me.OK_Button, True)
        Me.OK_Button.Size = New System.Drawing.Size(147, 37)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "&Tamam"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProviderHG.SetHelpKeyword(Me.Cancel_Button, "SifremiUnuttumFormu.htm#Cancel_Button")
        Me.HelpProviderHG.SetHelpNavigator(Me.Cancel_Button, System.Windows.Forms.HelpNavigator.Topic)
        Me.Cancel_Button.Location = New System.Drawing.Point(156, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.HelpProviderHG.SetShowHelp(Me.Cancel_Button, True)
        Me.Cancel_Button.Size = New System.Drawing.Size(147, 37)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "&Vazgeç"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kullanıcı Adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Güvenlik Sorusu:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cevap:"
        '
        'TextBoxUserName
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxUserName, "SifremiUnuttumFormu.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxUserName, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxUserName.Location = New System.Drawing.Point(100, 20)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.ReadOnly = True
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxUserName, True)
        Me.TextBoxUserName.Size = New System.Drawing.Size(176, 20)
        Me.TextBoxUserName.TabIndex = 4
        '
        'TextBoxSoru
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxSoru, "SifremiUnuttumFormu.htm#Label2")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxSoru, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxSoru.Location = New System.Drawing.Point(100, 46)
        Me.TextBoxSoru.Name = "TextBoxSoru"
        Me.TextBoxSoru.ReadOnly = True
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxSoru, True)
        Me.TextBoxSoru.Size = New System.Drawing.Size(306, 20)
        Me.TextBoxSoru.TabIndex = 5
        '
        'TextBoxCevap
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TextBoxCevap, "SifremiUnuttumFormu.htm#Label3")
        Me.HelpProviderHG.SetHelpNavigator(Me.TextBoxCevap, System.Windows.Forms.HelpNavigator.Topic)
        Me.TextBoxCevap.Location = New System.Drawing.Point(100, 72)
        Me.TextBoxCevap.Name = "TextBoxCevap"
        Me.HelpProviderHG.SetShowHelp(Me.TextBoxCevap, True)
        Me.TextBoxCevap.Size = New System.Drawing.Size(306, 20)
        Me.TextBoxCevap.TabIndex = 6
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Bip_Restoran_Programi.chm"
        '
        'SifremiUnuttumFormu
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(418, 157)
        Me.Controls.Add(Me.TextBoxCevap)
        Me.Controls.Add(Me.TextBoxSoru)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpProviderHG.SetHelpKeyword(Me, "SifremiUnuttumFormu.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SifremiUnuttumFormu"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Şifremi Unuttum"
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
    Friend WithEvents TextBoxUserName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSoru As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCevap As System.Windows.Forms.TextBox
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider

End Class
