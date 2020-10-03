CREATE PROCEDURE [dbo].[sp_role_add]

@Name nvarchar(100)

As
Begin
insert into Role(RoleName)Values(@Name)
end

