USE [comp400_2012]
GO
ALTER TABLE [dbo].[tire] DROP CONSTRAINT [DF_tire_retailPrice]
GO
ALTER TABLE [dbo].[tire] DROP CONSTRAINT [DF_tire_dealerPrice]
GO
ALTER TABLE [dbo].[tire] DROP CONSTRAINT [DF_tire_wholesaleCost]
GO
ALTER TABLE [dbo].[wholesaleOrder] DROP CONSTRAINT [dealerID]
GO
ALTER TABLE [dbo].[wholesaleOrderDetail] DROP CONSTRAINT [DF_wholesaleOrderDetail_tireQty]
GO
ALTER TABLE [dbo].[transferOrderDetail] DROP CONSTRAINT [DF_transferOrderDetail_tireQty]
GO
ALTER TABLE [dbo].[purchaseOrderDetail] DROP CONSTRAINT [DF_purchaseOrderDetail_tireQty]
GO
ALTER TABLE [dbo].[retailOrderDetail] DROP CONSTRAINT [DF_retailOrderDetail_tireQty]
GO
/****** Object:  ForeignKey [fkPOStore]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[purchaseOrder] DROP CONSTRAINT [fkPOStore]
GO
/****** Object:  ForeignKey [fkStoreInv]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkStoreInv]
GO
/****** Object:  ForeignKey [fkTireInv]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkTireInv]
GO
/****** Object:  ForeignKey [fkEmpStore]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[employee] DROP CONSTRAINT [fkEmpStore]
GO
/****** Object:  ForeignKey [fkTrnRecStore]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[transferOrder] DROP CONSTRAINT [fkTrnRecStore]
GO
/****** Object:  ForeignKey [fkTrnShipStore]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[transferOrder] DROP CONSTRAINT [fkTrnShipStore]
GO
/****** Object:  ForeignKey [fkWhslDealer]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[wholesaleOrder] DROP CONSTRAINT [fkWhslDealer]
GO
/****** Object:  ForeignKey [fkWhslDtlOrder]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail] DROP CONSTRAINT [fkWhslDtlOrder]
GO
/****** Object:  ForeignKey [fkWhslDtlTire]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail] DROP CONSTRAINT [fkWhslDtlTire]
GO
/****** Object:  ForeignKey [fkTnfrDtlOrder]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[transferOrderDetail] DROP CONSTRAINT [fkTnfrDtlOrder]
GO
/****** Object:  ForeignKey [fkTnfrDtlTire]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[transferOrderDetail] DROP CONSTRAINT [fkTnfrDtlTire]
GO
/****** Object:  ForeignKey [fkRtlOrdCust]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrdCust]
GO
/****** Object:  ForeignKey [fkRtlOrdEmp]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrdEmp]
GO
/****** Object:  ForeignKey [fkRtlOrdStore]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrdStore]
GO
/****** Object:  ForeignKey [fkPOOrdNbr]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[purchaseOrderDetail] DROP CONSTRAINT [fkPOOrdNbr]
GO
/****** Object:  ForeignKey [fkPOTire]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[purchaseOrderDetail] DROP CONSTRAINT [fkPOTire]
GO
/****** Object:  ForeignKey [fkRtlDtlOrder]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[retailOrderDetail] DROP CONSTRAINT [fkRtlDtlOrder]
GO
/****** Object:  ForeignKey [fkRtlDtlTire]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[retailOrderDetail] DROP CONSTRAINT [fkRtlDtlTire]
GO
/****** Object:  Table [dbo].[retailOrderDetail]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[retailOrderDetail]
GO
/****** Object:  Table [dbo].[purchaseOrderDetail]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[purchaseOrderDetail]
GO
/****** Object:  Table [dbo].[retailOrder]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[retailOrder]
GO
/****** Object:  Table [dbo].[transferOrderDetail]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[transferOrderDetail]
GO
/****** Object:  Table [dbo].[wholesaleOrderDetail]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[wholesaleOrderDetail]
GO
/****** Object:  Table [dbo].[wholesaleOrder]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[wholesaleOrder]
GO
/****** Object:  Table [dbo].[transferOrder]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[transferOrder]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[employee]
GO
/****** Object:  Table [dbo].[inventory]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[inventory]
GO
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[purchaseOrder]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[customer]
GO
/****** Object:  Table [dbo].[dealer]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[dealer]
GO
/****** Object:  Table [dbo].[store]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[store]
GO
/****** Object:  Table [dbo].[tire]    Script Date: 07/29/2012 20:09:53 ******/
DROP TABLE [dbo].[tire]
GO
/****** Object:  User [CS\amavrico]    Script Date: 07/29/2012 20:09:53 ******/
DROP USER [CS\amavrico]
GO
/****** Object:  User [CS\aschalt]    Script Date: 07/29/2012 20:09:53 ******/
DROP USER [CS\aschalt]
GO
/****** Object:  User [CS\aschole]    Script Date: 07/29/2012 20:09:53 ******/
DROP USER [CS\aschole]
GO
/****** Object:  User [CS\jellis]    Script Date: 07/29/2012 20:09:53 ******/
DROP USER [CS\jellis]
GO
/****** Object:  User [CS\mayer]    Script Date: 07/29/2012 20:09:53 ******/
DROP USER [CS\mayer]
GO
/****** Object:  User [CS\skaneko]    Script Date: 07/29/2012 20:09:53 ******/
DROP USER [CS\skaneko]
GO
/****** Object:  User [CS\skaneko]    Script Date: 07/29/2012 20:09:53 ******/
CREATE USER [CS\skaneko] FOR LOGIN [CS\skaneko] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [CS\mayer]    Script Date: 07/29/2012 20:09:53 ******/
CREATE USER [CS\mayer] FOR LOGIN [CS\mayer] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [CS\jellis]    Script Date: 07/29/2012 20:09:53 ******/
CREATE USER [CS\jellis] FOR LOGIN [CS\jellis] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [CS\aschole]    Script Date: 07/29/2012 20:09:53 ******/
CREATE USER [CS\aschole] FOR LOGIN [CS\aschole] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [CS\aschalt]    Script Date: 07/29/2012 20:09:53 ******/
CREATE USER [CS\aschalt] FOR LOGIN [CS\aschalt] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [CS\amavrico]    Script Date: 07/29/2012 20:09:53 ******/
CREATE USER [CS\amavrico] FOR LOGIN [CS\amavrico] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[tire]    Script Date: 07/29/2012 20:09:53 ******/
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
	[manufacturerSize] [varchar](20) NOT NULL,
	[retailPrice] [decimal](6, 2) NOT NULL,
	[dealerPrice] [decimal](6, 2) NOT NULL,
	[wholesaleCost] [decimal](6, 2) NOT NULL,
 CONSTRAINT [pkTire] PRIMARY KEY CLUSTERED 
(
	[tireCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'A123', N'Cooper All Weather Tread', N'Cooper Tires', N'R215', CAST(104.95 AS Decimal(6, 2)), CAST(0.00 AS Decimal(6, 2)), CAST(0.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'B378', N'All Terrain', N'Bridgestone', N'R235', CAST(235.95 AS Decimal(6, 2)), CAST(0.00 AS Decimal(6, 2)), CAST(0.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'J475', N'Rain Warrior', N'Michelin', N'R205', CAST(137.99 AS Decimal(6, 2)), CAST(0.00 AS Decimal(6, 2)), CAST(0.00 AS Decimal(6, 2)))
/****** Object:  Table [dbo].[store]    Script Date: 07/29/2012 20:09:53 ******/
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
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0001', N'987 SE Hall St', N'Portland', N'OR', N'97222', N'503 746-8267', N'503 746-8376', N'store0001@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0002', N'736 SW Elk Lane', N'Gresham', N'OR', N'97220', N'503 564-1237', N'503 564-1238', N'store0002@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0005', N'8379 SW 10th Ave', N'Eugene', N'OR', N'97378', N'541 876-1289', N'541 876-1290', N'store0005@store.com')
/****** Object:  Table [dbo].[dealer]    Script Date: 07/29/2012 20:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dealer](
	[dealerId] [int] IDENTITY(70000000,1) NOT NULL,
	[dealerAcctNbr] [varchar](10) NOT NULL,
	[dealerName] [varchar](30) NOT NULL,
	[dealerStreet] [varchar](30) NOT NULL,
	[dealerCity] [varchar](30) NOT NULL,
	[dealerState] [varchar](30) NOT NULL,
	[dealerZip] [varchar](10) NOT NULL,
	[dealerPhone] [varchar](16) NOT NULL,
 CONSTRAINT [pkDealer] PRIMARY KEY CLUSTERED 
(
	[dealerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[dealer] ON
INSERT [dbo].[dealer] ([dealerId], [dealerAcctNbr], [dealerName], [dealerStreet], [dealerCity], [dealerState], [dealerZip], [dealerPhone]) VALUES (70000000, N'1000000001', N'Joe''s Shell', N'1234 Main St', N'Detroit', N'OR', N'97456', N'503 645-3456')
SET IDENTITY_INSERT [dbo].[dealer] OFF
/****** Object:  Table [dbo].[customer]    Script Date: 07/29/2012 20:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customer](
	[customerID] [int] NOT NULL,
	[custFirstName] [varchar](30) NOT NULL,
	[custLastName] [varchar](30) NOT NULL,
	[custStreet] [varchar](30) NOT NULL,
	[custCity] [varchar](30) NOT NULL,
	[custState] [varchar](30) NOT NULL,
	[custZip] [varchar](10) NOT NULL,
	[custPhone] [varchar](16) NOT NULL,
 CONSTRAINT [pkCustomer] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[customer] ([customerID], [custFirstName], [custLastName], [custStreet], [custCity], [custState], [custZip], [custPhone]) VALUES (80000000, N'Ken', N'Adams', N'7356 Sampson Dr', N'Portland', N'OR', N'97026', N'503 563-7356')
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 07/29/2012 20:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchaseOrder](
	[poNbr] [int] IDENTITY(30000000,1) NOT NULL,
	[vendorID] [varchar](10) NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[poDate] [date] NOT NULL,
 CONSTRAINT [pkPurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[poNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[purchaseOrder] ON
INSERT [dbo].[purchaseOrder] ([poNbr], [vendorID], [storeNbr], [poDate]) VALUES (30000000, N'V0000001', N'0001', CAST(0xEA350B00 AS Date))
SET IDENTITY_INSERT [dbo].[purchaseOrder] OFF
/****** Object:  Table [dbo].[inventory]    Script Date: 07/29/2012 20:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inventory](
	[inventoryNbr] [int] IDENTITY(50000000,1) NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL,
 CONSTRAINT [pkInvID] PRIMARY KEY CLUSTERED 
(
	[inventoryNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[inventory] ON
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (50000000, N'A123', N'0001', CAST(4 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (50000001, N'A123', N'0002', CAST(6 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (50000002, N'B378', N'0002', CAST(4 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (50000003, N'J475', N'0005', CAST(10 AS Decimal(4, 0)))
SET IDENTITY_INSERT [dbo].[inventory] OFF
/****** Object:  Table [dbo].[employee]    Script Date: 07/29/2012 20:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employee](
	[employeeID] [int] IDENTITY(90000000,1) NOT NULL,
	[firstName] [varchar](30) NOT NULL,
	[lastName] [varchar](30) NOT NULL,
	[userID] [varchar](15) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[userSecurityLevel] [varchar](15) NOT NULL,
 CONSTRAINT [pkEmployeeID] PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[employee] ON
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (90000000, N'Stanley', N'Harris', N'sharris', N'sh1234', N'0001', N'Warehouse')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (90000001, N'Susan', N'Barnes', N'abarnes', N'sb1234', N'0002', N'Sales')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (90000002, N'Howard', N'Newton', N'hnewton', N'hn1234', N'0001', N'Manager')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (90000003, N'Alan', N'Rankin', N'arankin', N'ar1234', N'0001', N'Admin')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (90000004, N'Barb', N'Mason', N'bmason', N'bm1234', N'0005', N'General')
SET IDENTITY_INSERT [dbo].[employee] OFF
/****** Object:  Table [dbo].[transferOrder]    Script Date: 07/29/2012 20:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[transferOrder](
	[transferOrderNbr] [int] IDENTITY(20000000,1) NOT NULL,
	[shipStore] [varchar](5) NOT NULL,
	[receiveStore] [varchar](5) NOT NULL,
	[transferDate] [date] NOT NULL,
 CONSTRAINT [pkTransferOrder] PRIMARY KEY CLUSTERED 
(
	[transferOrderNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[transferOrder] ON
INSERT [dbo].[transferOrder] ([transferOrderNbr], [shipStore], [receiveStore], [transferDate]) VALUES (20000000, N'0002', N'0005', CAST(0xEA350B00 AS Date))
SET IDENTITY_INSERT [dbo].[transferOrder] OFF
/****** Object:  Table [dbo].[wholesaleOrder]    Script Date: 07/29/2012 20:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[wholesaleOrder](
	[whslOrderNbr] [int] IDENTITY(40000000,1) NOT NULL,
	[dealerAcctNbr] [varchar](10) NOT NULL,
	[transactionTotal] [decimal](7, 2) NOT NULL,
	[whslOrderDate] [date] NOT NULL,
	[dealerID] [int] NOT NULL,
 CONSTRAINT [pkWhslOrd] PRIMARY KEY CLUSTERED 
(
	[whslOrderNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[wholesaleOrder] ON
INSERT [dbo].[wholesaleOrder] ([whslOrderNbr], [dealerAcctNbr], [transactionTotal], [whslOrderDate], [dealerID]) VALUES (40000000, N'70000000', CAST(745.97 AS Decimal(7, 2)), CAST(0xEA350B00 AS Date), 70000000)
SET IDENTITY_INSERT [dbo].[wholesaleOrder] OFF
/****** Object:  Table [dbo].[wholesaleOrderDetail]    Script Date: 07/29/2012 20:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[wholesaleOrderDetail](
	[whslDtlLineID] [int] IDENTITY(40000000,1) NOT NULL,
	[whslOrderNbr] [int] NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL,
 CONSTRAINT [pkWhslOrdDtl] PRIMARY KEY CLUSTERED 
(
	[whslDtlLineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[wholesaleOrderDetail] ON
INSERT [dbo].[wholesaleOrderDetail] ([whslDtlLineID], [whslOrderNbr], [tireCode], [tireQty]) VALUES (40000000, 40000000, N'J475', CAST(15 AS Decimal(4, 0)))
SET IDENTITY_INSERT [dbo].[wholesaleOrderDetail] OFF
/****** Object:  Table [dbo].[transferOrderDetail]    Script Date: 07/29/2012 20:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[transferOrderDetail](
	[tnfrDtlLineID] [int] IDENTITY(20000000,1) NOT NULL,
	[transferOrderNbr] [int] NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL,
 CONSTRAINT [pkTnfrOrderDtl] PRIMARY KEY CLUSTERED 
(
	[tnfrDtlLineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[transferOrderDetail] ON
INSERT [dbo].[transferOrderDetail] ([tnfrDtlLineID], [transferOrderNbr], [tireCode], [tireQty]) VALUES (20000000, 20000000, N'A123', CAST(10 AS Decimal(4, 0)))
SET IDENTITY_INSERT [dbo].[transferOrderDetail] OFF
/****** Object:  Table [dbo].[retailOrder]    Script Date: 07/29/2012 20:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[retailOrder](
	[retailOrderNbr] [int] IDENTITY(10000000,1) NOT NULL,
	[customerID] [int] NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[employeeID] [int] NOT NULL,
	[salesDate] [date] NOT NULL,
	[taxableTotal] [decimal](7, 2) NOT NULL,
	[laborCharges] [decimal](7, 2) NOT NULL,
	[retailOrderTotal] [decimal](7, 2) NOT NULL,
 CONSTRAINT [pkRetailOrder] PRIMARY KEY CLUSTERED 
(
	[retailOrderNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[retailOrder] ON
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [taxableTotal], [laborCharges], [retailOrderTotal]) VALUES (10000000, 80000000, N'0002', 90000000, CAST(0xEA350B00 AS Date), CAST(476.89 AS Decimal(7, 2)), CAST(114.50 AS Decimal(7, 2)), CAST(591.39 AS Decimal(7, 2)))
SET IDENTITY_INSERT [dbo].[retailOrder] OFF
/****** Object:  Table [dbo].[purchaseOrderDetail]    Script Date: 07/29/2012 20:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchaseOrderDetail](
	[poDtlLineID] [int] IDENTITY(30000000,1) NOT NULL,
	[poNbr] [int] NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL,
	[comments] [varchar](50) NULL,
 CONSTRAINT [pkPOOrdDtl] PRIMARY KEY CLUSTERED 
(
	[poDtlLineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[purchaseOrderDetail] ON
INSERT [dbo].[purchaseOrderDetail] ([poDtlLineID], [poNbr], [tireCode], [tireQty], [comments]) VALUES (30000000, 30000000, N'B378', CAST(20 AS Decimal(4, 0)), NULL)
SET IDENTITY_INSERT [dbo].[purchaseOrderDetail] OFF
/****** Object:  Table [dbo].[retailOrderDetail]    Script Date: 07/29/2012 20:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[retailOrderDetail](
	[rtlDtlLineID] [int] IDENTITY(10000000,1) NOT NULL,
	[retailOrderNbr] [int] NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL,
 CONSTRAINT [pkRtlOrderDtl] PRIMARY KEY CLUSTERED 
(
	[rtlDtlLineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[retailOrderDetail] ON
INSERT [dbo].[retailOrderDetail] ([rtlDtlLineID], [retailOrderNbr], [tireCode], [tireQty]) VALUES (10000000, 10000000, N'B378', CAST(4 AS Decimal(4, 0)))
INSERT [dbo].[retailOrderDetail] ([rtlDtlLineID], [retailOrderNbr], [tireCode], [tireQty]) VALUES (10000001, 10000000, N'A123', CAST(2 AS Decimal(4, 0)))
SET IDENTITY_INSERT [dbo].[retailOrderDetail] OFF
/****** Object:  Default [DF_tire_retailPrice]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_retailPrice]  DEFAULT ((0)) FOR [retailPrice]
GO
/****** Object:  Default [DF_tire_dealerPrice]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_dealerPrice]  DEFAULT ((0)) FOR [dealerPrice]
GO
/****** Object:  Default [DF_tire_wholesaleCost]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_wholesaleCost]  DEFAULT ((0)) FOR [wholesaleCost]
GO
/****** Object:  Default [dealerID]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[wholesaleOrder] ADD  CONSTRAINT [dealerID]  DEFAULT ((0)) FOR [dealerID]
GO
/****** Object:  Default [DF_wholesaleOrderDetail_tireQty]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail] ADD  CONSTRAINT [DF_wholesaleOrderDetail_tireQty]  DEFAULT ((0)) FOR [tireQty]
GO
/****** Object:  Default [DF_transferOrderDetail_tireQty]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[transferOrderDetail] ADD  CONSTRAINT [DF_transferOrderDetail_tireQty]  DEFAULT ((0)) FOR [tireQty]
GO
/****** Object:  Default [DF_purchaseOrderDetail_tireQty]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[purchaseOrderDetail] ADD  CONSTRAINT [DF_purchaseOrderDetail_tireQty]  DEFAULT ((0)) FOR [tireQty]
GO
/****** Object:  Default [DF_retailOrderDetail_tireQty]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[retailOrderDetail] ADD  CONSTRAINT [DF_retailOrderDetail_tireQty]  DEFAULT ((0)) FOR [tireQty]
GO
/****** Object:  ForeignKey [fkPOStore]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[purchaseOrder]  WITH CHECK ADD  CONSTRAINT [fkPOStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[purchaseOrder] CHECK CONSTRAINT [fkPOStore]
GO
/****** Object:  ForeignKey [fkStoreInv]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkStoreInv] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkStoreInv]
GO
/****** Object:  ForeignKey [fkTireInv]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkTireInv] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkTireInv]
GO
/****** Object:  ForeignKey [fkEmpStore]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [fkEmpStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [fkEmpStore]
GO
/****** Object:  ForeignKey [fkTrnRecStore]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[transferOrder]  WITH CHECK ADD  CONSTRAINT [fkTrnRecStore] FOREIGN KEY([receiveStore])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[transferOrder] CHECK CONSTRAINT [fkTrnRecStore]
GO
/****** Object:  ForeignKey [fkTrnShipStore]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[transferOrder]  WITH CHECK ADD  CONSTRAINT [fkTrnShipStore] FOREIGN KEY([shipStore])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[transferOrder] CHECK CONSTRAINT [fkTrnShipStore]
GO
/****** Object:  ForeignKey [fkWhslDealer]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[wholesaleOrder]  WITH CHECK ADD  CONSTRAINT [fkWhslDealer] FOREIGN KEY([dealerID])
REFERENCES [dbo].[dealer] ([dealerId])
GO
ALTER TABLE [dbo].[wholesaleOrder] CHECK CONSTRAINT [fkWhslDealer]
GO
/****** Object:  ForeignKey [fkWhslDtlOrder]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkWhslDtlOrder] FOREIGN KEY([whslOrderNbr])
REFERENCES [dbo].[wholesaleOrder] ([whslOrderNbr])
GO
ALTER TABLE [dbo].[wholesaleOrderDetail] CHECK CONSTRAINT [fkWhslDtlOrder]
GO
/****** Object:  ForeignKey [fkWhslDtlTire]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkWhslDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[wholesaleOrderDetail] CHECK CONSTRAINT [fkWhslDtlTire]
GO
/****** Object:  ForeignKey [fkTnfrDtlOrder]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[transferOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkTnfrDtlOrder] FOREIGN KEY([transferOrderNbr])
REFERENCES [dbo].[transferOrder] ([transferOrderNbr])
GO
ALTER TABLE [dbo].[transferOrderDetail] CHECK CONSTRAINT [fkTnfrDtlOrder]
GO
/****** Object:  ForeignKey [fkTnfrDtlTire]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[transferOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkTnfrDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[transferOrderDetail] CHECK CONSTRAINT [fkTnfrDtlTire]
GO
/****** Object:  ForeignKey [fkRtlOrdCust]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrdCust] FOREIGN KEY([customerID])
REFERENCES [dbo].[customer] ([customerID])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrdCust]
GO
/****** Object:  ForeignKey [fkRtlOrdEmp]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrdEmp] FOREIGN KEY([employeeID])
REFERENCES [dbo].[employee] ([employeeID])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrdEmp]
GO
/****** Object:  ForeignKey [fkRtlOrdStore]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrdStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrdStore]
GO
/****** Object:  ForeignKey [fkPOOrdNbr]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[purchaseOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkPOOrdNbr] FOREIGN KEY([poNbr])
REFERENCES [dbo].[purchaseOrder] ([poNbr])
GO
ALTER TABLE [dbo].[purchaseOrderDetail] CHECK CONSTRAINT [fkPOOrdNbr]
GO
/****** Object:  ForeignKey [fkPOTire]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[purchaseOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkPOTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[purchaseOrderDetail] CHECK CONSTRAINT [fkPOTire]
GO
/****** Object:  ForeignKey [fkRtlDtlOrder]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[retailOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkRtlDtlOrder] FOREIGN KEY([retailOrderNbr])
REFERENCES [dbo].[retailOrder] ([retailOrderNbr])
GO
ALTER TABLE [dbo].[retailOrderDetail] CHECK CONSTRAINT [fkRtlDtlOrder]
GO
/****** Object:  ForeignKey [fkRtlDtlTire]    Script Date: 07/29/2012 20:09:53 ******/
ALTER TABLE [dbo].[retailOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkRtlDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[retailOrderDetail] CHECK CONSTRAINT [fkRtlDtlTire]
GO
