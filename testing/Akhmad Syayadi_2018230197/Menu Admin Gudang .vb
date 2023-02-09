Public Class Menu_Admin_Gudang
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Panel2.Visible = True
        PictureBox1.Visible = False
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Panel2.Visible = False
        PictureBox1.Visible = True
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Panel4.Visible = True
        PictureBox4.Visible = True
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Panel8.Visible = True
        PictureBox11.Visible = True
    End Sub
    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Data_Supplier.Show()
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Panel4.Visible = False
        PictureBox4.Visible = True
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Application.Exit()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Panel8.Visible = False
        PictureBox11.Visible = True
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Data_Barang.Show()
    End Sub

    Private Sub btLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogout.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Panel17.Visible = True
        PictureBox2.Visible = True
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Panel17.Visible = False
        PictureBox2.Visible = True
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Stok_Masuk.Show()
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        Stok_Keluar.Show()
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        Data_Reject.Show()
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        Data_Hilang.Show()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        AxCrystalReport1.ReportFileName = "LaporanStokBarang.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        AxCrystalReport2.ReportFileName = "laporan_stok_masuk.rpt"
        AxCrystalReport2.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport2.RetrieveDataFiles()
        AxCrystalReport2.Action = 1
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        AxCrystalReport5.ReportFileName = "laporan_stok_keluar.rpt"
        AxCrystalReport5.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport5.RetrieveDataFiles()
        AxCrystalReport5.Action = 1
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        AxCrystalReport3.ReportFileName = "laporan_supplier.rpt"
        AxCrystalReport3.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport3.RetrieveDataFiles()
        AxCrystalReport3.Action = 1
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        AxCrystalReport6.ReportFileName = "laporan_reject.rpt"
        AxCrystalReport6.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport6.RetrieveDataFiles()
        AxCrystalReport6.Action = 1
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        AxCrystalReport4.ReportFileName = "laporan_hilang.rpt"
        AxCrystalReport4.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport4.RetrieveDataFiles()
        AxCrystalReport4.Action = 1
    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs) Handles Panel11.Paint

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class