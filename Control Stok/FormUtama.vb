Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormUtama
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Timer1.Enabled = True
        Call isigrid()
        Call isigridhapus()
        Call cek()
        Call judulgrid()
    End Sub
    Sub judulgrid()
        If DataGridView1.RowCount > 0 Then
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            DataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = DataGridView1.Columns(0).DefaultCellStyle
            DataGridView1.Columns(0).HeaderText = "Tanggal Masuk"
            DataGridView1.Columns(1).HeaderText = "No Masuk"
            DataGridView1.Columns(2).HeaderText = "Id Barang"
            DataGridView1.Columns(3).HeaderText = "Nama Barang"
            DataGridView1.Columns(4).HeaderText = "Merek"
            DataGridView1.Columns(5).HeaderText = "Jumlah"
            DataGridView1.Columns(6).HeaderText = "Satuan Barang"
            DataGridView1.Columns(7).HeaderText = "Masa Kadaluarsa"
            DataGridView1.Columns(0).Width = 80
            DataGridView1.Columns(1).Width = 150
            objAlternatingCellStyle.BackColor = Color.AntiqueWhite
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub

    Sub cek()
        Dim id, no As String
        If DataGridView1.RowCount = 0 Then
            DataGridView1.Visible = False
            Label1.Visible = False
        Else
            DataGridView1.Visible = True
            Label1.Visible = True
            Dim i As Integer
            For i = 0 To DataGridView2.RowCount - 1
                no = DataGridView2.Item(0, i).Value
                id = DataGridView2.Item(1, i).Value
                If DataGridView1.RowCount > 0 Then
                    Dim delete As String = "delete from tb_stok_detail where no_masuk=" & no & " and id_barang = " & id & ""
                    Call HAPUSDATA(delete)
                    'MessageBox.Show("Found ----")
                End If
            Next
        End If
    End Sub
    Sub isigrid()
        Dim query As String = "SELECT tanggal_masuk,no_masuk,id_barang,nama_barang,merek,jumlah_brg,satuan,masa_kadaluarsa FROM tb_stok_detail inner join tb_stok using (id_barang) WHERE masa_kadaluarsa < DATE_ADD(NOW(), INTERVAL +1 MONTH)"
        Dim da As New MySqlDataAdapter(query, hubung)
        Dim ds As New DataSet()
        If da.Fill(ds) Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()
        End If
    End Sub
    Sub isigridhapus()
        Dim query As String = "SELECT * FROM tb_stok_detail WHERE masa_kadaluarsa = now() or masa_kadaluarsa <  DATE_ADD(NOW(), INTERVAL +1 MONTH)"
        Dim da As New MySqlDataAdapter(query, hubung)
        Dim ds As New DataSet()
        If da.Fill(ds) Then
            DataGridView2.DataSource = ds.Tables(0)
            DataGridView2.Refresh()
        End If
    End Sub
    Private Sub StokBarangMasuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokBarangMasuToolStripMenuItem.Click
        Formlaporan.TextBox1.Text = "1"
        Formlaporan.ShowDialog()
    End Sub

    Private Sub BarangMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangMasukToolStripMenuItem.Click
        FormPenginputanStokMasuk.ShowDialog()
    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangKeluarToolStripMenuItem.Click
        FormPenginputanStokKeluar.ShowDialog()
    End Sub

    Private Sub StokBarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokBarangKeluarToolStripMenuItem.Click
        Formlaporan.TextBox1.Text = "2"
        Formlaporan.ShowDialog()
    End Sub

    Private Sub StokBarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StokBarangToolStripMenuItem1.Click
        FormLaporanStok.ShowDialog()
    End Sub
    Private Sub StokRusakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokRusakToolStripMenuItem.Click
        FormKondisiStok.ShowDialog()
    End Sub

    Private Sub DaftarStokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarStokToolStripMenuItem.Click
        FormDaftarStok.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'TextBox1.Text = Format(Now, "yyyy/MM/dd")
        TextBox1.Text = Format(Now, "dd/MMM/yy")
    End Sub
End Class
