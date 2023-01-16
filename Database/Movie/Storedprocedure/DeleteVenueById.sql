CREATE PROCEDURE [movie].[DeleteVenueById]
	@Id UNIQUEIDENTIFIER
AS
	DELETE FROM movie.Show where VenueId = @Id
	DELETE FROM movie.Venue where Id = @Id
GO