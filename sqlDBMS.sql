CREATE DATABASE DBMS;
--
go
use DBMS;

Create table CASEWORK(

	CaseType nvarchar(256) Primary key,
	NameCase nvarchar(256) ,
	TimeWork int
);

Create table EMPLOYEE(
	IDEmp int PRIMARY KEY,
	NameEmployee nvarchar(256) NOT NULL,
	Gender BIT,
	Phone nvarchar(256),
	Email nvarchar(256),
	JobPosition nvarchar(256),
	BirthDay datetime,
	
	CaseType nvarchar(256) References CASEWORK(CaseType)
	
);

CREATE table WORK(
IDEmp int REFERENCES EMPLOYEE(IDEmp) ,
CheckIn DateTime,
CheckOut DATETime,
Constraint pk_Work PRIMARY KEY (IdEmp,CheckIn,CheckOut)


);
--
go

CREATE TABLE SALARY (
	salaryID int PRIMARY KEY,
	IDEmp int ,
	hour_Work Time,

	
	Reward float,
	TotalSalary float,
	 CONSTRAINT fk_id FOREIGN KEY (IDEmp) REFERENCEs EMPLOYEE(IDEmp),
	

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
nameMovie nvarchar(256),
director nvarchar(256),
TotalTime int,

typeMovie nvarchar(256) ,
EvaluteStar float,

constraint fk_TypeMovie_TypeMovie FOREIGN KEY(typeMovie) REFERENCES TYPEOFMOVIE(TypeID)

)
--

go

CREATE TABLE SHOWTIME(
showTimeID int PRIMARY KEY,
startTime DATETIME,
endTime DATETIME

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
roomId int PRIMARY KEY,

RoomStatus BIT

);
CREATE TABLE ROOMSEAT(
roomSeatID int  PRIMARY KEY,
roomID int REFERENCES ROOM(roomId),
SeatNumber INT,
TypeSeat int,
SeatStatus BIT,






)

CREATE TABLE MOVIESHOWTIME(
	showTimeID int PRIMARY KEY,
	IDMovie int REFERENCES MOVIE(IDMovie) ,
	roomId int REFERENCES ROOM(roomId),
	
	TotalTime Time,
	
	
	
	


);
--
go

CREATE TABLE BILL(
Billid nvarchar(256) PRIMARY KEY,
IDEmp int REFERENCES EMPLOYEE(IDEmp),
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

















