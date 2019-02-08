<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPilihItem
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtbox_id = New System.Windows.Forms.TextBox()
        Me.txtbox_nama = New System.Windows.Forms.TextBox()
        Me.txtbox_merek = New System.Windows.Forms.TextBox()
        Me.txtbox_satuan = New System.Windows.Forms.TextBox()
        Me.txtbox_jumlah = New System.Windows.Forms.TextBox()
        Me.txtbox_min = New System.Windows.Forms.TextBox()
        Me.txtbox_max = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 36)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Cari Nama Barang"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(292, 16)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(346, 40)
        Me.TextBox1.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Aquamarine
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 16.0!)
        Me.Button2.Location = New System.Drawing.Point(891, 11)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 49)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aquamarine
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 16.0!)
        Me.Button1.Location = New System.Drawing.Point(752, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 49)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Pilih"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 73)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1027, 457)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 17
        Me.DataGridView1.TabStop = False
        '
        'txtbox_id
        '
        Me.txtbox_id.Location = New System.Drawing.Point(1145, 95)
        Me.txtbox_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_id.Name = "txtbox_id"
        Me.txtbox_id.Size = New System.Drawing.Size(105, 22)
        Me.txtbox_id.TabIndex = 18
        '
        'txtbox_nama
        '
        Me.txtbox_nama.Location = New System.Drawing.Point(1145, 124)
        Me.txtbox_nama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_nama.Name = "txtbox_nama"
        Me.txtbox_nama.Size = New System.Drawing.Size(105, 22)
        Me.txtbox_nama.TabIndex = 19
        '
        'txtbox_merek
        '
        Me.txtbox_merek.Location = New System.Drawing.Point(1145, 153)
        Me.txtbox_merek.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_merek.Name = "txtbox_merek"
        Me.txtbox_merek.Size = New System.Drawing.Size(105, 22)
        Me.txtbox_merek.TabIndex = 20
        '
        'txtbox_satuan
        '
        Me.txtbox_satuan.Location = New System.Drawing.Point(1145, 180)
        Me.txtbox_satuan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_satuan.Name = "txtbox_satuan"
        Me.txtbox_satuan.Size = New System.Drawing.Size(105, 22)
        Me.txtbox_satuan.TabIndex = 21
        '
        'txtbox_jumlah
        '
        Me.txtbox_jumlah.Location = New System.Drawing.Point(1145, 209)
        Me.txtbox_jumlah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_jumlah.Name = "txtbox_jumlah"
        Me.txtbox_jumlah.Size = New System.Drawing.Size(105, 22)
        Me.txtbox_jumlah.TabIndex = 22
        '
        'txtbox_min
        '
        Me.txtbox_min.Location = New System.Drawing.Point(1145, 236)
        Me.txtbox_min.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_min.Name = "txtbox_min"
        Me.txtbox_min.Size = New System.Drawing.Size(105, 22)
        Me.txtbox_min.TabIndex = 23
        '
        'txtbox_max
        '
        Me.txtbox_max.Location = New System.Drawing.Point(1145, 264)
        Me.txtbox_max.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_max.Name = "txtbox_max"
        Me.txtbox_max.Size = New System.Drawing.Size(105, 22)
        Me.txtbox_max.TabIndex = 24
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(1145, 292)
        Me.txtkode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(105, 22)
        Me.txtkode.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1145, 319)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(105, 22)
        Me.TextBox2.TabIndex = 26
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(1145, 348)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(105, 22)
        Me.TextBox3.TabIndex = 27
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1145, 376)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(105, 22)
        Me.TextBox4.TabIndex = 28
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(1145, 404)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(105, 22)
        Me.TextBox5.TabIndex = 29
        '
        'FormPilihItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Control_Stok.My.Resources.Resources.umbnail_full08
        Me.ClientSize = New System.Drawing.Size(1071, 542)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.txtbox_max)
        Me.Controls.Add(Me.txtbox_min)
        Me.Controls.Add(Me.txtbox_jumlah)
        Me.Controls.Add(Me.txtbox_satuan)
        Me.Controls.Add(Me.txtbox_merek)
        Me.Controls.Add(Me.txtbox_nama)
        Me.Controls.Add(Me.txtbox_id)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormPilihItem"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPilihItem"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtbox_id As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_nama As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_merek As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_satuan As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_min As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_max As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
End Class
