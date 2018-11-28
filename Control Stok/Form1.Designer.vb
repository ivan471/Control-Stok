<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.laporanStokKeluar1 = New Control_Stok.LaporanStokKeluar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'dt1
        '
        Me.dt1.CustomFormat = "yyyy-MM-dd"
        Me.dt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt1.Location = New System.Drawing.Point(183, 102)
        Me.dt1.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.dt1.MinDate = New Date(2018, 10, 18, 0, 0, 0, 0)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(200, 34)
        Me.dt1.TabIndex = 0
        Me.dt1.Value = New Date(2018, 10, 18, 0, 0, 0, 0)
        '
        'dt2
        '
        Me.dt2.CustomFormat = "yyyy-MM-dd"
        Me.dt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt2.Location = New System.Drawing.Point(183, 202)
        Me.dt2.MaxDate = New Date(2035, 12, 31, 0, 0, 0, 0)
        Me.dt2.MinDate = New Date(2018, 10, 25, 0, 0, 0, 0)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(200, 34)
        Me.dt2.TabIndex = 1
        Me.dt2.Value = New Date(2018, 10, 25, 0, 0, 0, 0)
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(217, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 54)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sampai"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(446, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 36)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Laporan Tanggal"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(456, 214)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Control_Stok.My.Resources.Resources.umbnail_full08
        Me.ClientSize = New System.Drawing.Size(821, 368)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dt2)
        Me.Controls.Add(Me.dt1)
        Me.Name = "Form1"
        Me.Text = "Form Laporan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents laporanStokKeluar1 As Control_Stok.LaporanStokKeluar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
