﻿CREATE TABLE [movie].[Show]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[MovieId] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES movie.Movie(Id),
	[VenueId] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES movie.Venue(Id),
	[ShowDateTime] DateTime NOT NULL,
)
