Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormPenginputanStokKeluar
    Dim DREADER As MySqlDataReader
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPilihItem.txtkode.Text = "2"
        FormPilihItem.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = Format(Now, "dd/MM/yyyy")
        txtdate.Text = Format(Now, "yyyy/MM/dd")
    End Sub
    Private Sub FormPenginputanStokKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Kodeotomatis()
        Timer1.Enabled = True
        TextBox3.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub data1()
        Dim sisa As Integer = Val(TextBox3.Text) - Val(txtdata1jmlh.Text)
        If sisa < txtdata2jmlh.Text Then
            Dim hasil As Integer = Val(txtdata2jmlh.Text) - sisa
            Dim tblupdate As String = "Update tb_stok_detail set jumlah_brg = " & hasil & " where no_masuk = '" & txtdataid_2.Text & "'"
            Call simpandata(tblupdate)
        Else
            Dim tbldelete As String = "DELETE from tb_stok_detail where no_masuk = '" & txtdataid_2.Text & "'"
            Call simpandata(tbldelete)
        End If
    End Sub

    Sub Kodeotomatis()
        Dim date2 As String
        date2 = Format(Now, "MM")
        cmd = New MySqlCommand("Select no_keluar From tb_stok_keluar where no_keluar in(select max(no_keluar) from tb_stok_keluar) ", hubung)
        DREADER = cmd.ExecuteReader
        DREADER.Read()
        If Not DREADER.HasRows Then
            TextBox8.Text = date2 & "001"
            DREADER.Close()
        Else
            TextBox8.Text = Val(Microsoft.VisualBasic.Right(DREADER.Item("no_keluar").ToString, 5)) + 1
            If Len(TextBox8.Text) = 1 Then
                TextBox8.Text = date2 & "000" & TextBox8.Text & ""
            ElseIf Len(TextBox8.Text) = 2 Then
                TextBox8.Text = date2 & "00" & TextBox8.Text & ""
            ElseIf Len(TextBox8.Text) = 3 Then
                TextBox8.Text = date2 & "0" & TextBox8.Text & ""
            End If
            DREADER.Close()
        End If
    End Sub
    Private Sub statusif()
        Dim njum As Integer = Val(TextBox4.Text) - Val(TextBox3.Text)
        If njum > TextBox6.Text Then
            TextBox5.Text = "Kekurangan"
        ElseIf njum < TextBox7.Text Then
            TextBox5.Text = "Kelebihan"
        Else
            TextBox5.Text = "Mencukupi"
        End If
    End Sub
    Sub insert()
        Dim tblsimpan As String = "INSERT INTO tb_stok_keluar(no_keluar,id_barang,jmlh_keluar,tanggal_keluar)" _
                                 & "VALUES('" & TextBox8.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & txtdate.Text & "')"
        Call simpandata(tblsimpan)
        MsgBox("Proses Berhasil", MsgBoxStyle.Information, "Information")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim njum As Integer = Val(TextBox4.Text) - Val(TextBox3.Text)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or txtmerek.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        ElseIf Val(TextBox3.Text) < Val(txtdata1jmlh.Text) Then
            statusif()
            Dim hasil As Integer = Val(txtdata1jmlh.Text) - Val(TextBox3.Text)
            Dim tblupdate As String = "Update tb_stok_detail set jumlah_brg = " & hasil & " where no_masuk = '" & txtdataid_1.Text & "'"
            Call simpandata(tblupdate)
            Dim tblupdatestok As String = "Update tb_stok set Jumlah = " & njum & ", status = '" & TextBox5.Text & "' where id_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdatestok)
            insert()
            Me.Close()
        ElseIf Val(TextBox3.Text) = Val(txtdata1jmlh.Text) Then
            statusif()
            Dim tbldelete As String = "DELETE from tb_stok_detail where no_masuk = '" & txtdataid_1.Text & "'"
            Call simpandata(tbldelete)
            Dim tblupdatestok As String = "Update tb_stok set Jumlah = " & njum & ", status = '" & TextBox5.Text & "' where id_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdatestok)
            insert()
            Me.Close()
        ElseIf Val(TextBox3.Text) > Val(txtdata1jmlh.Text) Then
            Dim tbldelete As String = "DELETE from tb_stok_detail where no_masuk = '" & txtdataid_1.Text & "'"
            Call simpandata(tbldelete)
            Dim tblupdatestok As String = "Update tb_stok set Jumlah = " & njum & ", status = '" & TextBox5.Text & "' where id_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdatestok)
            insert()
            data1()
            Me.Close()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Hanya Boleh Angka Yang Diisi !!!", MsgBoxStyle.Information, "Peringatan")
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        txtmerek.Text = ""
        TextBox3.Text = ""
        txtbox_satuan.Text = ""
        Button1.Enabled = False
        TextBox3.Enabled = False
    End Sub
End Class