CREATE PROCEDURE [dbo].[sp_activity_delete]
	@id int
AS
Begin
	delete from Activity where Id=@id
End
