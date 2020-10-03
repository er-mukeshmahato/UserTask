CREATE TABLE [dbo].[UserRole]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [RoleId] INT NULL, 
    [UserId] INT NULL
)
