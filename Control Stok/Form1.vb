Imports CrystalDecisions.CrystalReports.Engine
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
     
        'TextBox2.Text = dt1.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "1" Then
            FormLaporanStokMasuk.LaporanMasuk1.SetParameterValue("tgl_awal", dt1.Text)
            FormLaporanStokMasuk.LaporanMasuk1.SetParameterValue("tgl_akhir", dt2.Text)
            'FormLaporanStokMasuk.LaporanMasuk1.RefreshReport()
            FormLaporanStokMasuk.ShowDialog()
            Me.Close()
        ElseIf TextBox1.Text = "2" Then
            FormLaporanStokKeluar.LaporanStokKeluar1.SetParameterValue("awal", dt1.Text)
            FormLaporanStokKeluar.LaporanStokKeluar1.SetParameterValue("akhir", dt2.Text)
            FormLaporanStokKeluar.LaporanStokKeluar1.Refresh()
            FormLaporanStokKeluar.ShowDialog()
            Me.Close()
        ElseIf TextBox1.Text = "3" Then
            FormLaporanKondisiStok.LaporanKondisi1.SetParameterValue("awal", dt1.Text)
            FormLaporanKondisiStok.LaporanKondisi1.SetParameterValue("akhir", dt2.Text)
            FormLaporanKondisiStok.LaporanKondisi1.Refresh()
            FormLaporanStokKeluar.ShowDialog()
            Me.Close()
        End If
        
    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged

    End Sub
End Class