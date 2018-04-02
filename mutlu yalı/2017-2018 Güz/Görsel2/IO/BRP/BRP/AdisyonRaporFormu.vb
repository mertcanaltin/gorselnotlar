Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class AdisyonRaporFormu

    Private Sub AdisyonRaporFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CRBaglantiBilgileri As New ConnectionInfo
        CRBaglantiBilgileri.ServerName = "."
        CRBaglantiBilgileri.DatabaseName = "BRP_VT"
        CRBaglantiBilgileri.UserID = "sa"
        CRBaglantiBilgileri.Password = "mmyo"
        'CRBaglantiBilgileri.IntegratedSecurity=True 
        Dim Rapor As ReportDocument = AdisyonCrystalReportViewer.ReportSource
        Dim RaporTablolari As Tables = Rapor.Database.Tables
        For Each Tablo As Table In RaporTablolari
            Dim BaglantiBilgileri As New TableLogOnInfo
            BaglantiBilgileri = Tablo.LogOnInfo
            BaglantiBilgileri.ConnectionInfo = CRBaglantiBilgileri
            Tablo.ApplyLogOnInfo(BaglantiBilgileri)
        Next
        AdisyonCrystalReportViewer.RefreshReport()
    End Sub
End Class