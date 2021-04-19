CREATE DATABASE DBMS;
--
go
use DBMS;

Create table CASEWORK(

	CaseType nvarchar(256) Primary key,
	NameCase nvarchar(256) ,
	TimeWork Time 
);

Create table EMPLOYEE(
	ID int PRIMARY KEY,
	NameEmployee nvarchar(256) NOT NULL,
	Gender BIT,
	Phone nvarchar(256),
	Email nvarchar(256),
	JobPosition nvarchar(256),
	
	CaseType nvarchar(256) References CASEWORK(CaseType)
	
);

CREATE table WORK(
IDEmp int REFERENCES EMPLOYEE(ID) ,
CheckIn DateTime,
CheckOut DATETime,
Constraint pk_Work PRIMARY KEY (IdEmp,CheckIn,CheckOut)


);
--
go

CREATE TABLE SALARY (
	IDSalary int PRIMARY KEY,
	IdEmp int ,
	CheckIn DATETIME NOT NULL,
	CheckOut DATETime NOT NULL,
	TotalHour int,
	Reward float,
	TotalSalary float,
	 CONSTRAINT fk_id FOREIGN KEY (idEmp) REFERENCEs EMPLOYEE(ID),
	

);

CREATE table CUSTOMER(
IDCustomer int PRIMARY KEY,
Phone nvarchar(256) ,
NameCus nvarchar(256) ,
Gender BIT,
BirthDay DateTIme,
TotalPrice float


);

CREATE TABLE TYPEOFMOVIE(
	TypeID nvarchar(256) PRIMARY KEY ,
	NameType nvarchar(256)
	);
	-----


	go

CREATE TABLE MOVIE(
IDMovie int PRImary KEY,
NameMovie nvarchar(256),
Producer nvarchar(256),
TotalTime Time,

TypeMovie nvarchar(256) ,
EvaluteStar int,

constraint fk_TypeMovie_TypeMovie FOREIGN KEY(TypeMovie) REFERENCES TYPEOFMOVIE(TypeID)

)
--

go

CREATE TABLE SHOWTIME(
ShowTimeID int PRIMARY KEY,
StartTime DATETIME,
EndTime DATETIME

)

--
go


CREATE TABLE TYPETICKET(
TypeTicket nvarchar(256) PRIMARY KEY,
TypeTicketName nvarchar(256),
Price float

);
---

CREATE TABLE ROOM(
RoomId int PRIMARY KEY,

RoomStatus BIT

);
CREATE TABLE ROOMSEAT(
RomSeatID int  PRIMARY KEY,
RoomID int REFERENCES ROOM(RoomId),
SeatNumber INT,
TypeSeat int,
StatuSeat BIT,






)

CREATE TABLE MOVIESHOWTIME(
	showTimeID int PRIMARY KEY,
	IDMovie int REFERENCES MOVIE(IDMovie) ,
	RoomId int REFERENCES ROOM(RoomId),
	ShowTime DateTime,
	EndTime DateTime,
	TotalTime Time,
	Constraint fk_IDmovie_Movie FOREiGN KEY (IDMovie) REFERENCES MOVIE(IDmovie),
	Constraint fk_RoomId_Room FOREiGN KEY (RoomId) REFERENCES ROOM(RoomId),
	
	


);
--
go

CREATE TABLE BILL(
Billid nvarchar(256) PRIMARY KEY,
IdEmp int REFERENCES EMPLOYEE(ID),
IDCustomer int REFERENCES CUSTOMER(IDCustomer),
Number int,
typeTicket nvarchar(256) REFERENCES TYPETICKET(TypeTicket),
Price FLOAT



);
--
go
CREATE TABLE BOOKING(
bookID int PRIMARY KEY,
CustomerID int REFERENCES CUSTOMER(IDCustomer),
movieShowTimeID int REFERENCES MOVIESHOWTIME(showTimeID),
BillID nvarchar(256) REFERENCES Bill(Billid)

)

--create trigger
go

--trigger Employee
CREATE TRIGGER check_salary ON SALARY
FOR INSERT,UPDATE
AS
BEGIN
	declare @totalSalary float;
	SELECT @totalSalary=inserted.TotalSalary FROM inserted;
	if(@totalSalary<30000000)
	BEGIN
	print('totalSalary need > 3000000')
	ROLLBACK TRAN

	END

END
---trigger check room have already showtime or not
go

CREATE TRIGGER tg_room_free
ON MOVIESHOWTIME
FOR INSERT,UPDATE
AS
BEGIN 
	declare @idRoom nvarchar(256),@roomStatus bit
	select @idRoom=inserted.RoomId FROM inserted
	select @roomStatus=Room.RoomStatus FROM ROOM
	if(@roomStatus=1)
	BEGIn
		print('Already movie show time in this Rooom')
		ROLLBACK TRAN
	END
	

END

---
go














