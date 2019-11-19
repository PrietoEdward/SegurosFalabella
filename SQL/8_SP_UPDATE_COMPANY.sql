USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea procedimiento actualizar clientes
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_UPDATE_COMPANY]
(
	@comp_address VARCHAR(50),
	@comp_phone INT,
	@comp_city VARCHAR(50),
	@comp_id INT
)
AS
BEGIN

	UPDATE	[dbo].[company]
	SET		[comp_address] = @comp_address,
			[comp_city] = @comp_city,
			[comp_phone] = @comp_phone
	WHERE	[comp_id] = @comp_id
	
END


GO


