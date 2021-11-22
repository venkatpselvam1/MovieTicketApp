CREATE PROCEDURE [movie].[GetMovieById]
	@Id UNIQUEIDENTIFIER = 0
AS
	SELECT * FROM movie.Movie where Id = @Id
GO
