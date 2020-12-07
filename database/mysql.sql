/*
DROP DATABASE blog;

*/
CREATE DATABASE blog CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;


create table album(
	id INT AUTO_INCREMENT PRIMARY KEY,			-- 自增列需为主键
	user_id INT NOT NULL,
	picture VARCHAR(64) DEFAULT NULL,
	name VARCHAR(64) DEFAULT NULL
);
insert into album values(1,1,'~/album/timg.png','头像相册');
insert into album values(2,1,'~/album/timg.png','手机相册');
insert into album values(3,1,'~/album/timg.png','电脑相册');

