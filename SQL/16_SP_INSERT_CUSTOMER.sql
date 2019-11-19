USE [pruebas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =======================================================================================================================================
-- Author               date                    Description
-- =======================================================================================================================================
-- Edward Prieto       18/11/2019           	Se crea procedimiento ingresar cliente nuevo
-- =======================================================================================================================================

CREATE PROCEDURE [dbo].[SP_INSERT_CUSTOMER]
(
	@cust_cc int,
	@cust_name varchar(20),
	@cust_lastName varchar(20),
	@cust_dateOfBirth date,
	@cust_address varchar(50),
	@cust_city varchar(50),
	@cust_phone int
)
AS
BEGIN

	INSERT INTO [dbo].[customer]
		(
			[cust_cc]
			,[cust_name]
			,[cust_lastName]
			,[cust_dateOfBirth]
			,[cust_address]
			,[cust_city]
			,[cust_phone]
		)
		VALUES 
		(
			@cust_cc
			,@cust_name
			,@cust_lastName
			,@cust_dateOfBirth
			,@cust_address
			,@cust_city
			,@cust_phone
		)
		
END


GO

