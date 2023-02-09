Imports System.Data.Odbc
Public Class Data_Pemesan
    Dim CONN As OdbcConnection
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim CMD As OdbcCommand
    Dim DR As OdbcDataReader
    Dim LokasiData As String
    Dim str As String

    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver};Database=2023_kp;server=localhost;uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub tampilkan()
        DA = New OdbcDataAdapter("select * from table_pemesanan", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub autokode()
        Try
            Call koneksi()
            CMD = New OdbcCommand("Select * from table_pemesanan order by No_Transaksi desc", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                txtkode.Text = "P01"
            Else
                txtkode.Text = Val(Microsoft.VisualBasic.Right(DR.GetString(0), 1)) + 1
                If Len(txtkode.Text) = 1 Then
                    txtkode.Text = "P0" & txtkode.Text & ""
                ElseIf Len(txtkode.Text) = 2 Then
                    txtkode.Text = "P" & txtkode.Text & ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan : " & ex.Message, "Pesan Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub kosongkan()
        txtkode.Clear()
        txtnama.Text = ""
        txttelepon.Clear()
        txtalamat.Clear()
        cbnama.Text = ""
        txtharga.Clear()
        txtjumlah.Clear()
        txttotal.Clear()
        txtbayar.Clear()
        txtkembali.Clear()
        txtkode.Focus()
    End Sub
    Sub MatikanForm()
        txtkode.Enabled = False
        txtnama.Enabled = False
        txttelepon.Enabled = False
        txtalamat.Enabled = False
        cbnama.Enabled = False
        txtharga.Enabled = False
        txtjumlah.Enabled = False
        txttotal.Enabled = False
        txtbayar.Enabled = False
        txtkembali.Enabled = False
    End Sub
    Sub HidupkanForm()
        txtkode.Enabled = False
        txtnama.Enabled = True
        txttelepon.Enabled = True
        txtalamat.Enabled = True
        cbnama.Enabled = True
        txtharga.Enabled = False
        txtjumlah.Enabled = True
        txttotal.Enabled = True
        txtbayar.Enabled = True
        txtkembali.Enabled = True
    End Sub
    Sub munculnamaharga()
        Call koneksi()
        cbnama.Items.Clear()
        CMD = New OdbcCommand("Select * from table_harga", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            cbnama.Items.Add(DR.Item(1))
        Loop
    End Sub

    Private Sub Data_Pemesan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Call MatikanForm()
        Call koneksi()
        Call tampilkan()
        Call munculnamaharga()

        DGV.Columns(0).HeaderText = "No.Transaksi"
        DGV.Columns(1).HeaderText = "Nama Perusahaan"
        DGV.Columns(2).HeaderText = "Telepon"
        DGV.Columns(3).HeaderText = "Alamat"
        DGV.Columns(4).HeaderText = "Nama Barang"
        DGV.Columns(5).HeaderText = "Harga"
        DGV.Columns(6).HeaderText = "Jumlah"
        DGV.Columns(7).HeaderText = "Total"
        DGV.Columns(8).HeaderText = "Bayar"
        DGV.Columns(9).HeaderText = "Kembali"

        DGV.Columns(0).Width = 80
        DGV.Columns(1).Width = 200
        DGV.Columns(2).Width = 100
        DGV.Columns(3).Width = 250
        DGV.Columns(4).Width = 200
        DGV.Columns(5).Width = 90
        DGV.Columns(6).Width = 90
        DGV.Columns(7).Width = 90
        DGV.Columns(8).Width = 90
        DGV.Columns(9).Width = 90
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
    End Sub

    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        If txtkode.Text = "" Or txtnama.Text = "" Or txttelepon.Text = "" Or txtalamat.Text = "" Or cbnama.Text = "" Or txtharga.Text = "" Or txtjumlah.Text = "" Or txttotal.Text = "" Or txtbayar.Text = "" Or txtkembali.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call autokode()
            Call koneksi()
            CMD = New OdbcCommand("select * from table_pemesanan where No_Transaksi ='" & txtkode.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call koneksi()
                Dim Simpan As String
                Simpan = "insert into table_pemesanan values('" & txtkode.Text & "','" & txtnama.Text & "','" & txttelepon.Text & "','" & txtalamat.Text & "','" & cbnama.Text & "','" & txtharga.Text & "','" & txtjumlah.Text & "','" & txttotal.Text & "','" & txtbayar.Text & "','" & txtkembali.Text & "')"
                Dim Strpembanding As String = "Select * from table_pemesanan where Nama_Perusahaan = '" & txtnama.Text & "'"
                CMD = New OdbcCommand(Strpembanding, CONN)
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
        If txtkode.Text = "" Or txtnama.Text = "" Or txttelepon.Text = "" Or txtalamat.Text = "" Or cbnama.Text = "" Or txtharga.Text = "" Or txtjumlah.Text = "" Or txttotal.Text = "" Or txtbayar.Text = "" Or txtkembali.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call tampilkan()
            Call koneksi()
            str = "update table_pemesanan set Nama_Perusahaan = '" & txtnama.Text & "' , Telepon = '" & txttelepon.Text & "' , Alamat = '" & txtalamat.Text & "' , Nama_Barang = '" & cbnama.Text & "' , Harga = '" & txtharga.Text & "' , Jumlah = '" & txtjumlah.Text & "' , Total = '" & txttotal.Text & "' , Bayar = '" & txtbayar.Text & "' , Kembali = '" & txtkembali.Text & "' where No_Transaksi = '" & txtkode.Text & "'"
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
                CMD = New OdbcCommand("delete from table_pemesanan where No_Transaksi ='" & txtkode.Text & "'", CONN)
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

    Private Sub txtjumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtharga.Text) = Val(txtjumlah.Text) Then
                txttotal.Text = 0
                Exit Sub
            Else
                txttotal.Text = Val(txtharga.Text) * Val(txtjumlah.Text)

            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txtbayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtbayar.Text) < Val(txttotal.Text) Then
                MsgBox("Pembayaran Kurang")
                txtkembali.Text = ""
                txtbayar.Focus()
                Exit Sub


            Else
                If Val(txtbayar.Text) = Val(txttotal.Text) Then
                    txtkembali.Text = 0
                Else
                    txtkembali.Text = Val(txtbayar.Text) - Val(txttotal.Text)
                End If
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        txtkode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txtnama.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        txttelepon.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txtalamat.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        cbnama.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        txtharga.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        txtjumlah.Text = DGV.Rows(e.RowIndex).Cells(6).Value
        txttotal.Text = DGV.Rows(e.RowIndex).Cells(7).Value
        txtbayar.Text = DGV.Rows(e.RowIndex).Cells(8).Value
        txtkembali.Text = DGV.Rows(e.RowIndex).Cells(9).Value

        txtkode.Enabled = False
        txtnama.Enabled = True
        txttelepon.Enabled = True
        txtalamat.Enabled = True
        cbnama.Enabled = True
        txtharga.Enabled = False
        txtjumlah.Enabled = True
        txttotal.Enabled = True
        txtbayar.Enabled = True
        txtkembali.Enabled = True
        btedit.Enabled = True
        bthapus.Enabled = True
        bttambah.Enabled = False
        btsimpan.Enabled = False
        btbatal.Enabled = True

        txtcode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txtcode.Focus()
    End Sub

    Private Sub txtpencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpencarian.TextChanged
        Call koneksi()
        CMD = New OdbcCommand("Select * From table_pemesanan Where Nama_Barang Like '%" & txtpencarian.Text & "%' Or No_Transaksi Like '%" & txtpencarian.Text & "%' Or Nama_Perusahaan Like '%" & txtpencarian.Text & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Call koneksi()
            DA = New OdbcDataAdapter("Select * From table_pemesanan Where Nama_Barang Like '%" & txtpencarian.Text & "%' Or No_Transaksi Like '%" & txtpencarian.Text & "%' Or Nama_Perusahaan Like '%" & txtpencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
    End Sub

    Private Sub cbnama_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbnama.SelectedIndexChanged
        Call koneksi()
        CMD = New OdbcCommand("Select * from table_harga where Nama_Harga ='" & cbnama.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtharga.Text = DR!Harga
        End If
    End Sub

    Private Sub btcetak_Click(sender As Object, e As EventArgs) Handles btcetak.Click
        If txtcode.Text = "" Then
            MsgBox("Silahkan Pilih Data Yang Ingin Dipilih")
        Else
            AxCrystalReport1.SelectionFormula = "totext({table_pemesanan.No_Transaksi}) = '" & txtcode.Text & "'"
            AxCrystalReport1.ReportFileName = "laporan_pemesanan.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If
    End Sub
End Class