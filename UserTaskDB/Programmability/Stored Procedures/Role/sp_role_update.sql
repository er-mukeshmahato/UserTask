CREATE PROCEDURE [dbo].[sp_role_update]
	@id int = 0,
	@name nvarchar(50)
AS
Begin
	update  Role set RoleName=@name where Id=@id
End
