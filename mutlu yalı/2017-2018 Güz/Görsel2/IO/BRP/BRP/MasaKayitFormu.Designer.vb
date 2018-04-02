<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasaKayitFormu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasaKayitFormu))
        Me.SplitContainerBRP = New System.Windows.Forms.SplitContainer()
        Me.MasaEkleButton = New System.Windows.Forms.Button()
        Me.imageListBRP = New System.Windows.Forms.ImageList(Me.components)
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        CType(Me.SplitContainerBRP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerBRP.Panel1.SuspendLayout()
        Me.SplitContainerBRP.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerBRP
        '
        Me.SplitContainerBRP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerBRP.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.HelpProviderHG.SetHelpKeyword(Me.SplitContainerBRP, "MasaKayitFormu.htm#SplitContainerBRP")
        Me.HelpProviderHG.SetHelpNavigator(Me.SplitContainerBRP, System.Windows.Forms.HelpNavigator.Topic)
        Me.SplitContainerBRP.IsSplitterFixed = True
        Me.SplitContainerBRP.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerBRP.Name = "SplitContainerBRP"
        '
        'SplitContainerBRP.Panel1
        '
        Me.SplitContainerBRP.Panel1.BackColor = System.Drawing.Color.Gray
        Me.SplitContainerBRP.Panel1.Controls.Add(Me.MasaEkleButton)
        Me.HelpProviderHG.SetShowHelp(Me.SplitContainerBRP, True)
        Me.SplitContainerBRP.Size = New System.Drawing.Size(1030, 500)
        Me.SplitContainerBRP.SplitterDistance = 100
        Me.SplitContainerBRP.TabIndex = 0
        '
        'MasaEkleButton
        '
        Me.MasaEkleButton.BackColor = System.Drawing.Color.Peru
        Me.MasaEkleButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MasaEkleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MasaEkleButton.ForeColor = System.Drawing.Color.White
        Me.HelpProviderHG.SetHelpKeyword(Me.MasaEkleButton, "MasaKayitFormu.htm#MasaEkleButton")
        Me.HelpProviderHG.SetHelpNavigator(Me.MasaEkleButton, System.Windows.Forms.HelpNavigator.Topic)
        Me.MasaEkleButton.Image = Global.BRP.My.Resources.Resources.bosmasa
        Me.MasaEkleButton.Location = New System.Drawing.Point(0, 0)
        Me.MasaEkleButton.Name = "MasaEkleButton"
        Me.HelpProviderHG.SetShowHelp(Me.MasaEkleButton, True)
        Me.MasaEkleButton.Size = New System.Drawing.Size(100, 100)
        Me.MasaEkleButton.TabIndex = 0
        Me.MasaEkleButton.Text = "Yeni Masa Ekle"
        Me.MasaEkleButton.UseVisualStyleBackColor = False
        '
        'imageListBRP
        '
        Me.imageListBRP.ImageStream = CType(resources.GetObject("imageListBRP.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListBRP.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListBRP.Images.SetKeyName(0, "bosmasa.png")
        Me.imageListBRP.Images.SetKeyName(1, "dolumasa.fw.png")
        Me.imageListBRP.Images.SetKeyName(2, "rezervemasa.fw.png")
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Bip_Restoran_Programi.chm"
        '
        'MasaKayitFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 500)
        Me.Controls.Add(Me.SplitContainerBRP)
        Me.HelpProviderHG.SetHelpKeyword(Me, "MasaKayitFormu.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Name = "MasaKayitFormu"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "Masa Kayıt"
        Me.SplitContainerBRP.Panel1.ResumeLayout(False)
        CType(Me.SplitContainerBRP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerBRP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerBRP As System.Windows.Forms.SplitContainer
    Friend WithEvents MasaEkleButton As System.Windows.Forms.Button
    Friend WithEvents imageListBRP As System.Windows.Forms.ImageList
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
