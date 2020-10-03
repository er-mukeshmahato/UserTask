create PROCEDURE [dbo].[sp_activity_taskidbyuserid]
@id int
AS
	SELECT TaskId from Activity where UserId=@id
RETURN 0
