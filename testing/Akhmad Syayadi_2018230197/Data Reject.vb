Imports System.Data.Odbc
Public Class Data_Reject
    Dim CONN As OdbcConnection
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim CMD As OdbcCommand
    Dim DR As OdbcDataReader
    Dim CMD2 As OdbcCommand
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
        DA = New OdbcDataAdapter("select * from table_reject", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub autokode()
        Try
            Call koneksi()
            CMD = New OdbcCommand("Select * from table_reject order by Kode_Reject desc", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                txtreject.Text = "R01"
            Else
                txtreject.Text = Val(Microsoft.VisualBasic.Right(DR.GetString(0), 1)) + 1
                If Len(txtreject.Text) = 1 Then
                    txtreject.Text = "R0" & txtreject.Text & ""
                ElseIf Len(txtreject.Text) = 2 Then
                    txtreject.Text = "R" & txtreject.Text & ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan : " & ex.Message, "Pesan Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub kosongkan()
        txtreject.Clear()
        DTP.Text = ""
        cbkode.Text = ""
        txtnama.Clear()
        txtqty.Clear()
        txtsatuan.Clear()
        txtqtyreject.Clear()
        txttotal.Clear()
        txtcari.Clear()
        txtreject.Focus()
    End Sub
    Sub MatikanForm()
        txtreject.Enabled = False
        DTP.Enabled = False
        cbkode.Enabled = False
        txtnama.Enabled = False
        txtqty.Enabled = False
        txtsatuan.Enabled = False
        txtqtyreject.Enabled = False
        txttotal.Enabled = False
        txtcari.Enabled = False
    End Sub
    Sub HidupkanForm()
        txtreject.Enabled = False
        DTP.Enabled = True
        cbkode.Enabled = True
        txtnama.Enabled = False
        txtqty.Enabled = False
        txtsatuan.Enabled = False
        txtqtyreject.Enabled = True
        txttotal.Enabled = False
        txtcari.Enabled = True
    End Sub
    Sub munculkodebarang()
        Call koneksi()
        cbkode.Items.Clear()
        CMD = New OdbcCommand("Select * from table_stokmasuk", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            cbkode.Items.Add(DR.Item(3))
        Loop
    End Sub
    Private Sub cbkode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbkode.SelectedIndexChanged
        Call koneksi()
        CMD = New OdbcCommand("Select * from table_stokmasuk where Kode_Barang ='" & cbkode.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtnama.Text = DR!Nama_Barang
            txtqty.Text = DR!Qty_Total
            txtsatuan.Text = DR!Satuan
        End If
    End Sub

    Private Sub Data_Reject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Call koneksi()
        Call MatikanForm()
        Call tampilkan()
        Call munculkodebarang()

        DA = New OdbcDataAdapter("Select * from table_barang", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "table_barang")
        DGV2.DataSource = (DS.Tables("table_barang"))

        txtqtyreject.Text = "0"

        DGV.Columns(0).HeaderText = "Kode Reject"
        DGV.Columns(1).HeaderText = "Tanggal"
        DGV.Columns(2).HeaderText = "Kode Barang"
        DGV.Columns(3).HeaderText = "Nama Barang"
        DGV.Columns(4).HeaderText = "Qty"
        DGV.Columns(5).HeaderText = "Satuan"
        DGV.Columns(6).HeaderText = "Qty Reject"
        DGV.Columns(7).HeaderText = "Total"

        DGV.Columns(0).Width = 80
        DGV.Columns(1).Width = 100
        DGV.Columns(2).Width = 80
        DGV.Columns(3).Width = 150
        DGV.Columns(4).Width = 50
        DGV.Columns(5).Width = 50
        DGV.Columns(6).Width = 50
        DGV.Columns(7).Width = 50

        btsimpan.Enabled = False
        btedit.Enabled = False
        bthapus.Enabled = False
        btbatal.Enabled = False
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        txtreject.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        DTP.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        cbkode.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txtnama.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txtqty.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        txtsatuan.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        txtqtyreject.Text = DGV.Rows(e.RowIndex).Cells(6).Value
        txttotal.Text = DGV.Rows(e.RowIndex).Cells(7).Value

        txtreject.Enabled = False
        DTP.Enabled = True
        cbkode.Enabled = True
        txtnama.Enabled = True
        txtqty.Enabled = True
        txtsatuan.Enabled = True
        txtqtyreject.Enabled = True
        txttotal.Enabled = True

        btedit.Enabled = True
        bthapus.Enabled = True
        bttambah.Enabled = False
        btsimpan.Enabled = False
        btbatal.Enabled = True
    End Sub

    Private Sub bttambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttambah.Click
        Call HidupkanForm()
        Call autokode()
        btsimpan.Enabled = True
        btbatal.Enabled = True
    End Sub

    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        If DTP.Text = "" Or cbkode.Text = "" Or txtqtyreject.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call autokode()
            Call koneksi()
            CMD = New OdbcCommand("select * from table_reject where Kode_Reject ='" & txtreject.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call koneksi()
                Dim Simpan As String
                Dim sisabrg As String

                Simpan = "insert into table_reject values('" & txtreject.Text & "','" & DTP.Text & "','" & cbkode.Text & "','" & txtnama.Text & "','" & txtqty.Text & "','" & txtsatuan.Text & "','" & txtqtyreject.Text & "','" & txttotal.Text & "')"
                Dim Strpembanding As String = "Select * from table_reject where Nama_Barang = '" & txtnama.Text & "'"
                CMD = New OdbcCommand(Strpembanding, CONN)
                sisabrg = "update table_stokmasuk set Qty = '" & txttotal.Text & "', Qty_Total = '" & txttotal.Text & "' where Kode_Barang ='" & cbkode.Text & "'"
                CMD2 = New OdbcCommand(sisabrg, CONN)

                DR2 = CMD.ExecuteReader
                DR2.Read()
                Call koneksi()

                CMD2 = New OdbcCommand(sisabrg, CONN)
                CMD2.ExecuteNonQuery()

                CMD = New OdbcCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan")
                Call tampilkan()
            End If
            Call MatikanForm()
            Call kosongkan()
            Call tampilkan()
        End If
    End Sub

    Private Sub btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
        If cbkode.Text = "" Or txtqtyreject.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call tampilkan()
            Call koneksi()
            Dim sisabrg As String
            str = "update table_reject set Tanggal = '" & DTP.Text & "' , Kode_Barang = '" & cbkode.Text & "' , Nama_Barang = '" & txtnama.Text & "' , Qty = '" & txtqty.Text & "' , Satuan = '" & txtsatuan.Text & "' , Qty_Reject = '" & txtqtyreject.Text & "' , Total = '" & txttotal.Text & "' where Kode_Reject = '" & txtreject.Text & "'"
            CMD = New OdbcCommand(str, CONN)
            CMD.ExecuteNonQuery()

            sisabrg = "update table_stokmasuk set Qty = '" & txttotal.Text & "', Qty_Total = '" & txttotal.Text & "' where Kode_Barang ='" & cbkode.Text & "'"
            CMD2 = New OdbcCommand(sisabrg, CONN)
            CMD2.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Diubah")
            Call tampilkan()
        End If
        Call MatikanForm()
        Call kosongkan()
        Call tampilkan()
    End Sub

    Private Sub btbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbatal.Click
        Call kosongkan()
        bttambah.Enabled = True
        btsimpan.Enabled = False
        btedit.Enabled = False
        bthapus.Enabled = False
    End Sub

    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        If txtreject.Text = "" Then
            MsgBox("Tidak ada data yang akan dihapus")
            Exit Sub
        Else
            If MessageBox.Show("Apakah Yakin Untuk Menghapusnya ?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                CMD = New OdbcCommand("delete from table_reject where Kode_Reject ='" & txtreject.Text & "'", CONN)
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

    Private Sub txtqtyreject_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqtyreject.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtqty.Text) = Val(txtqtyreject.Text) Then
                txttotal.Text = 0
                Exit Sub
            Else
                txttotal.Text = Val(txtqty.Text) - Val(txtqtyreject.Text)

            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txtqtyreject_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqtyreject.Leave
        txttotal.Text = Val(txtqty.Text - txtqtyreject.Text)
    End Sub

    Private Sub txtcari_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcari.Click
        Call koneksi()
        CMD = New OdbcCommand("Select * from table_barang where Nama_Barang Like '%" & txtcari.Text & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Call koneksi()
            DA = New OdbcDataAdapter("Select * from table_barang where Nama_Barang Like '%" & txtcari.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "KetemuData")
            DGV2.DataSource = DS.Tables("KetemuData")
            DGV2.ReadOnly = True
        End If
    End Sub

    Private Sub txtpencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpencarian.TextChanged
        Call koneksi()
        CMD = New OdbcCommand("Select * From table_reject Where Nama_Barang Like '%" & txtpencarian.Text & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Call koneksi()
            DA = New OdbcDataAdapter("Select * From table_reject Where Nama_Barang Like '%" & txtpencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        Call koneksi()
        CMD = New OdbcCommand("Select * From table_barang where Nama_Barang Like '%" & txtcari.Text & "%'", CONN)
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
End Class