Imports System.Data.Odbc
Public Class Login
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
    Sub kosongkan()
        txtid.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtid.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub btmasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmasuk.Click
        Try
            If txtid.Text = "" Or txtpass.Text = "" Then
                MessageBox.Show("Isi Username dan Password terlebih dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Call koneksi()
                CMD = New OdbcCommand("select * from table_register where Username = '" & txtid.Text & "' and Password = '" & txtpass.Text & "'", CONN)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    If DR("Status").ToString = "SupAdm" Then
                        Me.Hide()
                        Menu_Super_Admin.Show()
                    Else
                        If DR("Status").ToString = "AdmGud" Then
                            Me.Hide()
                            Menu_Admin_Gudang.Show()
                        End If
                        If DR("Status").ToString = "AdmPem" Then
                            Me.Hide()
                            Menu_Admin_Pemasaran.Show()
                        End If
                    End If
                Else
                    MessageBox.Show("Akun anda belum terdaftar!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            Call kosongkan()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If txtpass.UseSystemPasswordChar = True Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged
        txtpass.UseSystemPasswordChar = True
    End Sub

    Private Sub btkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkeluar.Click
        Application.Exit()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub
End Class