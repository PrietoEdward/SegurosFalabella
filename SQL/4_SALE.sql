USE [pruebas]
GO

-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea tabla Venta
-- =======================================================================================================================================

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[sale](
	[sale_id] [int] IDENTITY(1,1) NOT NULL,	
	[sale_coverage] [varchar](500) NULL,
	[sale_prima] [decimal](10,5) NULL,
	[sale_assistance] [varchar](500) NULL,
	[prod_id] [int] NOT NULL,
	[cust_id] [int] NOT NULL
PRIMARY KEY CLUSTERED 
(
	[sale_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[sale]  WITH CHECK ADD  CONSTRAINT [FK_dbo_sale_product_id] FOREIGN KEY([prod_id])
REFERENCES [dbo].[product] ([prod_id])
GO

ALTER TABLE [dbo].[sale]  WITH CHECK ADD  CONSTRAINT [FK_dbo_sale_customer_id] FOREIGN KEY([cust_id])
REFERENCES [dbo].[customer] ([cust_id])
GO
