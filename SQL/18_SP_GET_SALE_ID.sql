USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea procedimiento obtener una venta
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_GET_SALE_ID]
(
	@sale_id INT
)
AS
BEGIN

	SELECT
      [sale_coverage]
      ,[sale_prima]
      ,[sale_assistance]
      ,[prod_code]
      ,[prod_name]	  
	  ,[prod_features]
      ,[cust_cc]
	  ,[cust_name]
      ,[cust_lastName]
	  ,[cust_dateOfBirth]
      ,[cust_address]
	  ,[cust_city]
      ,[cust_phone]	  
  FROM [dbo].[sale] s
  INNER JOIN customer c ON c.cust_id = s.cust_id
  INNER JOIN product p ON p.prod_id = s.prod_id
  WHERE [sale_id] = @sale_id
	
END


GO


