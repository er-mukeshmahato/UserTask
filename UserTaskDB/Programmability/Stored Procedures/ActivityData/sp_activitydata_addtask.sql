CREATE PROCEDURE [dbo].[sp_activitydata_addtask]
	@fullname nvarchar(max),
	@name nvarchar(max),
	@status nvarchar(max),
	@id int
AS
	insert into ActivityData(Name,Fullname,Status, UserId,TaskId,CompletedDate,AssignedDate)values(@name,@fullname,@status,@id,0,null,null)
RETURN 0
