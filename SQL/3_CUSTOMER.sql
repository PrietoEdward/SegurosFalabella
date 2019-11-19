USE [pruebas]
GO

-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea tabla Cliente
-- =======================================================================================================================================

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[customer](
	[cust_id] [int] IDENTITY(1,1) NOT NULL,
	[cust_cc] [int] NOT NULL,
	[cust_name] [varchar](20) NOT NULL,
	[cust_lastName] [varchar](20) NOT NULL,
	[cust_dateOfBirth] [date] NULL,
	[cust_address] [varchar](50) NULL,
	[cust_city] [varchar](50) NULL,
	[cust_phone] [int] NOT NULL
PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


