CREATE DATABASE quanlyrapphim
GO

USE quanlyrapphim
GO

CREATE TABLE Account
(
	username nvarchar(100) PRIMARY KEY,
	password nvarchar(100) NOT NULL,
)
GO

INSERT INTO Account(username,password) values ('np123','123')

SELECT username, password
FROM Account
WHERE username = 'np123' and password = '123'

select username, password from Account where username = 'np123' and password = '123'