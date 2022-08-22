USE [MWC_CustomOrder]
GO

/****** Object:  Table [dbo].[customer]    Script Date: 8/21/2022 10:27:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[customer](
	[customerID] [uniqueidentifier] NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[state] [nchar](2) NOT NULL,
	[zip] [numeric](18, 0) NOT NULL,
	[email] [varchar](50) NULL,
	[phone] [numeric](18, 0) NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


