Public Class Menu_Super_Admin
    Private Sub btMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Application.Exit()
    End Sub

    Private Sub btDatamaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDatamaster.Click
        Label1.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        Label5.Visible = False
        Label7.Visible = False

        pnlDatamaster.Visible = True
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnltentang.Visible = False
    End Sub

    Private Sub btTransaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTransaksi.Click
        Label1.Visible = False
        Label2.Visible = True
        Label3.Visible = False
        Label5.Visible = False
        Label7.Visible = False

        pnlDatamaster.Visible = False
        pnlTransaksi.Visible = True
        pnlLaporan.Visible = False
        pnltentang.Visible = False
    End Sub

    Private Sub btLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLaporan.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = True
        Label5.Visible = False
        Label7.Visible = False

        pnlDatamaster.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = True
        pnltentang.Visible = False
    End Sub

    Private Sub btLainnya_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLainnya.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label5.Visible = True
        Label7.Visible = False

        pnlDatamaster.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnltentang.Visible = True
    End Sub

    Private Sub btLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogout.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btStokmasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStokmasuk.Click
        Stok_Masuk.Show()
    End Sub

    Private Sub btStokkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStokkeluar.Click
        Stok_Keluar.Show()
    End Sub

    Private Sub btLapstokbarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLapstokbarang.Click
        AxCrystalReport1.ReportFileName = "Laporan Stok Barang.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub btLapstokmasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLapstokmasuk.Click
        AxCrystalReport2.ReportFileName = "laporan_stok_masuk.rpt"
        AxCrystalReport2.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport2.RetrieveDataFiles()
        AxCrystalReport2.Action = 1
    End Sub

    Private Sub btLapstokkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLapstokkeluar.Click
        AxCrystalReport5.ReportFileName = "laporan_stok_keluar.rpt"
        AxCrystalReport5.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport5.RetrieveDataFiles()
        AxCrystalReport5.Action = 1
    End Sub

    Private Sub btLapsuplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLapsuplier.Click
        AxCrystalReport3.ReportFileName = "laporan_supplier.rpt"
        AxCrystalReport3.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport3.RetrieveDataFiles()
        AxCrystalReport3.Action = 1
    End Sub

    Private Sub btLapBarangReject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLapBarangReject.Click
        AxCrystalReport6.ReportFileName = "laporan_reject.rpt"
        AxCrystalReport6.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport6.RetrieveDataFiles()
        AxCrystalReport6.Action = 1
    End Sub

    Private Sub btLapBarangHilang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLapBarangHilang.Click
        AxCrystalReport7.ReportFileName = "laporan_hilang.rpt"
        AxCrystalReport7.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport7.RetrieveDataFiles()
        AxCrystalReport7.Action = 1
    End Sub

    Private Sub btreject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btreject.Click
        Data_Reject.Show()
    End Sub

    Private Sub bthilang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthilang.Click
        Data_Hilang.Show()
    End Sub

    Private Sub btregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btregister.Click
        Registervb.Show()
    End Sub

    Private Sub btLapPemesanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLapPemesanan.Click
        AxCrystalReport8.ReportFileName = "laporan_pemesanan.rpt"
        AxCrystalReport8.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport8.RetrieveDataFiles()
        AxCrystalReport8.Action = 1
    End Sub

    Private Sub btLapHarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLapHarga.Click
        AxCrystalReport4.ReportFileName = "laporan_harga.rpt"
        AxCrystalReport4.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport4.RetrieveDataFiles()
        AxCrystalReport4.Action = 1
    End Sub

    Private Sub btDatabarang_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDatabarang.Click
        Data_Barang.Show()
    End Sub

    Private Sub btDatasuplier_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDatasuplier.Click
        Data_Supplier.Show()
    End Sub

    Private Sub btDataPemesanan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDataPemesanan.Click
        Data_Pemesan.Show()
    End Sub

    Private Sub btDataHarga_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDataHarga.Click
        Data_Harga.Show()
    End Sub
End Class