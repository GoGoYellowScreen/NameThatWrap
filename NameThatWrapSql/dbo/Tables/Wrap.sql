CREATE TABLE [dbo].[Wrap] (
    [WrapID]       INT            IDENTITY (1, 1) NOT NULL,
    [Colorway]     NVARCHAR (100) NOT NULL,
    [Brand]        NVARCHAR (50)  NOT NULL,
    [ImgName]      NVARCHAR (50)  NOT NULL,
    [Date_created] DATETIME2 (7)  NULL,
    [Date_updated] DATETIME2 (7)  NULL,
    [Author]       NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([WrapID] ASC)
);

