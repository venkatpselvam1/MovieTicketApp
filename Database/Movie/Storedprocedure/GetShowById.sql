CREATE PROCEDURE [movie].[GetShowById]
	@Id UNIQUEIDENTIFIER 
AS
	SELECT * FROM movie.Show where Id = @Id
GO
