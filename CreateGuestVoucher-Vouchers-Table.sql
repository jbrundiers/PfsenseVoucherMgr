USE [GuestVoucher]
GO

/****** Object:  Table [dbo].[Vouchers]    Script Date: 25.11.2020 22:31:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vouchers](
	[vID] [int] IDENTITY(1,1) NOT NULL,
	[vCode] [varchar](20) NULL,
	[vRoll] [int] NULL,
	[vImportDate] [datetime] NULL,
	[vImportUser] [int] NULL,
	[vSpendUser] [int] NULL,
	[vSpendDate] [datetime] NULL,
	[vSpendToUser] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[vID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


