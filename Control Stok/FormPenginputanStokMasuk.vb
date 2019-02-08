Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormPenginputanStokMasuk
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tbldelete As String = "DELETE from tb_sementara"
        Call HAPUSDATA(tbldelete)
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        Button4.Enabled = False
        Button1.Enabled = False
        txtbox_id.Text = ""
        txtbox_namabrg.Text = ""
        txtbox_merek.Text = ""
        txtbox_satuan.Text = ""
        TextBox3.Text = ""
        Button1.Enabled = False
        TextBox3.Enabled = False
        Label11.Text = "0"
        judulgrid()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To DataGridView1.RowCount - 1
            TextBox5.Text = DataGridView1.Item(0, i).Value
            Dim kadaluarsa As String = DataGridView1.Item(4, i).Value
            TextBox6.Text = DataGridView1.Item(3, i).Value
            cmd = New MySqlCommand("SELECT * FROM tb_stok WHERE id_barang = '" & TextBox5.Text & "'", hubung)
            Dim mda As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            mda.Fill(table)
            If table.Rows.Count() > 0 Then
                txt_jumlah.Text = table.Rows(0)(3).ToString()
                txt_min.Text = table.Rows(0)(4).ToString()
                txt_max.Text = table.Rows(0)(5).ToString()
                Dim njum As Integer = Val(txt_jumlah.Text) + Val(TextBox6.Text)
                If njum <= txt_min.Text Then
                    TextBox1.Text = "Kekurangan"
                    Dim tblupdate As String = "Update tb_stok set Jumlah_stok = " & njum & ", status = '" & TextBox1.Text & "' where id_barang = '" & TextBox5.Text & "'"
                    Call simpandata(tblupdate)
                    Dim tblsimpan As String = "INSERT INTO tb_stok_masuk(no_masuk,id_barang,jumlah_masuk,tanggal_masuk)" _
                                      & "VALUES('" & Label10.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & txtdate.Text & "')"
                    Call simpandata(tblsimpan)
                    Dim tblsimpan1 As String = "INSERT INTO tb_stok_detail(no_masuk,id_barang,jumlah_brg,masa_kadaluarsa,tanggal_masuk)" _
                                         & "VALUES('" & Label10.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox2.Text & "','" & txtdate.Text & "')"
                    Call simpandata(tblsimpan1)
                ElseIf njum >= txt_max.Text Then
                    TextBox1.Text = "Kebanyakan"
                    Dim tblupdate As String = "Update tb_stok set Jumlah_stok = " & njum & ", status = '" & TextBox1.Text & "' where id_barang = '" & TextBox5.Text & "'"
                    Call simpandata(tblupdate)
                    Dim tblsimpan As String = "INSERT INTO tb_stok_masuk(no_masuk,id_barang,jumlah_masuk,tanggal_masuk)" _
                                      & "VALUES('" & Label10.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & txtdate.Text & "')"
                    Call simpandata(tblsimpan)
                    Dim tblsimpan1 As String = "INSERT INTO tb_stok_detail(no_masuk,id_barang,jumlah_brg,masa_kadaluarsa,tanggal_masuk)" _
                                         & "VALUES('" & Label10.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox2.Text & "','" & txtdate.Text & "')"
                    Call simpandata(tblsimpan1)
                Else
                    TextBox1.Text = "Mencukupi"
                    Dim tblupdate As String = "Update tb_stok set Jumlah_stok = " & njum & ", status = '" & TextBox1.Text & "' where id_barang = '" & TextBox5.Text & "'"
                    Call simpandata(tblupdate)
                    Dim tblsimpan As String = "INSERT INTO tb_stok_masuk(no_masuk,id_barang,jumlah_masuk,tanggal_masuk)" _
                                      & "VALUES('" & Label10.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & txtdate.Text & "')"
                    Call simpandata(tblsimpan)
                    Dim tblsimpan1 As String = "INSERT INTO tb_stok_detail(no_masuk,id_barang,jumlah_brg,masa_kadaluarsa,tanggal_masuk)" _
                                         & "VALUES('" & Label10.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox2.Text & "','" & txtdate.Text & "')"
                    Call simpandata(tblsimpan1)
                End If
            Else
            End If
        Next
        Dim tbldelete As String = "DELETE from tb_sementara"
        Call simpandata(tbldelete)
        MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Text = Format(Now, "dd/MM/yyyy")
        txtdate.Text = Format(Now, "yyyy/MM/dd")
    End Sub
    Sub isigrid()
        Dim query As String = "SELECT id_barang,nama_barang,merek,jumlah,masa_kadaluarsa from tb_stok inner join tb_sementara using(id_barang)"
        Dim da As New MySqlDataAdapter(query, hubung)
        Dim ds As New DataSet()
        If da.Fill(ds) Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()
        End If
    End Sub
    Sub judulgrid()
        If DataGridView1.RowCount > 0 Then
            Dim objAlternatingCellStyle As New DataGridViewCellStyle()
            DataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle
            Dim style As DataGridViewCellStyle = DataGridView1.Columns(0).DefaultCellStyle
            DataGridView1.Columns(0).HeaderText = "Id Barang"
            DataGridView1.Columns(1).HeaderText = "Nama Barang"
            DataGridView1.Columns(2).HeaderText = "Merek"
            DataGridView1.Columns(3).HeaderText = "Jumlah"
            DataGridView1.Columns(4).HeaderText = "Masa Kadaluarsa"
            DataGridView1.Columns(0).Width = 80
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 75
            DataGridView1.Columns(4).Width = 80
            objAlternatingCellStyle.BackColor = Color.AntiqueWhite
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub
    Private Sub FormPenginputanStokMasuk_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim clear As String = "delete from tb_sementara"
        Call HAPUSDATA(clear)
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
    End Sub
    Private Sub FormPengiputanStokMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Kodeotomatis()
        isigrid()
        judulgrid()
        Timer1.Enabled = True
        Button1.Enabled = False
        Button4.Enabled = False
        TextBox3.Enabled = False
        DateTimePicker1.Enabled = False
        txtbox_id.Text = ""
        txtbox_namabrg.Text = ""
        txtbox_merek.Text = ""
        txtbox_satuan.Text = ""
        TextBox3.Text = ""
        Label11.Text = "0"
    End Sub
    Sub Kodeotomatis()
        cmd = New MySqlCommand("Select no_masuk From tb_stok_masuk order by no_masuk desc ", hubung)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Label10.Text = Format(Today, "yyMM") + "01"
        Else
            If Microsoft.VisualBasic.Left(dr.Item("no_masuk"), 4) = Format(Today, "yyMM") Then
                Label10.Text = dr.Item("no_masuk") + 1
            Else
                Label10.Text = Format(Today, "yyMM") + "01"
            End If
        End If
        dr.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPilihItem.txtkode.Text = "1"
        FormPilihItem.ShowDialog()
    End Sub
    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox2.Text = Me.DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Hanya Boleh Angka Yang Diisi !!!", MsgBoxStyle.Information, "Peringatan")
            e.Handled = True
        End If
    End Sub
    Sub TotalKeluar()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To DataGridView1.RowCount - 1
            hitung = hitung + DataGridView1.Rows(baris).Cells(3).Value
        Next
        Label11.Text = hitung
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox3.Text = "" Then
            MsgBox("Jumlah Belum Diisi", MsgBoxStyle.Information, "Peringatan")
        ElseIf TextBox3.Text = "0" Then
            MsgBox("Jumlah Tidak Boleh 0", MsgBoxStyle.Information, "Peringatan")
        ElseIf DataGridView1.RowCount = 0 Then
            Dim tblsimpan As String = "INSERT INTO tb_sementara(id_barang,jumlah,masa_kadaluarsa)" _
                          & "VALUES('" & txtbox_id.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "')"
            Call simpandata(tblsimpan)
            isigrid()
            TotalKeluar()
            Button1.Enabled = True
        Else
            Dim i As Integer
            For i = 0 To DataGridView1.RowCount - 1
                TextBox5.Text = DataGridView1.Item(0, i).Value
                Dim kadaluarsa As String = DataGridView1.Item(4, i).Value
                TextBox6.Text = DataGridView1.Item(3, i).Value
                cmd = New MySqlCommand("SELECT * FROM tb_sementara WHERE id_barang = '" & txtbox_id.Text & "'", hubung)
                Dim mda As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                mda.Fill(table)
                If table.Rows.Count() > 0 Then
                    MsgBox("Barang sudah ada", MsgBoxStyle.Information, "Peringatan")
                Else
                    Dim tblsimpan As String = "INSERT INTO tb_sementara(id_barang,jumlah,masa_kadaluarsa)" _
                                  & "VALUES('" & txtbox_id.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "')"
                    Call simpandata(tblsimpan)
                    isigrid()
                    TotalKeluar()
                    Button1.Enabled = True
                End If
            Next
        End If
    End Sub
End Class