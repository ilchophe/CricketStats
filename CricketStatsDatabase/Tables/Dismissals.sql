CREATE TABLE [dbo].[Dismissals] (
    [dismissalid]   UNIQUEIDENTIFIER CONSTRAINT [DF_Dismissals_dismissalid] DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    [dismissalcode] NVARCHAR (50)    NULL,
    [dismissaldesc] NVARCHAR (100)   NOT NULL,
    [lastupdated]   DATETIME         CONSTRAINT [DF_Dismissals_lastupdated] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Dismissals] PRIMARY KEY CLUSTERED ([dismissalid] ASC)
);

