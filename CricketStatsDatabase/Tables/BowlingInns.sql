CREATE TABLE [dbo].[BowlingInns] (
    [bowlingInnsid]     UNIQUEIDENTIFIER NOT NULL,
    [matchid]           UNIQUEIDENTIFIER NOT NULL,
    [bowlingInnsnumber] SMALLINT         NOT NULL,
    [countryid]         UNIQUEIDENTIFIER NOT NULL,
    [playerid]          UNIQUEIDENTIFIER NOT NULL,
    [runs]              INT              CONSTRAINT [DF_BowlingInns_runs] DEFAULT ((0)) NULL,
    [wickets]           INT              CONSTRAINT [DF_BowlingInns_wickets] DEFAULT ((0)) NULL,
    [maidens]           INT              NULL,
    [overs]             INT              CONSTRAINT [DF_BowlingInns_overs] DEFAULT ((0)) NULL,
    [extras]            INT              CONSTRAINT [DF_BowlingInns_extras] DEFAULT ((0)) NULL,
    [lastupdated]       DATETIME         CONSTRAINT [DF_BowlingInns_lastupdated] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_BowlingInns] PRIMARY KEY CLUSTERED ([bowlingInnsid] ASC, [matchid] ASC, [bowlingInnsnumber] ASC, [countryid] ASC, [playerid] ASC),
    CONSTRAINT [FK_BowlingInns_BowlingInns] FOREIGN KEY ([bowlingInnsid], [matchid], [bowlingInnsnumber], [countryid], [playerid]) REFERENCES [dbo].[BowlingInns] ([bowlingInnsid], [matchid], [bowlingInnsnumber], [countryid], [playerid]),
    CONSTRAINT [FK_BowlingInns_Country] FOREIGN KEY ([countryid]) REFERENCES [dbo].[Country] ([countryid]),
    CONSTRAINT [FK_BowlingInns_Match] FOREIGN KEY ([matchid]) REFERENCES [dbo].[Match] ([matchid]),
    CONSTRAINT [FK_BowlingInns_Player] FOREIGN KEY ([playerid]) REFERENCES [dbo].[Player] ([playerid])
);

