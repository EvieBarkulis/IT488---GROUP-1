USE [MWC_CustomOrder]
GO

/****** Object:  Table [dbo].[quiltOrders]    Script Date: 8/21/2022 7:24:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[quiltOrders](
	[quiltOrderID] [uniqueidentifier] NOT NULL,
	[customerID] [uniqueidentifier] NOT NULL,
	[quiltOrderType] [varchar](50) NOT NULL,
	[quiltOrderSize] [varchar](50) NOT NULL,
	[quiltOrderFabric] [varchar](50) NOT NULL,
	[quiltDesign] [varchar](50) NOT NULL,
	[quiltFiller] [varchar](50) NOT NULL,
	[quiltBacking] [varchar](50) NOT NULL,
 CONSTRAINT [PK_quiltOrders] PRIMARY KEY CLUSTERED 
(
	[quiltOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[quiltOrders]  WITH CHECK ADD  CONSTRAINT [FK_quiltOrders_customer] FOREIGN KEY([customerID])
REFERENCES [dbo].[customer] ([customerID])
GO

ALTER TABLE [dbo].[quiltOrders] CHECK CONSTRAINT [FK_quiltOrders_customer]
GO


