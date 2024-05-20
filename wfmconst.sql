-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 15, 2021 at 03:05 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wfmconst`
--

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `c_id` int(15) NOT NULL,
  `c_fname` varchar(255) NOT NULL,
  `c_lname` varchar(255) NOT NULL,
  `c_email` varchar(255) NOT NULL,
  `c_phone` int(12) NOT NULL,
  `c_address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`c_id`, `c_fname`, `c_lname`, `c_email`, `c_phone`, `c_address`) VALUES
(1, 'jeewantha', 'Nipun', 'a', 5, 'a'),
(2, 'supun', 'sadaru', 'jj@', 7724, 'kkkk'),
(6, 'fd', 'd', 'f', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `E_id` int(15) NOT NULL,
  `E_fname` varchar(255) NOT NULL,
  `E_lname` varchar(255) NOT NULL,
  `E_job` varchar(255) NOT NULL,
  `E_gen` varchar(255) NOT NULL,
  `E_DOB` date NOT NULL,
  `E_email` varchar(255) NOT NULL,
  `E_phone` int(12) NOT NULL,
  `E_address` varchar(255) NOT NULL,
  `E_about` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`E_id`, `E_fname`, `E_lname`, `E_job`, `E_gen`, `E_DOB`, `E_email`, `E_phone`, `E_address`, `E_about`) VALUES
(1, 'jeewantha', 'ass', 'ass', 'Male', '0000-00-00', 's', 0, 'as', 'sa'),
(2, 'nipuna', 'ss', 'Accountant', 'Male', '0000-00-00', 'fd@', 0, 'rgeh', 'ddd'),
(3, 'Dulan', 'Bagya', 'Accountant', 'Female', '0000-00-00', 'aaa@', 777, 'sfsfd', 'a'),
(4, 'sudira', 'lakshan', 'Accountant', 'Male', '0000-00-00', 'jj@', 44, 'hjj', 'f'),
(5, 'llll', 'aaaa', 'Accountant', 'Male', '1999-01-15', 'sd', 58, 'gfrt', 'f');

-- --------------------------------------------------------

--
-- Table structure for table `jobs`
--

CREATE TABLE `jobs` (
  `job_id` int(10) NOT NULL,
  `job_Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `jobs`
--

INSERT INTO `jobs` (`job_id`, `job_Name`) VALUES
(1, 'Accountant'),
(2, 'Worker'),
(3, 'Financial\r\n');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `Pay_id` int(15) NOT NULL,
  `Pay_date` date NOT NULL,
  `pay_amount` int(50) NOT NULL,
  `Client` varchar(255) NOT NULL,
  `project` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`Pay_id`, `Pay_date`, `pay_amount`, `Client`, `project`) VALUES
(3, '0000-00-00', 154000, 'dfs', 'vc'),
(4, '2021-01-15', 444, '1233', 'aaaa');

-- --------------------------------------------------------

--
-- Table structure for table `projects`
--

CREATE TABLE `projects` (
  `p_id` int(10) NOT NULL,
  `p_title` varchar(255) NOT NULL,
  `p_startdate` date NOT NULL,
  `p_duration` varchar(50) NOT NULL,
  `p_cost` int(25) NOT NULL,
  `p_state` varchar(50) NOT NULL,
  `client` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `projects`
--

INSERT INTO `projects` (`p_id`, `p_title`, `p_startdate`, `p_duration`, `p_cost`, `p_state`, `client`) VALUES
(1, 'a', '0000-00-00', '11', 1000, 'a', 'a'),
(2, 'b', '0000-00-00', '44', 444, 'Active', 'a'),
(3, 'c', '0000-00-00', '5', 54455, 'Active', 'jeewantha Nipun'),
(4, 'aaaa', '2021-01-15', '4', 4444, 'Active', 'supun sadaru'),
(5, 'fdfss', '2021-01-15', 'h', 0, 'sf', 'sf');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `u_id` int(12) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `User_type` varchar(50) NOT NULL,
  `role` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`u_id`, `username`, `password`, `User_type`, `role`) VALUES
(1, 'admin', '1234', 'Administration', 0),
(2, 'Manager', '1234', 'Management', 1),
(4, 'jeewantha', '1234', 'Financial Manager', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`c_id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`E_id`);

--
-- Indexes for table `jobs`
--
ALTER TABLE `jobs`
  ADD PRIMARY KEY (`job_id`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`Pay_id`);

--
-- Indexes for table `projects`
--
ALTER TABLE `projects`
  ADD PRIMARY KEY (`p_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`u_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
  MODIFY `c_id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `E_id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `jobs`
--
ALTER TABLE `jobs`
  MODIFY `job_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `Pay_id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `projects`
--
ALTER TABLE `projects`
  MODIFY `p_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `u_id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
