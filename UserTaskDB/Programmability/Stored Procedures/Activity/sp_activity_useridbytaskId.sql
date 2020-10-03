Create PROCEDURE [dbo].[sp_activity_useridbytaskId]
@id int
AS
	SELECT UserId from Activity where TaskId=@id
RETURN 0