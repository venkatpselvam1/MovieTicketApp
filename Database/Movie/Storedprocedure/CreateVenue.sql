CREATE PROCEDURE [movie].[CreateVenue]
	@Id UNIQUEIDENTIFIER,
	@Name nvarchar(250),
	@Description nvarchar(250)
AS
	INSERT INTO movie.Venue (Id, Name, Description) values (@Id, @Name, @Description)
	SELECT * FROM movie.Venue where Id = @Id
RETURN 0
