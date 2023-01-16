-- dlete previouse entry
delete from movie.Show
delete from movie.Movie
delete from movie.Language
delete from movie.Rating
delete from movie.Venue

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

--insert into the venues table
insert into movie.Venue(Id, Name, Description) values ('83b01d7e-bdce-4d0b-834a-e908c7d0d334', 'Venue-1', 'North side venue')
insert into movie.Venue(Id, Name, Description) values ('c12995d4-96ee-48ff-a7ca-d7e6d5f52d06', 'Venue-2', 'South side venue')

--insert into the shows table
insert into movie.Show(Id, MovieId, VenueId, ShowDateTime) values ('741da27b-de47-4bcb-9ca6-2e901162bba2', '227155b2-60cf-4658-853f-ad0720f5620f', '83b01d7e-bdce-4d0b-834a-e908c7d0d334', '2023-01-16 10:00:00.000')
insert into movie.Show(Id, MovieId, VenueId, ShowDateTime) values ('17c5701f-3b58-4b1f-a235-0eacba8b6597', 'd410b464-0c0b-43e9-b50f-044b4a19ab9e', '83b01d7e-bdce-4d0b-834a-e908c7d0d334', '2023-01-16 14:00:00.000')

insert into movie.Show(Id, MovieId, VenueId, ShowDateTime) values ('d202fd16-acde-42b4-84df-00cb44337c03', '227155b2-60cf-4658-853f-ad0720f5620f', 'c12995d4-96ee-48ff-a7ca-d7e6d5f52d06', '2023-01-16 10:00:00.000')
insert into movie.Show(Id, MovieId, VenueId, ShowDateTime) values ('0a61e520-45c1-4e59-ba77-ac727e5fabf9', 'd410b464-0c0b-43e9-b50f-044b4a19ab9e', 'c12995d4-96ee-48ff-a7ca-d7e6d5f52d06', '2023-01-16 18:00:00.000')
GO