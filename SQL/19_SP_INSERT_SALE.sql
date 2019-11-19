USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea procedimiento ingresar ventas
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_INSERT_SALE]
(
	@sale_coverage varchar(500),
	@sale_prima decimal(10,5),
	@sale_assistance  varchar(500),
	@prod_id INT,
	@cust_id INT
)
AS
BEGIN

	INSERT INTO [dbo].[sale]
		(
			[sale_coverage]
			,[sale_prima]
			,[sale_assistance]
			,[prod_id]
			,[cust_id]
		)
		VALUES 
		(
			@sale_coverage
			,@sale_prima
			,@sale_assistance
			,@prod_id
			,@cust_id
		)
	
END

GO

