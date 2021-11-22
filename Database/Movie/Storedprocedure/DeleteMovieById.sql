CREATE PROCEDURE [movie].[DeleteMovieById]
	@Id UNIQUEIDENTIFIER = 0
AS
	DELETE FROM movie.Movie where Id = @Id
GO