USE [DB_SMP]
GO

/****** Object:  Table [dbo].[TB_CuS]    Script Date: 12/21/2022 3:34:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_CuS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Cus_name] [nvarchar](50) NULL,
	[Cus_phone] [nvarchar](50) NULL,
	[Cus_location] [nvarchar](50) NULL,
	[Cus_image] [image] NULL,
 CONSTRAINT [PK_TB_CuS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


