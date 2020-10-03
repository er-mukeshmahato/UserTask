CREATE PROCEDURE [dbo].[sp_user_delete]
	@UserId int 
	
AS
	BEGIN
		DELETE FROM [dbo].[User] WHERE Id = @UserId;
	END
GO
