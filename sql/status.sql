/*
 Navicat Premium Data Transfer

 Source Server         : xmuer
 Source Server Type    : MySQL
 Source Server Version : 80022
 Source Host           : localhost:3306
 Source Schema         : xmuer

 Target Server Type    : MySQL
 Target Server Version : 80022
 File Encoding         : 65001

 Date: 09/12/2020 08:12:43
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for status
-- ----------------------------
DROP TABLE IF EXISTS `status`;
CREATE TABLE `status`  (
  `id` int(0) NOT NULL,
  `user_id` int(0) NULL DEFAULT NULL,
  `content` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `state` tinyint(0) NULL DEFAULT NULL,
  `gmt_create` datetime(0) NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(0),
  `gmt_modified` datetime(0) NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(0),
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of status
-- ----------------------------
INSERT INTO `status` VALUES (1, 1, '<p>好心情</p>', 1, '2020-12-06 17:05:50', NULL);
INSERT INTO `status` VALUES (2, 1, '<p>哈</p>', 1, '2020-12-07 18:06:08', NULL);

SET FOREIGN_KEY_CHECKS = 1;
