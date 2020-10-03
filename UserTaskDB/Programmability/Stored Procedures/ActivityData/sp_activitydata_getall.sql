CREATE PROCEDURE [dbo].[sp_activitydata_getall]
	
AS
	SELECT Name,Fullname,TaskId,Status,UserId,CompletedDate,AssignedDate from ActivityData
RETURN 0
