Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormPenginputanStokKeluar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPilihItem.txtkode.Text = "2"
        FormPilihItem.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = Format(Now, "dd/MM/yyyy")
        txtdate.Text = Format(Now, "yyyy/MM/dd")
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
            DataGridView1.Columns(0).Width = 80
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 75
            objAlternatingCellStyle.BackColor = Color.AntiqueWhite
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub

    Private Sub FormPenginputanStokKeluar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim clear As String = "delete from tb_sementara"
        Call HAPUSDATA(clear)
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
    End Sub
    Private Sub FormPenginputanStokKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call isigrid()
        judulgrid()
        Kodeotomatis()
        Button4.Enabled = False
        Timer1.Enabled = True
        TextBox3.Enabled = False
        Button1.Enabled = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        txtmerek.Text = ""
        TextBox3.Text = ""
        txtbox_satuan.Text = ""
    End Sub
    Sub Kodeotomatis()
        cmd = New MySqlCommand("Select no_keluar From tb_stok_keluar order by no_keluar desc ", hubung)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Label9.Text = Format(Today, "yyMM") + "01"
        Else
            If Microsoft.VisualBasic.Left(dr.Item("no_keluar"), 4) = Format(Today, "yyMM") Then
                Label9.Text = dr.Item("no_keluar") + 1
            Else
                Label9.Text = Format(Today, "yyMM") + "01"
            End If
        End If
        dr.Close()
    End Sub
    Private Sub statusif()
        Dim njum1 As Integer = Val(TextBox7.Text) - Val(TextBox9.Text)
        TextBox11.Text = njum1
        If njum1 <= TextBox5.Text Then
            TextBox10.Text = "Kekurangan"
        ElseIf njum1 >= TextBox6.Text Then
            TextBox10.Text = "Kelebihan"
        Else
            TextBox10.Text = "Mencukupi"
        End If
    End Sub
    Sub insert()
        Dim tblsimpan As String = "INSERT INTO tb_stok_keluar(no_keluar,id_barang,jmlh_keluar,tanggal_keluar)" _
                                 & "VALUES('" & Label9.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & txtdate.Text & "')"
        Call simpandata(tblsimpan)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To DataGridView1.RowCount - 1
            Dim id As String = DataGridView1.Item(0, i).Value
            TextBox9.Text = DataGridView1.Item(3, i).Value
            cmd = New MySqlCommand("SELECT * FROM tb_stok WHERE id_barang = '" & id & "'", hubung)
            Dim mda As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            mda.Fill(table)
            If table.Rows.Count() > 0 Then
                TextBox7.Text = table.Rows(0)(3).ToString()
                TextBox5.Text = table.Rows(0)(4).ToString()
                TextBox6.Text = table.Rows(0)(5).ToString()
                Dim njum As Integer = Val(TextBox7.Text) - Val(TextBox9.Text)
                cmd = New MySqlCommand("SELECT * FROM tb_stok_detail WHERE id_barang = '" & id & "'", hubung)
                mda = New MySqlDataAdapter(cmd)
                table = New DataTable()
                mda.Fill(table)
                If table.Rows.Count() = 1 Then
                    txtdataid_1.Text = table.Rows(0)(0).ToString()
                    txtdata1jmlh.Text = table.Rows(0)(2).ToString()
                Else
                    txtdataid_1.Text = table.Rows(0)(0).ToString()
                    txtdata1jmlh.Text = table.Rows(0)(2).ToString()
                    txtdataid_2.Text = table.Rows(1)(0).ToString()
                    txtdata2jmlh.Text = table.Rows(1)(2).ToString()
                End If
                If TextBox9.Text < Val(txtdata1jmlh.Text) Then
                    statusif()
                    Dim hasil As Integer = Val(txtdata1jmlh.Text) - TextBox9.Text
                    Dim tblupdate As String = "Update tb_stok_detail set jumlah_brg = " & hasil & " where no_masuk = '" & txtdataid_1.Text & "' and id_barang = '" & id & "'"
                    Call simpandata(tblupdate)
                    Dim tblupdatestok As String = "Update tb_stok set Jumlah_stok = " & njum & ", status = '" & TextBox10.Text & "' where id_barang = '" & id & "'"
                    Call simpandata(tblupdatestok)
                    Dim tblsimpan As String = "INSERT INTO tb_stok_keluar(no_keluar,id_barang,jmlh_keluar,tanggal_keluar)" _
                                 & "VALUES('" & Label9.Text & "','" & id & "','" & TextBox9.Text & "','" & txtdate.Text & "')"
                    Call simpandata(tblsimpan)

                ElseIf TextBox9.Text = Val(txtdata1jmlh.Text) Then
                    statusif()
                    Dim tbldeletetable As String = "DELETE from tb_stok_detail where no_masuk = '" & txtdataid_1.Text & "' and id_barang = '" & id & "'"
                    Call simpandata(tbldeletetable)
                    Dim tblupdatestok As String = "Update tb_stok set Jumlah_stok = " & njum & ", status = '" & TextBox10.Text & "' where id_barang = '" & id & "'"
                    Call simpandata(tblupdatestok)
                    Dim tblsimpan1 As String = "INSERT INTO tb_stok_keluar(no_keluar,id_barang,jmlh_keluar,tanggal_keluar)" _
                                 & "VALUES('" & Label9.Text & "','" & id & "','" & TextBox9.Text & "','" & txtdate.Text & "')"
                    Call simpandata(tblsimpan1)
                ElseIf TextBox9.Text > Val(txtdata1jmlh.Text) Then
                    statusif()
                    Dim tbldelete2 As String = "DELETE from tb_stok_detail where no_masuk = '" & txtdataid_1.Text & "' and id_barang = '" & id & "'"
                    Call simpandata(tbldelete2)
                    Dim tblupdatestok As String = "Update tb_stok set Jumlah_stok = " & njum & ", status = '" & TextBox10.Text & "' where id_barang = '" & id & "'"
                    Call simpandata(tblupdatestok)
                    Dim tblsimpan2 As String = "INSERT INTO tb_stok_keluar(no_keluar,id_barang,jmlh_keluar,tanggal_keluar)" _
                                 & "VALUES('" & Label9.Text & "','" & id & "','" & TextBox9.Text & "','" & txtdate.Text & "')"
                    Call simpandata(tblsimpan2)
                    Dim sisa As Integer = TextBox9.Text - Val(txtdata1jmlh.Text)
                    If sisa < txtdata2jmlh.Text Then
                        Dim hasil As Integer = Val(txtdata2jmlh.Text) - sisa
                        Dim tblupdate As String = "Update tb_stok_detail set jumlah_brg = " & hasil & " where no_masuk = '" & txtdataid_2.Text & "'"
                        Call simpandata(tblupdate)
                    Else
                        Dim tbldelete1 As String = "DELETE from tb_stok_detail where no_masuk = '" & txtdataid_2.Text & "' and id_barang = '" & id & "'"
                        Call simpandata(tbldelete1)
                    End If
                End If
            End If
        Next
        Dim tbldelete As String = "DELETE from tb_sementara"
        Call simpandata(tbldelete)
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        judulgrid()
        MsgBox("Proses Berhasil", MsgBoxStyle.Information, "Information")
        Me.Close()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Hanya Boleh Angka Yang Diisi !!!", MsgBoxStyle.Information, "Peringatan")
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tbldelete As String = "DELETE from tb_sementara"
        Call HAPUSDATA(tbldelete)
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        Button4.Enabled = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        txtmerek.Text = ""
        TextBox3.Text = ""
        txtbox_satuan.Text = ""
        Button1.Enabled = False
        TextBox3.Enabled = False
        judulgrid()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox3.Text = "" Then
            MsgBox("Ada yang belum terisi", MsgBoxStyle.Information, "Peringatan")
        ElseIf TextBox3.Text = "0" Then
            MsgBox("Jumlah Tidak Boleh 0", MsgBoxStyle.Information, "Peringatan")
        Else
            If Val(TextBox4.Text) < Val(TextBox3.Text) Then
                MsgBox("Jumlah Tidak Mencukupi, Yang Tersedia = " & TextBox4.Text & "", MsgBoxStyle.Information, "Peringatan")
            Else
                If DataGridView1.RowCount = 0 Then
                    Dim tblsimpan As String = "INSERT INTO tb_sementara(id_barang,jumlah)" _
                                  & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "')"
                    Call simpandata(tblsimpan)
                    isigrid()
                    TotalKeluar()
                    Button1.Enabled = True
                Else
                    Dim i As Integer
                    For i = 0 To DataGridView1.RowCount - 1
                        TextBox5.Text = DataGridView1.Item(0, i).Value
                        TextBox6.Text = DataGridView1.Item(3, i).Value
                        cmd = New MySqlCommand("SELECT id_barang FROM tb_sementara WHERE id_barang = '" & TextBox1.Text & "'", hubung)
                        Dim mda As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        mda.Fill(table)
                        If table.Rows.Count() > 0 Then
                            MsgBox("Barang sudah ada", MsgBoxStyle.Information, "Peringatan")
                        Else
                            Dim tblsimpan As String = "INSERT INTO tb_sementara(id_barang,jumlah)" _
                                          & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "')"
                            Call simpandata(tblsimpan)
                            isigrid()
                            TotalKeluar()
                            Button1.Enabled = True
                        End If
                    Next
                End If
            End If
        End If
    End Sub
    Sub isigrid()
        Dim query As String = "SELECT id_barang,nama_barang,merek,jumlah from tb_stok inner join tb_sementara using(id_barang)"
        Dim da As New MySqlDataAdapter(query, hubung)
        Dim ds As New DataSet()
        If da.Fill(ds) Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()
        End If
    End Sub
    Sub TotalKeluar()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To DataGridView1.RowCount - 1
            hitung = hitung + DataGridView1.Rows(baris).Cells(3).Value
        Next
        Label11.Text = hitung
    End Sub
End Class