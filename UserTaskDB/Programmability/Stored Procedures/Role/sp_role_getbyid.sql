
CREATE PROCEDURE [dbo].[sp_role_getbyid]
	@id int 
AS
	SELECT RoleName from Role where Id=@id

RETURN 0
