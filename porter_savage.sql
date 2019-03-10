-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Mar 10, 2019 at 09:39 PM
-- Server version: 5.7.24-log
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `porter_savage`
--
CREATE DATABASE IF NOT EXISTS `porter_savage` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `porter_savage`;

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `stylist_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`id`, `name`, `stylist_id`) VALUES
(22, 'janeyyyy', 63),
(23, 'mandy', 64),
(24, 'bob', 0),
(25, 'bob', 0),
(26, 'bob', 0),
(27, 'bob', 0),
(28, 'bob', 0),
(29, 'bob', 0),
(30, 'bob', 0),
(31, 'bob', 0),
(32, 'bob', 0),
(33, 'bob', 0),
(34, 'bob', 0),
(35, 'bob', 0),
(36, 'bob', 0),
(37, 'bob', 0),
(38, 'bob', 0),
(39, 'bob', 0),
(40, 'bob', 0),
(41, 'bob', 0),
(42, 'bob', 0),
(43, 'bob', 0),
(44, 'bob', 0),
(45, 'bob', 0),
(46, 'bob', 0),
(47, 'bob', 0),
(48, 'bob', 0),
(49, 'bob', 0),
(50, 'bob', 0),
(51, 'bob', 0);

-- --------------------------------------------------------

--
-- Table structure for table `specialty`
--

CREATE TABLE `specialty` (
  `id` int(11) NOT NULL,
  `specialty` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `specialty`
--

INSERT INTO `specialty` (`id`, `specialty`) VALUES
(1, 'stuff'),
(2, 'stuff again'),
(3, 'some other stuff'),
(4, 'stuff'),
(5, 'Jane'),
(6, 'Jon'),
(7, 'john'),
(8, 'john'),
(9, 'john'),
(10, 'john');

-- --------------------------------------------------------

--
-- Table structure for table `stylists`
--

CREATE TABLE `stylists` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `stylists`
--

INSERT INTO `stylists` (`id`, `name`) VALUES
(63, 'jane'),
(64, 'jon'),
(65, 'jen'),
(66, 'jen'),
(67, 'jen'),
(68, 'jen'),
(69, 'style their hair'),
(70, 'cut the hair'),
(71, 'jen'),
(72, 'jen'),
(73, 'jen'),
(74, 'jen'),
(75, 'style their hair'),
(76, 'cut the hair'),
(77, 'jen'),
(78, 'jen'),
(79, 'jen'),
(80, 'jen'),
(81, 'style their hair'),
(82, 'cut the hair'),
(83, 'jen'),
(84, 'jen'),
(85, 'jen'),
(86, 'jen'),
(87, 'style their hair'),
(88, 'cut the hair'),
(89, 'jen'),
(90, 'jen'),
(91, 'jen'),
(92, 'jen'),
(93, 'style their hair'),
(94, 'cut the hair'),
(95, 'jen'),
(96, 'jen'),
(97, 'jen'),
(98, 'jen'),
(99, 'style their hair'),
(100, 'cut the hair'),
(101, 'jen'),
(102, 'jen'),
(103, 'jen'),
(104, 'jen'),
(105, 'style their hair'),
(106, 'cut the hair'),
(107, 'jen'),
(108, 'jen'),
(109, 'jen'),
(110, 'jen'),
(111, 'style their hair'),
(112, 'cut the hair'),
(113, 'jen'),
(114, 'jen'),
(115, 'jen'),
(116, 'jen'),
(117, 'style their hair'),
(118, 'cut the hair'),
(119, 'jen'),
(120, 'jen'),
(121, 'jen'),
(122, 'jen'),
(123, 'style their hair'),
(124, 'cut the hair'),
(125, 'jen'),
(126, 'jen'),
(127, 'jen'),
(128, 'jen'),
(129, 'style their hair'),
(130, 'cut the hair'),
(131, 'jen'),
(132, 'jen'),
(133, 'jen'),
(134, 'jen'),
(135, 'style their hair'),
(136, 'cut the hair'),
(137, 'jen'),
(138, 'jen'),
(139, 'jen'),
(140, 'jen'),
(141, 'style their hair'),
(142, 'cut the hair'),
(143, 'jen'),
(144, 'jen'),
(145, 'jen'),
(146, 'jen'),
(147, 'style their hair'),
(148, 'cut the hair');

-- --------------------------------------------------------

--
-- Table structure for table `stylists_specialties`
--

CREATE TABLE `stylists_specialties` (
  `id` int(11) NOT NULL,
  `stylist_id` int(11) NOT NULL,
  `specialty_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `stylists_specialties`
--

INSERT INTO `stylists_specialties` (`id`, `stylist_id`, `specialty_id`) VALUES
(1, 64, 1),
(2, 63, 1),
(3, 64, 1),
(4, 64, 1),
(5, 63, 3),
(6, 63, 4),
(7, 63, 3),
(8, 64, 3),
(9, 0, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `specialty`
--
ALTER TABLE `specialty`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `stylists`
--
ALTER TABLE `stylists`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `stylists_specialties`
--
ALTER TABLE `stylists_specialties`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `specialty`
--
ALTER TABLE `specialty`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `stylists`
--
ALTER TABLE `stylists`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=149;

--
-- AUTO_INCREMENT for table `stylists_specialties`
--
ALTER TABLE `stylists_specialties`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
