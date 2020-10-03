Create PROCEDURE [dbo].[sp_activity_update]
    @id int,
	@completed bit,
	@completeddate nvarchar(max),
	@status nvarchar(max)



AS
	update  Activity set Completed=@completed,CompletedDate=@completeddate,Status=@status where Id=@id
RETURN 0
