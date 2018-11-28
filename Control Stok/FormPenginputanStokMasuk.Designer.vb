<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenginputanStokMasuk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbox_satuan = New System.Windows.Forms.TextBox()
        Me.txtbox_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbox_merek = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbox_namabrg = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.txt_max = New System.Windows.Forms.TextBox()
        Me.txt_min = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(310, 63)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(135, 35)
        Me.TextBox4.TabIndex = 48
        Me.TextBox4.TabStop = False
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(78, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 29)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "No Masuk"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(147, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 32)
        Me.Label8.TabIndex = 57
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(310, 369)
        Me.DateTimePicker1.MaxDate = New Date(2039, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2018, 12, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(167, 30)
        Me.DateTimePicker1.TabIndex = 44
        Me.DateTimePicker1.Value = New Date(2018, 12, 1, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(78, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 29)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Masa Kaduwarsa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 32)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Tanggal"
        '
        'txtbox_satuan
        '
        Me.txtbox_satuan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtbox_satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_satuan.Location = New System.Drawing.Point(310, 258)
        Me.txtbox_satuan.Multiline = True
        Me.txtbox_satuan.Name = "txtbox_satuan"
        Me.txtbox_satuan.ReadOnly = True
        Me.txtbox_satuan.Size = New System.Drawing.Size(169, 35)
        Me.txtbox_satuan.TabIndex = 49
        Me.txtbox_satuan.TabStop = False
        Me.txtbox_satuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_id
        '
        Me.txtbox_id.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtbox_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_id.Location = New System.Drawing.Point(310, 114)
        Me.txtbox_id.Multiline = True
        Me.txtbox_id.Name = "txtbox_id"
        Me.txtbox_id.ReadOnly = True
        Me.txtbox_id.Size = New System.Drawing.Size(135, 35)
        Me.txtbox_id.TabIndex = 45
        Me.txtbox_id.TabStop = False
        Me.txtbox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 29)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Merek"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 29)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 29)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Jumlah"
        '
        'txtbox_merek
        '
        Me.txtbox_merek.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtbox_merek.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_merek.Location = New System.Drawing.Point(310, 212)
        Me.txtbox_merek.Multiline = True
        Me.txtbox_merek.Name = "txtbox_merek"
        Me.txtbox_merek.ReadOnly = True
        Me.txtbox_merek.Size = New System.Drawing.Size(169, 35)
        Me.txtbox_merek.TabIndex = 47
        Me.txtbox_merek.TabStop = False
        Me.txtbox_merek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(310, 313)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(169, 35)
        Me.TextBox3.TabIndex = 43
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 29)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Kode Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 29)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Nama Barang"
        '
        'txtbox_namabrg
        '
        Me.txtbox_namabrg.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtbox_namabrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_namabrg.Location = New System.Drawing.Point(310, 167)
        Me.txtbox_namabrg.Multiline = True
        Me.txtbox_namabrg.Name = "txtbox_namabrg"
        Me.txtbox_namabrg.ReadOnly = True
        Me.txtbox_namabrg.Size = New System.Drawing.Size(271, 33)
        Me.txtbox_namabrg.TabIndex = 46
        Me.txtbox_namabrg.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(832, 270)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 65
        Me.TextBox2.Visible = False
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(832, 241)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 22)
        Me.txtdate.TabIndex = 64
        Me.txtdate.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(832, 211)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 63
        Me.TextBox1.Visible = False
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(832, 174)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(100, 22)
        Me.txt_jumlah.TabIndex = 62
        Me.txt_jumlah.Visible = False
        '
        'txt_max
        '
        Me.txt_max.Location = New System.Drawing.Point(832, 141)
        Me.txt_max.Name = "txt_max"
        Me.txt_max.Size = New System.Drawing.Size(100, 22)
        Me.txt_max.TabIndex = 61
        Me.txt_max.Visible = False
        '
        'txt_min
        '
        Me.txt_min.Location = New System.Drawing.Point(832, 111)
        Me.txt_min.Name = "txt_min"
        Me.txt_min.Size = New System.Drawing.Size(100, 22)
        Me.txt_min.TabIndex = 60
        Me.txt_min.Visible = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.Aquamarine
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(630, 18)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 43)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Pilih Item"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Aquamarine
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Control_Stok.My.Resources.Resources.if_error_1646012
        Me.Button3.Location = New System.Drawing.Point(665, 412)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 92)
        Me.Button3.TabIndex = 67
        Me.Button3.Text = "Batal"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aquamarine
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderSize = 5000
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Control_Stok.My.Resources.Resources.if_floppy_285657
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(526, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 92)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Simpan"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormPenginputanStokMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Control_Stok.My.Resources.Resources.umbnail_full08
        Me.ClientSize = New System.Drawing.Size(818, 532)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt_jumlah)
        Me.Controls.Add(Me.txt_max)
        Me.Controls.Add(Me.txt_min)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbox_satuan)
        Me.Controls.Add(Me.txtbox_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbox_merek)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbox_namabrg)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaximizeBox = False
        Me.Name = "FormPenginputanStokMasuk"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPenginputanStokMasuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbox_satuan As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtbox_merek As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbox_namabrg As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents txt_max As System.Windows.Forms.TextBox
    Friend WithEvents txt_min As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
