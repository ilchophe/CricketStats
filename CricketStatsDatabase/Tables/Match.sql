CREATE TABLE [dbo].[Match] (
    [matchid]             UNIQUEIDENTIFIER CONSTRAINT [DF_Match_matchid] DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    [matchnumber]         SMALLINT         NOT NULL,
    [homecountryid]       UNIQUEIDENTIFIER NOT NULL,
    [awaycountryid]       UNIQUEIDENTIFIER NOT NULL,
    [venueid]             UNIQUEIDENTIFIER NOT NULL,
    [matchtypeid]         UNIQUEIDENTIFIER NOT NULL,
    [matchstartdate]      DATETIME         NULL,
    [tosswinnercountryid] UNIQUEIDENTIFIER NOT NULL,
    [lastupdated]         DATETIME         CONSTRAINT [DF_Match_lastupdated] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Match] PRIMARY KEY CLUSTERED ([matchid] ASC),
    CONSTRAINT [FK_Match_Away_Country] FOREIGN KEY ([awaycountryid]) REFERENCES [dbo].[Country] ([countryid]),
    CONSTRAINT [FK_Match_Home_Country] FOREIGN KEY ([homecountryid]) REFERENCES [dbo].[Country] ([countryid]),
    CONSTRAINT [FK_Match_MatchType] FOREIGN KEY ([matchtypeid]) REFERENCES [dbo].[MatchType] ([matchtypeid]),
    CONSTRAINT [FK_Match_Toss_Country] FOREIGN KEY ([tosswinnercountryid]) REFERENCES [dbo].[Country] ([countryid]),
    CONSTRAINT [FK_Match_Venue] FOREIGN KEY ([venueid]) REFERENCES [dbo].[Venue] ([venueid])
);

