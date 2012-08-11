USE [comp400_2012]
GO
ALTER TABLE [dbo].[retailOrderDetail] DROP CONSTRAINT [DF_retailOrderDetail_tireQty]
GO
ALTER TABLE [dbo].[tire] DROP CONSTRAINT [DF_tire_retailPrice]
GO
ALTER TABLE [dbo].[tire] DROP CONSTRAINT [DF_tire_dealerPrice]
GO
ALTER TABLE [dbo].[tire] DROP CONSTRAINT [DF_tire_wholesaleCost]
GO
ALTER TABLE [dbo].[transferOrderDetail] DROP CONSTRAINT [DF_transferOrderDetail_tireQty]
GO
ALTER TABLE [dbo].[wholesaleOrder] DROP CONSTRAINT [dealerID]
GO
ALTER TABLE [dbo].[wholesaleOrderDetail] DROP CONSTRAINT [DF_wholesaleOrderDetail_tireQty]
GO
/****** Object:  ForeignKey [fkEmpSecurity]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[employee] DROP CONSTRAINT [fkEmpSecurity]
GO
/****** Object:  ForeignKey [fkEmpStore]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[employee] DROP CONSTRAINT [fkEmpStore]
GO
/****** Object:  ForeignKey [fkStoreInv]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkStoreInv]
GO
/****** Object:  ForeignKey [fkTireInv]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkTireInv]
GO
/****** Object:  ForeignKey [fkPOStore]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[purchaseOrder] DROP CONSTRAINT [fkPOStore]
GO
/****** Object:  ForeignKey [fkPoVendor]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[purchaseOrder] DROP CONSTRAINT [fkPoVendor]
GO
/****** Object:  ForeignKey [fkPoDtlOrder]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[purchaseOrderDetail] DROP CONSTRAINT [fkPoDtlOrder]
GO
/****** Object:  ForeignKey [fkTireCode]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[purchaseOrderDetail] DROP CONSTRAINT [fkTireCode]
GO
/****** Object:  ForeignKey [fkRtlOrderCust]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrderCust]
GO
/****** Object:  ForeignKey [fkRtlOrderEmp]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrderEmp]
GO
/****** Object:  ForeignKey [fkRtlOrderStore]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrderStore]
GO
/****** Object:  ForeignKey [fkRtlDtlOrder]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[retailOrderDetail] DROP CONSTRAINT [fkRtlDtlOrder]
GO
/****** Object:  ForeignKey [fkRtlDtlTire]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[retailOrderDetail] DROP CONSTRAINT [fkRtlDtlTire]
GO
/****** Object:  ForeignKey [fkTrnRecStore]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[transferOrder] DROP CONSTRAINT [fkTrnRecStore]
GO
/****** Object:  ForeignKey [fkTrnShipStore]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[transferOrder] DROP CONSTRAINT [fkTrnShipStore]
GO
/****** Object:  ForeignKey [fkTnfrDtlOrder]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[transferOrderDetail] DROP CONSTRAINT [fkTnfrDtlOrder]
GO
/****** Object:  ForeignKey [fkTnfrDtlTire]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[transferOrderDetail] DROP CONSTRAINT [fkTnfrDtlTire]
GO
/****** Object:  ForeignKey [fkWhslDealer]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[wholesaleOrder] DROP CONSTRAINT [fkWhslDealer]
GO
/****** Object:  ForeignKey [fkWhslDtlOrder]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail] DROP CONSTRAINT [fkWhslDtlOrder]
GO
/****** Object:  ForeignKey [fkWhslDtlTire]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail] DROP CONSTRAINT [fkWhslDtlTire]
GO
/****** Object:  Table [dbo].[retailOrderDetail]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[retailOrderDetail]
GO
/****** Object:  Table [dbo].[purchaseOrderDetail]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[purchaseOrderDetail]
GO
/****** Object:  Table [dbo].[retailOrder]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[retailOrder]
GO
/****** Object:  Table [dbo].[transferOrderDetail]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[transferOrderDetail]
GO
/****** Object:  Table [dbo].[wholesaleOrderDetail]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[wholesaleOrderDetail]
GO
/****** Object:  Table [dbo].[wholesaleOrder]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[wholesaleOrder]
GO
/****** Object:  Table [dbo].[transferOrder]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[transferOrder]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[employee]
GO
/****** Object:  Table [dbo].[inventory]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[inventory]
GO
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[purchaseOrder]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[customer]
GO
/****** Object:  Table [dbo].[dealer]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[dealer]
GO
/****** Object:  Table [dbo].[securityClearance]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[securityClearance]
GO
/****** Object:  Table [dbo].[store]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[store]
GO
/****** Object:  Table [dbo].[tire]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[tire]
GO
/****** Object:  Table [dbo].[vendor]    Script Date: 08/11/2012 10:44:16 ******/
DROP TABLE [dbo].[vendor]
GO
/****** Object:  Table [dbo].[vendor]    Script Date: 08/11/2012 10:44:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vendor](
	[vendorID] [int] IDENTITY(1000,1) NOT NULL,
	[vendorName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_vendor] PRIMARY KEY CLUSTERED 
(
	[vendorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[vendor] ON
INSERT [dbo].[vendor] ([vendorID], [vendorName]) VALUES (1000, N'Bridgestone')
SET IDENTITY_INSERT [dbo].[vendor] OFF
/****** Object:  Table [dbo].[tire]    Script Date: 08/11/2012 10:44:16 ******/
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
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'A123', N'All Weather Radials', N'Cooper Tires', N'R215', CAST(104.95 AS Decimal(6, 2)), CAST(99.95 AS Decimal(6, 2)), CAST(85.45 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'B378', N'All Terrain', N'Bridgestone', N'R235', CAST(235.95 AS Decimal(6, 2)), CAST(4.88 AS Decimal(6, 2)), CAST(0.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'J475', N'Rain Warrior', N'Michelin', N'R205', CAST(137.99 AS Decimal(6, 2)), CAST(129.99 AS Decimal(6, 2)), CAST(0.00 AS Decimal(6, 2)))
/****** Object:  Table [dbo].[store]    Script Date: 08/11/2012 10:44:16 ******/
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
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0001', N'987 SE Hall St', N'Portland', N'OR', N'97222', N'5037468175', N'5037468760', N'store0001@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0002', N'736 SW Elk Lane 2', N'Gresham', N'OR', N'97220', N'5035641237', N'5035641238', N'store0002@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0003', N'Happy Hooker Lane', N'Happy Valley', N'OR', N'88888', N'222-255-5522', N'222-222-2222', N'store0003@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0005', N'8379 SW 10th Ave', N'Eugene', N'OR', N'97378', N'5418761283', N'5418761290', N'store0005@store.com')
/****** Object:  Table [dbo].[securityClearance]    Script Date: 08/11/2012 10:44:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[securityClearance](
	[Clearance] [varchar](15) NOT NULL,
 CONSTRAINT [PK_securityClearance] PRIMARY KEY CLUSTERED 
(
	[Clearance] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[securityClearance] ([Clearance]) VALUES (N'Admin')
INSERT [dbo].[securityClearance] ([Clearance]) VALUES (N'Manager')
INSERT [dbo].[securityClearance] ([Clearance]) VALUES (N'Sales')
INSERT [dbo].[securityClearance] ([Clearance]) VALUES (N'Temp')
INSERT [dbo].[securityClearance] ([Clearance]) VALUES (N'Warehouse')
/****** Object:  Table [dbo].[dealer]    Script Date: 08/11/2012 10:44:16 ******/
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
INSERT [dbo].[dealer] ([dealerId], [dealerAcctNbr], [dealerName], [dealerStreet], [dealerCity], [dealerState], [dealerZip], [dealerPhone]) VALUES (70000000, N'1000000001', N'Joe''s Shell', N'1234 Main St', N'Detroit', N'OR', N'97456', N'5036453456')
SET IDENTITY_INSERT [dbo].[dealer] OFF
/****** Object:  Table [dbo].[customer]    Script Date: 08/11/2012 10:44:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customer](
	[customerID] [int] IDENTITY(80000000,1) NOT NULL,
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
SET IDENTITY_INSERT [dbo].[customer] ON
INSERT [dbo].[customer] ([customerID], [custFirstName], [custLastName], [custStreet], [custCity], [custState], [custZip], [custPhone]) VALUES (80000000, N'Ken', N'Adams', N'7356 Sampson Dr', N'Portland', N'OR', N'97026', N'5035637356')
INSERT [dbo].[customer] ([customerID], [custFirstName], [custLastName], [custStreet], [custCity], [custState], [custZip], [custPhone]) VALUES (80000001, N'Joel', N'Smith', N'4332 NW Dickey Rd', N'McMinnville', N'OR', N'97128', N'5034742747')
SET IDENTITY_INSERT [dbo].[customer] OFF
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 08/11/2012 10:44:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchaseOrder](
	[poNbr] [int] IDENTITY(30000000,1) NOT NULL,
	[vendorID] [int] NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[poDate] [date] NOT NULL,
	[closed] [bit] NULL,
 CONSTRAINT [pkPurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[poNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[purchaseOrder] ON
INSERT [dbo].[purchaseOrder] ([poNbr], [vendorID], [storeNbr], [poDate], [closed]) VALUES (30000000, 1000, N'0001', CAST(0xEA350B00 AS Date), NULL)
INSERT [dbo].[purchaseOrder] ([poNbr], [vendorID], [storeNbr], [poDate], [closed]) VALUES (30000001, 1000, N'0002', CAST(0x01360B00 AS Date), NULL)
SET IDENTITY_INSERT [dbo].[purchaseOrder] OFF
/****** Object:  Table [dbo].[inventory]    Script Date: 08/11/2012 10:44:16 ******/
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
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (50000000, N'A123', N'0001', CAST(10 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (50000002, N'B378', N'0002', CAST(8 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (50000003, N'J475', N'0005', CAST(8 AS Decimal(4, 0)))
SET IDENTITY_INSERT [dbo].[inventory] OFF
/****** Object:  Table [dbo].[employee]    Script Date: 08/11/2012 10:44:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employee](
	[employeeID] [int] IDENTITY(1000,1) NOT NULL,
	[firstName] [varchar](30) NOT NULL,
	[lastName] [varchar](30) NOT NULL,
	[userID] [varchar](15) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[userSecurityLevel] [varchar](15) NOT NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[employee] ON
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (90000000, N'Stanley', N'Harrisy', N'sharris', N'sh1234', N'0001', N'Temp')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (90000001, N'Susan', N'Barnes', N'abarnes', N'sb1234', N'0002', N'Sales')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (90000002, N'Howard', N'Newton', N'hnewton', N'hn1234', N'0001', N'Manager')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (90000004, N'Alan', N'Rankin', N'arankin', N'ar1234', N'0001', N'Admin')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (90000005, N'Barb', N'Mason', N'bmason', N'bm1234', N'0005', N'Warehouse')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (90000006, N'James', N'Ellis', N'jellis', N'je1234', N'0003', N'Manager')
SET IDENTITY_INSERT [dbo].[employee] OFF
/****** Object:  Table [dbo].[transferOrder]    Script Date: 08/11/2012 10:44:16 ******/
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
/****** Object:  Table [dbo].[wholesaleOrder]    Script Date: 08/11/2012 10:44:16 ******/
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
/****** Object:  Table [dbo].[wholesaleOrderDetail]    Script Date: 08/11/2012 10:44:16 ******/
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
/****** Object:  Table [dbo].[transferOrderDetail]    Script Date: 08/11/2012 10:44:16 ******/
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
/****** Object:  Table [dbo].[retailOrder]    Script Date: 08/11/2012 10:44:16 ******/
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
	[closed] [bit] NULL,
 CONSTRAINT [pkRetailOrder] PRIMARY KEY CLUSTERED 
(
	[retailOrderNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[purchaseOrderDetail]    Script Date: 08/11/2012 10:44:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchaseOrderDetail](
	[poDtlLineID] [int] IDENTITY(2000,1) NOT NULL,
	[poNbr] [int] NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[tireQtyOrdered] [decimal](4, 0) NOT NULL,
	[tireQtyReceived] [decimal](4, 0) NULL,
	[comments] [varchar](max) NULL,
 CONSTRAINT [PK_purchaseOrderDetail] PRIMARY KEY CLUSTERED 
(
	[poDtlLineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[purchaseOrderDetail] ON
INSERT [dbo].[purchaseOrderDetail] ([poDtlLineID], [poNbr], [tireCode], [tireQtyOrdered], [tireQtyReceived], [comments]) VALUES (30000000, 30000000, N'B378', CAST(20 AS Decimal(4, 0)), NULL, NULL)
SET IDENTITY_INSERT [dbo].[purchaseOrderDetail] OFF
/****** Object:  Table [dbo].[retailOrderDetail]    Script Date: 08/11/2012 10:44:16 ******/
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
/****** Object:  Default [DF_retailOrderDetail_tireQty]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[retailOrderDetail] ADD  CONSTRAINT [DF_retailOrderDetail_tireQty]  DEFAULT ((0)) FOR [tireQty]
GO
/****** Object:  Default [DF_tire_retailPrice]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_retailPrice]  DEFAULT ((0)) FOR [retailPrice]
GO
/****** Object:  Default [DF_tire_dealerPrice]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_dealerPrice]  DEFAULT ((0)) FOR [dealerPrice]
GO
/****** Object:  Default [DF_tire_wholesaleCost]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_wholesaleCost]  DEFAULT ((0)) FOR [wholesaleCost]
GO
/****** Object:  Default [DF_transferOrderDetail_tireQty]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[transferOrderDetail] ADD  CONSTRAINT [DF_transferOrderDetail_tireQty]  DEFAULT ((0)) FOR [tireQty]
GO
/****** Object:  Default [dealerID]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[wholesaleOrder] ADD  CONSTRAINT [dealerID]  DEFAULT ((0)) FOR [dealerID]
GO
/****** Object:  Default [DF_wholesaleOrderDetail_tireQty]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail] ADD  CONSTRAINT [DF_wholesaleOrderDetail_tireQty]  DEFAULT ((0)) FOR [tireQty]
GO
/****** Object:  ForeignKey [fkEmpSecurity]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [fkEmpSecurity] FOREIGN KEY([userSecurityLevel])
REFERENCES [dbo].[securityClearance] ([Clearance])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [fkEmpSecurity]
GO
/****** Object:  ForeignKey [fkEmpStore]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [fkEmpStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [fkEmpStore]
GO
/****** Object:  ForeignKey [fkStoreInv]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkStoreInv] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkStoreInv]
GO
/****** Object:  ForeignKey [fkTireInv]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkTireInv] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkTireInv]
GO
/****** Object:  ForeignKey [fkPOStore]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[purchaseOrder]  WITH CHECK ADD  CONSTRAINT [fkPOStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[purchaseOrder] CHECK CONSTRAINT [fkPOStore]
GO
/****** Object:  ForeignKey [fkPoVendor]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[purchaseOrder]  WITH CHECK ADD  CONSTRAINT [fkPoVendor] FOREIGN KEY([vendorID])
REFERENCES [dbo].[vendor] ([vendorID])
GO
ALTER TABLE [dbo].[purchaseOrder] CHECK CONSTRAINT [fkPoVendor]
GO
/****** Object:  ForeignKey [fkPoDtlOrder]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[purchaseOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkPoDtlOrder] FOREIGN KEY([poNbr])
REFERENCES [dbo].[purchaseOrder] ([poNbr])
GO
ALTER TABLE [dbo].[purchaseOrderDetail] CHECK CONSTRAINT [fkPoDtlOrder]
GO
/****** Object:  ForeignKey [fkTireCode]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[purchaseOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkTireCode] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[purchaseOrderDetail] CHECK CONSTRAINT [fkTireCode]
GO
/****** Object:  ForeignKey [fkRtlOrderCust]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrderCust] FOREIGN KEY([customerID])
REFERENCES [dbo].[customer] ([customerID])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrderCust]
GO
/****** Object:  ForeignKey [fkRtlOrderEmp]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrderEmp] FOREIGN KEY([employeeID])
REFERENCES [dbo].[employee] ([employeeID])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrderEmp]
GO
/****** Object:  ForeignKey [fkRtlOrderStore]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrderStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrderStore]
GO
/****** Object:  ForeignKey [fkRtlDtlOrder]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[retailOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkRtlDtlOrder] FOREIGN KEY([retailOrderNbr])
REFERENCES [dbo].[retailOrder] ([retailOrderNbr])
GO
ALTER TABLE [dbo].[retailOrderDetail] CHECK CONSTRAINT [fkRtlDtlOrder]
GO
/****** Object:  ForeignKey [fkRtlDtlTire]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[retailOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkRtlDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[retailOrderDetail] CHECK CONSTRAINT [fkRtlDtlTire]
GO
/****** Object:  ForeignKey [fkTrnRecStore]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[transferOrder]  WITH CHECK ADD  CONSTRAINT [fkTrnRecStore] FOREIGN KEY([receiveStore])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[transferOrder] CHECK CONSTRAINT [fkTrnRecStore]
GO
/****** Object:  ForeignKey [fkTrnShipStore]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[transferOrder]  WITH CHECK ADD  CONSTRAINT [fkTrnShipStore] FOREIGN KEY([shipStore])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[transferOrder] CHECK CONSTRAINT [fkTrnShipStore]
GO
/****** Object:  ForeignKey [fkTnfrDtlOrder]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[transferOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkTnfrDtlOrder] FOREIGN KEY([transferOrderNbr])
REFERENCES [dbo].[transferOrder] ([transferOrderNbr])
GO
ALTER TABLE [dbo].[transferOrderDetail] CHECK CONSTRAINT [fkTnfrDtlOrder]
GO
/****** Object:  ForeignKey [fkTnfrDtlTire]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[transferOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkTnfrDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[transferOrderDetail] CHECK CONSTRAINT [fkTnfrDtlTire]
GO
/****** Object:  ForeignKey [fkWhslDealer]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[wholesaleOrder]  WITH CHECK ADD  CONSTRAINT [fkWhslDealer] FOREIGN KEY([dealerID])
REFERENCES [dbo].[dealer] ([dealerId])
GO
ALTER TABLE [dbo].[wholesaleOrder] CHECK CONSTRAINT [fkWhslDealer]
GO
/****** Object:  ForeignKey [fkWhslDtlOrder]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkWhslDtlOrder] FOREIGN KEY([whslOrderNbr])
REFERENCES [dbo].[wholesaleOrder] ([whslOrderNbr])
GO
ALTER TABLE [dbo].[wholesaleOrderDetail] CHECK CONSTRAINT [fkWhslDtlOrder]
GO
/****** Object:  ForeignKey [fkWhslDtlTire]    Script Date: 08/11/2012 10:44:16 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkWhslDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[wholesaleOrderDetail] CHECK CONSTRAINT [fkWhslDtlTire]
GO
