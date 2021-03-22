CREATE PROCEDURE [dbo].[spGetAllAppointments]

AS
begin
set nocount on;
	SELECT * from [dbo].[Appointment];
	end;