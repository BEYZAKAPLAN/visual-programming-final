-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 03 Oca 2023, 14:25:11
-- Sunucu sürümü: 10.4.27-MariaDB
-- PHP Sürümü: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `beyzabp`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `admin_mesaj`
--

CREATE TABLE `admin_mesaj` (
  `id` int(11) NOT NULL,
  `konu` varchar(50) NOT NULL,
  `mesaj` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `admin_mesaj`
--

INSERT INTO `admin_mesaj` (`id`, `konu`, `mesaj`) VALUES
(1, 'dfwgf', 'gfsfgshg'),
(4, '', ''),
(5, 'fin', 'murat hocanın zor finalleri'),
(6, 'fin', 'murat hocanın zor finalleri'),
(7, 'fin', 'murat hocanın zor finalleri'),
(8, 'fin', 'murat hocanın zor finalleri');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `gonderi`
--

CREATE TABLE `gonderi` (
  `id` int(11) NOT NULL,
  `nerede` varchar(50) NOT NULL,
  `kim` varchar(11) NOT NULL,
  `gonderi_no` int(11) NOT NULL,
  `müşteri ismi` varchar(255) NOT NULL,
  `kdurum` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `gonderi`
--

INSERT INTO `gonderi` (`id`, `nerede`, `kim`, `gonderi_no`, `müşteri ismi`, `kdurum`) VALUES
(1, 'ankara', 'Sabir', 1001, 'beyza', 'Kargo Taşınıyor');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kargo_arac`
--

CREATE TABLE `kargo_arac` (
  `id` int(11) NOT NULL,
  `arac_sayi` varchar(50) NOT NULL,
  `sofor_isim` varchar(50) NOT NULL,
  `guzergah` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `kargo_arac`
--

INSERT INTO `kargo_arac` (`id`, `arac_sayi`, `sofor_isim`, `guzergah`) VALUES
(1, '3', 'hayrettin', 'konya - istanbul');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kargo_gon`
--

CREATE TABLE `kargo_gon` (
  `id` int(11) NOT NULL,
  `teslim_tip` varchar(50) NOT NULL,
  `odeme_tip` varchar(50) NOT NULL,
  `adres` varchar(50) NOT NULL,
  `musteri_isim` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `kargo_gon`
--

INSERT INTO `kargo_gon` (`id`, `teslim_tip`, `odeme_tip`, `adres`, `musteri_isim`) VALUES
(2, 'elden', 'nakit', 'kutahya', 'asude'),
(3, 'elden', 'nakit', 'batman', 'buse'),
(4, 'elden', 'nakit', 'istanbul', 'beyza');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `id` int(11) NOT NULL,
  `kadi` varchar(255) NOT NULL,
  `sifre` varchar(255) NOT NULL,
  `yetki` int(255) NOT NULL DEFAULT 0,
  `Adsoyad` varchar(255) NOT NULL,
  `tc` varchar(255) NOT NULL,
  `dgm` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`id`, `kadi`, `sifre`, `yetki`, `Adsoyad`, `tc`, `dgm`) VALUES
(1, 'aaa', '123', 0, 'beyzaKaplan', '12312412', '24kasim'),
(2, 'beyza', '123', 0, '', '', ''),
(7, '1', '1', 1, '', '', '');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `admin_mesaj`
--
ALTER TABLE `admin_mesaj`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `gonderi`
--
ALTER TABLE `gonderi`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `kargo_arac`
--
ALTER TABLE `kargo_arac`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `kargo_gon`
--
ALTER TABLE `kargo_gon`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `admin_mesaj`
--
ALTER TABLE `admin_mesaj`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Tablo için AUTO_INCREMENT değeri `gonderi`
--
ALTER TABLE `gonderi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `kargo_arac`
--
ALTER TABLE `kargo_arac`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `kargo_gon`
--
ALTER TABLE `kargo_gon`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tablo için AUTO_INCREMENT değeri `kullanicilar`
--
ALTER TABLE `kullanicilar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
