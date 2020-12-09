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

INSERT INTO `xmuer`.`user` (`id`, `user_name`, `password`, `state`, `type`, `real_name`, `gender`, `birthday`, `hometown`, `email`, `mobile`, `university`, `high_school`, `junior_high_school`, `primary_school`, `hobby_music`, `hobby_book`, `hobby_movie`, `hobby_game`, `hobby_anime`, `hobby_sport`, `hobby_other`, `student_no`, `college`, `department`, `major`, `avatar`) VALUES ('1', 'wwc', '123', '1', '1', 'wang', '1', '1999-11-26', 'nj', '123@321.com', '12312344321', 'xmu', 'njssz', 'njsr', 'njspl', 'mm', 'bb', 'mm', 'ga', 'an', 'sp', 'ot', '123321', '信息学院', '软件工程', '软件工程', '~/album/timg.png');

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
insert into album values(5,1,'wwwroot/album/timg.png','我的相册');

DROP TABLE IF EXISTS `photo`;
create table photo(
	id INT AUTO_INCREMENT PRIMARY KEY,			-- 自增列需为主键
	album_id INT NOT NULL,
	picture VARCHAR(64) DEFAULT NULL
);

DROP TABLE IF EXISTS `status`;
CREATE TABLE `status`  (
  `id` int(0) NOT NULL,
  `user_id` int(0) NULL DEFAULT NULL,
  `content` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `state` tinyint(0) NULL DEFAULT NULL,
  `like` int NULL DEFAULT NULL,
  `gmt_create` datetime(0) NULL DEFAULT NULL,
  `gmt_modified` datetime(0) NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(0),
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

INSERT INTO `status` VALUES (1, 1, '<p>好心情</p>', 1, 0, '2020-12-06 17:05:50', NULL);
INSERT INTO `status` VALUES (2, 1, '<p>哈</p>', 1, 0, '2020-12-07 18:06:08', NULL);

DROP TABLE IF EXISTS `comment`;
CREATE TABLE `comment`  (
  `id` INT AUTO_INCREMENT PRIMARY KEY,
  `status_id` int(0) NULL DEFAULT NULL,
  `content` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL
);