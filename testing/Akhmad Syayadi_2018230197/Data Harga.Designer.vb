<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Harga
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtpencarian = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbnama = New System.Windows.Forms.ComboBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox4.Location = New System.Drawing.Point(60, 347)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(354, 139)
        Me.GroupBox4.TabIndex = 138
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "NAVIGASI"
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtpencarian)
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Location = New System.Drawing.Point(436, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 295)
        Me.GroupBox2.TabIndex = 139
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PENCARIAN"
        '
        'txtpencarian
        '
        Me.txtpencarian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpencarian.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpencarian.Location = New System.Drawing.Point(23, 28)
        Me.txtpencarian.Multiline = True
        Me.txtpencarian.Name = "txtpencarian"
        Me.txtpencarian.Size = New System.Drawing.Size(160, 20)
        Me.txtpencarian.TabIndex = 90
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(23, 58)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(331, 224)
        Me.DGV.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbnama)
        Me.GroupBox1.Controls.Add(Me.txtharga)
        Me.GroupBox1.Controls.Add(Me.txtkode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(60, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 150)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA BARANG"
        '
        'cbnama
        '
        Me.cbnama.Font = New System.Drawing.Font("Sitka Heading", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbnama.FormattingEnabled = True
        Me.cbnama.Location = New System.Drawing.Point(180, 72)
        Me.cbnama.Name = "cbnama"
        Me.cbnama.Size = New System.Drawing.Size(121, 24)
        Me.cbnama.TabIndex = 38
        '
        'txtharga
        '
        Me.txtharga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtharga.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.Location = New System.Drawing.Point(180, 114)
        Me.txtharga.Multiline = True
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(147, 20)
        Me.txtharga.TabIndex = 37
        '
        'txtkode
        '
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtkode.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(180, 36)
        Me.txtkode.Multiline = True
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(80, 20)
        Me.txtkode.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 21)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 21)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Kode Harga"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 24)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "FORM HARGA PT SEJAHTERA KELOLA ABADI"
        '
        'Data_Harga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(872, 613)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Data_Harga"
        Me.Text = " "
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpencarian As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbnama As System.Windows.Forms.ComboBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
