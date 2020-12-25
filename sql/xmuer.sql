CREATE DATABASE IF NOT EXISTS xmuer DEFAULT CHARSET utf8 COLLATE utf8_general_ci;

GRANT ALL ON xmuer.* TO 'dbuser'@'localhost';
GRANT ALL ON xmuer.* TO 'dbuser'@'%';

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

USE xmuer;

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `user_name` varchar(32) DEFAULT NULL,
  `password` varchar(128) DEFAULT NULL,
  `state` tinyint DEFAULT 0,
  `type` tinyint DEFAULT 0,
  `real_name` varchar(32) DEFAULT NULL,
  `gender` tinyint DEFAULT NULL,
  `birthday` date DEFAULT NULL,
  `hometown` varchar(128) DEFAULT NULL,
  `email` varchar(128) DEFAULT NULL,
  `mobile` varchar(128) DEFAULT NULL,
  `university` varchar(128) DEFAULT NULL,
  `high_school` varchar(128) DEFAULT NULL,
  `junior_high_school` varchar(128) DEFAULT NULL,
  `primary_school` varchar(128) DEFAULT NULL,
  `hobby_music` varchar(64) DEFAULT NULL,
  `hobby_book` varchar(64) DEFAULT NULL,
  `hobby_movie` varchar(64) DEFAULT NULL,
  `hobby_game` varchar(64) DEFAULT NULL,
  `hobby_anime` varchar(64) DEFAULT NULL,
  `hobby_sport` varchar(64) DEFAULT NULL,
  `hobby_other` varchar(64) DEFAULT NULL,
  `student_no` varchar(32) DEFAULT NULL,
  `college` varchar(32) DEFAULT NULL,
  `department` varchar(32) DEFAULT NULL,
  `major` varchar(32) DEFAULT NULL,
  `avatar` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

INSERT INTO `xmuer`.`user` (`id`, `user_name`, `password`, `state`, `type`, `real_name`, `gender`, `birthday`, `hometown`, `email`, `mobile`, `university`, `high_school`, `junior_high_school`, `primary_school`, `hobby_music`, `hobby_book`, `hobby_movie`, `hobby_game`, `hobby_anime`, `hobby_sport`, `hobby_other`, `student_no`, `college`, `department`, `major`, `avatar`) 
VALUES
('0', 'Admin', 'IloveDr.Song', '1', '100', 'I love Song Liang', '1', '2000-01-01', 'xm', 'xmuer@stu,edu.xmu.com', '1234567890', 'xmu', 'xmss', 'xmss', 'xmss', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u0.jpg');

INSERT INTO `xmuer`.`user` (`id`, `user_name`, `password`, `state`, `type`, `real_name`, `gender`, `birthday`, `hometown`, `email`, `mobile`, `university`, `high_school`, `junior_high_school`, `primary_school`, `hobby_music`, `hobby_book`, `hobby_movie`, `hobby_game`, `hobby_anime`, `hobby_sport`, `hobby_other`, `student_no`, `college`, `department`, `major`, `avatar`) 
VALUES 
('1', 'wwc1', '123456', '1', '1', 'wang1', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u1.jpg'),
('2', 'wwc2', '123456', '1', '1', 'wang2', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u2.jpg'),
('3', 'wwc3', '123456', '1', '1', 'wang3', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u3.jpg'),
('4', 'wwc4', '123456', '1', '1', 'wang4', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u4.jpg'),
('5', 'wwc5', '123456', '1', '1', 'wang5', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u5.jpg'),
('6', 'wwc6', '123456', '1', '1', 'wang6', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u6.jpg'),
('7', 'wwc7', '123456', '1', '1', 'wang7', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u7.jpg'),
('8', 'wwc8', '123456', '1', '1', 'wang8', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u8.jpg'),
('9', 'wwc9', '123456', '1', '1', 'wang9', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u9.jpg'),
('10', 'wwc10', '123456', '1', '1', 'wang10', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u10.jpg'),
('11', 'wwc11', '123456', '1', '1', 'wang11', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u11.jpg'),
('12', 'wwc12', '123456', '1', '1', 'wang12', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u12.jpg'),
('13', 'wwc13', '123456', '1', '1', 'wang13', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u13.jpg'),
('14', 'wwc14', '123456', '1', '1', 'wang14', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u14.jpg'),
('15', 'wwc15', '123456', '1', '1', 'wang15', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u15.jpg'),
('16', 'wwc16', '123456', '1', '1', 'wang16', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u16.jpg'),
('17', 'wwc17', '123456', '1', '1', 'wang17', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u17.jpg'),
('18', 'wwc18', '123456', '1', '1', 'wang18', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u18.jpg'),
('19', 'wwc19', '123456', '1', '1', 'wang19', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u19.jpg'),
('20', 'wwc20', '123456', '1', '1', 'wang20', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '/ava/u20.jpg');

DROP TABLE IF EXISTS `album`;
create table album(
	id INT AUTO_INCREMENT PRIMARY KEY,			-- 自增列需为主键
	user_id INT NOT NULL,
	picture VARCHAR(64) DEFAULT NULL,
	name VARCHAR(64) DEFAULT NULL
);

insert into album values(1,1,'~/album/timg.png','头像相册');
insert into album values(2,1,'~/album/timg.png','手机相册');
insert into album values(3,1,'~/album/timg.png','电脑相册');
insert into album values(5,1,'~/album/timg.png','我的相册');


DROP TABLE IF EXISTS `photo`;
create table photo(
	id INT AUTO_INCREMENT PRIMARY KEY,			-- 自增列需为主键
	album_id INT NOT NULL,
	picture VARCHAR(64) DEFAULT NULL
);

DROP TABLE IF EXISTS `status`;
CREATE TABLE `status`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `user_id` int(0) NULL DEFAULT NULL,
  `content` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `state` tinyint(0) NULL DEFAULT NULL, 
  `like` int(0) NULL DEFAULT NULL,
  `time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

INSERT INTO `status` (`id`, `user_id`, `content`, `state`, `like`) VALUES (1, 1, '<p>好心情</p>', 1, 2);
INSERT INTO `status` (`id`, `user_id`, `content`, `state`, `like`) VALUES (2, 1, '<p>哈</p>', 1, 0);
INSERT INTO `status` (`id`, `user_id`, `content`, `state`, `like`) VALUES (3, 1, '<h1>交互设计</h1>', 2, 8);

DROP TABLE IF EXISTS `comment`;
CREATE TABLE `comment`  (
  `id` INT AUTO_INCREMENT PRIMARY KEY,
  `user_id` int NOT NULL,
  `status_id` int(0) NULL DEFAULT NULL,
  `content` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
);