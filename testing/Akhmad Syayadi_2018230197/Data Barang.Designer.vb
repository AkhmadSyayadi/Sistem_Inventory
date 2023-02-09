<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Barang
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtpencarian = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbsatuan = New System.Windows.Forms.ComboBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtpencarian)
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Location = New System.Drawing.Point(587, 186)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(503, 484)
        Me.GroupBox2.TabIndex = 135
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Data"
        '
        'txtpencarian
        '
        Me.txtpencarian.BackColor = System.Drawing.SystemColors.Window
        Me.txtpencarian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpencarian.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpencarian.Location = New System.Drawing.Point(8, 23)
        Me.txtpencarian.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpencarian.Multiline = True
        Me.txtpencarian.Name = "txtpencarian"
        Me.txtpencarian.Size = New System.Drawing.Size(131, 25)
        Me.txtpencarian.TabIndex = 90
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.GridColor = System.Drawing.Color.Gray
        Me.DGV.Location = New System.Drawing.Point(31, 71)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(441, 373)
        Me.DGV.TabIndex = 42
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btkeluar)
        Me.GroupBox4.Controls.Add(Me.btedit)
        Me.GroupBox4.Controls.Add(Me.bthapus)
        Me.GroupBox4.Controls.Add(Me.btsimpan)
        Me.GroupBox4.Controls.Add(Me.btbatal)
        Me.GroupBox4.Controls.Add(Me.bttambah)
        Me.GroupBox4.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(76, 466)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(472, 203)
        Me.GroupBox4.TabIndex = 134
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "NAVIGASI"
        '
        'btkeluar
        '
        Me.btkeluar.BackColor = System.Drawing.Color.Transparent
        Me.btkeluar.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.ForeColor = System.Drawing.Color.Black
        Me.btkeluar.Location = New System.Drawing.Point(333, 123)
        Me.btkeluar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(100, 41)
        Me.btkeluar.TabIndex = 45
        Me.btkeluar.Text = "KELUAR"
        Me.btkeluar.UseVisualStyleBackColor = False
        '
        'btedit
        '
        Me.btedit.BackColor = System.Drawing.Color.Transparent
        Me.btedit.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btedit.ForeColor = System.Drawing.Color.Black
        Me.btedit.Location = New System.Drawing.Point(333, 59)
        Me.btedit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(100, 41)
        Me.btedit.TabIndex = 44
        Me.btedit.Text = "EDIT"
        Me.btedit.UseVisualStyleBackColor = False
        '
        'bthapus
        '
        Me.bthapus.BackColor = System.Drawing.Color.Transparent
        Me.bthapus.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.ForeColor = System.Drawing.Color.Black
        Me.bthapus.Location = New System.Drawing.Point(192, 123)
        Me.bthapus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(100, 41)
        Me.bthapus.TabIndex = 42
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = False
        '
        'btsimpan
        '
        Me.btsimpan.BackColor = System.Drawing.Color.Transparent
        Me.btsimpan.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.ForeColor = System.Drawing.Color.Black
        Me.btsimpan.Location = New System.Drawing.Point(192, 59)
        Me.btsimpan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(100, 41)
        Me.btsimpan.TabIndex = 41
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = False
        '
        'btbatal
        '
        Me.btbatal.BackColor = System.Drawing.Color.Transparent
        Me.btbatal.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbatal.ForeColor = System.Drawing.Color.Black
        Me.btbatal.Location = New System.Drawing.Point(53, 123)
        Me.btbatal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(100, 41)
        Me.btbatal.TabIndex = 39
        Me.btbatal.Text = "BATAL"
        Me.btbatal.UseVisualStyleBackColor = False
        '
        'bttambah
        '
        Me.bttambah.BackColor = System.Drawing.Color.Transparent
        Me.bttambah.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttambah.ForeColor = System.Drawing.Color.Black
        Me.bttambah.Location = New System.Drawing.Point(53, 59)
        Me.bttambah.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(100, 41)
        Me.bttambah.TabIndex = 38
        Me.bttambah.Text = "TAMBAH"
        Me.bttambah.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbsatuan)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Me.txtkode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(76, 186)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(472, 255)
        Me.GroupBox1.TabIndex = 133
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA BARANG"
        '
        'cbsatuan
        '
        Me.cbsatuan.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsatuan.FormattingEnabled = True
        Me.cbsatuan.Items.AddRange(New Object() {"Pcs", "Lusin"})
        Me.cbsatuan.Location = New System.Drawing.Point(243, 165)
        Me.cbsatuan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbsatuan.Name = "cbsatuan"
        Me.cbsatuan.Size = New System.Drawing.Size(105, 26)
        Me.cbsatuan.TabIndex = 43
        '
        'txtnama
        '
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnama.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(243, 126)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnama.Multiline = True
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(196, 25)
        Me.txtnama.TabIndex = 36
        '
        'txtkode
        '
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtkode.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(243, 84)
        Me.txtkode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtkode.Multiline = True
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(107, 25)
        Me.txtkode.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 28)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 28)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 28)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Kode Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(914, 46)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "FORM BARANG PT SEJAHTERA KELOLA ABADI"
        '
        'Data_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1167, 751)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Data_Barang"
        Me.Text = "Data_Barang"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpencarian As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbsatuan As System.Windows.Forms.ComboBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
