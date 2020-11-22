USE [TimeZoneData]
GO

/****** Object:  Table [dbo].[TimeZoneEntries]    Script Date: 11/22/2020 9:39:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TimeZoneEntries](
	[IANATimeZoneID] [nvarchar](255) NULL,
	[WinTimeZoneID] [nvarchar](255) NULL
) ON [PRIMARY]
GO


