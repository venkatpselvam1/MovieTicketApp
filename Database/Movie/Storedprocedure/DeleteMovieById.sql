CREATE PROCEDURE [movie].[DeleteMovieById]
	@Id UNIQUEIDENTIFIER
AS
	DELETE FROM movie.Show where MovieId = @Id
	DELETE FROM movie.Movie where Id = @Id
GO