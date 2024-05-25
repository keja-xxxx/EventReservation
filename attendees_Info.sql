CREATE TABLE [dbo].[member_Info]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [PhoneNumber] INT NOT NULL, 
    [Address] VARCHAR(MAX) NOT NULL
)
