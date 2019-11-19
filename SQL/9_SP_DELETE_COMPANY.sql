USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea procedimiento borrar clientes
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_DELETE_COMPANY]
(
	@comp_id INT
)
AS
BEGIN

	DELETE	[dbo].[company]
	WHERE	[comp_id] = @comp_id
	
END


GO


