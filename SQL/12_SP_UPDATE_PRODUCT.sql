USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea procedimiento actualizar Producto
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_UPDATE_PRODUCT]
(
	@prod_code VARCHAR(20),
	@prod_name VARCHAR(50),
	@prod_features VARCHAR(500),
	@prod_id INT
)
AS
BEGIN

	UPDATE	[dbo].[product]
	SET		[prod_code] = @prod_code,
			[prod_name] = @prod_name,
			[prod_features] = @prod_features
	WHERE	[prod_id] = @prod_id
	
END


GO


