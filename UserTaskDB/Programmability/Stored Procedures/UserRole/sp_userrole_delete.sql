CREATE PROCEDURE [dbo].[sp_userrole_delete]
@id int
As
begin
select * from UserRole where UserId=@id 
end
