Imports System.Data.Odbc
Public Class Data_Harga
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
        DA = New OdbcDataAdapter("select * from table_harga", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub autokode()
        Try
            Call koneksi()
            CMD = New OdbcCommand("Select * from table_harga order by Kode_Harga desc", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                txtkode.Text = "H01"
            Else
                txtkode.Text = Val(Microsoft.VisualBasic.Right(DR.GetString(0), 1)) + 1
                If Len(txtkode.Text) = 1 Then
                    txtkode.Text = "H0" & txtkode.Text & ""
                ElseIf Len(txtkode.Text) = 2 Then
                    txtkode.Text = "H" & txtkode.Text & ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan : " & ex.Message, "Pesan Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub kosongkan()
        txtkode.Clear()
        cbnama.Text = ""
        txtharga.Text = ""
        txtkode.Focus()
    End Sub
    Sub MatikanForm()
        txtkode.Enabled = False
        cbnama.Enabled = False
        txtharga.Enabled = False
    End Sub
    Sub HidupkanForm()
        txtkode.Enabled = False
        cbnama.Enabled = True
        txtharga.Enabled = True
    End Sub
    Sub munculnama()
        Call koneksi()
        cbnama.Items.Clear()
        CMD = New OdbcCommand("Select Nama_Barang from table_barang", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            cbnama.Items.Add(DR.Item(0))
        Loop
    End Sub

    Private Sub Data_Harga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Call MatikanForm()
        Call koneksi()
        Call tampilkan()
        Call munculnama()

        DGV.Columns(0).HeaderText = "Kode"
        DGV.Columns(1).HeaderText = "Nama Barang"
        DGV.Columns(2).HeaderText = "Harga"

        DGV.Columns(0).Width = 80
        DGV.Columns(1).Width = 150
        DGV.Columns(2).Width = 60

        btsimpan.Enabled = False
        btedit.Enabled = False
        bthapus.Enabled = False
        btbatal.Enabled = False
    End Sub
    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        txtkode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        cbnama.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        txtharga.Text = DGV.Rows(e.RowIndex).Cells(2).Value

        txtkode.Enabled = False
        cbnama.Enabled = True
        txtharga.Enabled = True
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
        If cbnama.Text = "" Or txtharga.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call autokode()
            Call koneksi()
            CMD = New OdbcCommand("select * from table_harga where Kode_Harga ='" & txtkode.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call koneksi()
                Dim Simpan As String
                Simpan = "insert into table_harga values('" & txtkode.Text & "','" & cbnama.Text & "','" & txtharga.Text & "')"
                Dim Strpembanding As String = "Select * from table_harga where Nama_Harga = '" & cbnama.Text & "'"
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
        If cbnama.Text = "" Or txtharga.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call tampilkan()
            Call koneksi()
            str = "update table_harga set Nama_Harga = '" & cbnama.Text & "' , Harga = '" & txtharga.Text & "' where Kode_Harga = '" & txtkode.Text & "'"
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
                CMD = New OdbcCommand("delete from table_harga where Kode_Harga ='" & txtkode.Text & "'", CONN)
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

    Private Sub txtpencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpencarian.TextChanged
        Call koneksi()
        CMD = New OdbcCommand("Select * From table_harga Where Nama_Barang Like '%" & txtpencarian.Text & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Call koneksi()
            DA = New OdbcDataAdapter("Select * From table_harga Where Nama_Barang Like '%" & txtpencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
    End Sub
End Class