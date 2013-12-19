USE [NameThatWrap]
GO

/****** Object: Table [dbo].[Wrap] Script Date: 12/18/2013 11:29:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Wrap] (
    [wrap_Id]      INT            NOT NULL,
    [colorway]     NVARCHAR (100) NOT NULL,
    [brand]        NVARCHAR (50)  NOT NULL,
    [date_created] DATETIME2 (7)  NOT NULL,
    [date_updated] DATETIME2 (7)  NOT NULL,
    [author]       NVARCHAR (100) NOT NULL,
    [img_name]     NVARCHAR (100) NOT NULL
);


