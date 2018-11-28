Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormInfoMasaKadaluasrsa

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
       
    End Sub
    Sub isigrid()
        Dim query As String = "SELECT * FROM tb_stok_detail WHERE masa_kadaluarsa < DATE_ADD(NOW(), INTERVAL +1 MONTH)"
        Dim da As New MySqlDataAdapter(query, hubung)
        Dim ds As New DataSet()
        If da.Fill(ds) Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub FormInfoMasaKadaluasrsa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call isigrid()
    End Sub
End Class