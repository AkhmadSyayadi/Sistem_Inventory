Imports System.Data.Odbc
Public Class Stok_Masuk
    Dim CONN As OdbcConnection
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim CMD As OdbcCommand
    Dim CMD2 As OdbcCommand
    Dim DR As OdbcDataReader
    Dim DR2 As OdbcDataReader
    Dim str As String
    Dim LokasiData As String
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver};Database=2023_kp;server=localhost;uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub tampilkan()
        DA = New OdbcDataAdapter("select * from table_stokmasuk", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub autokode()
        Try
            Call koneksi()
            CMD = New OdbcCommand("Select * from table_stokmasuk order by Kode_Masuk desc", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                txtkode.Text = "M01"
            Else
                txtkode.Text = Val(Microsoft.VisualBasic.Right(DR.GetString(0), 1)) + 1
                If Len(txtkode.Text) = 1 Then
                    txtkode.Text = "M0" & txtkode.Text & ""
                ElseIf Len(txtkode.Text) = 2 Then
                    txtkode.Text = "M" & txtkode.Text & ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan : " & ex.Message, "Pesan Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub kosongkan()
        txtkode.Clear()
        DTP.Text = ""
        cbbj.Text = ""
        cbkode.Text = ""
        txtnamabarang.Clear()
        txtsatuan.Clear()
        cbsuplier.Text = ""
        txtqty.Clear()
        txttambah.Clear()
        txtqtytotal.Clear()
        txtcari.Clear()
        txtkode.Focus()
    End Sub
    Sub MatikanForm()
        txtkode.Enabled = False
        DTP.Enabled = False
        cbbj.Enabled = False
        cbkode.Enabled = False
        txtnamabarang.Enabled = False
        txtsatuan.Enabled = False
        cbsuplier.Enabled = False
        txtqty.Enabled = False
        txttambah.Enabled = False
        txtqtytotal.Enabled = False
        txtcari.Enabled = False
    End Sub
    Sub HidupkanForm()
        txtkode.Enabled = False
        DTP.Enabled = True
        cbbj.Enabled = True
        cbkode.Enabled = True
        txtnamabarang.Enabled = False
        txtsatuan.Enabled = False
        cbsuplier.Enabled = True
        txtqty.Enabled = True
        txttambah.Enabled = False
        txtqtytotal.Enabled = False
        txtcari.Enabled = True
    End Sub
    Sub munculkodebarang()
        Call koneksi()
        cbkode.Items.Clear()
        CMD = New OdbcCommand("Select * from table_barang", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            cbkode.Items.Add(DR.Item(0))
        Loop
    End Sub
    Sub munculnamasuplier()
        Call koneksi()
        cbsuplier.Items.Clear()
        CMD = New OdbcCommand("Select Nama_Supplier from table_supplier", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            cbsuplier.Items.Add(DR.Item(0))
        Loop
    End Sub

    Private Sub Stok_Masuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Call MatikanForm()
        Call koneksi()
        Call tampilkan()
        Call munculkodebarang()
        Call munculnamasuplier()

        DA = New OdbcDataAdapter("Select * from table_barang", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "table_barang")
        DGV2.DataSource = (DS.Tables("table_barang"))

        txtqty.Text = "0"
        txttambah.Text = "0"
        txtqtytotal.Text = "0"

        DGV.Columns(0).HeaderText = "Kode"
        DGV.Columns(1).HeaderText = "Tanggal"
        DGV.Columns(2).HeaderText = "Bertanggung Jawab"
        DGV.Columns(3).HeaderText = "Kode Barang"
        DGV.Columns(4).HeaderText = "Nama Barang"
        DGV.Columns(5).HeaderText = "Satuan"
        DGV.Columns(6).HeaderText = "Supplier"
        DGV.Columns(7).HeaderText = "QTY"
        DGV.Columns(8).HeaderText = "QTY Total"

        DGV.Columns(0).Width = 50
        DGV.Columns(1).Width = 120
        DGV.Columns(2).Width = 100
        DGV.Columns(3).Width = 70
        DGV.Columns(4).Width = 100
        DGV.Columns(5).Width = 50
        DGV.Columns(6).Width = 100
        DGV.Columns(7).Width = 50
        DGV.Columns(8).Width = 100


        btsimpan.Enabled = False
        btedit.Enabled = False
        bthapus.Enabled = False
        btbatal.Enabled = False
    End Sub

    Private Sub bttambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttambah.Click
        Call HidupkanForm()
        Call autokode()
        btsimpan.Enabled = True
        btbatal.Enabled = True

        txtqty.Text = "0"
        txttambah.Text = "0"
        txtqtytotal.Text = "0"
    End Sub

    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        If DTP.Text = "" Or cbbj.Text = "" Or cbkode.Text = "" Or cbsuplier.Text = "" Or txtqty.Text = "" Or txttambah.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call autokode()
            Call koneksi()
            CMD = New OdbcCommand("select * from table_stokmasuk where Kode_Masuk ='" & txtkode.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call koneksi()
                Dim Simpan As String
                Simpan = "insert into table_stokmasuk values('" & txtkode.Text & "','" & DTP.Text & "','" & cbbj.Text & "','" & cbkode.Text & "','" & txtnamabarang.Text & "','" & txtsatuan.Text & "','" & cbsuplier.Text & "','" & txtqty.Text & "','" & txtqtytotal.Text & "')"
                Dim Strpembanding As String = "Select * from table_stokmasuk where Nama_Barang = '" & txtnamabarang.Text & "'"
                CMD = New OdbcCommand(Strpembanding, CONN)
                str = "update table_stokmasuk set Qty = '" & txtqty.Text & "' where Kode_Barang ='" & cbkode.Text & "'"
                CMD2 = New OdbcCommand(str, CONN)

                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    MsgBox("Data Sudah Ada")
                Else
                    Call koneksi()
                    CMD = New OdbcCommand(Simpan, CONN)
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil Disimpan")
                    Call tampilkan()
                End If
            End If
            Call MatikanForm()
            Call kosongkan()
            Call tampilkan()
        End If
    End Sub

    Private Sub btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
        If cbkode.Text = "" Or cbsuplier.Text = "" Or txtsatuan.Text = "" Or txtqty.Text = "" Or txtqtytotal.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call tampilkan()
            Call koneksi()
            txtqty.Text = txtqtytotal.Text
            str = "update table_stokmasuk set Bertanggung_Jawab = '" & cbbj.Text & "' , Kode_Barang = '" & cbkode.Text & "' , Supplier = '" & cbsuplier.Text & "', Satuan = '" & txtsatuan.Text & "', Qty = '" & txtqty.Text & "', Qty_Total = '" & txtqtytotal.Text & "' where Kode_Masuk = '" & txtkode.Text & "'"
            CMD = New OdbcCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Diubah")
            Call tampilkan()
        End If
        Call MatikanForm()
        Call kosongkan()
        Call tampilkan()
    End Sub

    Private Sub btbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbatal.Click
        Call MatikanForm()
        Call kosongkan()
        bttambah.Enabled = True
        btsimpan.Enabled = False
        btedit.Enabled = False
        bthapus.Enabled = False
    End Sub

    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        If txtkode.Text = "" Then
            MsgBox("Tidak ada data yang akan dihapus")
            Exit Sub
        Else
            If MessageBox.Show("Apakah Yakin Untuk Menghapusnya ?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                CMD = New OdbcCommand("delete from table_stokmasuk where Kode_Masuk ='" & txtkode.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Hapus Data Sukses")

                Call MatikanForm()
                Call kosongkan()
                Call tampilkan()
            Else
                Call MatikanForm()
                Call kosongkan()
            End If
        End If
    End Sub

    Private Sub btkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkeluar.Click
        Me.Close()
    End Sub

    Private Sub cbkode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbkode.SelectedIndexChanged
        Call koneksi()
        CMD = New OdbcCommand("Select * from table_barang where Kode_Barang ='" & cbkode.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtnamabarang.Text = DR!Nama_Barang
            txtsatuan.Text = DR!Satuan
        End If
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        txtkode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        DTP.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        cbbj.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        cbkode.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txtnamabarang.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        txtsatuan.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        cbsuplier.Text = DGV.Rows(e.RowIndex).Cells(6).Value
        txtqty.Text = DGV.Rows(e.RowIndex).Cells(7).Value
        txtqtytotal.Text = DGV.Rows(e.RowIndex).Cells(8).Value

        txtkode.Enabled = False
        DTP.Enabled = True
        cbbj.Enabled = True
        cbkode.Enabled = True
        txtnamabarang.Enabled = True
        txtsatuan.Enabled = True
        cbsuplier.Enabled = True
        txtqty.Enabled = True
        txttambah.Enabled = True
        txtqtytotal.Enabled = True
        btedit.Enabled = True
        bthapus.Enabled = True
        bttambah.Enabled = False
        btsimpan.Enabled = False
        btbatal.Enabled = True
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        Call koneksi()
        CMD = New OdbcCommand("Select * From table_barang Where Nama_Barang Like '%" & txtcari.Text & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Call koneksi()
            DA = New OdbcDataAdapter("Select * From table_barang Where Nama_Barang Like '%" & txtcari.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV2.DataSource = DS.Tables(0)
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
    End Sub

    Private Sub txtpencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpencarian.TextChanged
        Call koneksi()
        CMD = New OdbcCommand("Select * From table_stokmasuk Where Nama_Barang Like '%" & txtpencarian.Text & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Call koneksi()
            DA = New OdbcDataAdapter("Select * From table_stokmasuk Where Nama_Barang Like '%" & txtpencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
    End Sub

    Private Sub txttambah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttambah.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtqty.Text) = Val(txttambah.Text) Then
                txtqtytotal.Text = 0
                Exit Sub
            Else
                txtqtytotal.Text = Val(txtqty.Text) + Val(txttambah.Text)

            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtqty.Text) = Val(txttambah.Text) Then
                txtqtytotal.Text = 0
                Exit Sub
            Else
                txtqtytotal.Text = Val(txtqty.Text) + Val(txttambah.Text)

            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
End Class