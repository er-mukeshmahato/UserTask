CREATE TABLE [dbo].[Activity]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [UserId] INT NULL, 
    [AssignedTime] NVARCHAR(MAX) NULL, 
    [Completed] BIT NULL, 
    [Status] NVARCHAR(50) NULL, 
    [CompletedDate] NVARCHAR(MAX) NULL, 
    [TaskId] INT NULL, 
    [Assign] BIT NULL, 
    [Name] NVARCHAR(MAX) NULL
)
