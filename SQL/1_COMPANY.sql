USE [pruebas]
GO

-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea tabla Empresa
-- =======================================================================================================================================

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[company](
	[comp_id] [int] IDENTITY(1,1) NOT NULL,
	[comp_nit] [varchar](20) NOT NULL,
	[comp_name] [varchar](20) NOT NULL,
	[comp_address] [varchar](50) NULL,
	[comp_city] [varchar](50) NULL,
	[comp_phone] [int] NOT NULL
PRIMARY KEY CLUSTERED 
(
	[comp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


