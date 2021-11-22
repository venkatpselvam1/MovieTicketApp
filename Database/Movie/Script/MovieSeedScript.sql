-- dlete previouse entry
delete from movie.Movie
delete from movie.Language
delete from movie.Rating

--insert into the languages table
insert into movie.Language (id, Name) values (0,'Unknown')
insert into movie.Language (id, Name) values (1,'Tamil')
insert into movie.Language (id, Name) values (2,'English')
insert into movie.Language (id, Name) values (3,'Telugu')
insert into movie.Language (id, Name) values (4,'Kannada')
insert into movie.Language (id, Name) values (5,'Hindhi')
insert into movie.Language (id, Name) values (6,'Malayalam')

--insert into the Rating table
insert into movie.Rating(id, Name) values (0,'Unknown')
insert into movie.Rating(id, Name) values (1,'Unrestricted')
insert into movie.Rating(id, Name) values (2,'ParentalGuidance')
insert into movie.Rating(id, Name) values (3,'RestrictedToAdults')
insert into movie.Rating(id, Name) values (4,'RestrictedToSpecificGroup')

--insert into the movies table
insert into movie.Movie (Id, Name, Description, LanguageId, RatingId) values ('d410b464-0c0b-43e9-b50f-044b4a19ab9e', 'Bahubali', 'Bahubali movie', 3, 1)
insert into movie.Movie (Id, Name, Description, LanguageId, RatingId) values ('227155b2-60cf-4658-853f-ad0720f5620f', 'Annathe', 'Annathe rajini movie', 1, 1)
GO