CREATE TABLE [dbo].[Country] (
    [countryid]   UNIQUEIDENTIFIER CONSTRAINT [DF_Country_countryid] DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    [countrycode] NVARCHAR (50)    NOT NULL,
    [countrydesc] NVARCHAR (100)   NOT NULL,
    [lastupdated] DATETIME         CONSTRAINT [DF_Country_lastupdated] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([countryid] ASC)
);

