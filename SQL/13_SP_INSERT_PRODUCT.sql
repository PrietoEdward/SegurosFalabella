USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea procedimiento ingresar Producto
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_INSERT_PRODUCT]
(
	@prod_code VARCHAR(20),
	@prod_name VARCHAR(50),
	@prod_features VARCHAR(500),
	@comp_id INT
)
AS
BEGIN

	INSERT INTO [dbo].[product]
		(
			[prod_code]
			,[prod_name]
			,[prod_features]
			,[comp_id]
		)
		VALUES 
		(
			@prod_code
			,@prod_name
			,@prod_features
			,@comp_id
		)
	
END


GO

