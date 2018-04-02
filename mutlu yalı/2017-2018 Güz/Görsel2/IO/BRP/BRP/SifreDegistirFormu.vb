Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class SifreDegistirFormu

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim Baglanti As New VT_Baglan
        If BRPAnaForm.Password = Baglanti.SHA512_Hash(TextBoxMevcut.Text) Then
            If TextBoxYeni.Text = TextBoxTekrar.Text Then
                Dim Sorgu As String = "UPDATE Kullanici_Tablosu SET Sifre=@Sifre WHERE Kullanici_Adi=@KAdi"
                Dim SQLKomut As New SqlCommand(Sorgu, Baglanti.SQLBaglanti)
                SQLKomut.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128)
                SQLKomut.Parameters.Add("@KAdi", SqlDbType.NVarChar, 20)
                SQLKomut.Parameters("@Sifre").Value = Baglanti.SHA512_Hash(TextBoxYeni.Text)
                SQLKomut.Parameters("@KAdi").Value = BRPAnaForm.UserName
                Try
                    Baglanti.SQLBaglanti.Open()
                    SQLKomut.ExecuteNonQuery()
                    BRPAnaForm.Password = Baglanti.SHA512_Hash(TextBoxYeni.Text)
                    MsgBox("Şifreniz yenilenmiştir.")
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Şifre Değişiminde hata ile karşılaşıldı. Hata:" & ex.Message)
                Finally
                    Baglanti.SQLBaglanti.Close()
                End Try
            Else
                MsgBox("Şifre Tekrarında hata.")
                TextBoxTekrar.Focus()
            End If
        Else
            MsgBox("Mevcut şifrenizi hatalı girdiniz.")
            TextBoxMevcut.Focus()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SifreDegistirFormu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub SifreDegistirFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxUserName.Text = BRPAnaForm.UserName
    End Sub

    Private Sub CheckBoxGizle_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxGizle.CheckedChanged
        If CheckBoxGizle.Checked Then
            TextBoxMevcut.UseSystemPasswordChar = True
            TextBoxYeni.UseSystemPasswordChar = True
            TextBoxTekrar.UseSystemPasswordChar = True
        Else
            TextBoxMevcut.UseSystemPasswordChar = False
            TextBoxYeni.UseSystemPasswordChar = False
            TextBoxTekrar.UseSystemPasswordChar = False
        End If
    End Sub
End Class
