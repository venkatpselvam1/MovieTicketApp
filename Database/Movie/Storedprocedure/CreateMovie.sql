CREATE PROCEDURE [movie].[CreateMovie]
	@Id UNIQUEIDENTIFIER,
	@Name nvarchar(250),
	@Description nvarchar(250),
	@Language int = 0,
	@Rating int = 0
AS
	INSERT INTO movie.Movie (Id, Name, Description, LanguageId, RatingId) values (@Id, @Name, @Description, @Language, @Rating)
	SELECT * FROM movie.Movie where Id = @Id
RETURN 0