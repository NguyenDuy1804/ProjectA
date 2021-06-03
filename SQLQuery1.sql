
CREATE PROC USP_check
@userName nvarchar(256) , @per int
as
SELECT _Username, _Password FROM [dbo].[ACCOUNT] WHERE _Username = @userName AND _Permission = @per

go




CREATE PROC USP_checkEmployeeName 
@id nvarchar(256)
as
SELECT NameEmployee FROM[dbo].[EMPLOYEE] WHERE IDEmp = @id
go



CREATE PROC USP_login
@userName nvarchar(256) ,@pass nvarchar(256) 
as
SELECT _Username, _Password FROM [dbo].[ACCOUNT] WHERE _Username = @userName 



go
create proc USP_getAllEmployee
as
SELECT IDEmp AS ID, NameEmployee As 'Full Name', BirthDay AS 'Birth Day', Gender, Phone, Email, JobPosition AS' Position' FROM[dbo].[EMPLOYEE]

go


create function dbo.USF_getEmployeeByID
(
@idEmp nvarchar(256)
)

returns  table
as


	return SELECT IDEmp AS 'ID', NameEmployee As 'Full Name', BirthDay AS 'Birth Day', Gender, Phone, Email, JobPosition AS' Position' FROM [dbo].[EMPLOYEE] where IDEmp=@idEmp


go

go
create proc USP_searchEmployeeByID
@idEmp nvarchar(256)
as
	select * from dbo.USF_getEmployeeByID(@idEmp)
go


-------------------
CREATE TRIGGER tg_CheckAgeOfEmployee
ON EMPLOYEE
FOR INSERT ,UPDATE
AS
BEGIN
declare @day int, @dateBirth datetime, @nowDate datetime, @age float
SELECT @dateBirth = ise.BirthDay FROM inserted ise
SELECT @nowDate=GETDATE();
SELECT @day=DATEDIFF(dayofyear,@dateBirth,@nowDate);
set @age=@day/365;
if(@age<18)
BEGIN
print('Not enough age of employee (>18 year old)')
ROLLBACK tran;
return
END
END
----------------------
CREATE TRIGGER tg_checkTotalTimeShowTime
ON SHOWTIME
FOR INSERT, UPDATE
AS
BEGIN
Declare @totalTime datetime,@timeOfMovie datetime
SELECT @totalTime= DATEDIFF(hour,show.startTime,show.endTime) FROM SHOWTIME show
select @timeOfMovie = TotalTime FROM MOVIESHOWTIME
if(@totalTime < DATEPART(HOUR,@timeOfMovie))
BEGIN
print('edit again totaltime')
rollback tran
return
END

END
---------------------------
CREATE TRIGGER check_salary ON SALARY
FOR INSERT, UPDATE
AS
BEGIN
declare @totalSalary float;
SELECT @totalSalary = inserted.TotalSalary FROM inserted;
if(@totalSalary < 30000000)
BEGIN
print('totalSalary need > 3000000')
ROLLBACK TRAN
END
ENd
-------
CREATE TRIGGER tg_room_free
ON MOVIESHOWTIME
FOR INSERT, UPDATE
AS
BEGIN 
declare @idRoom nvarchar(256), @roomStatus bit
select @idRoom = inserted.roomId FROM inserted
select @roomStatus = Room.RoomStatus FROM ROOM
if(@roomStatus = 1)
BEGIn
print('Already movie show time in this Rooom')
ROLLBACK TRAN
END
END
------ Function
go
CREATE FUNCTION computeTotalSalary()
RETURNS TABLE 
AS
RETURN 
SELECT SUM(DATEPART(hour,CheckOut-DATEPART(hour,CheckIn)) AS syn
FROM WORK w JOIN EMPLOYEE e ON w.IDEmp=e.IDEmp
GROUP BY e.IDEmp,DATEPART(mm,CheckOut)

----------


---
















--go

insert into ACCOUNT(_Username,_Password,_Permission) values('np123','123',1)

insert into ACCOUNT(_Username,_Password,_Permission) values('np12345','123',2)


----insert data
insert into CASEWORK(CaseType,NameCase,TimeWork) values('PART','Part time',8);
insert into CASEWORK(CaseType,NameCase,TimeWork) values('FULL','Full time',12);


--insert into 
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('111',N'Nguyễn Hồng Tuấn',0,'0987011701','binnam0147@gmail.com','Manager','2001-08-03','PART')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('112',N'Hoàng Khải Ân',1,'0987011701','binnam0147@gmail.com','Sell','2001-08-03','FULL')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('113',N'Bạch Họa',0,'0987011701','binnam0147@gmail.com','Sweeper','2001-08-03','FULL')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('114',N'Trương Khải Hoàn',1,'0987011701','binnam0147@gmail.com','Sweeper','2001-08-03','PART')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('115',N'Lý Nhã Kì',0,'0987011701','binnam0147@gmail.com','Sell','2001-08-03','FULL')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('116',N'Trương Tiểu Lộ',0,'0987011701','binnam0147@gmail.com','Sweeper','2001-08-03','PART')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('117',N'Lý Phúc Khanh',1,'0987011701','binnam0147@gmail.com','Serve','2001-08-03','PART')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('118',N'Trần Trung Kiên',0,'0987011701','binnam0147@gmail.com','Manager','2001-08-03','PART')

insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('119',N'Bạch Tiểu Thuần',1,'0987011701','binnam0147@gmail.com','Serve','2001-08-03','PART')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('120',N'Trương Hoàng',0,'0987011701','binnam0147@gmail.com','Reception','2001-08-03','FULL')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('121',N'Hàn Lộ',1,'0987011701','binnam0147@gmail.com','Clean','2001-08-03','PART')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('122',N'Mộ dung tuyết',0,'0987011701','binnam0147@gmail.com','Clean','2001-08-03','FULL')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('123',N'Nguyễn Chính Trực',1,'0987011701','binnam0147@gmail.com','Reserve','2001-08-03','PART')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('124',N'Tống Văn Nam',1,'0987011701','binnam0147@gmail.com','Manager','2001-08-03','FULL')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('125',N'Trần kiêm',1,'0987011701','binnam0147@gmail.com','Sell','2001-08-03','PART')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('126',N'Nguyễn Thị Mộng Mơ',0,'0987011701','binnam0147@gmail.com','Sell','2001-08-03','FULL')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('127',N'Phạm Nguyễn Yến Nhi',1,'0987011701','binnam0147@gmail.com','Sell','2001-08-03','PART')

insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('128',N'Phạm Thu Trang',0,'0987011701','binnam0147@gmail.com','Serve','2001-08-03','FULL')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('129',N'Nguyễn Hàn Phi Dương',1,'0987011701','binnam0147@gmail.com','Sell','2001-08-03','FULL')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('130',N'Bùi Mạnh Tùng',1,'0987011701','binnam0147@gmail.com','Clean','2001-08-03','FULL')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('131',N'Nguyễn Hồng Sơn',1,'0987011701','binnam0147@gmail.com','Sweeper','2001-12-03','PART')

insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('132',N'Trần Thị Hoài Thương',0,'0987011701','binnam0147@gmail.com','Sweeper','2001-07-03','FULL')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('133',N'Nguyễn Phước Tiệp',1,'0987011701','binnam0147@gmail.com','Serve','2001-06-05','PART')
insert into EMPLOYEE(IDEmp,NameEmployee,Gender,Phone,Email,JobPosition,BirthDay,CaseType) values('134',N'Phạm Toản',0,'0987011701','binnam0147@gmail.com','Serve','2001-08-02','PART')



--movie type
insert into TYPEOFMOVIE(TypeID,NameType) values('01','Drama')
insert into TYPEOFMOVIE(TypeID,NameType) values('02','Romantic')
insert into TYPEOFMOVIE(TypeID,NameType) values('03','Cartoon')
insert into TYPEOFMOVIE(TypeID,NameType) values('04','comedy')
insert into TYPEOFMOVIE(TypeID,NameType) values('05','fantasy film')
insert into TYPEOFMOVIE(TypeID,NameType) values('06','horror film')
insert into TYPEOFMOVIE(TypeID,NameType) values('07','Junvenllie')
insert into TYPEOFMOVIE(TypeID,NameType) values('08','Love Story')
insert into TYPEOFMOVIE(TypeID,NameType) values('09','Musical')

insert into TYPEOFMOVIE(TypeID,NameType) values('10','Thrillet')
insert into TYPEOFMOVIE(TypeID,NameType) values('11','War film')


--data move







insert into MOVIE(IDMovie,nameMovie,director,TotalTime,typeMovie,EvaluteStar) values(1,'When Harry met Sallyy ','B.Crystal',90,'01',3.8)
insert into MOVIE(IDMovie,nameMovie,director,TotalTime,typeMovie,EvaluteStar) values(2,'Titanic ','Leonardo',120,'Dramatic love story',7.9)
insert into MOVIE(IDMovie,nameMovie,director,TotalTime,typeMovie,EvaluteStar) values(3,'City of Angle','N.Cage',90,'romance drama',8.8)
insert into MOVIE(IDMovie,nameMovie,director,TotalTime,typeMovie,EvaluteStar) values(4,'Lolita','J.Robert',90,'Comedy , rommance',7)
insert into MOVIE(IDMovie,nameMovie,director,TotalTime,typeMovie,EvaluteStar) values(5,'Notting Hill','J.ROberts',45,'comendy , romance',6.7)

insert into MOVIE(IDMovie,nameMovie,director,TotalTime,typeMovie,EvaluteStar) values(6,'Interview with Vampire','N.Gibson',60,'action , war ,horror',7)

insert into MOVIE(IDMovie,nameMovie,director,TotalTime,typeMovie,EvaluteStar) values(7,'Brave Heart','A.Tapping',90,'action , adventure,sci-fi',8)

insert into MOVIE(IDMovie,nameMovie,director,TotalTime,typeMovie,EvaluteStar) values(8,'Transformer','S.Labeouf',90,'action , sci-fi',9)

insert into MOVIE(IDMovie,nameMovie,director,TotalTime,typeMovie,EvaluteStar) values(9,'The matrix','K.Reeves',45,'action,sci-fic',9)
insert into MOVIE(IDMovie,nameMovie,director,TotalTime,typeMovie,EvaluteStar) values(10,'8MM','N.Cage',90,'thriller',8)


---data type ticktet
insert into TYPETICKET(TypeTicket,TypeTicketName,Price) values('SINGLEA','Single Seat normal',600)
insert into TYPETICKET(TypeTicket,TypeTicketName,Price) values('DOUBLEA','couple Seat normal',800)



-----


