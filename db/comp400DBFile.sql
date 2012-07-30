USE [comp400_2012]
GO
/****** Object:  User [CS\skaneko]    Script Date: 07/29/2012 15:52:09 ******/
CREATE USER [CS\skaneko] FOR LOGIN [CS\skaneko] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [CS\mayer]    Script Date: 07/29/2012 15:52:09 ******/
CREATE USER [CS\mayer] FOR LOGIN [CS\mayer] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [CS\jellis]    Script Date: 07/29/2012 15:52:09 ******/
CREATE USER [CS\jellis] FOR LOGIN [CS\jellis] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [CS\aschole]    Script Date: 07/29/2012 15:52:09 ******/
CREATE USER [CS\aschole] FOR LOGIN [CS\aschole] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [CS\aschalt]    Script Date: 07/29/2012 15:52:09 ******/
CREATE USER [CS\aschalt] FOR LOGIN [CS\aschalt] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [CS\amavrico]    Script Date: 07/29/2012 15:52:09 ******/
CREATE USER [CS\amavrico] FOR LOGIN [CS\amavrico] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[tire]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[store]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[dealer]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[customer]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[inventory]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[employee]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[transferOrder]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[wholesaleOrder]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[wholesaleOrderDetail]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[transferOrderDetail]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[retailOrder]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[purchaseOrderDetail]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Table [dbo].[retailOrderDetail]    Script Date: 07/29/2012 15:52:11 ******/
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
/****** Object:  Default [DF_tire_retailPrice]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_retailPrice]  DEFAULT ((0)) FOR [retailPrice]
GO
/****** Object:  Default [DF_tire_dealerPrice]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_dealerPrice]  DEFAULT ((0)) FOR [dealerPrice]
GO
/****** Object:  Default [DF_tire_wholesaleCost]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_wholesaleCost]  DEFAULT ((0)) FOR [wholesaleCost]
GO
/****** Object:  Default [dealerID]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[wholesaleOrder] ADD  CONSTRAINT [dealerID]  DEFAULT ((0)) FOR [dealerID]
GO
/****** Object:  Default [DF_wholesaleOrderDetail_tireQty]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail] ADD  CONSTRAINT [DF_wholesaleOrderDetail_tireQty]  DEFAULT ((0)) FOR [tireQty]
GO
/****** Object:  Default [DF_transferOrderDetail_tireQty]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[transferOrderDetail] ADD  CONSTRAINT [DF_transferOrderDetail_tireQty]  DEFAULT ((0)) FOR [tireQty]
GO
/****** Object:  Default [DF_purchaseOrderDetail_tireQty]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[purchaseOrderDetail] ADD  CONSTRAINT [DF_purchaseOrderDetail_tireQty]  DEFAULT ((0)) FOR [tireQty]
GO
/****** Object:  Default [DF_retailOrderDetail_tireQty]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[retailOrderDetail] ADD  CONSTRAINT [DF_retailOrderDetail_tireQty]  DEFAULT ((0)) FOR [tireQty]
GO
/****** Object:  ForeignKey [fkPOStore]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[purchaseOrder]  WITH CHECK ADD  CONSTRAINT [fkPOStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[purchaseOrder] CHECK CONSTRAINT [fkPOStore]
GO
/****** Object:  ForeignKey [fkStoreInv]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkStoreInv] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkStoreInv]
GO
/****** Object:  ForeignKey [fkTireInv]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkTireInv] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkTireInv]
GO
/****** Object:  ForeignKey [fkEmpStore]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [fkEmpStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [fkEmpStore]
GO
/****** Object:  ForeignKey [fkTrnRecStore]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[transferOrder]  WITH CHECK ADD  CONSTRAINT [fkTrnRecStore] FOREIGN KEY([receiveStore])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[transferOrder] CHECK CONSTRAINT [fkTrnRecStore]
GO
/****** Object:  ForeignKey [fkTrnShipStore]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[transferOrder]  WITH CHECK ADD  CONSTRAINT [fkTrnShipStore] FOREIGN KEY([shipStore])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[transferOrder] CHECK CONSTRAINT [fkTrnShipStore]
GO
/****** Object:  ForeignKey [fkWhslDealer]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[wholesaleOrder]  WITH CHECK ADD  CONSTRAINT [fkWhslDealer] FOREIGN KEY([dealerID])
REFERENCES [dbo].[dealer] ([dealerId])
GO
ALTER TABLE [dbo].[wholesaleOrder] CHECK CONSTRAINT [fkWhslDealer]
GO
/****** Object:  ForeignKey [fkWhslDtlOrder]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkWhslDtlOrder] FOREIGN KEY([whslOrderNbr])
REFERENCES [dbo].[wholesaleOrder] ([whslOrderNbr])
GO
ALTER TABLE [dbo].[wholesaleOrderDetail] CHECK CONSTRAINT [fkWhslDtlOrder]
GO
/****** Object:  ForeignKey [fkWhslDtlTire]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[wholesaleOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkWhslDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[wholesaleOrderDetail] CHECK CONSTRAINT [fkWhslDtlTire]
GO
/****** Object:  ForeignKey [fkTnfrDtlOrder]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[transferOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkTnfrDtlOrder] FOREIGN KEY([transferOrderNbr])
REFERENCES [dbo].[transferOrder] ([transferOrderNbr])
GO
ALTER TABLE [dbo].[transferOrderDetail] CHECK CONSTRAINT [fkTnfrDtlOrder]
GO
/****** Object:  ForeignKey [fkTnfrDtlTire]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[transferOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkTnfrDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[transferOrderDetail] CHECK CONSTRAINT [fkTnfrDtlTire]
GO
/****** Object:  ForeignKey [fkRtlOrdCust]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrdCust] FOREIGN KEY([customerID])
REFERENCES [dbo].[customer] ([customerID])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrdCust]
GO
/****** Object:  ForeignKey [fkRtlOrdEmp]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrdEmp] FOREIGN KEY([employeeID])
REFERENCES [dbo].[employee] ([employeeID])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrdEmp]
GO
/****** Object:  ForeignKey [fkRtlOrdStore]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrdStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrdStore]
GO
/****** Object:  ForeignKey [fkPOOrdNbr]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[purchaseOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkPOOrdNbr] FOREIGN KEY([poNbr])
REFERENCES [dbo].[purchaseOrder] ([poNbr])
GO
ALTER TABLE [dbo].[purchaseOrderDetail] CHECK CONSTRAINT [fkPOOrdNbr]
GO
/****** Object:  ForeignKey [fkPOTire]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[purchaseOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkPOTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[purchaseOrderDetail] CHECK CONSTRAINT [fkPOTire]
GO
/****** Object:  ForeignKey [fkRtlDtlOrder]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[retailOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkRtlDtlOrder] FOREIGN KEY([retailOrderNbr])
REFERENCES [dbo].[retailOrder] ([retailOrderNbr])
GO
ALTER TABLE [dbo].[retailOrderDetail] CHECK CONSTRAINT [fkRtlDtlOrder]
GO
/****** Object:  ForeignKey [fkRtlDtlTire]    Script Date: 07/29/2012 15:52:11 ******/
ALTER TABLE [dbo].[retailOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkRtlDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[retailOrderDetail] CHECK CONSTRAINT [fkRtlDtlTire]
GO
