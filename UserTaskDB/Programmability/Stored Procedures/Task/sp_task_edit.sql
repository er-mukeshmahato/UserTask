CREATE PROCEDURE [dbo].[sp_task_edit]
    @id int,
	@name nvarchar(50)
   


 AS
 begin
 UPDATE  Task set Name=@name where Id=@id
 end
