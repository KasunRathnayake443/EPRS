-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 11, 2024 at 07:06 PM
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
-- Table structure for table `medicine`
--

CREATE TABLE `medicine` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `description` text DEFAULT NULL,
  `amount_grams` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `medicine`
--

INSERT INTO `medicine` (`id`, `name`, `description`, `amount_grams`) VALUES
(1, 'Paracetamol', 'Used to reduce fever and relieve pain.', 409.50),
(2, 'Amoxicillin', 'An antibiotic used to treat bacterial infections.', -4.00),
(3, 'Ibuprofen', 'Non-steroidal anti-inflammatory drug used for pain relief.', 14.00),
(4, 'Cough Syrup', 'Syrup used to relieve cough and cold symptoms.', 100.00),
(5, 'Vitamin C', 'Boosts immunity and overall health.', 50.50),
(6, 'Aspirin', 'Pain reliever and anti-inflammatory', 95.50),
(7, 'Ibuprofen', 'Nonsteroidal anti-inflammatory drug (NSAID)', 150.00),
(8, 'Paracetamol', 'Pain reliever and fever reducer', 168.50),
(9, 'Amoxicillin', 'Antibiotic for bacterial infections', 245.50),
(10, 'Azithromycin', 'Antibiotic for bacterial infections', 300.00),
(11, 'Ciprofloxacin', 'Antibiotic for bacterial infections', 120.00),
(12, 'Metformin', 'Used to treat type 2 diabetes', 175.50),
(13, 'Lisinopril', 'ACE inhibitor for high blood pressure', 160.00),
(14, 'Atorvastatin', 'Statin for high cholesterol', 220.00),
(15, 'Omeprazole', 'Proton pump inhibitor for acid reflux', 140.00),
(16, 'Simvastatin', 'Cholesterol-lowering medication', 200.00),
(17, 'Clopidogrel', 'Blood thinner to prevent strokes', 130.00),
(18, 'Montelukast', 'Prevents asthma attacks', 175.00),
(19, 'Amlodipine', 'Calcium channel blocker for high blood pressure', 190.00),
(20, 'Losartan', 'Angiotensin II receptor antagonist for hypertension', 210.00),
(21, 'Levothyroxine', 'Thyroid hormone replacement', 250.00),
(22, 'Furosemide', 'Diuretic for fluid retention', 120.00),
(23, 'Hydrochlorothiazide', 'Thiazide diuretic for hypertension', 170.00),
(24, 'Warfarin', 'Anticoagulant to prevent blood clots', 110.00),
(25, 'Prednisone', 'Corticosteroid for inflammation', 130.00),
(26, 'Doxycycline', 'Antibiotic for bacterial infections', 180.00),
(27, 'Pantoprazole', 'Proton pump inhibitor for GERD', 185.50),
(28, 'Ranitidine', 'Histamine H2 receptor antagonist for ulcers', 220.00),
(29, 'Metoprolol', 'Beta blocker for high blood pressure', 140.00),
(30, 'Gabapentin', 'Anticonvulsant for nerve pain', 145.50),
(31, 'Sertraline', 'SSRI for depression and anxiety', 180.00),
(32, 'Zolpidem', 'Sedative for insomnia', 160.00),
(33, 'Albuterol', 'Bronchodilator for asthma', 100.00),
(34, 'Diazepam', 'Benzodiazepine for anxiety and seizures', 121.00),
(35, 'Hydrocodone', 'Opioid for pain relief', 120.00),
(36, 'Tramadol', 'Opioid for moderate pain relief', 140.00),
(37, 'Cyclobenzaprine', 'Muscle relaxant for spasms', 200.00),
(38, 'Tamsulosin', 'Alpha blocker for urinary retention', 170.00),
(39, 'Allopurinol', 'Reduces uric acid for gout treatment', 180.00),
(40, 'Sildenafil', 'Used to treat erectile dysfunction', 160.00),
(41, 'Fluoxetine', 'SSRI for depression and OCD', 140.00),
(42, 'Bupropion', 'Antidepressant and smoking cessation aid', 220.00),
(43, 'Meloxicam', 'NSAID for arthritis pain', 150.00),
(44, 'Loratadine', 'Antihistamine for allergies', 100.00),
(45, 'Cetirizine', 'Antihistamine for allergies', 140.00),
(46, 'Famotidine', 'H2 antagonist for stomach ulcers', 190.00),
(47, 'Duloxetine', 'SNRI for depression and anxiety', 180.00),
(48, 'Venlafaxine', 'SNRI for depression and anxiety', 210.00),
(49, 'Quetiapine', 'Atypical antipsychotic for bipolar disorder', 130.00),
(50, 'Alprazolam', 'Benzodiazepine for anxiety', 110.00),
(51, 'Risperidone', 'Atypical antipsychotic for schizophrenia', 200.00),
(52, 'Aripiprazole', 'Atypical antipsychotic for bipolar disorder', 150.00),
(53, 'Lamotrigine', 'Anticonvulsant for seizures', 190.00),
(54, 'Topiramate', 'Anticonvulsant for epilepsy', 160.00),
(55, 'Lithium', 'Mood stabilizer for bipolar disorder', 100.00),
(56, 'Escitalopram', 'SSRI for depression and anxiety', 120.00),
(57, 'Trazodone', 'Antidepressant and sleep aid', 170.00),
(58, 'Mirtazapine', 'Antidepressant for major depressive disorder', 140.00),
(59, 'Olanzapine', 'Atypical antipsychotic for schizophrenia', 150.00),
(60, 'Varenicline', 'Smoking cessation aid', 110.00),
(61, 'Carbamazepine', 'Anticonvulsant for epilepsy', 115.50),
(62, 'Valproic acid', 'Anticonvulsant for seizures', 140.00),
(63, 'Phenytoin', 'Anticonvulsant for epilepsy', 150.00),
(64, 'Levetiracetam', 'Anticonvulsant for seizures', 200.00),
(65, 'Pregabalin', 'Anticonvulsant for nerve pain', 140.00),
(66, 'Loperamide', 'Anti-diarrheal medication', 130.00),
(67, 'Bisacodyl', 'Laxative for constipation', 100.00),
(68, 'Docusate', 'Stool softener for constipation', 110.00),
(69, 'Polyethylene glycol', 'Laxative for bowel preparation', 200.00),
(70, 'Senna', 'Herbal laxative for constipation', 120.00),
(71, 'Ondansetron', 'Anti-nausea medication', 150.00),
(72, 'Meclizine', 'Antihistamine for vertigo and motion sickness', 180.00),
(73, 'Prochlorperazine', 'Antipsychotic for nausea and schizophrenia', 190.00),
(74, 'Metoclopramide', 'Gut motility stimulator', 170.00),
(75, 'Betamethasone', 'Corticosteroid for inflammation', 125.50);

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
('SEU/IS/19/MIT/100', 'John', 'Doe', '1985-06-15', 'Male', '123 Maple Street, Springfield', '555-1234', 'john.doe@example.com', '2024-09-03'),
('SEU/IS/19/MIT/101', 'Jane', 'Smith', '1990-08-22', 'Female', '456 Oak Avenue, Springfield', '555-5678', 'jane.smith@example.com', '2024-09-03'),
('SEU/IS/19/MIT/102', 'Robert', 'Johnson', '1975-02-11', 'Male', '789 Pine Road, Springfield', '555-8765', 'robert.johnson@example.com', '2024-09-03'),
('SEU/IS/19/MIT/103', 'Emily', 'Davis', '2000-01-05', 'Female', '101 Elm Street, Springfield', '555-3456', 'emily.davis@example.com', '2024-09-03'),
('SEU/IS/19/MIT/104', 'Michael', 'Wilson', '1995-09-30', 'Male', '202 Birch Lane, Springfield', '555-9876', 'michael.wilson@example.com', '2024-09-03');

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
(47, 'SEU/IS/19/MIT/103', 1, '2024-09-11', 'Vitamin C (Dose: 1)', 'new test');

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
(1, 'Doc NAme', 'doctor1', '123', 'Doctor'),
(2, 'admin1', 'admin1', '123', 'Admin'),
(3, 'staff NAme', 'staff1', '123', 'Staff'),
(4, 'Doc name', 'doctor2', '123', 'Doctor');

--
-- Indexes for dumped tables
--

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
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `medicine`
--
ALTER TABLE `medicine`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=76;

--
-- AUTO_INCREMENT for table `prescriptions`
--
ALTER TABLE `prescriptions`
  MODIFY `PrescriptionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

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
