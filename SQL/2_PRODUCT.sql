USE [pruebas]
GO

-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea tabla Producto
-- =======================================================================================================================================

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[product](
	[prod_id] [int] IDENTITY(1,1) NOT NULL,
	[prod_code] [varchar](20) NOT NULL,
	[prod_name] [varchar](50) NOT NULL,
	[prod_features] [varchar](500) NOT NULL,
	[comp_id] [int] NOT NULL
PRIMARY KEY CLUSTERED 
(
	[prod_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_dbo_product_company_id] FOREIGN KEY([comp_id])
REFERENCES [dbo].[company] ([comp_id])
GO

