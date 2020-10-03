CREATE PROCEDURE [dbo].[sp_task_getbyid]
	@id int
AS
	SELECT Name from Task where Id=@id
RETURN 0
