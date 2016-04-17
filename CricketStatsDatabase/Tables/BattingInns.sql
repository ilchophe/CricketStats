CREATE TABLE [dbo].[BattingInns] (
    [BatInnsid]        UNIQUEIDENTIFIER NOT NULL,
    [matchid]          UNIQUEIDENTIFIER NOT NULL,
    [BatInnsNumber]    SMALLINT         NOT NULL,
    [countryid]        UNIQUEIDENTIFIER NOT NULL,
    [playerid]         UNIQUEIDENTIFIER NOT NULL,
    [runs]             INT              CONSTRAINT [DF_BattingInns_runs] DEFAULT ((0)) NOT NULL,
    [ballsfaced]       INT              CONSTRAINT [DF_BattingInns_ballsfaced] DEFAULT ((0)) NOT NULL,
    [fours]            INT              CONSTRAINT [DF_BattingInns_fours] DEFAULT ((0)) NOT NULL,
    [sixes]            INT              CONSTRAINT [DF_BattingInns_sixes] DEFAULT ((0)) NOT NULL,
    [bowler_playerid]  UNIQUEIDENTIFIER NULL,
    [fielder_playerid] UNIQUEIDENTIFIER NULL,
    [dismissalid]      UNIQUEIDENTIFIER NOT NULL,
    [lastupdated]      DATETIME         CONSTRAINT [DF_BattingInns_lastupdated] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_BattingInns] PRIMARY KEY CLUSTERED ([BatInnsid] ASC, [matchid] ASC, [BatInnsNumber] ASC, [countryid] ASC, [playerid] ASC),
    CONSTRAINT [FK_BattingInns_Country] FOREIGN KEY ([countryid]) REFERENCES [dbo].[Country] ([countryid]),
    CONSTRAINT [FK_BattingInns_Dismissals] FOREIGN KEY ([dismissalid]) REFERENCES [dbo].[Dismissals] ([dismissalid]),
    CONSTRAINT [FK_BattingInns_Match] FOREIGN KEY ([matchid]) REFERENCES [dbo].[Match] ([matchid]),
    CONSTRAINT [FK_BattingInns_Player] FOREIGN KEY ([playerid]) REFERENCES [dbo].[Player] ([playerid]),
    CONSTRAINT [FK_BattingInns_Player_Bowler] FOREIGN KEY ([bowler_playerid]) REFERENCES [dbo].[Player] ([playerid]),
    CONSTRAINT [FK_BattingInns_Player_Fielder] FOREIGN KEY ([fielder_playerid]) REFERENCES [dbo].[Player] ([playerid])
);

