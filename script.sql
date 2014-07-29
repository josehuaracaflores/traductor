USE [NUMERO]
GO
/****** Object:  StoredProcedure [dbo].[buscrarU]    Script Date: 24/07/2014 12:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscrarU]
@u  int
 as begin
	select UNIDAD_Q from UNIDAD1 where UNIDAD=@u
end
GO
/****** Object:  Table [dbo].[CENTENA1]    Script Date: 24/07/2014 12:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CENTENA1](
	[CENTENA] [int] IDENTITY(1,1) NOT NULL,
	[CENTENA_Q] [nvarchar](100) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DECENA]    Script Date: 24/07/2014 12:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DECENA](
	[DECENA] [int] IDENTITY(1,1) NOT NULL,
	[DECENA_Q] [nvarchar](100) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MILLAR]    Script Date: 24/07/2014 12:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MILLAR](
	[MILLAR] [int] IDENTITY(1,1) NOT NULL,
	[MILLAR_Q] [nvarchar](100) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UNIDAD]    Script Date: 24/07/2014 12:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNIDAD](
	[UNIDAD] [int] IDENTITY(1,1) NOT NULL,
	[UNIDAD_Q] [nvarchar](100) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UNIDAD1]    Script Date: 24/07/2014 12:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNIDAD1](
	[UNIDAD] [int] IDENTITY(1,1) NOT NULL,
	[UNIDAD_Q] [nvarchar](100) NOT NULL
) ON [PRIMARY]

GO
