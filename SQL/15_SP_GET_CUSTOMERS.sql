USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea procedimiento obtener clientes
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_GET_CUSTOMERS]
AS
BEGIN

	SELECT	
      [cust_id]
      ,[cust_cc]
      ,[cust_name]
      ,[cust_lastName]
      ,[cust_dateOfBirth]
      ,[cust_address]
      ,[cust_city]
      ,[cust_phone]
  FROM [pruebas].[dbo].[customer]
	
END


GO


