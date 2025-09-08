-- MySQL dump 10.13  Distrib 9.1.0, for Win64 (x86_64)
--
-- Host: localhost    Database: Baza
-- ------------------------------------------------------
-- Server version	9.1.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ime` varchar(255) NOT NULL,
  `prezime` varchar(255) NOT NULL,
  `brojpasosa` varchar(255) NOT NULL,
  `datumrodjenja` varchar(255) NOT NULL,
  `emailadresa` varchar(255) DEFAULT NULL,
  `brojtelefona` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Stefan','Grujicic','8jJ8cwXZsGfVIiHcfysMJg==','24. jun 2003.','stefan@gmail.com','0603252928'),(2,'Pera','Peric','YVdTjFPnt8IjYp3g3bVSKg==','05. februar 2020.','perap@gmail.com','0603293232'),(3,'Mateja','Planic','FxZmOnizLqrk+4444H4mGA==','27. avgust 2003.','mata@gmail.com','060323923'),(4,'Jovana','Sajkic','9WYvho26ipI0tA4FllyTzw==','20. jul 2003.','jovana@gmail.com','0603239882'),(5,'asdasd','asdads','amahv9WpeFz2+vXpWPdJlw==','29. avgust 2025.','ads@gmail.com','123323122'),(6,'rthhrt','rthhtrhrthrt','+4dwjYJCWm12//xOeYMkxA==','08. septembar 2025.','asdsa@gmail.com','23112321'),(7,'asdads','asdsad','vW8gleFmyp0iA6I7soKTvA==','08. septembar 2025.','asdas@gmail.com','7435645656'),(8,'kerrrr','inaa','VCuyp2C4eALEfWdOvey7dw==','08. septembar 2025.','asddas@gmail.com','129039123'),(9,'dasda','asdasdasd','vW8gleFmyp0iA6I7soKTvA==','08. septembar 2025.','asds@gmail.com','12312313'),(10,'asdasd','asdasdasd','wpBjCaU9IMOL2rVDP/dWsA==','08. septembar 2025.','asdasd@gmail.com','0723723923'),(11,'asdsda','asddsadas','pZ6YT+DgLDzJdAdcv+Wbyg==','08. septembar 2025.','stsd@gmail.com','12312323'),(12,'gsgggs','gdfggdfdgf','fIgh5mzItkoh1eXp+s8TCA==','08. septembar 2025.','asdas@gmail.com','12312322');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `packages`
--

DROP TABLE IF EXISTS `packages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `packages` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ime` varchar(255) DEFAULT NULL,
  `destinacija` varchar(255) DEFAULT NULL,
  `transport` varchar(255) DEFAULT NULL,
  `smestaj` varchar(255) DEFAULT NULL,
  `cena` decimal(10,2) DEFAULT NULL,
  `dodatne_aktivnosti` varchar(255) DEFAULT NULL,
  `vodic` varchar(255) DEFAULT NULL,
  `trajanje` varchar(255) DEFAULT NULL,
  `brod` varchar(255) DEFAULT NULL,
  `ruta` varchar(255) DEFAULT NULL,
  `datum_polaska` varchar(255) DEFAULT NULL,
  `tip_kabine` varchar(255) DEFAULT NULL,
  `tip_paketa` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `packages`
--

LOCK TABLES `packages` WRITE;
/*!40000 ALTER TABLE `packages` DISABLE KEYS */;
INSERT INTO `packages` VALUES (1,'asddas','asdads',NULL,'asdasdas',123123.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'More'),(2,'dasdas','dsdasds',NULL,'asdsdadsa',123123.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'More');
/*!40000 ALTER TABLE `packages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservations`
--

DROP TABLE IF EXISTS `reservations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservations` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_client` int NOT NULL,
  `id_package` int NOT NULL,
  `state` varchar(255) DEFAULT NULL,
  `datum_rezervacije` varchar(255) NOT NULL,
  `broj_osoba` int DEFAULT NULL,
  `destinacija` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservations`
--

LOCK TABLES `reservations` WRITE;
/*!40000 ALTER TABLE `reservations` DISABLE KEYS */;
/*!40000 ALTER TABLE `reservations` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-08  1:53:06
