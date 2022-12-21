USE [DB_SMP]
GO

/****** Object:  Table [dbo].[TB_Supp]    Script Date: 12/21/2022 3:36:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_Supp](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Supp_Name] [nvarchar](50) NULL,
	[Supp_Phone] [nvarchar](50) NULL,
	[Supp_Email] [nvarchar](50) NULL,
	[Supp_Image] [image] NULL,
 CONSTRAINT [PK_TB_Supp] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


