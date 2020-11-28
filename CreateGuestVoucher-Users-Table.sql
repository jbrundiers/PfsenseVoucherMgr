USE [GuestVoucher]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 25.11.2020 22:21:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[uID] [int] IDENTITY(1,1) NOT NULL,
	[uName] [varchar](50) NULL,
	[uAdminStatus] [int] NULL,
	[uCDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[uID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


