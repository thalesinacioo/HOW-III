-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 02, 2021 at 02:58 AM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sandaliashavaianas`
--

-- --------------------------------------------------------

--
-- Table structure for table `estoquesandalias`
--

CREATE TABLE `estoquesandalias` (
  `idSandalia` int(11) NOT NULL,
  `nomeSandalia` varchar(100) NOT NULL,
  `modeloSandalia` varchar(100) NOT NULL,
  `corSandalia` varchar(20) NOT NULL,
  `numSandalia` varchar(20) NOT NULL,
  `descSandalia` text NOT NULL,
  `qtdSandalia` int(11) NOT NULL,
  `valorSandalia` varchar(20) NOT NULL,
  `ativoSandalia` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `estoquesandalias`
--

INSERT INTO `estoquesandalias` (`idSandalia`, `nomeSandalia`, `modeloSandalia`, `corSandalia`, `numSandalia`, `descSandalia`, `qtdSandalia`, `valorSandalia`, `ativoSandalia`) VALUES
(18, 'Sandalia Slim Glitter', 'Slim Glitter', 'Preta', '33-41', 'Possui glitter colado nas tiras', 25, 'R$ 59,90', 1),
(19, 'Sandalia Summer Hit', 'Summer Hit', 'Azul', '33-41', 'Sandalia com estampa diferenciada.', 50, 'R$ 45,90', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `estoquesandalias`
--
ALTER TABLE `estoquesandalias`
  ADD PRIMARY KEY (`idSandalia`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `estoquesandalias`
--
ALTER TABLE `estoquesandalias`
  MODIFY `idSandalia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
