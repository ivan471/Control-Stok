Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormDetailStok
    Sub isigrid()
        Dim query As String = "SELECT tanggal_masuk,no_masuk,id_barang,nama_barang,merek,jumlah_brg,satuan,masa_kadaluarsa FROM tb_stok_detail inner join tb_stok using(id_barang)WHERE id_barang= " & TextBox1.Text & " ORDER BY no_masuk DESC"
        Dim da As New MySqlDataAdapter(query, hubung)
        Dim ds As New DataSet()
        If da.Fill(ds) Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub FormDetailStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call isigrid()
        judulgrid()
    End Sub
    Sub judulgrid()
        Dim judul As New DataGridViewCellStyle()
        DataGridView1.AlternatingRowsDefaultCellStyle = judul
        Dim style As DataGridViewCellStyle = DataGridView1.Columns(0).DefaultCellStyle
        DataGridView1.Columns(0).HeaderText = "Tanggal Masuk"
        DataGridView1.Columns(1).HeaderText = "No Masuk"
        DataGridView1.Columns(2).HeaderText = "Id Barang"
        DataGridView1.Columns(3).HeaderText = "Nama Barang"
        DataGridView1.Columns(4).HeaderText = "Merek"
        DataGridView1.Columns(5).HeaderText = "Jumlah Barang"
        DataGridView1.Columns(6).HeaderText = "Satuan"
        DataGridView1.Columns(7).HeaderText = "Masa Kadaluarsa"
        DataGridView1.Columns(0).Width = 100
        judul.BackColor = Color.AliceBlue
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class