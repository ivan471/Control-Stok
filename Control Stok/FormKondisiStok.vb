Imports MySql.Data.MySqlClient
Public Class FormKondisiStok
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        Else
            Dim ubah As String = "Update tb_stok set stok_min='" & TextBox4.Text & "', stok_max = '" & TextBox5.Text & "' where id_barang='" & TextBox1.Text & "'"
            Call simpandata(ubah)
            MsgBox("Berhasil Diubah")
            Me.Close()
        End If
    End Sub
    Private Sub FormKondisiStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub
    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPilihItem.txtkode.Text = "3"
        FormPilihItem.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Hanya Boleh Angka Yang Diisi !!!", MsgBoxStyle.Information, "Peringatan")
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class