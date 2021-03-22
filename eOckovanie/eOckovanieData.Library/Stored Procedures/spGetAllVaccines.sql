CREATE PROCEDURE [dbo].[spGetAllVaccines]

AS
begin
set nocount on;
	SELECT * from [dbo].[Vaccines];
	end;
