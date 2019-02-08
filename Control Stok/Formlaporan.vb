Imports CrystalDecisions.CrystalReports.Engine
Public Class Formlaporan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "1" Then
            Dim report As New ReportDocument
            report.Load("..\..\LaporanMasuk.rpt")
            report.SetParameterValue("Tgl", DateTimePicker1.Value)
            report.SetParameterValue("Tgl2", DateTimePicker2.Value)
            FormLaporanStokMasuk.CrystalReportViewer1.ReportSource = report
            FormLaporanStokMasuk.CrystalReportViewer1.Refresh()
            Me.Close()
            FormLaporanStokMasuk.ShowDialog()
        Else
            Dim report As New ReportDocument
            report.Load("..\..\LaporanStokKeluar.rpt")
            report.SetParameterValue("awal", DateTimePicker1.Value)
            report.SetParameterValue("akhir", DateTimePicker2.Value)
            FormLaporanStokKeluar.CrystalReportViewer1.ReportSource = report
            FormLaporanStokKeluar.CrystalReportViewer1.Refresh()
            Me.Close()
            FormLaporanStokKeluar.ShowDialog()
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox2.Text = Me.DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        TextBox3.Text = Me.DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub
End Class