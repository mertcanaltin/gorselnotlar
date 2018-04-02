Imports System.Data.SqlClient
Public Class AdisyonFormu
    Private Baglanti As New VT_Baglan
    Private MasaSDA As SqlDataAdapter
    Private AdisyonSDA As SqlDataAdapter
    Private AdisyonDetaySDA As SqlDataAdapter
    Private MenuSDA As SqlDataAdapter
    Private PersonelSDA As SqlDataAdapter
    Private AdisyonDV As DataView
    Private AdisyonCR As CurrencyManager
    Private VeriDS As New DataSet
    Private Sub Masalar(ByVal Sorgu As String)
        Try
            MasaSDA = New SqlDataAdapter(Sorgu, Baglanti.SQLBaglanti)
            Baglanti.SQLBaglanti.Open()
            MasaSDA.Fill(VeriDS, "Masa_Tablosu")
            MasalariGetir()
        Catch ex As Exception
            MsgBox("Masalar Oluşturulurken hata ile karşılaşıldı.")
        Finally
            Baglanti.SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub MasalariGetir()
        If VeriDS.Tables("Masa_Tablosu").Rows.Count > 0 Then
            For Each Satir As DataRow In VeriDS.Tables("Masa_Tablosu").Rows
                Dim Durum As Integer
                Select Case Satir("Durum")
                    Case "B"
                        Durum = 0
                    Case "D"
                        Durum = 1
                    Case "R"
                        Durum = 2
                    Case Else
                        Durum = 0
                End Select
                Masa(Satir("Masa_No"), Satir("Kapasite"), Durum, Satir("Konum_X"), Satir("Konum_Y"))
            Next
        End If
    End Sub
    Private Sub Adisyon_Bilgilerini_Getir()
        Try
            'Adisyon_Baslik_Tablosu Bilgileri
            Dim Sorgu As String = "Select * From Adisyon_Baslik_Tablosu Where Durum=@Durum"
            AdisyonSDA = New SqlDataAdapter(Sorgu, Baglanti.SQLBaglanti)
            AdisyonSDA.SelectCommand.Parameters.Add("@Durum", SqlDbType.Bit).Value = 1
            Baglanti.SQLBaglanti.Open()
            AdisyonSDA.Fill(VeriDS, "Adisyon_Baslik_Tablosu")
            'Adisyon_Siparis_Tablosu Bilgileri
            Sorgu = "Select * From Adisyon_Siparis_Tablosu"
            AdisyonDetaySDA = New SqlDataAdapter(Sorgu, Baglanti.SQLBaglanti)
            AdisyonDetaySDA.Fill(VeriDS, "Adisyon_Siparis_Tablosu")

           
            'Adisyona konumlanmak için
            AdisyonDV = New DataView(VeriDS.Tables("Adisyon_Baslik_Tablosu"))
            AdisyonDV.Sort = "Masa_No"
            AdisyonCR = Me.BindingContext(AdisyonDV)
            'Adsiyon_Baslik_Tablos ile Adisyon_Siparis_Tablosu'nu ilişkilendir.
            Dim Adisyon_Baglantisi As New DataRelation("Adisyon_iliskisi", VeriDS.Tables("Adisyon_Baslik_Tablosu").Columns("Adisyon_No"), VeriDS.Tables("Adisyon_Siparis_Tablosu").Columns("Adisyon_No"))
            VeriDS.Relations.Add(Adisyon_Baglantisi)

            Dim Adisyon_Baslik_Kaynagi As New BindingSource
            Adisyon_Baslik_Kaynagi.DataSource = AdisyonDV

            Dim Adisyon_Siparis_Kaynagi As New BindingSource
            Adisyon_Siparis_Kaynagi.DataSource = Adisyon_Baslik_Kaynagi
            Adisyon_Siparis_Kaynagi.DataMember = "Adisyon_iliskisi"

            Adisyon_Baslik_Neslelerini_Bagla()
            DataGridView1.DataSource = Adisyon_Siparis_Kaynagi
        Catch ex As Exception
            MsgBox("Adisyon Bilgileri Getirilirken hata ile karşılaşıldı.")
        Finally
            Baglanti.SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub Adisyon_Baslik_Neslelerini_Bagla()
        LabelMasa_No.DataBindings.Add("Text", AdisyonDV, "Masa_No")
        TextBoxAdisyon_No.DataBindings.Add("Text", AdisyonDV, "Adisyon_No")
        ComboBoxGarson.DataBindings.Add("SelectedValue", AdisyonDV, "Personel_No")
        TextBoxKisiSayisi.DataBindings.Add("Text", AdisyonDV, "Kisi_Sayisi")
        TextBoxTutar.DataBindings.Add("Text", AdisyonDV, "Tutar")
        MaskedTextBoxTarihSaat.ValidatingType = GetType(System.DateTime)
        MaskedTextBoxTarihSaat.DataBindings.Add("Text", AdisyonDV, "Tarih_Saat", True, DataSourceUpdateMode.OnPropertyChanged, vbNull, "dd/MM/yyyy HH:mm")
    End Sub
    Private Sub Garsonlari_Getir()
        Try
            Dim Sorgu As String = "Select Personel_Adi+' '+ Personel_Soyadi AdSoyad, * From Personel_Tablosu Where Gorevi=@Gorevi"
            PersonelSDA = New SqlDataAdapter(Sorgu, Baglanti.SQLBaglanti)
            PersonelSDA.SelectCommand.Parameters.Add("@Gorevi", SqlDbType.NVarChar, 20).Value = "Garson"
            Baglanti.SQLBaglanti.Open()
            PersonelSDA.Fill(VeriDS, "Personel_Tablosu")
            'Combobox'ta personel verilerini kullanıcıya gösterme
            ComboBoxGarson.DataSource = VeriDS.Tables("Personel_Tablosu")
            ComboBoxGarson.DisplayMember = "AdSoyad"
            ComboBoxGarson.ValueMember = "Personel_No"
        Catch ex As Exception
            MsgBox("Garsonlar getirilirken hata ile karşılaşıldı.")
        Finally
            Baglanti.SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub AdisyonFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Masalar("Select * From Masa_Tablosu")
        Adisyon_Bilgilerini_Getir()
        Garsonlari_Getir()
    End Sub
    Private Sub Masa(ByVal MasaNo As String, ByVal Kapasite As Integer, ByVal Durum As Integer, Optional ByVal X As Integer = 0, Optional ByVal Y As Integer = 0)
        Dim MasaButton As New Button
        MasaButton.Size = New Size(100, 100)
        MasaButton.Location = New Point(X, Y)
        MasaButton.ImageList = imageListBRP
        MasaButton.ImageIndex = Durum
        MasaButton.Text = MasaNo
        MasaButton.Tag = Kapasite
        MasaButton.Parent = Me.SplitContainerBRP.Panel2
        MasaButton.ContextMenuStrip = ContextMenuStripBRP
        AddHandler MasaButton.Click, AddressOf MasaButton_Click
        'AddHandler MasaButton.MouseUp, AddressOf MasaButton_MouseUp
        'AddHandler MasaButton.MouseDown, AddressOf MasaButton_MouseDown
    End Sub
    Private Sub MasaButton_Click(sender As Object, e As EventArgs)
        Dim Masa As Button = sender
        Dim Masa_No As String = Masa.Text
        Dim DV As New DataView(VeriDS.Tables("Masa_Tablosu"))
        DV.Sort = "Masa_No"
        Dim SatirNo As Integer = DV.Find(Masa_No)
        Dim Satir As DataRowView = DV(SatirNo)
        If Satir("Durum") = "D" Then
            'Adisyon Bilgisine Konumlan
            SatirNo = AdisyonDV.Find(Masa_No)
            If SatirNo > -1 Then
                AdisyonCR.Position = SatirNo
            End If
        Else
            If MsgBox(Satir("Masa_No") & " masası için adisyon açmak istediğinize emin misiniz?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Adisyon Açma uyarısı") = MsgBoxResult.Yes Then
                'Masaya adisyon aç
                If GarsonSecimFormu.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim GarsonNo As Integer = GarsonSecimFormu.ComboBox1.SelectedValue
                    GarsonSecimFormu.Dispose()
                    'Dim YeniAdisyon As DataRow = AdisyonDV.Table.NewRow()
                    'YeniAdisyon.BeginEdit()
                    'Tüm alanlara bilgi gönder
                    'YeniAdisyon("Masa_No") = Masa_No
                    'YeniAdisyon("Durum") = True
                    'YeniAdisyon.EndEdit()
                    ' AdisyonDV.Table.Rows.Add(YeniAdisyon)
                    'AdisyonSDA Update metodunu çalıştır
                    'Adisyon_Bilgilerini_Getir()
                End If
            End If
            End If
    End Sub

    Private Sub AdisyonAçToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdisyonAçToolStripMenuItem.Click
        Dim Masa As Button = DirectCast(ContextMenuStripBRP.SourceControl, Button)
        If Masa.ImageIndex = 0 Or Masa.ImageIndex = 2 Then
            If GarsonSecimFormu.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim GarsonNo As Integer = GarsonSecimFormu.ComboBox1.SelectedValue
                GarsonSecimFormu.Dispose()
                Dim MasaNo As String = Masa.Text

                MsgBox(GarsonNo)
            End If
        Else
            MsgBox("Bu masa dolu. Adisyon açmadan önce açık adisyonu kapatınız.")
        End If
    End Sub
End Class