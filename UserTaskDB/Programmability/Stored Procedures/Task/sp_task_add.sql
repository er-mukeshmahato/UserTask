Create PROCEDURE [dbo].[sp_task_add]
	@name nvarchar(50)
  
   


 AS
	Begin
    declare @date datetime
	set @date = (SELECT GETDATE())
    INSERT INTO Task(Name,Created) VALUES (@name,@date)
   
    end







