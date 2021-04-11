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
	Id int PRIMARY KEY,
	NameEmployee nvarchar(256) NOT NULL,
	Gender BIT,
	Phone nvarchar(256),
	Email nvarchar(256),
	JobPosition nvarchar(256),
	Salary float ,
	CaseType nvarchar(256) References CASEWORK(CaseType)
	
);

CREATE table WORK(
IdEmp int REFERENCES EMPLOYEE(Id) ,
CheckIn DateTime,
CheckOut DATETime,
Constraint pk_Work PRIMARY KEY (IdEmp)


);
--
go

CREATE TABLE SALARY (
	IdEmp int ,
	CheckIn DATETIME NOT NULL,
	CheckOut DATETime NOT NULL,
	TotalHour int,
	Reward float,
	TotalSalary float,
	 CONSTRAINT fk_id FOREIGN KEY (idEmp) REFERENCEs EMPLOYEE(Id),
	 CONSTRAINT pk_Salary PRIMARY KEY (idEmp,CheckIn,CheckOut)

);

CREATE table Customer(
Phone nvarchar(256) Primary key,
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


CREATE TABLE MOVIE(
IDmovie int PRImary KEY,
NameMovie nvarchar(256),
Producer nvarchar(256),
TotalTime Time,
ShowDate DateTime,
TypeMovie nvarchar(256) ,
EvaluteStar int,

constraint fk_TypeMovie_TypeMovie FOREIGN KEY(TypeMovie) REFERENCES TYPEOFMOVIE(TypeID)

)
--

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
CREATE TABLE SEATROOMSTATUS(
RoomID int REFERENCES ROOM(RoomId),
ColumnRoom int,
RowRoom int,
StatuSeat BIT,
CONSTRAINT pk_seatRoom PRIMARY KEY(RoomID,ColumnRoom,RowRoom)





)

CREATE TABLE MOVIESHOWTIME(
	IDMovie int ,
	RoomId int,
	ShowTime DateTime,
	EndTime DateTime,
	TotalTime Time,
	Constraint fk_IDmovie_Movie FOREiGN KEY (IDMovie) REFERENCES MOVIE(IDmovie),
	Constraint fk_RoomId_Room FOREiGN KEY (RoomId) REFERENCES ROOM(RoomId),
	Constraint pk_MovieShowTime PRIMARY KEY(IDMovie,RoomId,ShowTime)
	


);
--
go

CREATE TABLE BILL(
Billid nvarchar(256),
IdEmp  int REFERENCES EMPLOYEE(Id),
NameEmp nvarchar(256) ,

PhoneCus nvarchar(256) REFERENCES CUSTOMER(Phone),
NameCus nvarchar(256) ,
TypeTicket nvarchar(256) REFERENCES TYPETICKET(TypeTicket),
Number int,
Price float,
IDmovie int references MOVIE(IDmovie),
NameMovie text ,
RoomID int REFERENCES ROOM(RoomId)



);
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














