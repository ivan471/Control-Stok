Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormPilihItem

    Private Sub FormPilihItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call isigrid()
        Button1.Enabled = False
    End Sub
    Sub isigrid()
        If txtkode.Text = "3" Then
            Dim query As String = "SELECT no_masuk,id_barang,nama_barang,merek,jumlah_brg,satuan,masa_kadaluarsa,stok_min,stok_max from tb_stok_detail inner join tb_stok using(id_barang)"
            Dim da As New MySqlDataAdapter(query, hubung)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                DataGridView1.DataSource = ds.Tables(0)
                DataGridView1.Refresh()
            End If
        Else
            Dim query As String = "SELECT * from tb_stok"
            Dim da As New MySqlDataAdapter(query, hubung)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                DataGridView1.DataSource = ds.Tables(0)
                DataGridView1.Refresh()
            End If
        End If
    End Sub
    Sub isigriditem()
        If txtkode.Text = "3" Then
            cmd = New MySqlCommand("SELECT * FROM tb_stok WHERE id_barang= @id", hubung)
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = txtbox_id.Text
            Dim mda As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            mda.Fill(table)
            If table.Rows.Count() > 0 Then
                TextBox3.Text = table.Rows(0)(3).ToString()
            Else
                MessageBox.Show("No Data Found")
            End If
        Else
            cmd = New MySqlCommand("SELECT * FROM tb_stok_detail WHERE id_barang= @id ORDER BY no_masuk ASC LIMIT 2", hubung)
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = txtbox_id.Text
            Dim mda As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            mda.Fill(table)
            If table.Rows.Count() > 1 Then
                TextBox2.Text = table.Rows(0)(0).ToString()
                TextBox3.Text = table.Rows(0)(2).ToString()
                TextBox4.Text = table.Rows(1)(0).ToString()
                TextBox5.Text = table.Rows(1)(2).ToString()
            ElseIf table.Rows.Count() = 1 Then
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox2.Text = table.Rows(0)(0).ToString()
                TextBox3.Text = table.Rows(0)(2).ToString()
            Else
                ' MessageBox.Show("No Data Found")
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If txtkode.Text = "3" Then
            If DataGridView1.RowCount > 0 Then
                Dim baris As Integer
                With DataGridView1
                    baris = .CurrentRow.Index
                    TextBox2.Text = .Item(0, baris).Value
                    txtbox_id.Text = .Item(1, baris).Value
                    txtbox_nama.Text = .Item(2, baris).Value
                    txtbox_merek.Text = .Item(3, baris).Value
                    txtbox_jumlah.Text = .Item(4, baris).Value
                    txtbox_satuan.Text = .Item(5, baris).Value
                    txtbox_min.Text = .Item(7, baris).Value
                    txtbox_max.Text = .Item(8, baris).Value
                End With
            Else
            End If
            Button1.Enabled = True
            isigriditem()
        Else
            If DataGridView1.RowCount > 0 Then
                Dim baris As Integer
                With DataGridView1
                    baris = .CurrentRow.Index

                    txtbox_id.Text = .Item(0, baris).Value
                    txtbox_nama.Text = .Item(1, baris).Value
                    txtbox_merek.Text = .Item(2, baris).Value
                    txtbox_jumlah.Text = .Item(3, baris).Value
                    txtbox_satuan.Text = .Item(6, baris).Value
                    txtbox_min.Text = .Item(4, baris).Value
                    txtbox_max.Text = .Item(5, baris).Value
                End With
            Else
            End If
            Button1.Enabled = True
            isigriditem()
        End If
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtkode.Text = "1" Then
            FormPenginputanStokMasuk.txtbox_id.Text = txtbox_id.Text
            FormPenginputanStokMasuk.txtbox_namabrg.Text = txtbox_nama.Text
            FormPenginputanStokMasuk.txtbox_merek.Text = txtbox_merek.Text
            FormPenginputanStokMasuk.txtbox_satuan.Text = txtbox_satuan.Text
            FormPenginputanStokMasuk.txt_jumlah.Text = txtbox_jumlah.Text
            FormPenginputanStokMasuk.txt_min.Text = txtbox_min.Text
            FormPenginputanStokMasuk.txt_max.Text = txtbox_max.Text
            FormPenginputanStokMasuk.TextBox3.Enabled = True
            FormPenginputanStokMasuk.DateTimePicker1.Enabled = True
            FormPenginputanStokMasuk.Button1.Enabled = True
            Me.Close()
        ElseIf txtkode.Text = "2" Then
            FormPenginputanStokKeluar.TextBox1.Text = txtbox_id.Text
            FormPenginputanStokKeluar.TextBox2.Text = txtbox_nama.Text
            FormPenginputanStokKeluar.txtmerek.Text = txtbox_merek.Text
            FormPenginputanStokKeluar.txtbox_satuan.Text = txtbox_satuan.Text
            FormPenginputanStokKeluar.txtdataid_1.Text = TextBox2.Text
            FormPenginputanStokKeluar.txtdata1jmlh.Text = TextBox3.Text
            FormPenginputanStokKeluar.txtdataid_2.Text = TextBox4.Text
            FormPenginputanStokKeluar.txtdata2jmlh.Text = TextBox5.Text
            FormPenginputanStokKeluar.TextBox6.Text = txtbox_min.Text
            FormPenginputanStokKeluar.TextBox7.Text = txtbox_max.Text
            FormPenginputanStokKeluar.TextBox4.Text = txtbox_jumlah.Text
            FormPenginputanStokKeluar.TextBox3.Enabled = True
            FormPenginputanStokKeluar.Button1.Enabled = True
            Me.Close()
        Else
            FormKondisiStok.TextBox5.Text = TextBox2.Text
            FormKondisiStok.TextBox1.Text = txtbox_id.Text
            FormKondisiStok.TextBox2.Text = txtbox_nama.Text
            FormKondisiStok.TextBox10.Text = txtbox_merek.Text
            FormKondisiStok.TextBox4.Text = txtbox_satuan.Text
            FormKondisiStok.txt_jmlh.Text = txtbox_jumlah.Text
            FormKondisiStok.txt_min.Text = txtbox_min.Text
            FormKondisiStok.txt_max.Text = txtbox_max.Text
            FormKondisiStok.txtstok.Text = TextBox3.Text
            FormKondisiStok.Button1.Enabled = True
            FormKondisiStok.TextBox3.Enabled = True
            FormKondisiStok.RichTextBox1.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call seleksi()
    End Sub
    Sub seleksi()
        If txtkode.Text = "1" Then
            Dim strtext As String = "SELECT * FROM tb_stok WHERE id_barang like '%" & TextBox1.Text & "%'"
            Using cmd As New MySqlCommand(strtext, hubung)
                Using adapter As New MySqlDataAdapter(cmd)
                    Using DataSet As New DataSet()
                        adapter.Fill(DataSet)
                        DataGridView1.DataSource = DataSet.Tables(0)
                        DataGridView1.ReadOnly = True
                    End Using
                End Using
            End Using
        Else
            Dim strtext As String = "SELECT no_masuk,id_barang,nama_barang,merek,jumlah_brg,satuan,masa_kadaluarsa,stok_min,stok_max from tb_stok_detail inner join tb_stok using(id_barang) WHERE nama_barang like '%" & TextBox1.Text & "%'"
            Using cmd As New MySqlCommand(strtext, hubung)
                Using adapter As New MySqlDataAdapter(cmd)
                    Using DataSet As New DataSet()
                        adapter.Fill(DataSet)
                        DataGridView1.DataSource = DataSet.Tables(0)
                        DataGridView1.ReadOnly = True
                    End Using
                End Using
            End Using
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class