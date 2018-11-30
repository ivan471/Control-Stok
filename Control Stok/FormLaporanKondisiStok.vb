Public Class FormLaporanKondisiStok

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stringformula As String
        stringformula = "{tb_kondisi1.tanggal} >= #" & Me.DateTimePicker1.Value.ToShortDateString & "#"
        stringformula &= "AND {tb_kondisi1.tanggal} <= #" & Me.DateTimePicker2.Value.ToShortDateString & "#"
        CrystalReportViewer1.SelectionFormula = stringformula
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class