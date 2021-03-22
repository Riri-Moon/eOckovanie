CREATE PROCEDURE [dbo].[spGetDoctorById]
	@Id int
AS 
begin

	SELECT * from [dbo].[Doctor] where Id = @Id;
	end;
