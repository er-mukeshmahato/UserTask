CREATE PROCEDURE [dbo].[sp_role_getbyname]
	@name nvarchar(50)

AS
Begin
	SELECT Id from Role where RoleName=@name
End
