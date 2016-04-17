CREATE TABLE [dbo].[MatchType] (
    [matchtypeid]   UNIQUEIDENTIFIER CONSTRAINT [DF_MatchType_matchtypeid] DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    [matchtypename] NVARCHAR (100)   NOT NULL,
    [lastupdated]   DATETIME         CONSTRAINT [DF_MatchType_lastupdated] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_MatchType] PRIMARY KEY CLUSTERED ([matchtypeid] ASC)
);

