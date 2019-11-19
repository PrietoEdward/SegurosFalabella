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

CREATE PROCEDURE [dbo].[SP_GET_COMPANY]
AS
BEGIN

	SELECT
	   [comp_id]
      ,[comp_nit]
      ,[comp_name]
      ,[comp_address]
      ,[comp_city]
      ,[comp_phone]
  FROM [dbo].[company]
	
END


GO

