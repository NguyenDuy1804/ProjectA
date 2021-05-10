CREATE DATABASE quanlirapphim
GO

USE quanlirapphim
GO

CREATE TABlE Account
(
	username nvarchar(256) primary key,
	password nvarchar(256),
)
GO

INSERT INTO Account VALUES ('np123', '123')
INSERT INTO Account VALUES ('np12345', '123')

SELECT * FROM Account

INSERT INTO Account VALUES ('m00110001', 'manage01')
INSERT INTO Account VALUES ('m00110010', 'manage02')
INSERT INTO Account VALUES ('e00110001', 'employee01')
INSERT INTO Account VALUES ('e00110010', 'employee02')

