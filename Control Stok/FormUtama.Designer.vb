<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PenginputanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarStokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokRusakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokBarangToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokBarangMasuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokBarangKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenginputanToolStripMenuItem, Me.DaftarToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1477, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PenginputanToolStripMenuItem
        '
        Me.PenginputanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangMasukToolStripMenuItem, Me.BarangKeluarToolStripMenuItem})
        Me.PenginputanToolStripMenuItem.Name = "PenginputanToolStripMenuItem"
        Me.PenginputanToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.PenginputanToolStripMenuItem.Text = "Transaksi"
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.BarangMasukToolStripMenuItem.Text = "Barang Masuk"
        '
        'BarangKeluarToolStripMenuItem
        '
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang Keluar"
        '
        'DaftarToolStripMenuItem
        '
        Me.DaftarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarStokToolStripMenuItem, Me.StokRusakToolStripMenuItem})
        Me.DaftarToolStripMenuItem.Name = "DaftarToolStripMenuItem"
        Me.DaftarToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.DaftarToolStripMenuItem.Text = "Stok"
        '
        'DaftarStokToolStripMenuItem
        '
        Me.DaftarStokToolStripMenuItem.Name = "DaftarStokToolStripMenuItem"
        Me.DaftarStokToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.DaftarStokToolStripMenuItem.Text = "Daftar Stok"
        '
        'StokRusakToolStripMenuItem
        '
        Me.StokRusakToolStripMenuItem.Name = "StokRusakToolStripMenuItem"
        Me.StokRusakToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.StokRusakToolStripMenuItem.Text = "Kondisi Stok "
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StokBarangToolStripMenuItem1, Me.StokBarangMasuToolStripMenuItem, Me.StokBarangKeluarToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'StokBarangToolStripMenuItem1
        '
        Me.StokBarangToolStripMenuItem1.Name = "StokBarangToolStripMenuItem1"
        Me.StokBarangToolStripMenuItem1.Size = New System.Drawing.Size(210, 26)
        Me.StokBarangToolStripMenuItem1.Text = "Stok Barang"
        '
        'StokBarangMasuToolStripMenuItem
        '
        Me.StokBarangMasuToolStripMenuItem.Name = "StokBarangMasuToolStripMenuItem"
        Me.StokBarangMasuToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.StokBarangMasuToolStripMenuItem.Text = "Stok Barang Masuk"
        '
        'StokBarangKeluarToolStripMenuItem
        '
        Me.StokBarangKeluarToolStripMenuItem.Name = "StokBarangKeluarToolStripMenuItem"
        Me.StokBarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.StokBarangKeluarToolStripMenuItem.Text = "Stok Barang Keluar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(957, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Data Barang yang akan Expaired"
        Me.Label1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(911, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(441, 239)
        Me.DataGridView1.TabIndex = 8
        Me.DataGridView1.Visible = False
        '
        'Timer1
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1423, 457)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(69, 22)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(1423, 307)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(95, 125)
        Me.DataGridView2.TabIndex = 10
        Me.DataGridView2.Visible = False
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Control_Stok.My.Resources.Resources.umbnail_full08
        Me.ClientSize = New System.Drawing.Size(1477, 589)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PenginputanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StokBarangToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StokBarangMasuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StokBarangKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DaftarStokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StokRusakToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView

End Class
