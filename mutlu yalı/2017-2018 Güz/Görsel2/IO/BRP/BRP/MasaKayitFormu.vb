Imports System.Data.SqlClient
Public Class MasaKayitFormu
    Private XY As Point
    Private Baglanti As New VT_Baglan
    Private SQLVeriBRP_SDA As SqlDataAdapter
    Private MasaVeriDS As New DataSet
    Private Sub Kaydet()
        Try
            Me.Validate()
            Baglanti.SQLBaglanti.Open()
            SQLVeriBRP_SDA.Update(MasaVeriDS.Tables("Masa_Tablosu"))
        Catch ex As Exception
            MsgBox("Hata: " & ex.Message)
        Finally
            Baglanti.SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub MasaEkleButton_Click(sender As Object, e As EventArgs) Handles MasaEkleButton.Click
        If MasaBilgileriFormu.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim MasaNo As String = MasaBilgileriFormu.MasaNo_TBox.Text
            Dim Kapasite As Integer = MasaBilgileriFormu.Kapasite_NUD.Value
            Dim Satir As DataRow = MasaVeriDS.Tables("Masa_tablosu").NewRow
            Satir("Masa_No") = MasaNo
            Satir("Kapasite") = Kapasite
            Satir("Durum") = "B"
            Satir("Konum_X") = 0
            Satir("Konum_Y") = 0
            MasaVeriDS.Tables("Masa_Tablosu").Rows.Add(Satir)
            Kaydet()
            MasaGetir(MasaVeriDS)
        End If
    End Sub
    Private Sub Masa(ByVal MasaNo As String, ByVal Kapasite As Integer, Optional ByVal X As Integer = 0, Optional ByVal Y As Integer = 0)
        Dim MasaButton As New Button
        MasaButton.Size = New Size(100, 100)
        MasaButton.Location = New Point(X, Y)
        MasaButton.ImageList = imageListBRP
        MasaButton.ImageIndex = 0
        MasaButton.Text = MasaNo
        MasaButton.Tag = Kapasite
        MasaButton.Parent = Me.SplitContainerBRP.Panel2
        AddHandler MasaButton.MouseMove, AddressOf MasaButton_MouseMove
        AddHandler MasaButton.MouseUp, AddressOf MasaButton_MouseUp
        AddHandler MasaButton.MouseDown, AddressOf MasaButton_MouseDown
    End Sub
    Private Sub MasaButton_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim MButton As Button = sender
            XY = MButton.PointToClient(Control.MousePosition)
        End If
    End Sub
    Private Sub MasaButton_MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim MButton As Button = sender
            MButton.Location = Me.SplitContainerBRP.Panel2.PointToClient(Control.MousePosition) - XY
        End If
    End Sub
    Private Sub MasaButton_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim MButton As Button = sender
            Dim Satir As DataRow = MasaVeriDS.Tables("Masa_Tablosu").Select("Masa_No='" & MButton.Text & "'")(0)
            Satir.BeginEdit()
            Satir("Konum_X") = MButton.Location.X
            Satir("Konum_Y") = MButton.Location.Y
            Satir.EndEdit()
            Kaydet()
        End If
    End Sub

    Private Sub MasaKayitFormu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Baglanti.SQLBaglanti.Open()
            Dim Sorgu As String = "Select * From Masa_Tablosu"
            SQLVeriBRP_SDA = New SqlDataAdapter(Sorgu, Baglanti.SQLBaglanti)
            SQLVeriBRP_SDA.Fill(MasaVeriDS, "Masa_Tablosu")
            'SQLDataAdapter nesnesine INSERT, UPDATE ve DELETE cümlelerini ekliyoruz
            Dim KomutOlustur As New SqlCommandBuilder(SQLVeriBRP_SDA)
            SQLVeriBRP_SDA.InsertCommand = KomutOlustur.GetInsertCommand
            SQLVeriBRP_SDA.UpdateCommand = KomutOlustur.GetUpdateCommand
            SQLVeriBRP_SDA.DeleteCommand = KomutOlustur.GetDeleteCommand
            'Kayıtlı masaları panele yerleştir.
            MasaGetir(MasaVeriDS)
        Catch ex As Exception
            MsgBox("Veri tabanı hatası. Hata: " & ex.Message)
        Finally
            If Baglanti.SQLBaglanti.State <> ConnectionState.Closed Then
                Baglanti.SQLBaglanti.Close()
            End If
        End Try
    End Sub
    Private Sub MasaGetir(ByRef MasaDS As DataSet)
        SplitContainerBRP.Panel2.Controls.Clear()
        For Each Satir As DataRow In MasaDS.Tables("Masa_Tablosu").Rows
            Dim MasaNo As String = Satir("Masa_No")
            Dim Kapasite As Integer = Satir("Kapasite")
            Dim X As Integer = Satir("Konum_X")
            Dim Y As Integer = Satir("Konum_Y")
            Masa(MasaNo, Kapasite, X, Y)
        Next
    End Sub
End Class