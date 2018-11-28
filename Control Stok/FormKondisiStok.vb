Imports MySql.Data.MySqlClient
Public Class FormKondisiStok
    Dim DREADER As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim njum As Integer = Val(txt_jmlh.Text) - Val(TextBox3.Text)
        Dim total As Integer = Val(txtstok.Text) - Val(TextBox3.Text)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        ElseIf njum < txt_min.Text Then
            txt_status.Text = "Kekurangan"
            Dim tblupdatedetail As String = "Update tb_stok_detail set jumlah_brg = " & njum & " where no_masuk = '" & TextBox5.Text & "'"
            Call simpandata(tblupdatedetail)
            Dim tblupdate As String = "Update tb_stok set Jumlah = " & total & ", status = '" & TextBox9.Text & "' where id_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate)
            Dim tblsimpan As String = "INSERT INTO tb_kondisi(no_masuk,id_barang,jmlh,keterangan,tanggal)" _
                                 & "VALUES('" & TextBox5.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & RichTextBox1.Text & "','" & TextBox3.Text & "')"
            Call simpandata(tblsimpan)
            Me.Close()
        ElseIf njum > txt_max.Text Then
            txt_status.Text = "Kebanyakan"
            Dim tblupdatedetail As String = "Update tb_stok_detail set jumlah_brg = " & njum & " where no_masuk = '" & TextBox5.Text & "'"
            Call simpandata(tblupdatedetail)
            Dim tblupdate As String = "Update tb_stok set Jumlah = " & total & ", status = '" & TextBox9.Text & "' where id_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate)
            Dim tblsimpan As String = "INSERT INTO tb_kondisi(no_masuk,id_barang,jmlh,keterangan,tanggal)" _
                                 & "VALUES('" & TextBox5.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & RichTextBox1.Text & "','" & TextBox3.Text & "')"
            Call simpandata(tblsimpan)
            Me.Close()
        Else
            txt_status.Text = "Mencukupi"
            Dim tblupdatedetail As String = "Update tb_stok_detail set jumlah_brg = " & njum & " where no_masuk = '" & TextBox5.Text & "'"
            Call simpandata(tblupdatedetail)
            Dim tblupdate As String = "Update tb_stok set Jumlah = " & total & ", status = '" & TextBox9.Text & "' where id_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate)
            Dim tblsimpan As String = "INSERT INTO tb_kondisi(no_masuk,id_barang,jmlh,keterangan,tanggal)" _
                                 & "VALUES('" & TextBox5.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & RichTextBox1.Text & "','" & TextBox3.Text & "')"
            Call simpandata(tblsimpan)
            Me.Close()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = Format(Now, "dd/MM/yyyy")
        TextBox9.Text = Format(Now, "yyyy/MM/dd")
    End Sub
    Private Sub FormKondisiStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Kodeotomatis()
        Timer1.Enabled = True
        Button1.Enabled = False
        TextBox3.Enabled = False
        RichTextBox1.Enabled = False
    End Sub
    Sub Kodeotomatis()
        'Call koneksi()
        Dim date2 As String
        date2 = Format(Now, "MM")
        cmd = New MySqlCommand("Select no From tb_kondisi where no in(select max(no) from tb_kondisi) ", hubung)
        DREADER = cmd.ExecuteReader
        DREADER.Read()
        If Not DREADER.HasRows Then
            TextBox6.Text = date2 & "01"
            DREADER.Close()
        Else
            TextBox6.Text = Val(Microsoft.VisualBasic.Right(DREADER.Item("no_masuk").ToString, 4)) + 1
            If Len(TextBox6.Text) = 1 Then
                TextBox6.Text = date2 & "00" & TextBox6.Text & ""
            ElseIf Len(TextBox6.Text) = 2 Then
                TextBox6.Text = date2 & "0" & TextBox6.Text & ""
            End If
            DREADER.Close()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPilihItem.txtkode.Text = "3"
        FormPilihItem.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Hanya Boleh Angka Yang Diisi !!!", MsgBoxStyle.Information, "Peringatan")
            e.Handled = True
        End If
    End Sub

End Class