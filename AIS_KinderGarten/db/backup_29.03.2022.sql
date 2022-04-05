-- MySqlBackup.NET 2.3.6
-- Dump Time: 2022-03-29 21:02:19
-- --------------------------------------
-- Server version 5.5.50 MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of attendance
-- 

DROP TABLE IF EXISTS `attendance`;
CREATE TABLE IF NOT EXISTS `attendance` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `last_name` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `three_name` varchar(255) NOT NULL,
  `reason` varchar(255) NOT NULL,
  `date` date NOT NULL,
  `groups` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table attendance
-- 

/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
INSERT INTO `attendance`(`id`,`last_name`,`name`,`three_name`,`reason`,`date`,`groups`) VALUES(1,'Иванов','Илья','Александрович','Больничный','2022-03-22 00:00:00','Младшая группа'),(2,'Дикарев','Роман','Олегович','Прогулял','2022-03-22 00:00:00','Младшая группа'),(3,'Ковальский','Кирилл','Ренатович','Неизвестна','2022-03-22 00:00:00','Старшая группа'),(4,'Тест','Тестсс','Поыл','ПАЫВп','2022-03-21 00:00:00','Младшая группа');
/*!40000 ALTER TABLE `attendance` ENABLE KEYS */;

-- 
-- Definition of pupils
-- 

DROP TABLE IF EXISTS `pupils`;
CREATE TABLE IF NOT EXISTS `pupils` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `last_name` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `three_name` varchar(255) NOT NULL,
  `date_born` date NOT NULL,
  `groups` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table pupils
-- 

/*!40000 ALTER TABLE `pupils` DISABLE KEYS */;
INSERT INTO `pupils`(`id`,`last_name`,`name`,`three_name`,`date_born`,`groups`) VALUES(0,'Иванова','Анна','Олеговна','2022-02-09 00:00:00','Младшая группа'),(1,'Иванов','Иван','Иванович','2020-12-08 00:00:00','Младшая группа'),(2,'Орлов','Олег','Александрович','2020-07-10 00:00:00','Средняя группа'),(3,'Смирнов','Александр','Олегович','2014-05-20 00:00:00','Младшая группа'),(5,'Смирнова','Алена','Олеговна','2020-01-20 00:00:00','Средняя группа'),(6,'Петров','Петр','Иванович','2020-04-18 00:00:00','Младшая группа'),(7,'Шарапов','Василий','Федосеевич','2019-12-10 00:00:00','Старшая группа'),(8,'Кулаков','Пантелей','Даниилович','2019-10-10 00:00:00','Старшая группа'),(9,'Семёнов','Денис','Петрович','2019-11-01 00:00:00','Старшая группа'),(10,'Родионов','Борис','Тимурович','2018-11-10 00:00:00','Подготовительная группа'),(11,'Блинов','Василий','Георгьевич','2019-12-12 00:00:00','Подготовительная группа'),(12,'Константинов','Лаврентий','Сергеевич','2019-12-10 00:00:00','Средняя группа'),(13,'Герасимов','Олег','Петрович','2007-02-20 00:00:00','Средняя группа'),(14,'Смирнова','Марина','Олеговна','2024-02-20 00:00:00','Подготовительная группа'),(15,'Ковальский','Кирилл','Ренатович','2003-02-25 00:00:00','Подготовительная группа'),(16,'Немой','Владимир','Алексеевич','2026-03-20 00:00:00','Подготовительная группа'),(17,'Алексеева','Анастасия','Романовна','2013-06-20 00:00:00','Подготовительная группа');
/*!40000 ALTER TABLE `pupils` ENABLE KEYS */;

-- 
-- Definition of staff
-- 

DROP TABLE IF EXISTS `staff`;
CREATE TABLE IF NOT EXISTS `staff` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `last_name` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `three_name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `job_title` varchar(255) NOT NULL,
  `fixed_group` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table staff
-- 

/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff`(`id`,`last_name`,`name`,`three_name`,`password`,`job_title`,`fixed_group`,`status`) VALUES(1,'Иванов','Иван','Иванович','admin','Заведующий','Нету','Администратор'),(2,'Иванова','Анна','Ивановна','user25','Воспитатель','Младшая группа','Пользователь'),(3,'Ковальский','Кирилл','Ренатович','kirill34','Директор ФСБ','Нету','Администратор'),(4,'Смирнова','Мария','Олеговна','user34','Воспитатель','Старшая группа','Пользователь'),(5,'Курьянова','Анастасия','Ивановна','user14','Воспитатель','Средння группа','Пользователь'),(6,'Петрова','Алена','Александровна','user74','Воспитатель','Подготовительная группа','Пользователь');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2022-03-29 21:02:20
-- Total time: 0:0:0:0:141 (d:h:m:s:ms)
