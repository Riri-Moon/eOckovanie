CREATE PROCEDURE [dbo].[spGetAllAppointmentsForOneUser]
@Id nvarchar(128)
AS
begin
set nocount on;
	SELECT * from [dbo].[Appointment] where userId=@Id;
	end;