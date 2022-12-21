USE [DB_SMP]
GO

/****** Object:  Table [dbo].[TB_Pur]    Script Date: 12/21/2022 3:35:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_Pur](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Supp_id] [int] NULL,
	[Pur_Name] [nvarchar](50) NULL,
	[Pur_Type] [nvarchar](50) NULL,
	[Pur_Cat] [nvarchar](50) NULL,
	[Pur_Sup] [nvarchar](50) NULL,
	[Pur_Det] [nvarchar](50) NULL,
	[Pur_Buy] [float] NULL,
	[Pur_Sell] [float] NULL,
	[Pur_Qt] [float] NULL,
	[Pur_Tsell] [float] NULL,
	[Pur_Tbuy] [float] NULL,
	[Pur_TRev] [float] NULL,
	[Cat_id] [int] NULL,
 CONSTRAINT [PK_TB_Pur] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TB_Pur]  WITH CHECK ADD  CONSTRAINT [FK_TB_Pur_TB_CAT] FOREIGN KEY([Cat_id])
REFERENCES [dbo].[TB_CAT] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[TB_Pur] CHECK CONSTRAINT [FK_TB_Pur_TB_CAT]
GO

ALTER TABLE [dbo].[TB_Pur]  WITH CHECK ADD  CONSTRAINT [FK_TB_Pur_TB_Supp] FOREIGN KEY([Supp_id])
REFERENCES [dbo].[TB_Supp] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[TB_Pur] CHECK CONSTRAINT [FK_TB_Pur_TB_Supp]
GO


