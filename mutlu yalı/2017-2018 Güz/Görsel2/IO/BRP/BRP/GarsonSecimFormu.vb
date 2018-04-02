Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class GarsonSecimFormu



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ComboBox1.SelectedIndex > -1 Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Lütfen garson seçimi yapınız.")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub GarsonSecimFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Baglanti As New VT_Baglan
        Try
            Dim Sorgu As String = "SELECT * FROM Personel_Tablosu WHERE Gorevi=@Gorevi"
            Dim SQLKomut As New SqlCommand(Sorgu, Baglanti.SQLBaglanti)
            SQLKomut.Parameters.Add("@Gorevi", SqlDbType.NVarChar, 20).Value = "Garson"
            Dim VeriTablosu As New DataTable
            Baglanti.SQLBaglanti.Open()
            VeriTablosu.Load(SQLKomut.ExecuteReader)
            ComboBox1.Items.Clear()
            Dim Garsonlar As New Dictionary(Of String, Integer)
            For Each Satir As DataRow In VeriTablosu.Rows
                Dim AdSoyad As String = String.Format("{0} {1}", Satir("Personel_Adi"), Satir("Personel_Soyadi"))
                Garsonlar.Add(AdSoyad, Satir("Personel_No"))
            Next
            ComboBox1.DataSource = New BindingSource(Garsonlar, Nothing)
            ComboBox1.DisplayMember = "Key"
            ComboBox1.ValueMember = "Value"
        Catch ex As Exception
            MsgBox("Hata oluştu. Hata:" & ex.Message)
        Finally
            Baglanti.SQLBaglanti.Close()
        End Try
    End Sub
End Class
