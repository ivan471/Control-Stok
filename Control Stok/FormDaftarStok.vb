Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormDaftarStok

    Private Sub FormDaftarStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call isigrid()
        Call judulgrid()
        Button1.Enabled = False
    End Sub
    Sub judulgrid()
        If DataGridView1.RowCount > 0 Then
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            DataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = DataGridView1.Columns(0).DefaultCellStyle
            DataGridView1.Columns(0).HeaderText = "Id Barang"
            DataGridView1.Columns(1).HeaderText = "Nama Barang"
            DataGridView1.Columns(2).HeaderText = "Merek"
            DataGridView1.Columns(3).HeaderText = "Jumlah Stok"
            DataGridView1.Columns(4).HeaderText = "Min Stok"
            DataGridView1.Columns(5).HeaderText = "Max Stok"
            DataGridView1.Columns(6).HeaderText = "Satuan Barang"
            DataGridView1.Columns(7).HeaderText = "Status Stok"
            DataGridView1.Columns(0).Width = 80
            DataGridView1.Columns(1).Width = 150
            objAlternatingCellStyle.BackColor = Color.AntiqueWhite
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub
    Sub isigrid()
        Dim query As String = "SELECT * from tb_stok"
        Dim da As New MySqlDataAdapter(query, hubung)
        Dim ds As New DataSet()
        If da.Fill(ds) Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.RowCount > 0 Then
            Dim baris As Integer
            With DataGridView1
                baris = .CurrentRow.Index
                TextBox1.Text = .Item(0, baris).Value
            End With
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then

        Else
            FormDetailStok.TextBox1.Text = TextBox1.Text
            FormDetailStok.ShowDialog()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class