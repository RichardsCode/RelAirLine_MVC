CREATE TABLE [dbo].[Customer]
(
	[CustomerId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [MiddleName] NVARCHAR(50) NULL, 
    [Suffix] NVARCHAR(50) NULL, 
    [BirthDate] DATE NOT NULL, 
    [Gender] NVARCHAR(50) NULL, 
    [PhoneNumber] INT NULL, 
    [AddressLine1] NVARCHAR(MAX) NOT NULL, 
    [AdressLine2] NVARCHAR(MAX) NULL, 
    [ZipCode] NVARCHAR(50) NOT NULL, 
    [City] NVARCHAR(50) NOT NULL, 
    [State] NVARCHAR(100) NOT NULL, 
    [EmailAddress] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL

)
