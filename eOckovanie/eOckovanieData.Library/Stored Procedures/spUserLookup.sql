CREATE PROCEDURE [dbo].[spUserLookup]
	@Id nvarchar(128)
	
AS
begin
set nocount on;
	SELECT Id,firstName,lastName,pin,Email,PhoneNumber,insuranceCompany from [dbo].[AspNetUsers] where Id=@Id;
	end;