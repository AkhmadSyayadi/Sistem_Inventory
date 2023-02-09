Imports System.Data.Odbc
Public Class Registervb
    Dim CONN As OdbcConnection
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim CMD As OdbcCommand
    Dim DR As OdbcDataReader
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
        DA = New OdbcDataAdapter("select * from table_register", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub autokode()
        Try
            Call koneksi()
            CMD = New OdbcCommand("Select * from table_register order by Id desc", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                txtid.Text = "001"
            Else
                txtid.Text = Val(Microsoft.VisualBasic.Right(DR.GetString(0), 1)) + 1
                If Len(txtid.Text) = 1 Then
                    txtid.Text = "00" & txtid.Text & ""
                ElseIf Len(txtid.Text) = 2 Then
                    txtid.Text = "0" & txtid.Text & ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan : " & ex.Message, "Pesan Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub kosongkan()
        txtid.Clear()
        txtalamat.Clear()
        txtnama.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        cbstatus.Text = ""
        txtid.Focus()
    End Sub
    Sub MatikanForm()
        txtid.Enabled = False
        txtnama.Enabled = False
        txtalamat.Enabled = False
        txtusername.Enabled = False
        txtpassword.Enabled = False
        cbstatus.Enabled = False
    End Sub
    Sub HidupkanForm()
        txtid.Enabled = False
        txtnama.Enabled = True
        txtalamat.Enabled = True
        txtusername.Enabled = True
        txtpassword.Enabled = True
        cbstatus.Enabled = True
    End Sub

    Private Sub Registervb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Call MatikanForm()
        Call koneksi()
        Call tampilkan()

        DGV.Columns(0).HeaderText = "Id"
        DGV.Columns(1).HeaderText = "Nama Lengkap"
        DGV.Columns(2).HeaderText = "Alamat"
        DGV.Columns(3).HeaderText = "Username"
        DGV.Columns(4).HeaderText = "Password"
        DGV.Columns(5).HeaderText = "Status"

        DGV.Columns(0).Width = 30
        DGV.Columns(1).Width = 120
        DGV.Columns(2).Width = 120
        DGV.Columns(3).Width = 80
        DGV.Columns(4).Width = 80
        DGV.Columns(5).Width = 50
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

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        txtid.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txtnama.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        txtalamat.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txtusername.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txtpassword.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        cbstatus.Text = DGV.Rows(e.RowIndex).Cells(5).Value

        txtid.Enabled = False
        txtnama.Enabled = True
        txtalamat.Enabled = True
        txtusername.Enabled = True
        txtpassword.Enabled = True
        cbstatus.Enabled = True
        btedit.Enabled = True
        bthapus.Enabled = True
        bttambah.Enabled = False
        btsimpan.Enabled = False
        btbatal.Enabled = True
    End Sub

    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        If txtid.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Or cbstatus.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call autokode()
            Call koneksi()
            CMD = New OdbcCommand("select * from table_register where Id ='" & txtid.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call koneksi()
                Dim Simpan As String
                Simpan = "insert into table_register values('" & txtid.Text & "','" & txtnama.Text & "','" & txtalamat.Text & "','" & txtusername.Text & "','" & txtpassword.Text & "','" & cbstatus.Text & "')"
                Dim Strpembanding As String = "Select * from table_register where Username = '" & txtusername.Text & "'"
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

    Private Sub btbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbatal.Click
        Call MatikanForm()
        Call kosongkan()
        bttambah.Enabled = True
        btsimpan.Enabled = False
        btedit.Enabled = False
        bthapus.Enabled = False
    End Sub

    Private Sub btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
        If txtnama.Text = "" Or txtalamat.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Or cbstatus.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call tampilkan()
            Call koneksi()
            str = "update table_register set Nama_Lengkap = '" & txtnama.Text & "', Alamat = '" & txtalamat.Text & "', Username = '" & txtusername.Text & "' , Password = '" & txtpassword.Text & "' , Status = '" & cbstatus.Text & "' where Id = '" & txtid.Text & "'"
            CMD = New OdbcCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Diubah")
            Call tampilkan()
        End If
        Call MatikanForm()
        Call kosongkan()
        Call tampilkan()
    End Sub

    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        If txtid.Text = "" Then
            MsgBox("Tidak ada data yang akan dihapus")
            Exit Sub
        Else
            If MessageBox.Show("Apakah Yakin Untuk Menghapusnya ?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                CMD = New OdbcCommand("delete from table_register where Id ='" & txtid.Text & "'", CONN)
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
        CMD = New OdbcCommand("Select * From table_register Where Nama_Lengkap Like '%" & txtpencarian.Text & "%'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Call koneksi()
            DA = New OdbcDataAdapter("Select * From table_register Where Nama_Lengkap Like '%" & txtpencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
    End Sub
End Class