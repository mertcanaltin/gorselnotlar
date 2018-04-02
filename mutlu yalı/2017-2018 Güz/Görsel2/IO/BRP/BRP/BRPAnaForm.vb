Public Class BRPAnaForm
    Public UserName, Password, Yetki As String
    Private Sub MenuKayitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuKayitToolStripMenuItem.Click, MenuKayitButton.Click
        MenuKayitFormu.MdiParent = Me
        MenuKayitFormu.Show()
        MenuKayitFormu.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MasaKayıtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasaKayıtToolStripMenuItem.Click
        MasaKayitFormu.MdiParent = Me
        MasaKayitFormu.Show()
        MasaKayitFormu.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BRPAnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KullaniciGirisFormu.ShowDialog()
    End Sub

    Private Sub ŞifreDeğiştirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ŞifreDeğiştirToolStripMenuItem.Click
        SifreDegistirFormu.ShowDialog()
    End Sub

    Private Sub YeniKullanıcıEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeniKullanıcıEkleToolStripMenuItem.Click
        If Yetki = "Y" Then
            YeniKullaniciEkleFormu.ShowDialog()
        Else
            MsgBox("Yeni kullanıcı ekleme yetkiniz yok. Sistem yöneticinize başvurunuz.")
        End If
    End Sub

    Private Sub AdisyonKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdisyonKaydıToolStripMenuItem.Click, ToolStripButton1.Click
        AdisyonFormu.MdiParent = Me
        AdisyonFormu.Show()
        AdisyonFormu.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AdisyonRaporuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdisyonRaporuToolStripMenuItem.Click
        AdisyonRaporFormu.ShowDialog()
    End Sub
End Class
