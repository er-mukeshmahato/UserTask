CREATE PROCEDURE [dbo].[sp_user_getall]
	
AS
Begin
	SELECT FullName,Email,Password,Address,PhoneNo,Id,CreatedOn from [dbo].[User]
end
