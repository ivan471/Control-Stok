Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormDetailStok

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Sub isigrid()
        Dim query As String = "SELECT * FROM tb_stok_detail WHERE id_barang= " & TextBox1.Text & " ORDER BY no_masuk DESC"
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
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class