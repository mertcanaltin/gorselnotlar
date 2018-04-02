Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class SifremiUnuttumFormu
    Public UserName As String = ""
    Private OkunanCevap As String = Nothing



    Private Function SifreOlustur(Optional ByVal Uzunluk As Integer = 5) As String
        Dim KaynakMetin As String = "abcdefghijklnmoprstuvyzqwxABCDEFGHIJKLNMOPRSTUVYZQWX1234567890.,;_?"
        Dim Rast As New Random
        Dim YeniSifre As String = Nothing
        For i = 1 To Uzunluk
            YeniSifre &= KaynakMetin(Rast.Next(0, KaynakMetin.Length - 1))
        Next
        Return YeniSifre
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim Baglanti As New VT_Baglan
        If OkunanCevap = Baglanti.SHA512_Hash(TextBoxCevap.Text) Then
            Dim Password As String = SifreOlustur()
            Dim Sorgu As String = "UPDATE Kullanici_Tablosu SET Sifre=@Sifre WHERE Kullanici_Adi=@KAdi"
            Dim SQLKomut As New SqlCommand(Sorgu, Baglanti.SQLBaglanti)
            SQLKomut.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128)
            SQLKomut.Parameters.Add("@KAdi", SqlDbType.NVarChar, 20)
            SQLKomut.Parameters("@Sifre").Value = Baglanti.SHA512_Hash(Password)
            SQLKomut.Parameters("@KAdi").Value = UserName
            Try
                Baglanti.SQLBaglanti.Open()
                SQLKomut.ExecuteNonQuery()
                MsgBox("Şifreniz yenilenmiştir. Yeni şifrenizi not almayı unutmayınız.Şifreniz: " & Password)
                Clipboard.Clear()
                Clipboard.SetText(Password)
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MsgBox("Şifre Değişiminde hata ile karşılaşıldı. Hata:" & ex.Message)
            Finally
                Baglanti.SQLBaglanti.Close()
            End Try
        Else
            MsgBox("Verilen cevap doğru değil.")
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SifremiUnuttumFormu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub SifremiUnuttumFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxUserName.Text = UserName
        Dim Baglanti As New VT_Baglan
        Try
            '***************Kullanıcı Bilgilerini Veri Tabanından Getir************
            Dim Sorgu As String = "Select * From Kullanici_Tablosu Where Kullanici_Adi=@KAdi"
            Dim Giris_SDA As New SqlDataAdapter(Sorgu, Baglanti.SQLBaglanti)
            'Parametre tanımlamaları
            Giris_SDA.SelectCommand.Parameters.Add("@KAdi", SqlDbType.NVarChar, 20)
            'Parametrelere değer aktar
            Giris_SDA.SelectCommand.Parameters("@KAdi").Value = UserName
            Dim VeriTablosu As New DataTable
            Baglanti.SQLBaglanti.Open()
            Giris_SDA.Fill(VeriTablosu)
            '***************************************************************************
            If VeriTablosu.Rows.Count = 1 AndAlso VeriTablosu.Rows(0)("Kullanici_Adi") = UserName Then
                Dim Satir As DataRow = VeriTablosu.Rows(0)
                TextBoxSoru.Text = Satir("Guvenlik_Sorusu")
                OkunanCevap = Satir("Cevap")
            Else
                MsgBox("Kullanıcı adı bulunamadı.")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Hata: " & ex.Message)
        Finally
            Baglanti.SQLBaglanti.Close()
        End Try
    End Sub
End Class
