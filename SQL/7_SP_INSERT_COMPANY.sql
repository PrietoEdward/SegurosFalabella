USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea procedimiento ingresar clientes
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_INSERT_COMPANY]
(
	@comp_nit VARCHAR(50),
	@comp_name VARCHAR(50),
	@comp_address  VARCHAR(50),
	@comp_city VARCHAR(50),
	@comp_phone INT
)
AS
BEGIN

	INSERT INTO [dbo].[company]
		(
			[comp_nit]
			,[comp_name]
			,[comp_address]
			,[comp_city]
			,[comp_phone]
		)
		VALUES 
		(
			@comp_nit
			,@comp_name
			,@comp_address
			,@comp_city
			,@comp_phone
		)
	
END


GO

