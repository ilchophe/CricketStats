CREATE TABLE [dbo].[Player] (
    [playerid]      UNIQUEIDENTIFIER CONSTRAINT [DF_Player_playerid] DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    [playername]    NVARCHAR (100)   NOT NULL,
    [playersurname] NVARCHAR (100)   NOT NULL,
    [countryid]     UNIQUEIDENTIFIER NOT NULL,
    [dob]           DATETIME         NOT NULL,
    [retired]       BIT              CONSTRAINT [DF_Player_retired] DEFAULT ((0)) NULL,
    [lastupdated]   DATETIME         CONSTRAINT [DF_Player_lastupdated] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Player] PRIMARY KEY CLUSTERED ([playerid] ASC),
    CONSTRAINT [FK_Player_Country] FOREIGN KEY ([countryid]) REFERENCES [dbo].[Country] ([countryid])
);

