CREATE PROCEDURE [movie].[CreatShow]
	@Id UNIQUEIDENTIFIER,
	@MovieId UNIQUEIDENTIFIER,
	@VenueId UNIQUEIDENTIFIER,
	@ShowDateTime DATETIME
AS
	INSERT INTO movie.Show (Id, MovieId, VenueId, ShowDateTime)
	values (@Id, @MovieId, @VenueId, @ShowDateTime)
	SELECT * FROM movie.Show where Id = @Id
RETURN 0