<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdisyonRaporFormu
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
        Me.AdisyonCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.AdisyonRaporu1 = New BRP.AdisyonRaporu()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout()
        '
        'AdisyonCrystalReportViewer
        '
        Me.AdisyonCrystalReportViewer.ActiveViewIndex = 0
        Me.AdisyonCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdisyonCrystalReportViewer.CachedPageNumberPerDoc = 10
        Me.AdisyonCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.AdisyonCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProviderHG.SetHelpKeyword(Me.AdisyonCrystalReportViewer, "AdisyonRaporFormu.htm#AdisyonCrystalReportViewer")
        Me.HelpProviderHG.SetHelpNavigator(Me.AdisyonCrystalReportViewer, System.Windows.Forms.HelpNavigator.Topic)
        Me.AdisyonCrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.AdisyonCrystalReportViewer.Name = "AdisyonCrystalReportViewer"
        Me.AdisyonCrystalReportViewer.ReportSource = Me.AdisyonRaporu1
        Me.HelpProviderHG.SetShowHelp(Me.AdisyonCrystalReportViewer, True)
        Me.AdisyonCrystalReportViewer.Size = New System.Drawing.Size(831, 490)
        Me.AdisyonCrystalReportViewer.TabIndex = 0
        Me.AdisyonCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Bip_Restoran_Programi.chm"
        '
        'AdisyonRaporFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 490)
        Me.Controls.Add(Me.AdisyonCrystalReportViewer)
        Me.HelpProviderHG.SetHelpKeyword(Me, "AdisyonRaporFormu.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Name = "AdisyonRaporFormu"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "Adisyon Raporu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdisyonCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents AdisyonRaporu1 As BRP.AdisyonRaporu
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
