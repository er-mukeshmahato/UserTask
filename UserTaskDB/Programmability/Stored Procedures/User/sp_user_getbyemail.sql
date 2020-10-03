CREATE PROCEDURE [dbo].[sp_user_getbyemail]
	@email nvarchar(50) 
AS
	SELECT FullName,Id,Password from [dbo].[User] where Email=@email
RETURN 0
