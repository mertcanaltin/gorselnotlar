Imports System.Data.SqlClient
Public Class KullaniciGirisFormu

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Giris As Boolean = False
    Private Hak As SByte = 3
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Hak -= 1
        Dim Baglanti As New VT_Baglan
        Try
            '***************Kullanıcı Bilgilerini Veri Tabanından Kontrol Et************
            Dim Sorgu As String = "Select * From Kullanici_Tablosu Where Kullanici_Adi=@KAdi and Sifre=@Sifre"
            Dim Giris_SDA As New SqlDataAdapter(Sorgu, Baglanti.SQLBaglanti)
            'Parametre tanımlamaları
            Giris_SDA.SelectCommand.Parameters.Add("@KAdi", SqlDbType.NVarChar, 20)
            Giris_SDA.SelectCommand.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128)
            'Parametrelere değer aktar
            Giris_SDA.SelectCommand.Parameters("@KAdi").Value = UsernameTextBox.Text
            Giris_SDA.SelectCommand.Parameters("@Sifre").Value = Baglanti.SHA512_Hash(PasswordTextBox.Text)
            Dim VeriTablosu As New DataTable
            Baglanti.SQLBaglanti.Open()
            Giris_SDA.Fill(VeriTablosu)
            '***************************************************************************
            If Hak >= 0 AndAlso VeriTablosu.Rows.Count = 1 AndAlso VeriTablosu.Rows(0)("Kullanici_Adi") = UsernameTextBox.Text Then
                Dim Satir As DataRow = VeriTablosu.Rows(0)
                BRPAnaForm.UserName = Satir("Kullanici_Adi")
                BRPAnaForm.Password = Satir("Sifre")
                BRPAnaForm.Yetki = Satir("Yetki")
                Giris = True
                Me.Close()
            ElseIf Hak > 0 Then
                MsgBox("Kullanıcı adı veya şifre hatalı. Tekrar deneyiniz.")
            Else
                MsgBox("Kullanıcı adı veya şifre hatalı. Uygulama kapatılacak")
                Giris = False
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Hata: " & ex.Message)
        Finally
            Baglanti.SQLBaglanti.Close()
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Giris = False
        Me.Close()
    End Sub

    Private Sub KullaniciGirisFormu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Giris = False Then
            Application.Exit()
        Else
            Me.Dispose()
        End If

    End Sub

    Private Sub LinkLabelUnuttum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelUnuttum.LinkClicked
        If UsernameTextBox.TextLength > 0 Then
            SifremiUnuttumFormu.UserName = UsernameTextBox.Text
            If SifremiUnuttumFormu.ShowDialog = Windows.Forms.DialogResult.OK Then
                PasswordTextBox.Text = Clipboard.GetText
            End If
        Else
            MsgBox("Lütfen kullanıcı adını giriniz.")
            UsernameTextBox.Focus()
        End If
    End Sub
End Class
