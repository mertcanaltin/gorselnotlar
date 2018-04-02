Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class YeniKullaniciEkleFormu
    Private Function KullaniciAra(ByVal Aranan As String) As DataTable
        Dim Kayitlar As New DataTable
        Dim Baglanti As New VT_Baglan
        Try
            Dim Sorgu As String = "SELECT * FROM Kullanici_Tablosu WHERE Kullanici_Adi=@KAdi"
            Dim SQLKomut As New SqlCommand(Sorgu, Baglanti.SQLBaglanti)
            SQLKomut.Parameters.Add("@KAdi", SqlDbType.NVarChar, 20).Value = Aranan
            Baglanti.SQLBaglanti.Open()
            Kayitlar.Load(SQLKomut.ExecuteReader)
        Catch ex As Exception
        Finally
            Baglanti.SQLBaglanti.Close()
        End Try
        Return Kayitlar
    End Function
    Private Function Dolumu() As Boolean
        Dim Sonuc As Boolean = True
        For Each MetinKutusu As TextBox In Me.Controls.OfType(Of TextBox)()
            If MetinKutusu.Text.Trim.Length = 0 Then
                Sonuc = False
                ErrorProviderBRP.SetError(MetinKutusu, "Bu alan boş geçilemez")
            Else
                ErrorProviderBRP.SetError(MetinKutusu, Nothing)
            End If
        Next
        Return Sonuc
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Dolumu() = True Then
            If TextBoxSifre.Text = TextBoxTekrar.Text Then
                If KullaniciAra(TextBoxUserName.Text).Rows.Count = 0 Then
                    'Kullanıcıyı Ekle
                    ErrorProviderBRP.SetError(TextBoxTekrar, Nothing)
                    Dim Baglanti As New VT_Baglan
                    Try
                        Dim Sorgu As String = "INSERT INTO Kullanici_Tablosu (Kullanici_Adi,Sifre,Guvenlik_Sorusu,Cevap,Yetki) VALUES (@KAdi,@Sifre,@Soru,@Cevap,@Yetki)"
                        Dim SQLKomut As New SqlCommand(Sorgu, Baglanti.SQLBaglanti)
                        SQLKomut.Parameters.Add("@KAdi", SqlDbType.NVarChar, 20).Value = TextBoxUserName.Text
                        SQLKomut.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128).Value = Baglanti.SHA512_Hash(TextBoxSifre.Text)
                        SQLKomut.Parameters.Add("@Soru", SqlDbType.NVarChar, 40).Value = TextBoxSoru.Text
                        SQLKomut.Parameters.Add("@Cevap", SqlDbType.NVarChar, 128).Value = Baglanti.SHA512_Hash(TextBoxCevap.Text)
                        SQLKomut.Parameters.Add("@Yetki", SqlDbType.NVarChar, 1).Value = ComboBoxYetki.SelectedItem.ToString.Substring(0, 1)
                        Baglanti.SQLBaglanti.Open()
                        SQLKomut.ExecuteNonQuery()
                        MsgBox(TextBoxUserName.Text & " kullanıcısı başarılı bir şekilde eklenmiştir.")
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                        Me.Close()
                    Catch ex As Exception
                        MsgBox("Yeni kullanıcı ekleme işleminde hata. " & ex.Message)
                    Finally
                        Baglanti.SQLBaglanti.Close()
                    End Try
                Else
                    MsgBox("Bu kullanıcı daha önceden eklenmiş. Tekrar ekleyemezsiniz.")
                End If
            Else
                ErrorProviderBRP.SetError(TextBoxTekrar, "Şifre tekrarı hatalı")
                TextBoxTekrar.Focus()
            End If

        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub YeniKullaniciEkleFormu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub YeniKullaniciEkleFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxYetki.SelectedIndex = 0
    End Sub

    Private Sub PictureBoxSifre_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBoxSifre.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            TextBoxSifre.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub PictureBoxSifre_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBoxSifre.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            TextBoxSifre.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBoxTekrar_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBoxTekrar.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            TextBoxTekrar.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub PictureBoxTekrar_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBoxTekrar.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            TextBoxTekrar.UseSystemPasswordChar = True
        End If
    End Sub
End Class
