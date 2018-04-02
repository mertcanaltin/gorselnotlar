Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class MenuKayitFormu
    Private Baglanti As New VT_Baglan
    Private SQLVeriBRP_SDA As SqlDataAdapter
    Private MenuVeriTablosu As New DataTable
    Private Gezgin As CurrencyManager

    Private Sub MenuKayitFormu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Gezgin.EndCurrentEdit()
        Dim DegisiklikTablosu As DataTable = MenuVeriTablosu.GetChanges
        If Not IsNothing(DegisiklikTablosu) Then
            Dim DonenDeger As MsgBoxResult = MsgBox("Kayıtlar üzerinde Silme, Düzenleme veya ekleme gibi işlemler yapılmış. Bu işlemleri kaydetmek istiyormusunuz?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton3 + MsgBoxStyle.Question, "Kayıtlar Üzerinde Değişiklik Uyarısı")
            If DonenDeger = MsgBoxResult.Yes Then
                Kaydet()
            ElseIf DonenDeger = MsgBoxResult.No Then
                MsgBox("Yapılan değişiklikler kaydedilmedi.")
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub MenuKayitFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Baglanti.SQLBaglanti.Open()
            Dim SqlCumle As String = "Select * From Menu_Tablosu"
            SQLVeriBRP_SDA = New SqlDataAdapter(SqlCumle, Baglanti.SQLBaglanti)
            SQLVeriBRP_SDA.Fill(MenuVeriTablosu)
            MenuDataGridView.DataSource = MenuVeriTablosu
            KategoriYukle()
            NesneleriBagla(MenuVeriTablosu)
            '********Insert, Update ve Delete SQL cümlelerini oluştur**********
            Dim KomutOlustur As New SqlCommandBuilder(SQLVeriBRP_SDA)
            SQLVeriBRP_SDA.InsertCommand = KomutOlustur.GetInsertCommand
            SQLVeriBRP_SDA.UpdateCommand = KomutOlustur.GetUpdateCommand
            SQLVeriBRP_SDA.DeleteCommand = KomutOlustur.GetDeleteCommand
            '*******Gezgin nesnesi ile MenuVeriTablosunu ilişkilendir.**********
            Gezgin = CType(Me.BindingContext(MenuVeriTablosu), CurrencyManager)
            'Gezgin nesnesine olay atama
            AddHandler Gezgin.PositionChanged, AddressOf Gezgin_PozisyonDegisimi
            Gezgin.Position = Gezgin.Count - 1
            Duzenle(False)
        Catch ex As Exception
            MsgBox("Veri tabanı hatası. Hata: " & ex.Message)
        Finally
            If Baglanti.SQLBaglanti.State <> ConnectionState.Closed Then
                Baglanti.SQLBaglanti.Close()
            End If
        End Try
    End Sub
    Private Sub NesneleriBagla(ByRef VeriTablosu As DataTable)
        Menu_Urun_Adi_TBox.DataBindings.Add("Text", VeriTablosu, "Menu_Urun_Adi")
        Fiyat_TBox.DataBindings.Add("Text", VeriTablosu, "Fiyat")
        icerik_TBox.DataBindings.Add("Text", VeriTablosu, "icerik")
        Kategori_CBox.DataBindings.Add("SelectedValue", VeriTablosu, "Kategori")
        Fotograf_PBox.DataBindings.Add("Image", VeriTablosu, "Fotograf", True, DataSourceUpdateMode.Never)
    End Sub
    Private Sub KategoriYukle()
        Dim Liste As New XmlDocument
        Liste.Load("Kategoriler.xml")
        Dim isimListesi As XmlNodeList = Liste.SelectNodes("/kategori/isim")

        Dim Kategoriler As New Dictionary(Of String, String)()
        Kategori_CBox.Items.Clear()
        For Each isim As XmlNode In isimListesi
            Kategoriler.Add(isim.InnerText, isim.InnerText)
        Next
        Kategori_CBox.DataSource = New BindingSource(Kategoriler, Nothing)
        Kategori_CBox.DisplayMember = "Value"
        Kategori_CBox.ValueMember = "Key"
    End Sub

    Private Sub ilkKayitBtn_Click(sender As Object, e As EventArgs) Handles ilkKayitBtn.Click
        Gezgin.Position = 0
    End Sub

    Private Sub OncekiBtn_Click(sender As Object, e As EventArgs) Handles OncekiBtn.Click
        If Gezgin.Position > 0 Then
            Gezgin.Position -= 1
        End If
    End Sub

    Private Sub SonrakiBtn_Click(sender As Object, e As EventArgs) Handles SonrakiBtn.Click
        If Gezgin.Position < Gezgin.Count - 1 Then
            Gezgin.Position += 1
        End If
    End Sub

    Private Sub SonKayitBtn_Click(sender As Object, e As EventArgs) Handles SonKayitBtn.Click
        Gezgin.Position = Gezgin.Count - 1
    End Sub

    Private Sub YeniKayitBtn_Click(sender As Object, e As EventArgs) Handles YeniKayitBtn.Click
        Gezgin.AddNew()
        Duzenle(True)
        Menu_Urun_Adi_TBox.Focus()
    End Sub

    Private Sub DuzenleBtn_Click(sender As Object, e As EventArgs) Handles DuzenleBtn.Click
        Duzenle()
    End Sub

    Private Sub SilBtn_Click(sender As Object, e As EventArgs) Handles SilBtn.Click
        If BRPAnaForm.Yetki = "Y" Then
            If MsgBox("Üzerinde bulunduğunuz kayıt silinecek. Kaydı silmek istediğinize emin misiniz?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Kayıt Silme Uyarısı") = MsgBoxResult.Yes Then
                Gezgin.RemoveAt(Gezgin.Position)
                Me.Validate()
            End If
        Else
            MsgBox("Kayıt silme yetkiniz bulunmamaktadır. Sistem yöneticinize başvurunuz.")
        End If
    End Sub

    Private Sub VazgecBtn_Click(sender As Object, e As EventArgs) Handles VazgecBtn.Click
        If MsgBox("Yaptığınız değişiklikler iptal edilecek. İptal etmek istediğinize emin misiniz?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Kayıt Silme Uyarısı") = MsgBoxResult.Yes Then
            Gezgin.CancelCurrentEdit()
            Me.Validate()
        End If
    End Sub

    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Kaydet()
    End Sub
    Private Sub Kaydet()
        Try
            Me.Validate()
            Gezgin.EndCurrentEdit()
            Baglanti.SQLBaglanti.Open()
            SQLVeriBRP_SDA.Update(MenuVeriTablosu)
            MsgBox("Kaydetme işlemi başarılı olarak gerçekleşti.")
        Catch ex As Exception
            MsgBox("Hata: " & ex.Message)
        Finally
            Baglanti.SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub Gezgin_PozisyonDegisimi(sender As Object, e As EventArgs)
        Duzenle(False)
        ilkKayitBtn.Enabled = True
        OncekiBtn.Enabled = True
        SonrakiBtn.Enabled = True
        SonKayitBtn.Enabled = True
        If Gezgin.Position = 0 Then
            ilkKayitBtn.Enabled = False
            OncekiBtn.Enabled = False
        End If
        If Gezgin.Position = Gezgin.Count - 1 Then
            SonrakiBtn.Enabled = False
            SonKayitBtn.Enabled = False
        End If
    End Sub
    Private Sub Duzenle(Optional ByVal Durum As Boolean = True)
        For Each Nesne As Control In Me.SplitContainerBRP.Panel1.Controls
            If Nesne.Tag = "D" Then
                Nesne.Enabled = Durum
            End If
        Next
    End Sub

    Private Sub Fotograf_PBox_DoubleClick(sender As Object, e As EventArgs) Handles Fotograf_PBox.DoubleClick
        If Gezgin.Count > 0 And Menu_Urun_Adi_TBox.Enabled = True Then
            If OpenFileDialogBRP.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Foto As Image = Image.FromFile(OpenFileDialogBRP.FileName)

                Dim EnBoy As Size
                EnBoy.Height = Fotograf_PBox.Size.Height
                Dim Oran As Decimal = EnBoy.Height / Foto.Height
                EnBoy.Width = Foto.Width * Oran

                Dim Resim As Bitmap = New Bitmap(EnBoy.Width, EnBoy.Height)
                Dim Grafik As Graphics = Graphics.FromImage(Resim)
                Grafik.InterpolationMode = Drawing2D.InterpolationMode.High
                Grafik.DrawImage(Foto, 0, 0, EnBoy.Width, EnBoy.Height)

                Foto = Resim
                Fotograf_PBox.Image = Foto

                Dim Satir As DataRowView = Gezgin.Current
                Satir.BeginEdit()
                Dim MS As New MemoryStream
                Foto.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                Satir("Fotograf") = MS.ToArray()
                Satir.EndEdit()
            End If
        End If
    End Sub
End Class