CREATE PROCEDURE [dbo].[sp_activity_getbyid]
	@id int
AS
	SELECT * from Activity where Id=@id
RETURN 0
