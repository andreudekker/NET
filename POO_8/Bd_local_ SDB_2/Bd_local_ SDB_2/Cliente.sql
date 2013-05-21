CREATE TABLE [dbo].[Table]
(
	[ClienteID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre ] NVARCHAR(50) NOT NULL, 
    [Apellidos] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NULL, 
    [FechaDeCompra] DATETIME NOT NULL, 
    [CreditoOefectivo] NVARCHAR(50) NULL
)
