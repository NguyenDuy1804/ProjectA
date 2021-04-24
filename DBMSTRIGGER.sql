USE DBMS;

go
--CREATE TRiGGER
--trigger Employee check salary > 300000
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
--trigger check age of employee when insert update
CREATE TRIGGER tg_CheckAgeOfEmployee
ON EMPLOYEE
FOR INSERT ,UPDATE
AS
BEGIN
	declare @day int ,@dateBirth datetime,@nowDate datetime,@age float
	SELECT @dateBirth = ise.BirthDay FROM inserted ise
	SELECT @nowDate=GETDATE();
	
	--get difference between years 
	--set @year=DATEPART(dd,@nowDate)-DATEPART(dd,@dateBirth);
	--set @month=DATEPART(mm,@nowDate)-DATEPART(mm,@dateBirth);
	--set @day=DATEPART(yy,@nowDate)-DATEPART(yy,@dateBirth);
	--seem some the way of happend 
	--first seem that month <0
	SELECT @day=DATEDIFF(dayofyear,@dateBirth,@nowDate);
	set @age=@day/365;
	if(@age<18)
	BEGIN
	print('Not enough age of employee (>18 year old)')
	ROLLBACK tran;
	return
	END



END






go
---trigger check starttime and end time of SHOW time >= totaltime of movieshowtime
---may be it not need
CREATE TRIGGER tg_checkTotalTimeShowTime
ON SHOWTIME
FOR INSERT ,UPDATE
AS

BEGIN
	Declare @totalTime time,@timeOfMovie time
	--we get different of hour two time
	SELECT @totalTime=DATEDIFF(hour,show.StartTime,show.EndTime) FROM SHOWTIME show
	select @timeOfMovie=TotalTime FROM MOVIESHOWTIME

	if(@totalTime<DATEPART(HOUR,@timeOfMovie))
	BEGIN
	print('edit again totaltime')
	rollback tran
	return
	END

END

go
-- function compute total salary
--image how to compute salary
--check the image 
go
CREATE FUNCTION computeTotalSalary()
returns table 
AS

----return a table 
	--get type of employee(manager ) , 
	--computer hour check_In and check_Out 

RETURN	SELECT sum(DATEPART(hour,CheckOut)-DATEPART(hour,CheckIn)) as syn
	FROM WORK w JOIN EMPLOYEE e ON w.IDEmp=e.IDEmp
	GROUP by e.IDEmp,DATEPART(mm,CheckOut)


	---
	go







---

