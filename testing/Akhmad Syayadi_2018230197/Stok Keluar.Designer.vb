<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stok_Keluar
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtqtykeluar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbbj = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsatuan = New System.Windows.Forms.TextBox()
        Me.cbkode = New System.Windows.Forms.ComboBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtpencarian = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.txttransaksi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.txttotal)
        Me.GroupBox6.Controls.Add(Me.txtqtykeluar)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(523, 302)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(472, 76)
        Me.GroupBox6.TabIndex = 137
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "JUMLAH"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(292, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 28)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "="
        '
        'txttotal
        '
        Me.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttotal.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(327, 34)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(99, 25)
        Me.txttotal.TabIndex = 80
        '
        'txtqtykeluar
        '
        Me.txtqtykeluar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtqtykeluar.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqtykeluar.Location = New System.Drawing.Point(185, 34)
        Me.txtqtykeluar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtqtykeluar.Multiline = True
        Me.txtqtykeluar.Name = "txtqtykeluar"
        Me.txtqtykeluar.Size = New System.Drawing.Size(99, 25)
        Me.txtqtykeluar.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 31)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 28)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Qty Keluar"
        '
        'cbbj
        '
        Me.cbbj.Font = New System.Drawing.Font("Sitka Heading", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbj.FormattingEnabled = True
        Me.cbbj.Items.AddRange(New Object() {"Ayatullah", "Agus Sulaeman", "Herlina"})
        Me.cbbj.Location = New System.Drawing.Point(220, 129)
        Me.cbbj.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbbj.Name = "cbbj"
        Me.cbbj.Size = New System.Drawing.Size(160, 28)
        Me.cbbj.TabIndex = 90
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.DGV2)
        Me.GroupBox5.Controls.Add(Me.txtcari)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(49, 385)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(440, 171)
        Me.GroupBox5.TabIndex = 136
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PENCARIAN"
        '
        'DGV2
        '
        Me.DGV2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(24, 63)
        Me.DGV2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.Size = New System.Drawing.Size(391, 90)
        Me.DGV2.TabIndex = 88
        '
        'txtcari
        '
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcari.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.Location = New System.Drawing.Point(157, 31)
        Me.txtcari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcari.Multiline = True
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(241, 25)
        Me.txtcari.TabIndex = 87
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 30)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 28)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Cari Data"
        '
        'txtsatuan
        '
        Me.txtsatuan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsatuan.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsatuan.Location = New System.Drawing.Point(272, 126)
        Me.txtsatuan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtsatuan.Multiline = True
        Me.txtsatuan.Name = "txtsatuan"
        Me.txtsatuan.Size = New System.Drawing.Size(57, 22)
        Me.txtsatuan.TabIndex = 45
        '
        'cbkode
        '
        Me.cbkode.Font = New System.Drawing.Font("Baskerville Old Face", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbkode.FormattingEnabled = True
        Me.cbkode.Location = New System.Drawing.Point(185, 42)
        Me.cbkode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbkode.Name = "cbkode"
        Me.cbkode.Size = New System.Drawing.Size(92, 25)
        Me.cbkode.TabIndex = 44
        '
        'txtqty
        '
        Me.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtqty.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(185, 123)
        Me.txtqty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtqty.Multiline = True
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(79, 25)
        Me.txtqty.TabIndex = 43
        '
        'txtnama
        '
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnama.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(185, 81)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnama.Multiline = True
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(160, 25)
        Me.txtnama.TabIndex = 42
        '
        'txtpencarian
        '
        Me.txtpencarian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpencarian.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpencarian.Location = New System.Drawing.Point(24, 34)
        Me.txtpencarian.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpencarian.Multiline = True
        Me.txtpencarian.Name = "txtpencarian"
        Me.txtpencarian.Size = New System.Drawing.Size(213, 25)
        Me.txtpencarian.TabIndex = 89
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.btkeluar)
        Me.GroupBox7.Controls.Add(Me.btedit)
        Me.GroupBox7.Controls.Add(Me.bthapus)
        Me.GroupBox7.Controls.Add(Me.btsimpan)
        Me.GroupBox7.Controls.Add(Me.btbatal)
        Me.GroupBox7.Controls.Add(Me.bttambah)
        Me.GroupBox7.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(523, 385)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Size = New System.Drawing.Size(472, 171)
        Me.GroupBox7.TabIndex = 138
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "NAVIGASI"
        '
        'btkeluar
        '
        Me.btkeluar.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.Location = New System.Drawing.Point(320, 101)
        Me.btkeluar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(100, 41)
        Me.btkeluar.TabIndex = 45
        Me.btkeluar.Text = "KELUAR"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btedit.Location = New System.Drawing.Point(320, 37)
        Me.btedit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(100, 41)
        Me.btedit.TabIndex = 44
        Me.btedit.Text = "EDIT"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.Location = New System.Drawing.Point(179, 101)
        Me.bthapus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(100, 41)
        Me.bthapus.TabIndex = 42
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.Location = New System.Drawing.Point(179, 37)
        Me.btsimpan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(100, 41)
        Me.btsimpan.TabIndex = 41
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbatal.Location = New System.Drawing.Point(40, 101)
        Me.btbatal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(100, 41)
        Me.btbatal.TabIndex = 39
        Me.btbatal.Text = "BATAL"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttambah.Location = New System.Drawing.Point(40, 37)
        Me.bttambah.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(100, 41)
        Me.bttambah.TabIndex = 38
        Me.bttambah.Text = "TAMBAH"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 122)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 28)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Qty"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 128)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(177, 28)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Bertanggung Jawab"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtpencarian)
        Me.GroupBox4.Controls.Add(Me.DGV)
        Me.GroupBox4.Location = New System.Drawing.Point(49, 577)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(945, 258)
        Me.GroupBox4.TabIndex = 134
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PENCARIAN"
        '
        'DGV
        '
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(28, 74)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(887, 161)
        Me.DGV.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cbbj)
        Me.GroupBox3.Controls.Add(Me.DTP)
        Me.GroupBox3.Controls.Add(Me.txttransaksi)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(49, 117)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(440, 174)
        Me.GroupBox3.TabIndex = 135
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATA KELUAR"
        '
        'DTP
        '
        Me.DTP.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Location = New System.Drawing.Point(220, 84)
        Me.DTP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(193, 26)
        Me.DTP.TabIndex = 75
        '
        'txttransaksi
        '
        Me.txttransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttransaksi.Enabled = False
        Me.txttransaksi.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttransaksi.Location = New System.Drawing.Point(220, 39)
        Me.txttransaksi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttransaksi.Multiline = True
        Me.txttransaksi.Name = "txttransaksi"
        Me.txttransaksi.Size = New System.Drawing.Size(91, 25)
        Me.txttransaksi.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 28)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 28)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "No.Transaksi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 28)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Kode Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(695, 31)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "FORM STOK KELUAR PT SEJAHTERA KELOLA ABADI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 80)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 28)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Nama Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtsatuan)
        Me.GroupBox2.Controls.Add(Me.cbkode)
        Me.GroupBox2.Controls.Add(Me.txtqty)
        Me.GroupBox2.Controls.Add(Me.txtnama)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(523, 117)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(383, 174)
        Me.GroupBox2.TabIndex = 133
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA BARANG"
        '
        'Stok_Keluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1037, 878)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Stok_Keluar"
        Me.Text = "Stok_Keluar"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtqtykeluar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbbj As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtsatuan As System.Windows.Forms.TextBox
    Friend WithEvents cbkode As System.Windows.Forms.ComboBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtpencarian As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
