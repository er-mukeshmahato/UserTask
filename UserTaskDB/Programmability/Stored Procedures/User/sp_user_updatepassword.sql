CREATE PROCEDURE [dbo].[sp_user_updatepassword]
	@Id int,
	@password nvarchar(100)
	
AS
BEGIN
UPDATE [dbo].[User] set Password=@password where Id=@Id
END
