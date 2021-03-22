CREATE PROCEDURE [dbo].[spGetAllDoctors]
AS
begin
set nocount on;
	SELECT * from [dbo].[Doctor];
	end;