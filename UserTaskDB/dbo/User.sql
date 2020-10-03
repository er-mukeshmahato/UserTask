CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
   
    [Email] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(MAX) NULL, 
    [FullName] NVARCHAR(MAX) NULL, 
    [CreatedOn] NVARCHAR(50) NULL, 
    [Address] NVARCHAR(50) NULL, 
    [PhoneNo] NUMERIC NULL
)
