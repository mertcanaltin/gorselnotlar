<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasaBilgileriFormu
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
        Me.MasaNo_TBox = New System.Windows.Forms.TextBox()
        Me.Kapasite_NUD = New System.Windows.Forms.NumericUpDown()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Kapasite_NUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 68)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(218, 38)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProviderHG.SetHelpKeyword(Me.OK_Button, "MasaBilgileriFormu.htm#OK_Button")
        Me.HelpProviderHG.SetHelpNavigator(Me.OK_Button, System.Windows.Forms.HelpNavigator.Topic)
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.HelpProviderHG.SetShowHelp(Me.OK_Button, True)
        Me.OK_Button.Size = New System.Drawing.Size(103, 32)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Tamam"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProviderHG.SetHelpKeyword(Me.Cancel_Button, "MasaBilgileriFormu.htm#Cancel_Button")
        Me.HelpProviderHG.SetHelpNavigator(Me.Cancel_Button, System.Windows.Forms.HelpNavigator.Topic)
        Me.Cancel_Button.Location = New System.Drawing.Point(112, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.HelpProviderHG.SetShowHelp(Me.Cancel_Button, True)
        Me.Cancel_Button.Size = New System.Drawing.Size(103, 32)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Vazgeç"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Masa No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kapasite:"
        '
        'MasaNo_TBox
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.MasaNo_TBox, "MasaBilgileriFormu.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.MasaNo_TBox, System.Windows.Forms.HelpNavigator.Topic)
        Me.MasaNo_TBox.Location = New System.Drawing.Point(89, 14)
        Me.MasaNo_TBox.Name = "MasaNo_TBox"
        Me.HelpProviderHG.SetShowHelp(Me.MasaNo_TBox, True)
        Me.MasaNo_TBox.Size = New System.Drawing.Size(120, 20)
        Me.MasaNo_TBox.TabIndex = 3
        '
        'Kapasite_NUD
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.Kapasite_NUD, "MasaBilgileriFormu.htm#Kapasite_NUD")
        Me.HelpProviderHG.SetHelpNavigator(Me.Kapasite_NUD, System.Windows.Forms.HelpNavigator.Topic)
        Me.Kapasite_NUD.Location = New System.Drawing.Point(89, 40)
        Me.Kapasite_NUD.Name = "Kapasite_NUD"
        Me.HelpProviderHG.SetShowHelp(Me.Kapasite_NUD, True)
        Me.Kapasite_NUD.Size = New System.Drawing.Size(84, 20)
        Me.Kapasite_NUD.TabIndex = 4
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Bip_Restoran_Programi.chm"
        '
        'MasaBilgileriFormu
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(218, 106)
        Me.Controls.Add(Me.Kapasite_NUD)
        Me.Controls.Add(Me.MasaNo_TBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpProviderHG.SetHelpKeyword(Me, "MasaBilgileriFormu.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MasaBilgileriFormu"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Masa Bilgileri"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Kapasite_NUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MasaNo_TBox As System.Windows.Forms.TextBox
    Friend WithEvents Kapasite_NUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider

End Class
