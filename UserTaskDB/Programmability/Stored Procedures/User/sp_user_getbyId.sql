CREATE PROCEDURE [dbo].[sp_user_getbyId]
	@id int 
AS
	SELECT FullName,Email,Password,Address,PhoneNo from [dbo].[User] where Id=@id
RETURN 0
