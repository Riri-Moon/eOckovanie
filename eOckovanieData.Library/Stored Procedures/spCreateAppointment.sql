CREATE PROCEDURE [dbo].[spCreateAppointment]
	@DoctorId int,
	@UserId nvarchar(128),
	@Time1 Time(7),
	@Time2 Time(7),
	@Status nvarchar(20),
	@Location nvarchar(50),
	@VaccineId int,
	@Date date

AS
begin
	Insert INTO  [dbo].[Appointment] (docId,userId,time1,time2,status,location,vacId,Date) 
	values (@DoctorId,@UserId,@Time1,@Time2,@Status,@Location,@VaccineId,@Date)
	end;