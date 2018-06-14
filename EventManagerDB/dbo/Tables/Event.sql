CREATE TABLE [dbo].[Event] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (200) NOT NULL,
    [Location]  NVARCHAR (200) NOT NULL,
    [StartDate] DATETIME       NOT NULL,
    [EndDate]   DATETIME       NOT NULL,
    CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED ([ID] ASC)
);

