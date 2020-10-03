CREATE PROCEDURE [dbo].[sp_user_update]
	@id int,
    @email nvarchar(max),
    @password nvarchar(max),
    @phone numeric,
    @address nvarchar(max),
    @fullname  nvarchar(max)
AS
	 update  [dbo].[User] set Email=@email, Password=@password,PhoneNo=@phone,Address=@address,FullName=@fullname  where Id=@id
RETURN 0

