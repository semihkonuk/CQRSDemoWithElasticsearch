CREATE DATABASE ExampleDb

USE [ExampleDb]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[BirthDate] [datetime] NULL,
	[UpdatedOn] [datetime] NULL,
	[CreatedOn] [datetime] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [ExampleDb]
EXEC sys.sp_cdc_enable_db


USE [ExampleDb] 
GO 
EXEC sys.sp_cdc_enable_table 
@source_schema = N'dbo', 
@source_name = N'Customers', 
@role_name = NULL, 
@filegroup_name = N'',
@supports_net_changes = 0 
GO