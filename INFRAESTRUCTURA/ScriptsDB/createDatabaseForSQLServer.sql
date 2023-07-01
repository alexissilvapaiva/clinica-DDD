USE [ClinicaVeterinaria]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id] [uniqueidentifier] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[email] [varchar](40) NOT NULL
) ON [PRIMARY]
GO
