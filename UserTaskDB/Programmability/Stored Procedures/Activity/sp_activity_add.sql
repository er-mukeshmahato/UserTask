create PROCEDURE [dbo].[sp_activity_add]
	@taskId int,
	@userId int,
	@status nvarchar(max),
	@name nvarchar(max)
	
AS

    declare @date datetime
	set @date = (SELECT GETDATE())
	insert into Activity(TaskId,Status,UserId,AssignedTime,CompletedDate,Completed,Assign,Name)values(@taskId,@status,@userId,@date,null,0,1,@name) 
RETURN 0
