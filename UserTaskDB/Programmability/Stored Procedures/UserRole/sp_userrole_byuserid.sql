CREATE PROCEDURE [dbo].[sp_userrole_byuserid]
	@id int 
	
as
begin
select RoleId from UserRole where UserId=@id
end



