-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2026. Nov 10. 05:28
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `diakok`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `diakok`
--

CREATE TABLE `diakok` (
  `id` int(11) NOT NULL,
  `nev` varchar(100) NOT NULL,
  `eletkor` int(11) NOT NULL,
  `osztaly` varchar(10) NOT NULL,
  `atlag` decimal(3,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `diakok`
--

INSERT INTO `diakok` (`id`, `nev`, `eletkor`, `osztaly`, `atlag`) VALUES
(1, 'Anna', 17, '11A', 4.50),
(2, 'Bence', 18, '12B', 3.20),
(3, 'Csilla', 17, '11A', 4.80),
(4, 'Dávid', 19, '13A', 2.90),
(5, 'Eszter', 18, '12B', 4.10),
(6, 'Ferenc', 20, '13A', 3.70),
(7, 'Gabriella', 17, '11A', 3.90),
(8, 'Hunor', 18, '12B', 4.60);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `diakok`
--
ALTER TABLE `diakok`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `diakok`
--
ALTER TABLE `diakok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
