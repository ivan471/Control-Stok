Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormPenginputanStokMasuk
    Dim DREADER As MySqlDataReader
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtbox_id.Text = ""
        txtbox_namabrg.Text = ""
        txtbox_merek.Text = ""
        txtbox_satuan.Text = ""
        TextBox3.Text = ""
        Button1.Enabled = False
        TextBox3.Enabled = False
    End Sub
    Sub simpan()
        Dim tblsimpan As String = "INSERT INTO tb_stok_masuk(no_masuk,id_barang,jumlah_masuk,tanggal_masuk)" _
                                  & "VALUES('" & TextBox4.Text & "','" & txtbox_id.Text & "','" & TextBox3.Text & "','" & txtdate.Text & "')"
        Call simpandata(tblsimpan)
        Dim tblsimpan1 As String = "INSERT INTO tb_stok_detail(no_masuk,id_barang,jumlah_brg,masa_kadaluarsa,tanggal_masuk)" _
                             & "VALUES('" & TextBox4.Text & "','" & txtbox_id.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "','" & txtdate.Text & "')"
        Call simpandata(tblsimpan1)
        MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim njum As Integer = Val(txt_jumlah.Text) + Val(TextBox3.Text)
        If txtbox_id.Text = "" Or txtbox_namabrg.Text = "" Or txtbox_merek.Text = "" Or txtbox_satuan.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        ElseIf njum <= txt_min.Text Then
            TextBox1.Text = "Kekurangan"
            Dim tblupdate As String = "Update tb_stok set Jumlah = " & njum & ", status = '" & TextBox1.Text & "' where id_barang = '" & txtbox_id.Text & "'"
            Call simpandata(tblupdate)
            simpan()
            Me.Close()
        ElseIf njum >= txt_max.Text Then
            TextBox1.Text = "Kebanyakan"
            Dim tblupdate As String = "Update tb_stok set Jumlah = " & njum & ", status = '" & TextBox1.Text & "' where id_barang = '" & txtbox_id.Text & "'"
            Call simpandata(tblupdate)
            simpan()
            Me.Close()
        Else
            TextBox1.Text = "Mencukupi"
            Dim tblupdate As String = "Update tb_stok set Jumlah = " & njum & ", status = '" & TextBox1.Text & "' where id_barang = '" & txtbox_id.Text & "'"
            Call simpandata(tblupdate)
            simpan()
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Text = Format(Now, "dd/MM/yyyy")
        txtdate.Text = Format(Now, "yyyy/MM/dd")
    End Sub

    Private Sub FormPengiputanStokMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Kodeotomatis()
        Timer1.Enabled = True
        Button1.Enabled = False
        TextBox3.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub
    Sub Kodeotomatis()
        cmd = New MySqlCommand("Select no_masuk From tb_stok_masuk order by no_masuk desc ", hubung)
        DREADER = cmd.ExecuteReader
        DREADER.Read()
        If Not DREADER.HasRows Then
            TextBox4.Text = Format(Today, "yyMM") + "01"
        Else
            If Microsoft.VisualBasic.Left(DREADER.Item("no_masuk"), 4) = Format(Today, "yyMM") Then
                TextBox4.Text = DREADER.Item("no_masuk") + 1
            Else
                TextBox4.Text = Format(Today, "yyMM") + "01"
            End If
        End If
        DREADER.Close()
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

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class