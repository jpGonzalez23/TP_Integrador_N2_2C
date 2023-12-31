USE [RESERVAS_TP]
GO
/****** Object:  Table [dbo].[Lista_Reservas]    Script Date: 19/11/2023 22:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lista_Reservas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Dni] [int] NOT NULL,
	[CantComensales] [int] NOT NULL,
	[HoraReserva] [datetime] NOT NULL,
 CONSTRAINT [PK_Lista_Reservas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
