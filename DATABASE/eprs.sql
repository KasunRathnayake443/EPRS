-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 25, 2025 at 02:33 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eprs`
--

-- --------------------------------------------------------

--
-- Table structure for table `logs`
--

CREATE TABLE `logs` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `type` varchar(50) NOT NULL,
  `description` text DEFAULT NULL,
  `time` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `logs`
--

INSERT INTO `logs` (`id`, `user_id`, `type`, `description`, `time`) VALUES
(1, 2, 'Add User Account', 'User doctor3 added successfully.', '2024-12-16 16:13:26');

-- --------------------------------------------------------

--
-- Table structure for table `medicine`
--

CREATE TABLE `medicine` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `amount_grams` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `medicine`
--

INSERT INTO `medicine` (`id`, `name`, `amount_grams`) VALUES
(1, 'Paracetamol', 2141.50),
(2, 'Amoxicillin', 500.00),
(4, 'Cough Syrup', 100.00),
(5, 'Vitamin C', 491.00),
(6, 'Aspirin', 77.50),
(9, 'Amoxicillin', 245.50),
(11, 'Ciprofloxacin', 120.00),
(13, 'Lisinopril', 160.00),
(14, 'Atorvastatin', 220.00),
(15, 'Omeprazole', 140.00),
(16, 'Simvastatin', 200.00),
(17, 'Clopidogrel', 13.00),
(18, 'Montelukast', 175.00),
(19, 'Amlodipine', 190.00),
(20, 'Losartan', 210.00),
(22, 'Furosemide', 120.00),
(23, 'Hydrochlorothiazide', 170.00),
(24, 'Warfarin', 110.00),
(25, 'Prednisone', 130.00),
(26, 'Doxycycline', 180.00),
(27, 'Pantoprazole', 181.00),
(28, 'Ranitidine', 220.00),
(29, 'Metoprolol', 140.00),
(30, 'Gabapentin', 145.50),
(31, 'Sertraline', 180.00),
(32, 'Zolpidem', 160.00),
(33, 'Albuterol', 100.00),
(34, 'Diazepam', 121.00),
(35, 'Hydrocodone', 120.00),
(36, 'Tramadol', 140.00),
(37, 'Cyclobenzaprine', 200.00),
(38, 'Tamsulosin', 170.00),
(39, 'Allopurinol', 180.00),
(40, 'Sildenafil', 160.00),
(41, 'Fluoxetine', 140.00),
(42, 'Bupropion', 220.00),
(43, 'Meloxicam', 150.00),
(44, 'Loratadine', 100.00),
(45, 'Cetirizine', 140.00),
(46, 'Famotidine', 190.00),
(47, 'Duloxetine', 180.00),
(48, 'Venlafaxine', 210.00),
(49, 'Quetiapine', 130.00),
(50, 'Alprazolam', 110.00),
(51, 'Risperidone', 200.00),
(52, 'Aripiprazole', 150.00),
(53, 'Lamotrigine', 190.00),
(54, 'Topiramate', 160.00),
(55, 'Lithium', 100.00),
(56, 'Escitalopram', 120.00),
(57, 'Trazodone', 170.00),
(58, 'Mirtazapine', 140.00),
(59, 'Olanzapine', 150.00),
(60, 'Varenicline', 110.00),
(61, 'Carbamazepine', 115.50),
(62, 'Valproic acid', 140.00),
(63, 'Phenytoin', 145.50),
(64, 'Levetiracetam', 200.00),
(65, 'Pregabalin', 140.00),
(66, 'Loperamide', 130.00),
(67, 'Bisacodyl', 100.00),
(68, 'Docusate', 110.00),
(69, 'Polyethylene glycol', 200.00),
(70, 'Senna', 120.00),
(71, 'Ondansetron', 145.50),
(72, 'Meclizine', 180.00),
(73, 'Prochlorperazine', 190.00),
(74, 'Metoclopramide', 170.00),
(75, 'Betam', 125.50);

-- --------------------------------------------------------

--
-- Table structure for table `patients`
--

CREATE TABLE `patients` (
  `PatientID` varchar(20) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `DateOfBirth` date DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `PhoneNumber` varchar(15) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `DateRegistered` date DEFAULT curdate()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patients`
--

INSERT INTO `patients` (`PatientID`, `FirstName`, `LastName`, `DateOfBirth`, `Gender`, `Address`, `PhoneNumber`, `Email`, `DateRegistered`) VALUES
('SEU/IS/19/MIT/100', 'Test', 'Helllo', '2000-03-17', 'Female', '123 Temple Rd, School Junction', '555-1234 5478', 'johne@example.com', '2024-09-03'),
('SEU/IS/19/MIT/101', 'Name', 'Patient', '1990-08-22', 'Female', '123, Old Road, New Town', '555-5678 222', 'test.patient@example.com', '2024-09-03'),
('SEU/IS/19/MIT/102', 'Robert', 'Johnson', '1975-02-11', 'Male', '789 Pine Road, Springfield', '555-8765', 'robert.johnson@example.com', '2024-09-03'),
('SEU/IS/19/MIT/103', 'Emily', 'Davis', '2000-01-05', 'Female', '101 Elm Street', '555-3456', 'emily@example.com', '2024-09-03'),
('SEU/IS/19/MIT/104', 'Mi', 'Wilson', '1995-09-30', 'Female', '202 Birch Lane, Springfield', '555-9876', 'michael.wilson@example.com', '2024-09-03'),
('SEU/IS/19/MIT/105', 'Test', 'Test', '2024-09-10', 'Female', 'test address', '01214587', 'testemail@gmail.com', '2024-09-13'),
('SEU/IS/19/MIT/106', 'TEST', 'Name', '2024-09-14', 'Male', 'TEST', '46466666', 'email@email.COM', '2024-09-14');

-- --------------------------------------------------------

--
-- Table structure for table `prescriptions`
--

CREATE TABLE `prescriptions` (
  `PrescriptionID` int(11) NOT NULL,
  `PatientID` varchar(20) DEFAULT NULL,
  `DoctorID` int(11) DEFAULT NULL,
  `PrescriptionDate` date DEFAULT curdate(),
  `Medication` text DEFAULT NULL,
  `Description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `prescriptions`
--

INSERT INTO `prescriptions` (`PrescriptionID`, `PatientID`, `DoctorID`, `PrescriptionDate`, `Medication`, `Description`) VALUES
(11, 'SEU/IS/19/MIT/103', 1, '2024-09-03', 'Ibuprofen', 'Pain relief for mild headache'),
(12, 'SEU/IS/19/MIT/104', 1, '2024-09-03', 'Amoxicillin', 'Antibiotic for respiratory infection'),
(13, 'SEU/IS/19/MIT/101', 1, '2024-09-03', 'Paracetamol', 'Fever and mild pain treatment'),
(14, 'SEU/IS/19/MIT/100', 4, '2024-09-03', 'Metformin', 'Treatment for Type 2 Diabetes'),
(15, 'SEU/IS/19/MIT/102', 1, '2024-09-03', 'Losartan', 'Treatment for high blood pressure'),
(16, 'SEU/IS/19/MIT/103', 4, '2024-09-04', 'Loratadine', 'Allergy relief'),
(17, 'SEU/IS/19/MIT/104', 4, '2024-09-04', 'Ciprofloxacin', 'Urinary tract infection treatment'),
(18, 'SEU/IS/19/MIT/101', 1, '2024-09-04', 'Aspirin', 'Blood thinner for heart condition'),
(19, 'SEU/IS/19/MIT/100', 4, '2024-09-04', 'Lisinopril', 'Treatment for high blood pressure'),
(20, 'SEU/IS/19/MIT/102', 1, '2024-09-04', 'Atorvastatin', 'Cholesterol management'),
(21, 'SEU/IS/19/MIT/100', 1, '2024-09-07', 'para', 'sssddssasdsdss'),
(22, 'SEU/IS/19/MIT/100', 1, '2024-09-07', 'para, ss, ssss', 'g'),
(23, 'SEU/IS/19/MIT/102', 1, '2024-09-07', 'Paracetamol (Dose: 0.5), Amoxicillin (Dose: 0.5), Vitamin C (Dose: 0.5)', 'new new'),
(24, 'SEU/IS/19/MIT/100', 1, '2024-09-07', 'Amoxicillin (Dose: 0.5)', 'New Test Prescription'),
(25, 'SEU/IS/19/MIT/100', 1, '2024-09-07', 'Paracetamol (Dose: 5), Amoxicillin (Dose: 0.5)', 'test test'),
(26, 'SEU/IS/19/MIT/100', 1, '2024-09-07', 'Paracetamol (Dose: 100)', 'test'),
(27, 'SEU/IS/19/MIT/101', 1, '2024-09-07', 'Paracetamol (Dose: 0.5), Amoxicillin (Dose: 0.5)', 'Test Prescription Description'),
(28, 'SEU/IS/19/MIT/101', 1, '2024-09-07', 'Paracetamol (Dose: 0.5), Amoxicillin (Dose: 0.5), Vitamin C (Dose: 0.5)', 'test test'),
(29, 'SEU/IS/19/MIT/104', 4, '2024-09-08', 'Paracetamol (Dose: 0.5), Amoxicillin (Dose: 1)', 'test'),
(30, 'SEU/IS/19/MIT/101', 1, '2024-09-08', 'Paracetamol (Dose: 0.5), Amoxicillin (Dose: 0.5)', 'test'),
(31, 'SEU/IS/19/MIT/101', 1, '2024-09-08', 'Amoxicillin (Dose: 0.5), Vitamin C (Dose: 0.5)', 'test'),
(32, 'SEU/IS/19/MIT/100', 1, '2024-09-08', 'Paracetamol (Dose: 0.5), Amoxicillin (Dose: 0.5), Vitamin C (Dose: 1)', 'test'),
(33, 'SEU/IS/19/MIT/101', 1, '2024-09-09', 'Amoxicillin (Dose: 0.5), Vitamin C (Dose: 0.5)', 'test'),
(34, 'SEU/IS/19/MIT/100', 1, '2024-09-09', 'Vitamin C (Dose: 0.5)', 'test'),
(35, 'SEU/IS/19/MIT/101', 1, '2024-09-09', 'Amoxicillin (Dose: 0.5), Carbamazepine (Dose: 0.5), Metformin (Dose: 0.5)', 'test after public void'),
(36, 'SEU/IS/19/MIT/103', 1, '2024-09-09', 'Vitamin C (Dose: 0.5)', 'test to see auto refresh'),
(37, NULL, 1, '2024-09-10', 'Paracetamol (Dose: 0.5), Vitamin C (Dose: 0.5), Gabapentin (Dose: 0.5), Aspirin (Dose: 0.5)', 'test'),
(38, NULL, 1, '2024-09-10', 'Paracetamol (Dose: 0.5), Diazepam (Dose: 0.5)', 'test'),
(39, NULL, 1, '2024-09-10', 'Paracetamol (Dose: 0.5)', 'test now'),
(40, NULL, 1, '2024-09-10', 'Paracetamol (Dose: 0.5)', 'test1'),
(41, NULL, 1, '2024-09-10', 'Paracetamol (Dose: 0.5)', 'te'),
(42, 'SEU/IS/19/MIT/101', 1, '2024-09-10', 'Paracetamol (Dose: 0.5)', 'test'),
(43, 'SEU/IS/19/MIT/101', 1, '2024-09-10', 'Paracetamol (Dose: 0.5)', 'd'),
(44, 'SEU/IS/19/MIT/104', 1, '2024-09-10', 'Pantoprazole (Dose: 0.5)', 'tesst doc id'),
(45, 'SEU/IS/19/MIT/102', 1, '2024-09-10', 'Diazepam (Dose: 0.5)', 'test'),
(46, 'SEU/IS/19/MIT/103', 4, '2024-09-10', 'Betamethasone (Dose: 0.5)', 'test'),
(47, 'SEU/IS/19/MIT/103', 1, '2024-09-11', 'Vitamin C (Dose: 1)', 'new test'),
(48, 'SEU/IS/19/MIT/104', 1, '2024-09-15', 'Paracetamol (Dose: 0.5), Vitamin C (Dose: 1), Aspirin (Dose: 2)', 'test'),
(49, 'SEU/IS/19/MIT/101', 1, '2024-09-17', 'Paracetamol (Dose: 1), Vitamin C (Dose: 0.5)', 'test'),
(50, 'SEU/IS/19/MIT/101', 1, '2024-09-17', 'Paracetamol (Dose: 1)', 'test'),
(51, 'SEU/IS/19/MIT/104', 1, '2024-09-19', 'Vitamin C (Dose: 0.5), Paracetamol (Dose: 1)', 'New Prescription'),
(52, 'SEU/IS/19/MIT/103', 1, '2024-09-20', 'Ondansetron (Dose: 0.5), Paracetamol (Dose: 0.5)', 'test '),
(53, 'SEU/IS/19/MIT/102', 1, '2024-09-21', 'Paracetamol (Dose: 0.5), Vitamin C (Dose: 0.5)', 'test'),
(54, 'SEU/IS/19/MIT/106', 1, '2024-09-21', 'Pantoprazole (Dose: 0.5), Vitamin C (Dose: 0.5), Phenytoin (Dose: 0.5)', 'test'),
(55, 'SEU/IS/19/MIT/101', 1, '2024-09-22', 'Paracetamol (Dose: 0.5), Vitamin C (Dose: 0.5)', 'test'),
(56, 'SEU/IS/19/MIT/105', 1, '2024-11-09', 'Paracetamol (Dose: 1), Vitamin C (Dose: 0.5)', 'Test'),
(57, 'SEU/IS/19/MIT/104', 1, '2024-11-18', 'Paracetamol (Dose: 1), Vitamin C (Dose: 0.5)', 'jknkj');

-- --------------------------------------------------------

--
-- Table structure for table `settings`
--

CREATE TABLE `settings` (
  `id` int(11) NOT NULL,
  `low_stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `settings`
--

INSERT INTO `settings` (`id`, `low_stock`) VALUES
(1, 100);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `role` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `username`, `password`, `role`) VALUES
(1, 'Doctor Test', 'doctor1', '123', 'Doctor'),
(2, 'Admin Test', 'admin1', '123', 'Admin'),
(3, 'Test Name', 'staff1', '123', 'Staff'),
(4, 'Doc name', 'doctor2', '123', 'Doctor'),
(12, 'doctor3', 'doctor3', '123', 'Doctor');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `medicine`
--
ALTER TABLE `medicine`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `patients`
--
ALTER TABLE `patients`
  ADD PRIMARY KEY (`PatientID`);

--
-- Indexes for table `prescriptions`
--
ALTER TABLE `prescriptions`
  ADD PRIMARY KEY (`PrescriptionID`),
  ADD KEY `PatientID` (`PatientID`),
  ADD KEY `DoctorID` (`DoctorID`);

--
-- Indexes for table `settings`
--
ALTER TABLE `settings`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `logs`
--
ALTER TABLE `logs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `medicine`
--
ALTER TABLE `medicine`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=83;

--
-- AUTO_INCREMENT for table `prescriptions`
--
ALTER TABLE `prescriptions`
  MODIFY `PrescriptionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT for table `settings`
--
ALTER TABLE `settings`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `prescriptions`
--
ALTER TABLE `prescriptions`
  ADD CONSTRAINT `prescriptions_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`),
  ADD CONSTRAINT `prescriptions_ibfk_2` FOREIGN KEY (`DoctorID`) REFERENCES `users` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
