-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 11, 2022 at 09:56 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `show off`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblproduct`
--

CREATE TABLE `tblproduct` (
  `productId` int(20) NOT NULL,
  `productCode` varchar(20) NOT NULL,
  `productName` varchar(50) NOT NULL,
  `productCategory` varchar(50) NOT NULL,
  `price` double NOT NULL,
  `tax` int(11) NOT NULL,
  `qty` int(5) NOT NULL,
  `status` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblproduct`
--

INSERT INTO `tblproduct` (`productId`, `productCode`, `productName`, `productCategory`, `price`, `tax`, `qty`, `status`) VALUES
(6, '103', 'Red T Shirt', 'Casula Shirt', 1200, 2, 20, ''),
(7, '104', 'T-Shirt', 'Formal Shirt', 400, 5, 0, ''),
(8, '111', 'Shirt', 'men', 300, 5, 0, ''),
(9, '11', 'pant', 'men', 100, 5, 0, ''),
(11, '201', 'Man T-Shirt Long Sleev', 'Men', 30000, 5, 0, ''),
(12, '301', 'Printed Shirt', 'Casula Shirt', 1200, 5, 0, ''),
(15, '302', 'Red Shirt', 'Casula Shirt', 1300, 5, 10, ''),
(16, '303', 'Yellow shirt', 'Casula Shirt', 1400, 5, 10, ''),
(17, '304', 'hj', 'Casula Shirt', 12, 2, 2, ''),
(18, '306', 'Check Shirt', 'Formal Shirt', 1250, 5, 20, ''),
(19, '401', 'Check', 'Formal Shirt', 1100, 0, 20, ''),
(20, '1111', 'Shirt', 'Formal Shirt', 1100, 5, 60, '');

-- --------------------------------------------------------

--
-- Table structure for table `tblsold`
--

CREATE TABLE `tblsold` (
  `productId` int(20) NOT NULL,
  `qty` int(5) NOT NULL,
  `createdAt` date NOT NULL,
  `updatedAt` date NOT NULL,
  `status` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `ID` int(5) NOT NULL,
  `userName` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `userRole` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`ID`, `userName`, `password`, `userRole`) VALUES
(2, 'fahim ahammad', '112345', 'SALES_MAN'),
(3, 'tarif', '123', 'SALES_MAN'),
(4, 'a', 'a', 'ADMIN'),
(6, 'test', '123', 'CASHIER'),
(7, 'Motalib', '12345', 'ADMIN');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblproduct`
--
ALTER TABLE `tblproduct`
  ADD PRIMARY KEY (`productId`),
  ADD UNIQUE KEY `productCode` (`productCode`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `userName` (`userName`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblproduct`
--
ALTER TABLE `tblproduct`
  MODIFY `productId` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `ID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
