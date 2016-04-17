CREATE TABLE [dbo].[Venue] (
    [venueid]     UNIQUEIDENTIFIER CONSTRAINT [DF_Venue_venueid] DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    [venuename]   NVARCHAR (100)   NULL,
    [venuecity]   NVARCHAR (100)   NOT NULL,
    [countryid]   UNIQUEIDENTIFIER NOT NULL,
    [lastupdated] DATETIME         CONSTRAINT [DF_Venue_lastupdated] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Venue] PRIMARY KEY CLUSTERED ([venueid] ASC),
    CONSTRAINT [FK_Venue_Country] FOREIGN KEY ([countryid]) REFERENCES [dbo].[Country] ([countryid])
);

