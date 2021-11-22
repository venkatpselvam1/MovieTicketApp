CREATE TABLE [movie].[Movie]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(250) NOT NULL, 
    [Description] NVARCHAR(1500) NOT NULL, 
    [LanguageId] INT NOT NULL, 
    [RatingId] INT NOT NULL
)
