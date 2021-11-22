CREATE PROCEDURE [movie].[DeleteMovieById]
	@Id UNIQUEIDENTIFIER
AS
	DELETE FROM movie.Movie where Id = @Id
GO