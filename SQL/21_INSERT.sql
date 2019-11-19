USE [pruebas]
GO

-- company
INSERT INTO [dbo].[company]
           ([comp_nit]
           ,[comp_name]
           ,[comp_address]
           ,[comp_city]
           ,[comp_phone])
     VALUES
           (8007987521
           ,'Agility'
           ,'Carrea 4 # 31 -47'
           ,'Medellin'
           ,'9007965'),

           (8004234161
           ,'Provedeseg'
           ,'Calle 65 # 01-73'
           ,'Bogota'
           ,'7895421'),

           (8004231584
           ,'SegurosAgi'
           ,'Calle 73D # 10-8'
           ,'Bogota'
           ,'5321452'),

           (8921551000
           ,'Aseguradora Bolivar'
           ,'Transversal 12 # 52 -08'
           ,'Pereira'
           ,'2534842')
GO

--Product
INSERT INTO [dbo].[product]
           ([prod_code]
           ,[prod_name]
           ,[prod_features]
           ,[comp_id])
     VALUES
           (1000
           ,'ProductoUno'
           ,'DescripcionUno'
           ,1),

		  (2000
           ,'ProductoDos'
           ,'DescripcionDos'
           ,1),

		  (3000
           ,'ProductoTres'
           ,'DescripcionTres'
           ,2),

		   (4000
           ,'ProductoCuatro'
           ,'DescripcionCuatro'
           ,2),

		  (5000
           ,'ProductoCinco'
           ,'DescripcionCinco'
           ,3),

		   (6000
           ,'ProductoSeis'
           ,'DescripcionSeis'
           ,3),

		   (7000
           ,'ProductoSiete'
           ,'DescripcionSiete'
           ,4),

		   (8000
           ,'ProductoOcho'
           ,'DescripcionOcho'
           ,4)
GO

-- Sale
INSERT INTO [dbo].[customer]
           ([cust_cc]
           ,[cust_name]
           ,[cust_lastName]
           ,[cust_dateOfBirth]
           ,[cust_address]
           ,[cust_city]
           ,[cust_phone])
     VALUES
           (1024501551
           ,'Edwar'
           ,'Prieto'
           ,'1990-03-02'
           ,'Calle Falsa 123'
           ,'Bogota'
           ,9007968),

		   (1024501553
           ,'Edinson'
           ,'Fuentes'
           ,'1990-02-27'
           ,'Carrea 45 # 108-30'
           ,'Bogota'
           ,5559875)
GO





