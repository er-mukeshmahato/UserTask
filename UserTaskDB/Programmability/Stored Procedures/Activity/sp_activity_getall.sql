create PROCEDURE [dbo].[sp_activity_getall]
	
AS
	SELECT Id,Name,TaskId,UserId,AssignedTime,Completed,CompletedDate,Status,Assign from Activity
RETURN 0
