<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stok_Masuk
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
        Me.cbbj = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtpencarian = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.txtsatuan = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttambah = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtqtytotal = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.cbsuplier = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbkode = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btedit = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbbj
        '
        Me.cbbj.Font = New System.Drawing.Font("Baskerville Old Face", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbj.FormattingEnabled = True
        Me.cbbj.Items.AddRange(New Object() {"Ayatullah", "Agus Sulaeman", "Herlina"})
        Me.cbbj.Location = New System.Drawing.Point(180, 105)
        Me.cbbj.Name = "cbbj"
        Me.cbbj.Size = New System.Drawing.Size(140, 21)
        Me.cbbj.TabIndex = 93
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.txtpencarian)
        Me.GroupBox5.Controls.Add(Me.DGV)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(31, 473)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(723, 210)
        Me.GroupBox5.TabIndex = 137
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PENCARIAN"
        '
        'txtpencarian
        '
        Me.txtpencarian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpencarian.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpencarian.Location = New System.Drawing.Point(33, 29)
        Me.txtpencarian.Multiline = True
        Me.txtpencarian.Name = "txtpencarian"
        Me.txtpencarian.Size = New System.Drawing.Size(137, 20)
        Me.txtpencarian.TabIndex = 92
        '
        'DGV
        '
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(33, 62)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(660, 122)
        Me.DGV.TabIndex = 77
        '
        'txtsatuan
        '
        Me.txtsatuan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsatuan.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsatuan.Location = New System.Drawing.Point(306, 68)
        Me.txtsatuan.Multiline = True
        Me.txtsatuan.Name = "txtsatuan"
        Me.txtsatuan.Size = New System.Drawing.Size(33, 20)
        Me.txtsatuan.TabIndex = 87
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.DGV2)
        Me.GroupBox4.Controls.Add(Me.txtcari)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(31, 254)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(339, 179)
        Me.GroupBox4.TabIndex = 136
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PENCARIAN"
        '
        'DGV2
        '
        Me.DGV2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(32, 65)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.Size = New System.Drawing.Size(288, 89)
        Me.DGV2.TabIndex = 91
        '
        'txtcari
        '
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcari.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.Location = New System.Drawing.Point(115, 33)
        Me.txtcari.Multiline = True
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(137, 20)
        Me.txtcari.TabIndex = 90
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 21)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Cari Data"
        '
        'txttambah
        '
        Me.txttambah.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttambah.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttambah.Location = New System.Drawing.Point(276, 22)
        Me.txttambah.Multiline = True
        Me.txttambah.Name = "txttambah"
        Me.txttambah.Size = New System.Drawing.Size(55, 20)
        Me.txttambah.TabIndex = 86
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(198, 25)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(64, 21)
        Me.Label.TabIndex = 87
        Me.Label.Text = "Tambah"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label)
        Me.GroupBox3.Controls.Add(Me.txttambah)
        Me.GroupBox3.Controls.Add(Me.txtqtytotal)
        Me.GroupBox3.Controls.Add(Me.txtqty)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(400, 239)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 83)
        Me.GroupBox3.TabIndex = 135
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "JUMLAH"
        '
        'txtqtytotal
        '
        Me.txtqtytotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtqtytotal.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqtytotal.Location = New System.Drawing.Point(116, 53)
        Me.txtqtytotal.Multiline = True
        Me.txtqtytotal.Name = "txtqtytotal"
        Me.txtqtytotal.Size = New System.Drawing.Size(55, 20)
        Me.txtqtytotal.TabIndex = 85
        '
        'txtqty
        '
        Me.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtqty.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(116, 22)
        Me.txtqty.Multiline = True
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(55, 20)
        Me.txtqty.TabIndex = 84
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 21)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 21)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Qty  "
        '
        'txtnamabarang
        '
        Me.txtnamabarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnamabarang.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamabarang.Location = New System.Drawing.Point(145, 68)
        Me.txtnamabarang.Multiline = True
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(155, 20)
        Me.txtnamabarang.TabIndex = 82
        '
        'cbsuplier
        '
        Me.cbsuplier.Font = New System.Drawing.Font("Baskerville Old Face", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsuplier.FormattingEnabled = True
        Me.cbsuplier.Location = New System.Drawing.Point(145, 104)
        Me.cbsuplier.Name = "cbsuplier"
        Me.cbsuplier.Size = New System.Drawing.Size(139, 22)
        Me.cbsuplier.TabIndex = 83
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtsatuan)
        Me.GroupBox2.Controls.Add(Me.cbsuplier)
        Me.GroupBox2.Controls.Add(Me.txtnamabarang)
        Me.GroupBox2.Controls.Add(Me.cbkode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(400, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 146)
        Me.GroupBox2.TabIndex = 134
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA BARANG"
        '
        'cbkode
        '
        Me.cbkode.Font = New System.Drawing.Font("Baskerville Old Face", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbkode.FormattingEnabled = True
        Me.cbkode.Location = New System.Drawing.Point(145, 34)
        Me.cbkode.Name = "cbkode"
        Me.cbkode.Size = New System.Drawing.Size(70, 22)
        Me.cbkode.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 21)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Suplier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 21)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 21)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Kode Barang"
        '
        'btkeluar
        '
        Me.btkeluar.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.Location = New System.Drawing.Point(240, 82)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 33)
        Me.btkeluar.TabIndex = 45
        Me.btkeluar.Text = "KELUAR"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.btkeluar)
        Me.GroupBox6.Controls.Add(Me.btedit)
        Me.GroupBox6.Controls.Add(Me.bthapus)
        Me.GroupBox6.Controls.Add(Me.btsimpan)
        Me.GroupBox6.Controls.Add(Me.btbatal)
        Me.GroupBox6.Controls.Add(Me.bttambah)
        Me.GroupBox6.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(400, 328)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(354, 139)
        Me.GroupBox6.TabIndex = 138
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "NAVIGASI"
        '
        'btedit
        '
        Me.btedit.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btedit.Location = New System.Drawing.Point(240, 30)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 33)
        Me.btedit.TabIndex = 44
        Me.btedit.Text = "EDIT"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.Location = New System.Drawing.Point(134, 82)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 33)
        Me.bthapus.TabIndex = 42
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.Location = New System.Drawing.Point(134, 30)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 33)
        Me.btsimpan.TabIndex = 41
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbatal.Location = New System.Drawing.Point(30, 82)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(75, 33)
        Me.btbatal.TabIndex = 39
        Me.btbatal.Text = "BATAL"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttambah.Location = New System.Drawing.Point(30, 30)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 33)
        Me.bttambah.TabIndex = 38
        Me.bttambah.Text = "TAMBAH"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbbj)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.DTP)
        Me.GroupBox1.Controls.Add(Me.txtkode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 146)
        Me.GroupBox1.TabIndex = 133
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA MASUK"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 21)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Bertanggung Jawab"
        '
        'DTP
        '
        Me.DTP.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Location = New System.Drawing.Point(180, 70)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(130, 22)
        Me.DTP.TabIndex = 80
        '
        'txtkode
        '
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtkode.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(180, 34)
        Me.txtkode.Multiline = True
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(54, 20)
        Me.txtkode.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 21)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Kode Masuk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(522, 24)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "FORM STOK MASUK PT SEJAHTERA KELOLA ABADI"
        '
        'Stok_Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(785, 705)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Stok_Masuk"
        Me.Text = "Stok_Masuk"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbbj As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpencarian As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents txtsatuan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttambah As System.Windows.Forms.TextBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtqtytotal As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents cbsuplier As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbkode As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
