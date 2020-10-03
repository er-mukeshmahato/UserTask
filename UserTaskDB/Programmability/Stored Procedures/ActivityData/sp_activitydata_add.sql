create PROCEDURE [dbo].[sp_activitydata_add]
	@taskid int,
	@userId int,
	@assignTime nvarchar(max),
	@completedTime nvarchar(max),
	@status nvarchar(max),
	@name nvarchar(max),
	@fullname nvarchar(max)
AS
	insert into ActivityData(TaskId,UserId,AssignedDate,CompletedDate,Status,Name,Fullname)values(@taskid,@userId,@assignTime,@completedTime,@status,@name,@fullname)
RETURN 0
