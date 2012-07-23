USE [comp400_2012]
GO
/****** Object:  ForeignKey [fkEmpStore]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[employee] DROP CONSTRAINT [fkEmpStore]
GO
/****** Object:  ForeignKey [fkStoreinv]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkStoreinv]
GO
/****** Object:  ForeignKey [fkTireinv]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkTireinv]
GO
/****** Object:  ForeignKey [fkPOStore]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[purchaseOrder] DROP CONSTRAINT [fkPOStore]
GO
/****** Object:  ForeignKey [fkPODtlOrder]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[purchaseOrderDetail] DROP CONSTRAINT [fkPODtlOrder]
GO
/****** Object:  ForeignKey [fkPODtlTire]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[purchaseOrderDetail] DROP CONSTRAINT [fkPODtlTire]
GO
/****** Object:  ForeignKey [fkRtlOrdCust]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrdCust]
GO
/****** Object:  ForeignKey [fkRtlOrdEmp]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrdEmp]
GO
/****** Object:  ForeignKey [fkRtlOrdStore]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrdStore]
GO
/****** Object:  ForeignKey [fkRtlDtlOrder]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[retailOrderDetail] DROP CONSTRAINT [fkRtlDtlOrder]
GO
/****** Object:  ForeignKey [fkRtlDtlTire]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[retailOrderDetail] DROP CONSTRAINT [fkRtlDtlTire]
GO
/****** Object:  ForeignKey [fkTrnRecStore]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[transferOrder] DROP CONSTRAINT [fkTrnRecStore]
GO
/****** Object:  ForeignKey [fkTrnShipStore]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[transferOrder] DROP CONSTRAINT [fkTrnShipStore]
GO
/****** Object:  ForeignKey [fkTnfrDtlOrder]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[transferOrderDetail] DROP CONSTRAINT [fkTnfrDtlOrder]
GO
/****** Object:  ForeignKey [fkTnfrDtlTire]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[transferOrderDetail] DROP CONSTRAINT [fkTnfrDtlTire]
GO
/****** Object:  ForeignKey [fkWhslDealer]    Script Date: 07/22/2012 21:18:09 ******/
ALTER TABLE [dbo].[wholesaleOrder] DROP CONSTRAINT [fkWhslDealer]
GO
/****** Object:  ForeignKey [fkWhslDtlOrder]    Script Date: 07/22/2012 21:18:09 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail] DROP CONSTRAINT [fkWhslDtlOrder]
GO
/****** Object:  ForeignKey [fkWhslDtlTire]    Script Date: 07/22/2012 21:18:09 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail] DROP CONSTRAINT [fkWhslDtlTire]
GO
/****** Object:  Table [dbo].[retailOrderDetail]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[retailOrderDetail] DROP CONSTRAINT [fkRtlDtlOrder]
GO
ALTER TABLE [dbo].[retailOrderDetail] DROP CONSTRAINT [fkRtlDtlTire]
GO
ALTER TABLE [dbo].[retailOrderDetail] DROP CONSTRAINT [DF_retailOrderDetail_tireQty]
GO
DROP TABLE [dbo].[retailOrderDetail]
GO
/****** Object:  Table [dbo].[purchaseOrderDetail]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[purchaseOrderDetail] DROP CONSTRAINT [fkPODtlOrder]
GO
ALTER TABLE [dbo].[purchaseOrderDetail] DROP CONSTRAINT [fkPODtlTire]
GO
ALTER TABLE [dbo].[purchaseOrderDetail] DROP CONSTRAINT [DF_purchaseOrderDetail_tireQty]
GO
DROP TABLE [dbo].[purchaseOrderDetail]
GO
/****** Object:  Table [dbo].[retailOrder]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrdCust]
GO
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrdEmp]
GO
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrdStore]
GO
DROP TABLE [dbo].[retailOrder]
GO
/****** Object:  Table [dbo].[transferOrderDetail]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[transferOrderDetail] DROP CONSTRAINT [fkTnfrDtlOrder]
GO
ALTER TABLE [dbo].[transferOrderDetail] DROP CONSTRAINT [fkTnfrDtlTire]
GO
ALTER TABLE [dbo].[transferOrderDetail] DROP CONSTRAINT [DF_transferOrderDetail_tireQty]
GO
DROP TABLE [dbo].[transferOrderDetail]
GO
/****** Object:  Table [dbo].[wholesaleOrderDetail]    Script Date: 07/22/2012 21:18:09 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail] DROP CONSTRAINT [fkWhslDtlOrder]
GO
ALTER TABLE [dbo].[wholesaleOrderDetail] DROP CONSTRAINT [fkWhslDtlTire]
GO
ALTER TABLE [dbo].[wholesaleOrderDetail] DROP CONSTRAINT [DF_wholesaleOrderDetail_tireQty]
GO
DROP TABLE [dbo].[wholesaleOrderDetail]
GO
/****** Object:  Table [dbo].[wholesaleOrder]    Script Date: 07/22/2012 21:18:09 ******/
ALTER TABLE [dbo].[wholesaleOrder] DROP CONSTRAINT [fkWhslDealer]
GO
DROP TABLE [dbo].[wholesaleOrder]
GO
/****** Object:  Table [dbo].[transferOrder]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[transferOrder] DROP CONSTRAINT [fkTrnRecStore]
GO
ALTER TABLE [dbo].[transferOrder] DROP CONSTRAINT [fkTrnShipStore]
GO
DROP TABLE [dbo].[transferOrder]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[employee] DROP CONSTRAINT [fkEmpStore]
GO
DROP TABLE [dbo].[employee]
GO
/****** Object:  Table [dbo].[inventory]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkStoreinv]
GO
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkTireinv]
GO
DROP TABLE [dbo].[inventory]
GO
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[purchaseOrder] DROP CONSTRAINT [fkPOStore]
GO
DROP TABLE [dbo].[purchaseOrder]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 07/22/2012 21:18:08 ******/
DROP TABLE [dbo].[customer]
GO
/****** Object:  Table [dbo].[dealer]    Script Date: 07/22/2012 21:18:08 ******/
DROP TABLE [dbo].[dealer]
GO
/****** Object:  Table [dbo].[store]    Script Date: 07/22/2012 21:18:08 ******/
DROP TABLE [dbo].[store]
GO
/****** Object:  Table [dbo].[tire]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[tire] DROP CONSTRAINT [DF_tire_retailPrice]
GO
ALTER TABLE [dbo].[tire] DROP CONSTRAINT [DF_tire_dealerPrice]
GO
ALTER TABLE [dbo].[tire] DROP CONSTRAINT [DF_tire_wholesaleCost]
GO
DROP TABLE [dbo].[tire]
GO
/****** Object:  Table [dbo].[tire]    Script Date: 07/22/2012 21:18:08 ******/
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
	[retailPrice] [decimal](6, 2) NOT NULL CONSTRAINT [DF_tire_retailPrice]  DEFAULT ((0)),
	[dealerPrice] [decimal](6, 2) NOT NULL CONSTRAINT [DF_tire_dealerPrice]  DEFAULT ((0)),
	[wholesaleCost] [decimal](6, 2) NOT NULL CONSTRAINT [DF_tire_wholesaleCost]  DEFAULT ((0)),
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
/****** Object:  Table [dbo].[store]    Script Date: 07/22/2012 21:18:08 ******/
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
/****** Object:  Table [dbo].[dealer]    Script Date: 07/22/2012 21:18:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dealer](
	[dealerAcctNbr] [varchar](10) NOT NULL,
	[dealerName] [varchar](30) NOT NULL,
	[dealerStreet] [varchar](30) NOT NULL,
	[dealerCity] [varchar](30) NOT NULL,
	[dealerState] [varchar](30) NOT NULL,
	[dealerZip] [varchar](10) NOT NULL,
	[dealerPhone] [varchar](16) NOT NULL,
 CONSTRAINT [pkDealer] PRIMARY KEY CLUSTERED 
(
	[dealerAcctNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[dealer] ([dealerAcctNbr], [dealerName], [dealerStreet], [dealerCity], [dealerState], [dealerZip], [dealerPhone]) VALUES (N'D000000001', N'Steve''s Auto Repair', N'847 Broadway Blvd', N'Colton', N'OR', N'97047', N'503 425-9876')
/****** Object:  Table [dbo].[customer]    Script Date: 07/22/2012 21:18:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customer](
	[customerID] [varchar](10) NOT NULL,
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
INSERT [dbo].[customer] ([customerID], [custFirstName], [custLastName], [custStreet], [custCity], [custState], [custZip], [custPhone]) VALUES (N'C000000001', N'Dave', N'Johnson', N'736 SE York Lane', N'Coos Bay', N'OR', N'97856', N'541 746-2276')
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 07/22/2012 21:18:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchaseOrder](
	[poNbr] [varchar](8) NOT NULL,
	[vendorID] [varchar](10) NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
 CONSTRAINT [pkPurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[poNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[purchaseOrder] ([poNbr], [vendorID], [storeNbr]) VALUES (N'P0000001', N'V000000001', N'0001')
/****** Object:  Table [dbo].[inventory]    Script Date: 07/22/2012 21:18:08 ******/
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
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (N'T00001', N'A123', N'0001', CAST(3 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (N'T00002', N'A123', N'0002', CAST(6 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (N'T00003', N'B378', N'0002', CAST(1 AS Decimal(4, 0)))
/****** Object:  Table [dbo].[employee]    Script Date: 07/22/2012 21:18:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employee](
	[employeeID] [varchar](10) NOT NULL,
	[firstName] [varchar](30) NOT NULL,
	[lastName] [varchar](30) NOT NULL,
	[userID] [varchar](15) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[userSecurityLevel] [varchar](15) NOT NULL,
 CONSTRAINT [pkEmployee] PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (N'1000000001', N'Stanley', N'Harris', N'sharris', N'sh1234', N'0001', N'Warehouse')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (N'1000000002', N'Susan', N'Barnes', N'abarnes', N'sb1234', N'0002', N'Sales')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (N'1000000003', N'Howard', N'Newton', N'hnewton', N'hn1234', N'0001', N'Manager')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (N'1000000004', N'Alan', N'Rankin', N'arankin', N'ar1234', N'0001', N'Admin')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (N'1000000005', N'Barb', N'Mason', N'bmason', N'bm1234', N'0005', N'General')
/****** Object:  Table [dbo].[transferOrder]    Script Date: 07/22/2012 21:18:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[transferOrder](
	[transferOrderNbr] [varchar](8) NOT NULL,
	[shipStore] [varchar](5) NOT NULL,
	[receiveStore] [varchar](5) NOT NULL,
 CONSTRAINT [pkTransferOrder] PRIMARY KEY CLUSTERED 
(
	[transferOrderNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[transferOrder] ([transferOrderNbr], [shipStore], [receiveStore]) VALUES (N'T0000001', N'0002', N'0005')
/****** Object:  Table [dbo].[wholesaleOrder]    Script Date: 07/22/2012 21:18:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[wholesaleOrder](
	[whslOrderNbr] [varchar](8) NOT NULL,
	[dealerAcctNbr] [varchar](10) NOT NULL,
	[transactionTotal] [decimal](7, 2) NOT NULL,
 CONSTRAINT [pkWholesaleOrder] PRIMARY KEY CLUSTERED 
(
	[whslOrderNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[wholesaleOrder] ([whslOrderNbr], [dealerAcctNbr], [transactionTotal]) VALUES (N'W0000001', N'D000000001', CAST(745.97 AS Decimal(7, 2)))
/****** Object:  Table [dbo].[wholesaleOrderDetail]    Script Date: 07/22/2012 21:18:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[wholesaleOrderDetail](
	[whslDtlLineID] [varchar](11) NOT NULL,
	[whslOrderNbr] [varchar](8) NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL CONSTRAINT [DF_wholesaleOrderDetail_tireQty]  DEFAULT ((0)),
 CONSTRAINT [pkWhslOrdDtl] PRIMARY KEY CLUSTERED 
(
	[whslDtlLineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[wholesaleOrderDetail] ([whslDtlLineID], [whslOrderNbr], [tireCode], [tireQty]) VALUES (N'W0000001001', N'W0000001', N'J475', CAST(15 AS Decimal(4, 0)))
/****** Object:  Table [dbo].[transferOrderDetail]    Script Date: 07/22/2012 21:18:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[transferOrderDetail](
	[tnfrDtlLineID] [varchar](11) NOT NULL,
	[transferOrderNbr] [varchar](8) NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL CONSTRAINT [DF_transferOrderDetail_tireQty]  DEFAULT ((0)),
 CONSTRAINT [pkTnfrOrderDtl] PRIMARY KEY CLUSTERED 
(
	[tnfrDtlLineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[transferOrderDetail] ([tnfrDtlLineID], [transferOrderNbr], [tireCode], [tireQty]) VALUES (N'T0000001001', N'T0000001', N'A123', CAST(10 AS Decimal(4, 0)))
/****** Object:  Table [dbo].[retailOrder]    Script Date: 07/22/2012 21:18:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[retailOrder](
	[retailOrderNbr] [varchar](8) NOT NULL,
	[customerID] [varchar](10) NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[employeeID] [varchar](10) NOT NULL,
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
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [taxableTotal], [laborCharges], [retailOrderTotal]) VALUES (N'R0000001', N'C000000001', N'0002', N'1000000002', CAST(0xEA350B00 AS Date), CAST(476.89 AS Decimal(7, 2)), CAST(114.50 AS Decimal(7, 2)), CAST(591.39 AS Decimal(7, 2)))
/****** Object:  Table [dbo].[purchaseOrderDetail]    Script Date: 07/22/2012 21:18:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchaseOrderDetail](
	[poDtlLineID] [varchar](11) NOT NULL,
	[poNbr] [varchar](8) NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL CONSTRAINT [DF_purchaseOrderDetail_tireQty]  DEFAULT ((0)),
 CONSTRAINT [pkPODtl] PRIMARY KEY CLUSTERED 
(
	[poDtlLineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[purchaseOrderDetail] ([poDtlLineID], [poNbr], [tireCode], [tireQty]) VALUES (N'P0000001001', N'P0000001', N'B378', CAST(20 AS Decimal(4, 0)))
/****** Object:  Table [dbo].[retailOrderDetail]    Script Date: 07/22/2012 21:18:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[retailOrderDetail](
	[rtlDtlLineID] [varchar](11) NOT NULL,
	[retailOrderNbr] [varchar](8) NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL CONSTRAINT [DF_retailOrderDetail_tireQty]  DEFAULT ((0)),
 CONSTRAINT [pkRtlOrderDtl] PRIMARY KEY CLUSTERED 
(
	[rtlDtlLineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[retailOrderDetail] ([rtlDtlLineID], [retailOrderNbr], [tireCode], [tireQty]) VALUES (N'R0000001001', N'R0000001', N'B378', CAST(4 AS Decimal(4, 0)))
INSERT [dbo].[retailOrderDetail] ([rtlDtlLineID], [retailOrderNbr], [tireCode], [tireQty]) VALUES (N'R0000001002', N'R0000001', N'A123', CAST(2 AS Decimal(4, 0)))
/****** Object:  ForeignKey [fkEmpStore]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [fkEmpStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [fkEmpStore]
GO
/****** Object:  ForeignKey [fkStoreinv]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkStoreinv] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkStoreinv]
GO
/****** Object:  ForeignKey [fkTireinv]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkTireinv] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkTireinv]
GO
/****** Object:  ForeignKey [fkPOStore]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[purchaseOrder]  WITH CHECK ADD  CONSTRAINT [fkPOStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[purchaseOrder] CHECK CONSTRAINT [fkPOStore]
GO
/****** Object:  ForeignKey [fkPODtlOrder]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[purchaseOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkPODtlOrder] FOREIGN KEY([poNbr])
REFERENCES [dbo].[purchaseOrder] ([poNbr])
GO
ALTER TABLE [dbo].[purchaseOrderDetail] CHECK CONSTRAINT [fkPODtlOrder]
GO
/****** Object:  ForeignKey [fkPODtlTire]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[purchaseOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkPODtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[purchaseOrderDetail] CHECK CONSTRAINT [fkPODtlTire]
GO
/****** Object:  ForeignKey [fkRtlOrdCust]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrdCust] FOREIGN KEY([customerID])
REFERENCES [dbo].[customer] ([customerID])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrdCust]
GO
/****** Object:  ForeignKey [fkRtlOrdEmp]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrdEmp] FOREIGN KEY([employeeID])
REFERENCES [dbo].[employee] ([employeeID])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrdEmp]
GO
/****** Object:  ForeignKey [fkRtlOrdStore]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrdStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrdStore]
GO
/****** Object:  ForeignKey [fkRtlDtlOrder]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[retailOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkRtlDtlOrder] FOREIGN KEY([retailOrderNbr])
REFERENCES [dbo].[retailOrder] ([retailOrderNbr])
GO
ALTER TABLE [dbo].[retailOrderDetail] CHECK CONSTRAINT [fkRtlDtlOrder]
GO
/****** Object:  ForeignKey [fkRtlDtlTire]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[retailOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkRtlDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[retailOrderDetail] CHECK CONSTRAINT [fkRtlDtlTire]
GO
/****** Object:  ForeignKey [fkTrnRecStore]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[transferOrder]  WITH CHECK ADD  CONSTRAINT [fkTrnRecStore] FOREIGN KEY([receiveStore])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[transferOrder] CHECK CONSTRAINT [fkTrnRecStore]
GO
/****** Object:  ForeignKey [fkTrnShipStore]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[transferOrder]  WITH CHECK ADD  CONSTRAINT [fkTrnShipStore] FOREIGN KEY([shipStore])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[transferOrder] CHECK CONSTRAINT [fkTrnShipStore]
GO
/****** Object:  ForeignKey [fkTnfrDtlOrder]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[transferOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkTnfrDtlOrder] FOREIGN KEY([transferOrderNbr])
REFERENCES [dbo].[transferOrder] ([transferOrderNbr])
GO
ALTER TABLE [dbo].[transferOrderDetail] CHECK CONSTRAINT [fkTnfrDtlOrder]
GO
/****** Object:  ForeignKey [fkTnfrDtlTire]    Script Date: 07/22/2012 21:18:08 ******/
ALTER TABLE [dbo].[transferOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkTnfrDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[transferOrderDetail] CHECK CONSTRAINT [fkTnfrDtlTire]
GO
/****** Object:  ForeignKey [fkWhslDealer]    Script Date: 07/22/2012 21:18:09 ******/
ALTER TABLE [dbo].[wholesaleOrder]  WITH CHECK ADD  CONSTRAINT [fkWhslDealer] FOREIGN KEY([dealerAcctNbr])
REFERENCES [dbo].[dealer] ([dealerAcctNbr])
GO
ALTER TABLE [dbo].[wholesaleOrder] CHECK CONSTRAINT [fkWhslDealer]
GO
/****** Object:  ForeignKey [fkWhslDtlOrder]    Script Date: 07/22/2012 21:18:09 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkWhslDtlOrder] FOREIGN KEY([whslOrderNbr])
REFERENCES [dbo].[wholesaleOrder] ([whslOrderNbr])
GO
ALTER TABLE [dbo].[wholesaleOrderDetail] CHECK CONSTRAINT [fkWhslDtlOrder]
GO
/****** Object:  ForeignKey [fkWhslDtlTire]    Script Date: 07/22/2012 21:18:09 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkWhslDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[wholesaleOrderDetail] CHECK CONSTRAINT [fkWhslDtlTire]
GO
