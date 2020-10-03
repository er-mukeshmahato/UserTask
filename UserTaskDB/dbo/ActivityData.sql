CREATE TABLE [dbo].[ActivityData]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [TaskId] INT NULL, 
    [UserId] INT NULL, 
    [AssignedDate] NVARCHAR(50) NULL, 
    [CompletedDate] NVARCHAR(50) NULL, 
    [Status] NVARCHAR(MAX) NULL, 
    [Name] NVARCHAR(MAX) NULL, 
    [Fullname] NVARCHAR(MAX) NULL
)
