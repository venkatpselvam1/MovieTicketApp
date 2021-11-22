CREATE PROCEDURE [movie].[GetMovieById]
	@Id UNIQUEIDENTIFIER 
AS
	SELECT * FROM movie.Movie where Id = @Id
GO
