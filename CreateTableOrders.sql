USE [MWC_CustomOrder]
GO

/****** Object:  Table [dbo].[tableOrders]    Script Date: 8/21/2022 7:24:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tableOrders](
	[tableOrderID] [uniqueidentifier] NOT NULL,
	[customerID] [uniqueidentifier] NOT NULL,
	[tableOrderType] [varchar](50) NOT NULL,
	[tableOrderFinish] [varchar](50) NOT NULL,
	[tableOrderWood] [varchar](50) NOT NULL,
	[tableOrderThickness] [varchar](50) NOT NULL,
	[tableOrderDesign] [varchar](max) NOT NULL,
 CONSTRAINT [PK_tableOrders] PRIMARY KEY CLUSTERED 
(
	[tableOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[tableOrders]  WITH CHECK ADD  CONSTRAINT [FK_tableOrders_customer] FOREIGN KEY([customerID])
REFERENCES [dbo].[customer] ([customerID])
GO

ALTER TABLE [dbo].[tableOrders] CHECK CONSTRAINT [FK_tableOrders_customer]
GO


