CREATE PROCEDURE [dbo].[spGetVaccineById]
	@Id int
AS 
begin

	SELECT * from [dbo].[Vaccines] where Id = @Id;
	end;

