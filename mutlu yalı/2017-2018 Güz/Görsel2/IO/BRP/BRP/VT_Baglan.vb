Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class VT_Baglan
    Public SQLBaglanti As New SqlConnection(SQLBaglantiCumlesi)

    Private Function SQLBaglantiCumlesi() As String
        Dim BagCumle As New SqlConnectionStringBuilder
        BagCumle.DataSource = "localhost"
        BagCumle.InitialCatalog = "BRP_VT"
        BagCumle.UserID = "sa"
        BagCumle.Password = "mmyo"
        Return BagCumle.ConnectionString
    End Function
    Public Function SHA512_Hash(ByVal Metin As String) As String
        Dim HashServis As New SHA512CryptoServiceProvider 'Kriptolamada kullanılacak servis sağlayıcısını tanımla
        Dim ByteMetin() As Byte = Encoding.UTF8.GetBytes(Metin) 'Metin değişkenindeki bilgiyi byte dizisi halıine getir
        ByteMetin = HashServis.ComputeHash(ByteMetin) 'Kriptolama işlemini gerçekleştir
        Dim Sonuc As String = Nothing
        For Each Karakter As Byte In ByteMetin
            Sonuc &= Karakter.ToString("x2") 'karakter byte türünden x2 formatında string
            ' ifadeye dönüşüm yapıp sonuc değişkenine birleştirme yapıyor
        Next
        Return Sonuc
    End Function
End Class
