USE [Ecom]
GO

/****** Object:  Table [dbo].[AdharMaster]    Script Date: 24-01-2026 14:55:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AdharMaster](
	[AdharId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Location] [nvarchar](50) NOT NULL,
	[Degree] [nvarchar](50) NOT NULL,
	[PinCode] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AdharMaster] PRIMARY KEY CLUSTERED 
(
	[AdharId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [Ecom]
GO

/****** Object:  Table [dbo].[LaptopPurchase]    Script Date: 24-01-2026 14:55:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LaptopPurchase](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Laptop_brand] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[AdharId] [int] NOT NULL,
 CONSTRAINT [PK_LaptopPurchase] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LaptopPurchase]  WITH CHECK ADD  CONSTRAINT [FK_LaptopPurchase_AdharMaster] FOREIGN KEY([AdharId])
REFERENCES [dbo].[AdharMaster] ([AdharId])
GO

ALTER TABLE [dbo].[LaptopPurchase] CHECK CONSTRAINT [FK_LaptopPurchase_AdharMaster]
GO


