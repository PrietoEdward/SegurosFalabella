USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea procedimiento borrar Producto
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_DELETE_PRODUCT]
(
	@prod_id INT
)
AS
BEGIN

	DELETE	[dbo].[product]
	WHERE	[prod_id] = @prod_id
	
END


GO


