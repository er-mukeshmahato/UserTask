CREATE PROCEDURE [dbo].[sp_task_delete]
		@id int 
	
AS
	BEGIN
		DELETE FROM Task WHERE Id = @id;
	END
GO

