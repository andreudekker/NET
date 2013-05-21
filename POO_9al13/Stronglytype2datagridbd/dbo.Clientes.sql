CREATE TABLE [dbo].[Clientes] (
    [Nombre]   NVARCHAR (50) NOT NULL,
    [Apellido] NVARCHAR (50) NULL,
    [Pais]     NVARCHAR (50) NULL,
    [ClienteID] INT NOT NULL IDENTITY, 
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([ClienteID]) 
);

