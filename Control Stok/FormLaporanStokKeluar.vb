Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormLaporanStokKeluar

    Private Sub LaporanStokKeluar1_InitReport(sender As Object, e As EventArgs) Handles LaporanStokKeluar1.InitReport

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stringformula As String
        stringformula = "{tb_stok_masuk1.tanggal_masuk} >= #" & Me.DateTimePicker1.Value.ToShortDateString & "#"
        stringformula &= "AND {tb_stok_masuk1.tanggal_masuk} <= #" & Me.DateTimePicker2.Value.ToShortDateString & "#"
        CrystalReportViewer1.SelectionFormula = stringformula
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class