USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea procedimiento obtener Producto
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_GET_PRODUCT]
AS
BEGIN

	SELECT
      [prod_id]
      ,[prod_name]
      ,[comp_address]
      ,[prod_features]
      ,p.[comp_id]
	  ,c.[comp_name]
  FROM [dbo].[product] p
  INNER JOIN company c ON c.comp_id = p.comp_id
	
END


GO

