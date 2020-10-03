CREATE PROCEDURE [dbo].[sp_role_delete]
	@id int 
AS
begin
	Delete  from Role where Id=@id
end
