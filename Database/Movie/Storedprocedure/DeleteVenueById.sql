CREATE PROCEDURE [movie].[DeleteVenueById]
	@Id UNIQUEIDENTIFIER
AS
	DELETE FROM movie.Venue where Id = @Id
GO