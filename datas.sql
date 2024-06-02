CREATE DATABASE  IF NOT EXISTS `usersinfo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `usersinfo`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: usersinfo
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bannedproducts`
--

DROP TABLE IF EXISTS `bannedproducts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bannedproducts` (
  `id` int NOT NULL,
  `Banned` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bannedproducts`
--

LOCK TABLES `bannedproducts` WRITE;
/*!40000 ALTER TABLE `bannedproducts` DISABLE KEYS */;
INSERT INTO `bannedproducts` VALUES (123,'2'),(124,'12'),(234,'4'),(239,'6'),(252,'14'),(299,'20'),(322,'18'),(353,'2'),(401,'6'),(418,'3'),(436,'8'),(443,'1'),(498,'13'),(546,'12'),(654,'2'),(662,'3'),(785,'1'),(789,'5'),(801,'6'),(877,'5'),(888,'1'),(962,'3'),(29385,'2'),(55434,'2'),(222232323,'3');
/*!40000 ALTER TABLE `bannedproducts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `canteenproducts`
--

DROP TABLE IF EXISTS `canteenproducts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `canteenproducts` (
  `id` int NOT NULL,
  `NameofProduct` varchar(255) NOT NULL,
  `Price` varchar(45) NOT NULL,
  `Stock` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `canteenproducts`
--

LOCK TABLES `canteenproducts` WRITE;
/*!40000 ALTER TABLE `canteenproducts` DISABLE KEYS */;
INSERT INTO `canteenproducts` VALUES (1,'Water','2','120'),(2,'Chips','3','50'),(3,'Gum','1','179'),(4,'Kebab','5','19'),(5,'Hamburger','7','49'),(6,'Cola','2','100'),(7,'Fanta','2','120'),(8,'Sprite','2','150'),(9,'Pane','4','40'),(10,'Bacon Sandwich','6','25'),(11,'Pen','1','120'),(12,'Eraser','1','130'),(13,'Notebooks','2','200'),(14,'Paints','1','80'),(15,'Paint Books','3','25'),(16,'Ruler','2','30'),(17,'Pencil Box','3','20'),(18,'Puding','4','80'),(19,'Icecream','2','200'),(20,'Pencil Sharpener','1','50'),(21,'Sandwich','4','100'),(22,'Pizza Slice','3','300'),(23,'French Fries','4','160'),(24,'Salad','2','100'),(25,'Donut','6','50'),(26,'Croissant','2','100'),(27,'Bagel','4','75'),(28,'Nachos','2','26'),(29,'Pretzel','5','88'),(30,'Coffee','7','120'),(31,'Tea','2','130'),(32,'Green Tea','2','22');
/*!40000 ALTER TABLE `canteenproducts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `canteenreg`
--

DROP TABLE IF EXISTS `canteenreg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `canteenreg` (
  `id` int NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `canteenreg`
--

LOCK TABLES `canteenreg` WRITE;
/*!40000 ALTER TABLE `canteenreg` DISABLE KEYS */;
INSERT INTO `canteenreg` VALUES (1,'emir','yasko'),(2,'berru','hanedar');
/*!40000 ALTER TABLE `canteenreg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classlistreport`
--

DROP TABLE IF EXISTS `classlistreport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classlistreport` (
  `id` int NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Surname` varchar(45) NOT NULL,
  `Gender` varchar(45) NOT NULL,
  `NationId` varchar(45) NOT NULL,
  `Birth_Date` varchar(45) NOT NULL,
  `Grade` varchar(45) NOT NULL,
  `Letter` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classlistreport`
--

LOCK TABLES `classlistreport` WRITE;
/*!40000 ALTER TABLE `classlistreport` DISABLE KEYS */;
INSERT INTO `classlistreport` VALUES (124,'Seda','Tezcan','Female','328451090','19/01/2010','3','B'),(231,'Emir','Ibrahimoglu','Male','123123342','20/02/2010','3','B'),(234,'Umut','Korkmaz','Male','651784423','17/04/2012','2','C'),(239,'Zeynep','Altın','Female','984017756','24/02/2011','3','A'),(252,'Ayşe','Özcan','Female','217340989','09/05/2013','5','I'),(299,'Şirin','Kaya','Female','772906545','15/09/2010','7','A'),(322,'Işıl','Aydın','Male','851785523','30/12/2010','5','C'),(353,'Elif','Somer','Female','306239978','09/05/2008','7','D'),(401,'Emre','Yılmaz','Male','106239878','11/02/2008','8','G'),(418,'Mehmet','Kara','Male','873906645','01/07/2010','4','F'),(436,'Emir','Genç','Male','639563301','22/03/2013','7','A'),(443,'Leyla','Arslan','Female','995128767','22/08/2013','7','A'),(498,'Kerem','Soyer','Male','962896634','20/02/2008','7','A'),(546,'Oğuz','Demirci','Male','439562201','23/10/2009','1','C'),(654,'Burak','Şimşek','Male','417341089','18/08/2009','3','E'),(662,'Ali','Demir','Male','884017656','01/03/2012','4','C'),(785,'Gizem','Şahin','Female','540673312','18/06/2008','4','A'),(789,'Simge','Polat','Female','528452190','10/01/2012','4','B'),(801,'Fatma','Koç','Female','762895534','12/03/2008','6','D'),(877,'Nil','Yüksel','Female','740674412','08/11/2008','8','D'),(888,'Ali','Koc','Male','123123133','12/22/1905','3','B'),(962,'Hasan','Güneş','Male','195128867','15/06/2010','3','B'),(29385,'Anıl','Celik','Male	','228','10/10/2010','3','B'),(55434,'Zehra','Ulucınar','Female','864','13/07/2002','3','B');
/*!40000 ALTER TABLE `classlistreport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `desktopauthorization`
--

DROP TABLE IF EXISTS `desktopauthorization`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `desktopauthorization` (
  `idnew_table` int NOT NULL,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  PRIMARY KEY (`idnew_table`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `desktopauthorization`
--

LOCK TABLES `desktopauthorization` WRITE;
/*!40000 ALTER TABLE `desktopauthorization` DISABLE KEYS */;
INSERT INTO `desktopauthorization` VALUES (1,'aiakos','emir123'),(2,'berru','hanedar');
/*!40000 ALTER TABLE `desktopauthorization` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kayiteacher`
--

DROP TABLE IF EXISTS `kayiteacher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kayiteacher` (
  `id` varchar(255) NOT NULL,
  `Tcname` varchar(255) NOT NULL,
  `Tcsurname` varchar(45) NOT NULL,
  `TcAdress` varchar(255) NOT NULL,
  `TcPhone` varchar(255) NOT NULL,
  `TcMail` varchar(255) NOT NULL,
  `TcGrade` varchar(45) NOT NULL,
  `TcLetter` varchar(45) NOT NULL,
  `Tcgender` varchar(45) NOT NULL,
  `Birth_Date` varchar(45) NOT NULL,
  `Reg_Date` varchar(45) NOT NULL,
  `TcArea` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kayiteacher`
--

LOCK TABLES `kayiteacher` WRITE;
/*!40000 ALTER TABLE `kayiteacher` DISABLE KEYS */;
INSERT INTO `kayiteacher` VALUES ('12324','Serra','Zeynep','aydinli nazil','0507283279','serranazilli@outlook.com','7','A','Female','12/09/2005','25/05/2024','Social Information'),('15873','Murat','Tekin','Bursa Sokak No:12, Bursa','05481234567','murat.tekin@mail.com','8','C','Male','08/12/1989','10/05/2021','Matematik'),('20635','Fatma','Koç','Samsun Caddesi No:23, Samsun','05351234567','fatma.koc@mail.com','7','B','Female','21/06/1992','17/04/2021','Sosyal Bilgiler'),('22321','Ayşe','Yılmaz','Ankara Caddesi No:123, Ankara','05321234567','ayse.yilmaz@mail.com','5','D','Female','12/05/1987','03/09/2023','Matematik'),('23232','Mehmet','Kaya','İzmir Sokak No:45, İzmir','05431234567','mehmet.kaya@mail.com','7','B','Male','23/03/1991','22/01/2022','Fen Bilgisi'),('28461','İbrahim','Polat','Hatay Mahallesi No:43, Hatay','05301234567','ibrahim.polat@mail.com','7','B','Male','05/05/1987','12/11/2022','Matematik'),('31313','Zeynep','Arslan','Adana Caddesi No:34, Adana','05051234567','zeynep.arslan@mail.com','4','G','Female','25/04/1993','15/07/2020','İngilizce'),('55555','Berru','Hanedar','Maltepe,İstanbul','0503943045','berruhanedar@outlook.com','3','B','Female','15/02/1999','02/06/2024','German'),('56924','Melike','Çelik','Kocaeli Sokak No:34, Kocaeli','05331234567','melike.celik@mail.com','3','B','Female','17/09/1996','04/12/2021','Matematik'),('62758','Hasan','Çetin','Kayseri Bulvarı No:45, Kayseri','05501234567','hasan.cetin@mail.com','8','E','Male','28/12/1986','07/05/2022','Sosyal Bilgiler'),('64239','Emine','Yıldırım','Antalya Bulvarı No:67, Antalya','05371234567','emine.yildirim@mail.com','6','E','Female','30/08/1995','25/02/2022','Fen Bilgisi'),('72684','Mehmet','Kaya','İzmir Sokak No:45, İzmir','05431234567','mehmet.kaya@mail.com','7','B','Male','23/03/1991','22/01/2022','Fen Bilgisi'),('74583','Serkan','Yavuz','Mersin Mahallesi No:90, Mersin','05411234567','serkan.yavuz@mail.com','6','G','Male','22/03/1984','29/06/2020','Fen Bilgisi'),('81023','Aslı','Kılıç','Diyarbakır Sokak No:23, Diyarbakır','05271234567','asli.kilic@mail.com','2','A','Female','11/10/1993','15/03/2021','İngilizce'),('83147','Kemal','Özdemir','Gaziantep Bulvarı No:56, Gaziantep','05091234567','kemal.ozdemir@mail.com','5','A','Male','03/01/1990','11/10/2022','İngilizce'),('89015','Elif','Demir','İstanbul Mahallesi No:78, İstanbul','05551234567','elif.demir@mail.com','3','F','Female','10/07/1994','18/12/2021','Fen Bilgisi'),('92346','Ahmet','Şahin','Konya Bulvarı No:56, Konya','05341234567','ahmet.sahin@mail.com','2','A','Male','19/11/1985','05/11/2023','Sosyal Bilgiler');
/*!40000 ALTER TABLE `kayiteacher` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kayitstudent`
--

DROP TABLE IF EXISTS `kayitstudent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kayitstudent` (
  `id` int NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Surname` varchar(45) NOT NULL,
  `Grade` varchar(255) NOT NULL,
  `NationId` varchar(255) NOT NULL,
  `MotherName` varchar(255) NOT NULL,
  `FatherName` varchar(255) NOT NULL,
  `Adress` varchar(255) NOT NULL,
  `ParentPhone` varchar(255) NOT NULL,
  `ParentEmail` varchar(255) NOT NULL,
  `Letter` varchar(255) NOT NULL,
  `Birth_Date` varchar(45) NOT NULL,
  `Reg_Date` varchar(45) NOT NULL,
  `Gender` varchar(45) NOT NULL,
  `Absence` varchar(45) NOT NULL,
  `Balance` varchar(45) NOT NULL,
  `Banned` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kayitstudent`
--

LOCK TABLES `kayitstudent` WRITE;
/*!40000 ALTER TABLE `kayitstudent` DISABLE KEYS */;
INSERT INTO `kayitstudent` VALUES (123,'Emir','Ibrahimoglu','4','12312352','Ceyda','Necip','Zumrutevler Maltepe Istanbul','05078721312','student@hotmail.com','D','11/04/2009','12/05/2024','Male','Arrived','268','2'),(124,'Seda','Tezcan','5','328451090','Merve','Levent','Şanlıurfa, Haliliye','05011002435','seda.tezcan@example.com','F','19/01/2010','10/09/2020 ','Female','Absence','220','12'),(229,'Fazil','Aksoy','3','18242297522','Melek','Hakan','mithatpasaCaddesi Bogurltensokakdfsdf;lskdf;lskdfs;dlkfsd;lfksd','05082312394','emir21355@outlook.com','G','24/07/2010','11/05/2024','Male','Arrived','150','10     '),(232,'Can','Çelik ','2','448596321 ','Esra       ','Cem        ','Ankara, Kızılay','05012233445','can.celik@example.com','G','23/01/2011','03/09/2020','Female','Absence','23','5'),(233,'Zeynep','Serra','5','345906545','Sedef','Yagız','Nazilli Aydın','0503203920','serranazilli@outlook.com','D','12/09/2005','25/05/2024','Female','Arrived','4','16'),(234,'Umut','Korkmaz','2','651784423','Dilek','Mert','Mersin, Mezitli','05014335768','umut.korkmaz@example.com','C','17/04/2012','13/09/2020','Male','Arrived','224','4'),(239,'Zeynep','Altın','3','984017756','Serap','Hakan','Trabzon, Ortahisar','05017668001','zeynep.altin@example.com','A','24/02/2011','16/09/2020','Female','Absence','288','6'),(252,'Ayşe','Özcan','5','217340989','Gülay','Halit','Van, İpekyolu','05019901324','ayse.ozcan@example.com','I','09/05/2013','09/09/2020','Female','Arrived','334','14'),(299,'Şirin','Kaya','7','772906545','Derya','Murat','Antalya, Lara','05015566778','sirin.kaya@example.com','A','15/09/2010','05/09/2020 ','Female','Absence','223','20'),(314,'Hayriye','Alcan','4','661795434','Fatma','Mahmut','bogurtlen sokak no 3 daire 23','05314120329','alcan@gmail.com','D','08/02/2011','09/05/2024','Female','Absence','2','6'),(322,'Işıl','Aydın','5','851785523','Yeşim','Tuncer','Bursa, Nilüfer','05015345778',' isil.aydin@example.com ','C','30/12/2010','23/09/2020','Male','Arrived','140','18'),(353,'Elif','Somer','7','306239978','Sibel','Murat','İzmir, Bornova','05019890223','elif.somer@example.com','D','09/05/2008','18/09/2020','Female','Arrived','223','2'),(401,'Emre','Yılmaz','8','106239878','Aysu','Doğan','Gaziantep, Şahinbey','05018890213','emre.yilmaz@example.com','G','11/02/2008',' 08/09/2020','Male','Absence','66','6'),(418,'Mehmet','Kara','4','873906645','Leman','Faruk','Erzurum, Palandöken','05016557990','mehmet.kara@example.com','F','01/07/2010','15/09/2020','Male','Arrived','144','3'),(433,'Berk','Özdemir','5','661795474','Hande','Necip','Bursa, Osmangazi','05014455667','berk.ozdemir@example.com','D','30/07/2008','04/09/2020','Male	','Arrived','5','14'),(436,'Emir','Genç','7','639563301','Pınar','Deniz','Konya, Selçuklu','05013123556','emir.genc@example.com','A','22/03/2013','21/09/2020','Male','Arrived','22','8'),(443,'Leyla','Arslan','7','995128767','Elif','Salih','Diyarbakır, Bağlar ','05017789102','leyla.arslan@example.com','B','22/08/2013','07/09/2020','Female','Arrived','44','1'),(498,'Kerem','Soyer','7','962896634','Fulya','Serdar',' Muğla, Marmaris','05016456889','kerem.soyer@example.com','F','20/02/2008','24/09/2020','Male','Absence','188','13'),(546,'Oğuz','Demirci','1','439562201','Hülya','Sinan','Kocaeli, İzmit','05012113546','oguz.demirci@example.com','C','23/10/2009','11/09/2020','Male','Arrived','223','12'),(654,'Burak','Şimşek','3','417341089','Nesrin','Cenk','Kayseri, Melikgazi','05010901334','burak.simssek@example.com','E','18/08/2009','19/09/2020','Male','Absence','111','2'),(662,'Ali','Demir','4','884017656','Canan','Kemal','Edirne, Merkez','05016678901','ali.demir@example.com','C','01/03/2012','06/09/2020','Male','Absence','23','3'),(748,'Deniz','Aksoy','3','354216879 ','Zeynep  ','Ahmet','İstanbul, Üsküdar','05011122334   ',' deniz.aksoy@example.com','G','12/05/2010','01/09/2020','Female','Arrived','10     ','2'),(785,'Gizem','Şahin','4','540673312','Sevgi','İbrahim','Samsun, İlkadım','05013224657','gizem.sahin@example.com','A','18/06/2008','12/09/2020','Female','Absence','12','1'),(789,'Simge','Polat','4','528452190','Ayşen','Sami','Sivas, Merkez','05012012445','simge.polat@example.com','B','10/01/2012','20/09/2020','Female','Absence','30','5'),(801,'Fatma','Koç','6','762895534','Banu','Tahir','Adana, Seyhan','05015446879','fatma.koc@example.com','D','12/03/2008','14/09/2020','Female','Absence','123','6'),(877,'Nil','Yüksel','8','740674412','Gökçe','Barış','Malatya, Yeşilyurt','05014234667','nil.yuksel@example.com','D','08/11/2008','22/09/2020','Female','Absence','133','5'),(962,'Hasan','Güneş','5','195128867','Nurten','Ali','Hatay, Antakya','05018779112','hasan.gunes@example.com','G','15/06/2010','17/09/2020','Male','Arrived','455','3'),(29385,'Anıl','Celik','3','228','Ceyda','Hakan','Maltepe,İstanbul','0506932930','ceydacelik@outlook.com','B','10/10/2010','02/06/2024','Male	','Arrived','330','2'),(55434,'Zehra','Ulucınar','3','864','Melike','Necati','Beşiktaş,İstanbul','05030829839','melıkeulucınar@outlook.com','B','13/07/2002','02/06/2024','Female','Absence	','300','2');
/*!40000 ALTER TABLE `kayitstudent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `listofstudent`
--

DROP TABLE IF EXISTS `listofstudent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `listofstudent` (
  `id` int NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Surname` varchar(45) NOT NULL,
  `Grade` varchar(255) NOT NULL,
  `Absence` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `listofstudent`
--

LOCK TABLES `listofstudent` WRITE;
/*!40000 ALTER TABLE `listofstudent` DISABLE KEYS */;
INSERT INTO `listofstudent` VALUES (123,'Emir','Ibrahimoglu','4','Absence'),(124,'Seda','Tezcan','5','Absence'),(229,'Fazil','Korkmaz','3','Arrived'),(234,'Umut','Korkmaz','2','Arrived'),(239,'Zeynep','Altın','3','Absence'),(252,'Ayşe','Özcan','5','Arrived'),(299,'Şirin','Kaya','7','Absence'),(314,'Hayriye','Alcan','4','Absence'),(322,'Işıl','Aydın','5','Arrived'),(353,'Elif','Somer','7','Arrived'),(401,'Emre','Yılmaz','8','Absence'),(418,'Mehmet','Kara','4','Arrived'),(433,'Emir','Yasin','5','Arrived'),(436,'Emir','Genç','7','Arrived'),(443,'Leyla','Arslan','7','Arrived'),(498,'Kerem','Soyer','7','Absence'),(546,'Oğuz','Demirci','1','Arrived'),(654,'Burak','Şimşek','3','Absence'),(662,'Ali','Demir','4','Absence'),(785,'Gizem','Şahin','4','Absence'),(789,'Simge','Polat','4','Absence'),(801,'Fatma','Koç','6','Absence'),(877,'Nil','Yüksel','8','Absence'),(962,'Hasan','Güneş','5','Arrived'),(999,'Zeynep','Serra','5','Arrived'),(29385,'Anıl','Celik','3','Arrived'),(55434,'Zehra','Ulucınar','3','Absence	');
/*!40000 ALTER TABLE `listofstudent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mobilereg`
--

DROP TABLE IF EXISTS `mobilereg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mobilereg` (
  `id` int NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Surname` varchar(255) NOT NULL,
  `Grade` varchar(255) NOT NULL,
  `Letter` varchar(45) NOT NULL,
  `NationID` varchar(45) NOT NULL,
  `Adress` varchar(45) NOT NULL,
  `Birth_Date` varchar(45) NOT NULL,
  `Reg_Date` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `CurrentBalance` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mobilereg`
--

LOCK TABLES `mobilereg` WRITE;
/*!40000 ALTER TABLE `mobilereg` DISABLE KEYS */;
INSERT INTO `mobilereg` VALUES (134,'Büşra','Öztürk','4','B','67890123456','321 Pembe Sokak','2010-04-16','2024-01-01','sifre678','115.75'),(154,'Ali','Aydın','5','G','78901234567','321 Yeni Cadde','2010-07-07','2024-01-01','sifre901','120.00'),(228,'Emir Yasin','Ibrahimoglu','6','A','13123124','pendik istanbul','19/04/2010','12/05/2024','agaclar123','118'),(271,'Özlem','Arslan','7','G','45678901234','654 Siyah Sokak','2009-02-14','2024-01-01','sifre012','190.20'),(333,'Berru','Hanedar','6','C','12312312','maltepe','20/11/2009','11/05/2024','bmwauidi132','50'),(393,'Hasan','Taş','7','B','90123456789','987 Yeşil Cadde','2009-09-09','2024-01-01','sifre567','200.00'),(426,'Mert','Celik','7','D','21331231','camlica','01/01/2011','10/05/2024','kralMert123','14'),(444,'Betül','Çetin','7','D','89012345678','987 Gri Sokak','2010-06-18','2024-01-01','sifre234','95.00'),(474,'Fatma','Şahin','7','D','45678901234','321 Küçük Sokak','2010-04-04','2024-01-01','sifre012','50.25'),(500,'Selin','Erdem','6','E','23456789012','789 Beyaz Sokak','2010-12-12','2024-01-01','sifre456','175.80'),(565,'Mustafa','Çelik','4','E','56789012345','654 Geniş Cadde','2010-05-05','2024-01-01','sifre345','75.00'),(570,'Mehmet','Demir','6','C','34567890123','789 Büyük Cadde','2010-03-03','2024-01-01','sifre789','200.00'),(591,'Kemal','Koç','5','F','34567890123','321 Sarı Cadde','2010-01-13','2024-01-01','sifre789','60.00'),(592,'Can','Tuna','8','E','90123456789','123 Kahverengi Sokak','2009-07-19','2024-01-01','sifre567','200.00'),(615,'Ahmet','Yılmaz','5','A','12345678901','123 Ana Cadde','2010-01-01','2024-01-01','sifre123','100.50'),(685,'Gamze','Şimşek','5','F','01234567890','456 Lacivert Cadde','2010-08-20','2024-01-01','sifre890','50.30'),(729,'Orhan','Korkmaz','8','A','56789012345','987 Mor Cadde','2010-03-15','2024-01-01','sifre345','140.50'),(732,'Ayşe','Kaya','8','B','23456789012','456 Yan Sokak','2009-02-02','2024-01-01','sifre456','150.75'),(748,'Yusuf','Polat','6','C','78901234567','654 Turuncu Cadde','2009-05-17','2024-01-01','sifre901','160.80'),(771,'Zeynep','Kara','8','F','67890123456','987 Dar Sokak','2009-06-06','2024-01-01','sifre678','180.30'),(793,'Murat','Güneş','8','D','12345678901','456 Kırmızı Cadde','2009-11-11','2024-01-01','sifre123','130.60'),(808,'Elif','Bulut','4','C','01234567890','123 Mavi Sokak','2010-10-10','2024-01-01','sifre890','85.15'),(876,'Emine','Yıldız','6','A','89012345678','654 Eski Sokak','2010-08-08','2024-01-01','sifre234','95.40');
/*!40000 ALTER TABLE `mobilereg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mobileregparent`
--

DROP TABLE IF EXISTS `mobileregparent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mobileregparent` (
  `id` int NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Surname` varchar(45) NOT NULL,
  `ParentEmail` varchar(45) NOT NULL,
  `ParentPhone` varchar(45) NOT NULL,
  `CreditCardNum` varchar(45) NOT NULL,
  `CreditCardDate` varchar(45) NOT NULL,
  `CreditCardBackSide` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `CurrentBalance` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mobileregparent`
--

LOCK TABLES `mobileregparent` WRITE;
/*!40000 ALTER TABLE `mobileregparent` DISABLE KEYS */;
INSERT INTO `mobileregparent` VALUES (123213,'Cinar','Ozturk','cinarozturk@hotmail.cm','0550349202','12312312313','09/25','232','cinar12314','220$'),(123123123,'Zeynep','Adiguzel','adiguzeel@hotmail.com','0503409020','12312031292','02/29','592','zeynoqueen','5$'),(1231231239,'Mahmut','Alcan','mahmut@hotmail.com','0503049120','12031239120','09/26','532','uyarkral232','233$');
/*!40000 ALTER TABLE `mobileregparent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentabsence`
--

DROP TABLE IF EXISTS `studentabsence`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studentabsence` (
  `id` varchar(16) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Surname` varchar(32) NOT NULL,
  `Grade` varchar(45) NOT NULL,
  `Letter` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentabsence`
--

LOCK TABLES `studentabsence` WRITE;
/*!40000 ALTER TABLE `studentabsence` DISABLE KEYS */;
INSERT INTO `studentabsence` VALUES ('223','Ali','Zade','2','D'),('230','Ayse','Kral','8','C'),('232','Baris','Alper','3','C'),('84','Rifat','Can','4','A'),('99','Mert','Enes','6','A');
/*!40000 ALTER TABLE `studentabsence` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentarrived`
--

DROP TABLE IF EXISTS `studentarrived`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studentarrived` (
  `id` int NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Surname` varchar(255) NOT NULL,
  `Letter` varchar(45) NOT NULL,
  `Grade` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentarrived`
--

LOCK TABLES `studentarrived` WRITE;
/*!40000 ALTER TABLE `studentarrived` DISABLE KEYS */;
INSERT INTO `studentarrived` VALUES (225,'Ali','Yazici','C','3'),(228,'Emir','Yasin','A','3'),(444,'Burak','Yilmaz','D','5'),(448,'Mert','Anil','G','7'),(555,'Ali','Yazar','A','4'),(874,'Yagmur','Dilek','F','6');
/*!40000 ALTER TABLE `studentarrived` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teacherlistreport`
--

DROP TABLE IF EXISTS `teacherlistreport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teacherlistreport` (
  `id` int NOT NULL,
  `Tcname` varchar(45) NOT NULL,
  `Tcsurname` varchar(45) NOT NULL,
  `Tcgender` varchar(45) NOT NULL,
  `TcGrade` varchar(45) NOT NULL,
  `TcLetter` varchar(45) NOT NULL,
  `TcArea` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teacherlistreport`
--

LOCK TABLES `teacherlistreport` WRITE;
/*!40000 ALTER TABLE `teacherlistreport` DISABLE KEYS */;
INSERT INTO `teacherlistreport` VALUES (12313,'Emır','Ibra','Male','3','C','Math'),(15873,'Murat','Tekin','Male','8','C','Matematik'),(20635,'Fatma','Koç','Female','7','B','Sosyal Bilgiler'),(22321,'Ayşe','Yılmaz','Female','5','D','Matematik'),(23232,'Mehmet','Kaya','Male','7','B','Fen Bilgisi'),(28461,'İbrahim','Polat','Male','7','A','Matematik'),(31452,'Ayşe','Yılmaz','Female','5','D','Matematik'),(39142,'Neslihan','Erdem','Female','4','C','Türkçe'),(44444,'Ayşe','Yılmaz','Female','5','D','Matematik'),(47592,'Ali','Acar','Male','1','D','Türkçe'),(50721,'Zeynep','Arslan','Female','4','G','İngilizce'),(55555,'Berru','Hanedar','Female','3','B','German'),(56924,'Melike','Çelik','Female','3','F','Matematik'),(62758,'Hasan','Çetin','Male','8','E','Sosyal Bilgiler'),(64239,'Emine','Yıldırım','Female','3','B','Fen Bilgisi'),(72684,'Mehmet','Kaya','Male','7','B','Fen Bilgisi'),(74583,'Serkan','Yavuz','Male','6','G','Fen Bilgisi'),(81023,'Aslı','Kılıç','Female','2','A','İngilizce'),(83147,'Kemal','Özdemir','Male','5','A','İngilizce'),(89015,'Elif','Demir','Female','3','F','Fen Bilgisi'),(92346,'Ahmet','Şahin','Male','2','A','Sosyal Bilgiler');
/*!40000 ALTER TABLE `teacherlistreport` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-02 22:41:36
