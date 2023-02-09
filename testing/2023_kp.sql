-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 01 Feb 2023 pada 03.16
-- Versi server: 10.4.21-MariaDB
-- Versi PHP: 7.4.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `2023_kp`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `table_barang`
--

CREATE TABLE `table_barang` (
  `Kode_Barang` varchar(8) NOT NULL,
  `Nama_Barang` varchar(20) NOT NULL,
  `Satuan` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `table_barang`
--

INSERT INTO `table_barang` (`Kode_Barang`, `Nama_Barang`, `Satuan`) VALUES
('B01', 'Meja Belajar', 'Pcs'),
('B02', 'Kursi Gaming', 'Pcs'),
('B03', 'Mouse', 'Pcs'),
('B04', 'Baju RRQ', 'Pcs');

-- --------------------------------------------------------

--
-- Struktur dari tabel `table_harga`
--

CREATE TABLE `table_harga` (
  `Kode_Harga` varchar(8) NOT NULL,
  `Nama_Harga` varchar(20) NOT NULL,
  `Harga` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `table_harga`
--

INSERT INTO `table_harga` (`Kode_Harga`, `Nama_Harga`, `Harga`) VALUES
('H01', 'Meja Belajar', '50000'),
('H02', 'Kursi Gaming', '10000'),
('H03', 'Mouse', '2000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `table_hilang`
--

CREATE TABLE `table_hilang` (
  `Kode_Hilang` varchar(8) NOT NULL,
  `Tanggal` varchar(20) NOT NULL,
  `Kode_Barang` varchar(8) NOT NULL,
  `Nama_Barang` varchar(20) NOT NULL,
  `Qty` int(6) NOT NULL,
  `Satuan` char(8) NOT NULL,
  `Qty_Hilang` int(6) NOT NULL,
  `Total` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `table_hilang`
--

INSERT INTO `table_hilang` (`Kode_Hilang`, `Tanggal`, `Kode_Barang`, `Nama_Barang`, `Qty`, `Satuan`, `Qty_Hilang`, `Total`) VALUES
('H01', '29 January 2023', 'B01', 'Meja Belajar', 95, 'Pcs', 1, 94);

-- --------------------------------------------------------

--
-- Struktur dari tabel `table_pemesanan`
--

CREATE TABLE `table_pemesanan` (
  `No_Transaksi` varchar(5) NOT NULL,
  `Nama_Perusahaan` varchar(25) NOT NULL,
  `Telepon` varchar(15) NOT NULL,
  `Alamat` varchar(25) NOT NULL,
  `Nama_Barang` char(15) NOT NULL,
  `Harga` int(15) NOT NULL,
  `Jumlah` int(15) NOT NULL,
  `Total` int(15) NOT NULL,
  `Bayar` int(15) NOT NULL,
  `Kembali` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `table_pemesanan`
--

INSERT INTO `table_pemesanan` (`No_Transaksi`, `Nama_Perusahaan`, `Telepon`, `Alamat`, `Nama_Barang`, `Harga`, `Jumlah`, `Total`, `Bayar`, `Kembali`) VALUES
('P01', 'PT. Jalan', '08129029090', 'Jl. Doang', 'Meja Belajar', 50000, 5, 250000, 1000000, 750000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `table_register`
--

CREATE TABLE `table_register` (
  `Id` int(5) NOT NULL,
  `Nama_Lengkap` char(25) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Username` char(15) NOT NULL,
  `Password` varchar(15) NOT NULL,
  `Status` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `table_register`
--

INSERT INTO `table_register` (`Id`, `Nama_Lengkap`, `Alamat`, `Username`, `Password`, `Status`) VALUES
(1, 'Iqbal', 'Jl. Bintara', 'iqbal', '1234', 'AdmGud'),
(2, 'Adun', 'Jl.Sejahtera', 'adun', '1234', 'SupAdm'),
(3, 'Indra', 'Jl.Duren Sawit', 'indra', '1234', 'AdmPem');

-- --------------------------------------------------------

--
-- Struktur dari tabel `table_reject`
--

CREATE TABLE `table_reject` (
  `Kode_Reject` varchar(8) NOT NULL,
  `Tanggal` varchar(20) NOT NULL,
  `Kode_Barang` varchar(8) NOT NULL,
  `Nama_Barang` varchar(25) NOT NULL,
  `Qty` int(10) NOT NULL,
  `Satuan` char(7) NOT NULL,
  `Qty_Reject` int(10) NOT NULL,
  `Total` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `table_reject`
--

INSERT INTO `table_reject` (`Kode_Reject`, `Tanggal`, `Kode_Barang`, `Nama_Barang`, `Qty`, `Satuan`, `Qty_Reject`, `Total`) VALUES
('R01', '29 January 2023', 'B01', 'Meja Belajar', 94, 'Pcs', 4, 90);

-- --------------------------------------------------------

--
-- Struktur dari tabel `table_stokkeluar`
--

CREATE TABLE `table_stokkeluar` (
  `No_Transaksi` varchar(8) NOT NULL,
  `Tanggal` varchar(25) NOT NULL,
  `Bertanggung_Jawab` char(30) NOT NULL,
  `Kode_Barang` varchar(8) NOT NULL,
  `Nama_Barang` char(15) NOT NULL,
  `Qty` int(10) NOT NULL,
  `Satuan` char(10) NOT NULL,
  `Qty_Keluar` int(10) NOT NULL,
  `Total` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `table_stokkeluar`
--

INSERT INTO `table_stokkeluar` (`No_Transaksi`, `Tanggal`, `Bertanggung_Jawab`, `Kode_Barang`, `Nama_Barang`, `Qty`, `Satuan`, `Qty_Keluar`, `Total`) VALUES
('T01', '29 January 2023', 'Ayatullah', 'B01', 'Meja Belajar', 105, 'Pcs', 10, 95);

-- --------------------------------------------------------

--
-- Struktur dari tabel `table_stokmasuk`
--

CREATE TABLE `table_stokmasuk` (
  `Kode_Masuk` varchar(8) NOT NULL,
  `Tanggal` varchar(25) NOT NULL,
  `Bertanggung_Jawab` char(30) NOT NULL,
  `Kode_Barang` varchar(8) NOT NULL,
  `Nama_Barang` char(25) NOT NULL,
  `Satuan` char(10) NOT NULL,
  `Supplier` char(25) NOT NULL,
  `Qty` int(10) NOT NULL,
  `Qty_Total` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `table_stokmasuk`
--

INSERT INTO `table_stokmasuk` (`Kode_Masuk`, `Tanggal`, `Bertanggung_Jawab`, `Kode_Barang`, `Nama_Barang`, `Satuan`, `Supplier`, `Qty`, `Qty_Total`) VALUES
('M01', '29 January 2023', 'Ayatullah', 'B01', 'Meja Belajar', 'Pcs', 'Cv. Sejahtera', 90, 90);

-- --------------------------------------------------------

--
-- Struktur dari tabel `table_supplier`
--

CREATE TABLE `table_supplier` (
  `Kode_Supplier` varchar(8) NOT NULL,
  `Nama_Supplier` char(25) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Telepon` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `table_supplier`
--

INSERT INTO `table_supplier` (`Kode_Supplier`, `Nama_Supplier`, `Alamat`, `Telepon`) VALUES
('S01', 'Cv. Sejahtera', 'Jl.Bahagia', '01234456676'),
('S02', 'Cv.Sedih', 'Jl.SedihBanget', '0812394882');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `table_barang`
--
ALTER TABLE `table_barang`
  ADD PRIMARY KEY (`Kode_Barang`);

--
-- Indeks untuk tabel `table_harga`
--
ALTER TABLE `table_harga`
  ADD PRIMARY KEY (`Kode_Harga`);

--
-- Indeks untuk tabel `table_hilang`
--
ALTER TABLE `table_hilang`
  ADD PRIMARY KEY (`Kode_Hilang`);

--
-- Indeks untuk tabel `table_pemesanan`
--
ALTER TABLE `table_pemesanan`
  ADD PRIMARY KEY (`No_Transaksi`);

--
-- Indeks untuk tabel `table_register`
--
ALTER TABLE `table_register`
  ADD PRIMARY KEY (`Id`);

--
-- Indeks untuk tabel `table_reject`
--
ALTER TABLE `table_reject`
  ADD PRIMARY KEY (`Kode_Reject`);

--
-- Indeks untuk tabel `table_stokkeluar`
--
ALTER TABLE `table_stokkeluar`
  ADD PRIMARY KEY (`No_Transaksi`);

--
-- Indeks untuk tabel `table_stokmasuk`
--
ALTER TABLE `table_stokmasuk`
  ADD PRIMARY KEY (`Kode_Masuk`);

--
-- Indeks untuk tabel `table_supplier`
--
ALTER TABLE `table_supplier`
  ADD PRIMARY KEY (`Kode_Supplier`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
