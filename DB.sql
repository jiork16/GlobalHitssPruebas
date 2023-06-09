CREATE DATABASE GLOBALHITSS
GO
USE [GLOBALHITSS]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 17/04/2023 17:17:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[customers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CI] [varchar](13) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[date_birth] [date] NOT NULL,
	[home_adress] [varchar](250) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[phone_numer] [varchar](50) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_customers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
