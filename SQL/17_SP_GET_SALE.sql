USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea procedimiento obtener venta
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_GET_SALE]
AS
BEGIN

	SELECT	
      [sale_id]
      ,[sale_coverage]
      ,[sale_prima]
      ,[sale_assistance]
      ,[prod_name]
      ,[cust_cc]
	  ,[cust_name]
      ,[cust_lastName]  
  FROM [dbo].[sale] s
  INNER JOIN customer c ON c.cust_id = s.cust_id
  INNER JOIN product p ON p.prod_id = s.prod_id
	
END


GO

