CREATE PROCEDURE [movie].[DeleteMovieById]
	@Id UNIQUEIDENTIFIER = 0
AS
	DELETE FROM Movie.Movie where Id = @Id
GO