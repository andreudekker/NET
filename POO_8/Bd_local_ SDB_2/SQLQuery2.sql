﻿USE [C:\USERS\MI_HOGAR\DOCUMENTS\VISUAL STUDIO 2012\PROJECTS\GIT-HUB CSHARP\POO_CAP8\BD_LOCAL_ SDB_2\BD_LOCAL_ SDB_2\DATABASE1.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[GetOrdenes]

SELECT	'Return Value' = @return_value

GO