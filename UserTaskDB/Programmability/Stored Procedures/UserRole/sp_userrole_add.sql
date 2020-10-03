CREATE PROCEDURE [dbo].[sp_userrole_add]
	@roleid int,
	@userid int
AS
begin
	insert into UserRole(RoleId,UserId) values(@roleid,@userid)
end
