-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 28, 2018 at 02:52 PM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `thesis`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `AccNo` int(50) NOT NULL,
  `F_Name` varchar(50) NOT NULL,
  `Section` varchar(50) NOT NULL,
  `Adviser` varchar(50) NOT NULL,
  `Lrn` int(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Dob` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`AccNo`, `F_Name`, `Section`, `Adviser`, `Lrn`, `Address`, `Dob`) VALUES
(1, 'Lance Louix M. De Guzman', '3B', 'Mr. Raymond Cruz', 201510302, 'ph 4 blk 5 lt 46 ruby st. ', 'October 2,1998 '),
(2, 'Ma. Hannah C. Pena', '3B', 'Ms. Bordon', 201510303, 'maryhomes', ''),
(7, 'Lance Louix M. De Guzman', 'admin', 'admin', 102030405, 'admin', 'October 1,1998'),
(4, 'Juan Dela Cruz', '1A', 'Sir Batula', 11110212, 'palico IV', ''),
(5, 'Joey A. Vergom', 'BSIT-4B', 'Romnick', 201510201, 'bacoor', ''),
(8, 'Ma. Hannah C. Pena', '3B', 'Sir Reboya', 201510304, 'admin', ''),
(9, 'Princess Stephanie M. De Guzman', '4A', 'Ms. Lanie', 201510306, 'cityhomes', 'March 10,2000'),
(20181001, 'Christian Gabriel T. Yano', 'BSIT-3B', 'Sir. Malabanan', 201510302, 'mambog', 'October 18, 1998'),
(20181002, 'Ma. Hannah C. Pena', 'BSIT-3B', 'sir.Malabanan', 201510301, 'dyan lang', 'September 28, 1998');

-- --------------------------------------------------------

--
-- Table structure for table `riasec`
--

CREATE TABLE `riasec` (
  `Type` text NOT NULL,
  `Meaning` varchar(500) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `riasec`
--

INSERT INTO `riasec` (`Type`, `Meaning`) VALUES
('Realistic', ''),
('Investigative', ''),
('Artistic', ''),
('Social', ''),
('Enterprising', ''),
('Conventional', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`AccNo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `AccNo` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20181003;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
