USE [DB_SMP]
GO

/****** Object:  Table [dbo].[TB_Sell]    Script Date: 12/21/2022 3:36:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_Sell](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Sell_Name] [nvarchar](50) NULL,
	[Sell_Cus] [nvarchar](50) NULL,
	[Sell_price] [float] NULL,
	[Sell_Qt] [float] NULL,
	[Sell_TPrice] [float] NULL,
	[Sell_Date] [datetime] NULL,
 CONSTRAINT [PK_TB_Sell] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


