Public Class Menu_Admin_Pemasaran
    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Panel8.Visible = True
        PictureBox11.Visible = True
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Panel8.Visible = False
        PictureBox11.Visible = True
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        AxCrystalReport1.ReportFileName = "LaporanStokBarang.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Panel2.Visible = True
        PictureBox1.Visible = False
    End Sub

    Private Sub btLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogout.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Panel4.Visible = True
        PictureBox4.Visible = True
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Panel4.Visible = False
        PictureBox4.Visible = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Data_Pemesan.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        AxCrystalReport2.ReportFileName = "laporan_pemesanan.rpt"
        AxCrystalReport2.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport2.RetrieveDataFiles()
        AxCrystalReport2.Action = 1
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Data_Harga.Show()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        AxCrystalReport3.ReportFileName = "laporan_harga.rpt"
        AxCrystalReport3.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport3.RetrieveDataFiles()
        AxCrystalReport3.Action = 1
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class