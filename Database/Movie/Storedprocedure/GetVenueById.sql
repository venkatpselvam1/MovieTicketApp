CREATE PROCEDURE [movie].[GetVenueById]
	@Id UNIQUEIDENTIFIER 
AS
	SELECT * FROM movie.Venue where Id = @Id
GO
