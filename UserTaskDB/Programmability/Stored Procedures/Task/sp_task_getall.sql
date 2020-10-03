CREATE PROCEDURE [dbo].[sp_task_getall]
	
AS
	select Name,Id from Task
RETURN 0
