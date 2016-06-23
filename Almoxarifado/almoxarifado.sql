-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2016 at 05:11 PM
-- Server version: 10.1.10-MariaDB
-- PHP Version: 5.6.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `almoxarifado`
--

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Sector` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`ID`, `Name`, `Sector`) VALUES
(2, 'Gabriel', 'Administração'),
(3, 'João', 'Administração'),
(4, 'Carlos', 'RH'),
(5, 'Roxerio', 'RH'),
(8, 'Jamelão', 'Fuderagem'),
(9, '', ''),
(10, 'Marcelo', 'Informática');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`ID`, `Name`, `Quantity`) VALUES
(1, 'Papel', 580),
(2, 'Grampeador', 10),
(3, 'Marcador Azul', 10),
(4, 'Caneta', 55),
(5, 'Apagador', 15),
(6, 'Lápis', 100),
(7, 'Pacote de Grampos', 25),
(8, 'Tesoura', 50),
(9, 'Fita Adesiva', 125),
(10, 'Bloco de Notas', 50),
(11, 'Caixa de Clips 100un', 500),
(12, 'Pasta Sanfonada 31 Divisões', 10),
(13, 'Papel Fotografico', 100),
(14, 'Evolope Auto Colante 80gr', 325),
(15, 'Pasta em L Ofício', 100),
(16, 'Cartolina Branca 150g 215x315mm', 100);

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `ID` int(11) NOT NULL,
  `Date` datetime NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Type` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `EmployeeID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`ID`, `Date`, `ProductID`, `Type`, `Quantity`, `EmployeeID`) VALUES
(1, '2016-04-12 11:30:13', 1, 0, 100, 9),
(2, '2016-04-12 11:31:10', 1, 1, 500, 9),
(3, '2016-04-12 11:31:27', 1, 2, 1, 2),
(4, '2016-04-12 11:31:47', 1, 2, 5, 2),
(5, '2016-04-12 11:42:07', 2, 0, 10, 9),
(6, '2016-04-12 11:42:16', 3, 0, 15, 9),
(7, '2016-04-12 11:42:38', 4, 0, 55, 9),
(8, '2016-04-13 17:35:40', 3, 2, 5, 2),
(9, '2016-04-13 18:28:18', 5, 0, 15, 9),
(10, '2016-04-13 18:28:26', 6, 0, 100, 9),
(11, '2016-04-13 18:28:59', 7, 0, 25, 9),
(12, '2016-04-13 18:32:07', 8, 0, 50, 9),
(13, '2016-04-13 18:32:17', 9, 0, 125, 9),
(14, '2016-04-13 18:33:05', 10, 0, 50, 9),
(15, '2016-04-13 18:33:27', 11, 0, 500, 9),
(16, '2016-04-13 18:34:11', 12, 0, 10, 9),
(17, '2016-04-13 18:34:18', 13, 0, 100, 9),
(18, '2016-04-13 18:34:46', 14, 0, 325, 9),
(19, '2016-04-13 18:35:12', 15, 0, 100, 9),
(20, '2016-04-13 18:35:44', 16, 0, 100, 9),
(21, '2016-04-13 18:36:09', 1, 2, 15, 3),
(22, '2016-04-13 18:36:18', 1, 2, 25, 4),
(23, '2016-04-13 19:06:22', 1, 2, 4, 5),
(24, '2016-04-13 19:06:40', 1, 2, 10, 2),
(25, '2016-05-23 19:00:30', 1, 1, 50, 9);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ProductID` (`ProductID`),
  ADD KEY `EmployeeID` (`EmployeeID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `transactions_ibfk_1` FOREIGN KEY (`ProductID`) REFERENCES `products` (`ID`),
  ADD CONSTRAINT `transactions_ibfk_2` FOREIGN KEY (`EmployeeID`) REFERENCES `employees` (`ID`);transactions

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
