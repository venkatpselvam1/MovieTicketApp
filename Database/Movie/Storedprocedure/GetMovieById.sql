CREATE PROCEDURE [movie].[GetMovieById]
	@Id UNIQUEIDENTIFIER = 0
AS
	SELECT * FROM Movie.Movie where Id = @Id
GO
