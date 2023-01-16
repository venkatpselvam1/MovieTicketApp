CREATE PROCEDURE [movie].[DeleteShowById]
	@Id UNIQUEIDENTIFIER
AS
	DELETE FROM movie.Show where Id = @Id
GO