USE [Capstone400Project]
GO
/****** Object:  Table [dbo].[tire]    Script Date: 07/08/2012 15:55:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tire](
	[tireCode] [varchar](4) NOT NULL,
	[description] [varchar](50) NOT NULL,
	[manufacturer] [varchar](30) NOT NULL,
	[manufacturerSize] [varchar](4) NOT NULL,
	[wholesalePrice] [decimal](6, 2) NOT NULL,
	[retailPrice] [decimal](6, 2) NOT NULL,
 CONSTRAINT [pkTire] PRIMARY KEY CLUSTERED 
(
	[tireCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[store]    Script Date: 07/08/2012 15:55:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[store](
	[storeNbr] [varchar](5) NOT NULL,
	[streetAddress] [varchar](50) NOT NULL,
	[city] [varchar](30) NOT NULL,
	[state] [varchar](30) NOT NULL,
	[zip] [varchar](10) NOT NULL,
	[phone] [varchar](16) NOT NULL,
	[fax] [varchar](16) NOT NULL,
	[email] [varchar](50) NOT NULL,
 CONSTRAINT [pkStore] PRIMARY KEY CLUSTERED 
(
	[storeNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inventory]    Script Date: 07/08/2012 15:55:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inventory](
	[inventoryNbr] [varchar](8) NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL,
 CONSTRAINT [pkInventory] PRIMARY KEY CLUSTERED 
(
	[inventoryNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [fkStoreinv]    Script Date: 07/08/2012 15:55:21 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkStoreinv] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkStoreinv]
GO
/****** Object:  ForeignKey [fkTireinv]    Script Date: 07/08/2012 15:55:21 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkTireinv] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkTireinv]
GO
