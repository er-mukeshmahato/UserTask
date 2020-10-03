CREATE PROCEDURE [dbo].[sp_user_add]
	@email nvarchar(max),
    @password nvarchar(max),
    @phone numeric,
    @address nvarchar(max),
    @fullname  nvarchar(max)
AS
   declare @date datetime
	set @date = (SELECT GETDATE())
	 INSERT INTO [dbo].[User](FullName,Email,PhoneNo,Address,Password,CreatedOn) VALUES (@fullname,@email,@phone,@address,@password,@date)
RETURN 0
 