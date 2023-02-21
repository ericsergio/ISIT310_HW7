
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/20/2023 23:03:09
-- Generated from EDMX file: \\mac\Home\Documents\School\23\Winter\isit310\hw\Homework7\OrderModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OrdersEF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BirdCount_Bird]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BirdCount] DROP CONSTRAINT [FK_BirdCount_Bird];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bird]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bird];
GO
IF OBJECT_ID(N'[dbo].[BirdCount]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BirdCount];
GO
IF OBJECT_ID(N'[dbo].[Birder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Birder];
GO
IF OBJECT_ID(N'[dbo].[Region]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Region];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [SupplierID] int IDENTITY(1,1) NOT NULL,
    [CompanyName] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [OrderID] int IDENTITY(1,1) NOT NULL,
    [SupplierID] int  NOT NULL,
    [OrderDate] datetime  NOT NULL,
    [PartID] int  NOT NULL,
    [Quantity] int  NOT NULL
);
GO

-- Creating table 'Parts'
CREATE TABLE [dbo].[Parts] (
    [PartID] int IDENTITY(1,1) NOT NULL,
    [PartName] nvarchar(max)  NOT NULL,
    [Price] decimal(18,0)  NOT NULL,
    [SupplierID] int  NOT NULL,
    [OrderID] int  NOT NULL
);
GO

-- Creating table 'Birds'
CREATE TABLE [dbo].[Birds] (
    [BirdID] nvarchar(10)  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Description] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'BirdCounts'
CREATE TABLE [dbo].[BirdCounts] (
    [CountID] int IDENTITY(1,1) NOT NULL,
    [RegionID] nvarchar(5)  NOT NULL,
    [BirderID] int  NOT NULL,
    [BirdID] nvarchar(10)  NOT NULL,
    [CountDate] datetime  NOT NULL,
    [Counted] int  NOT NULL
);
GO

-- Creating table 'Birders'
CREATE TABLE [dbo].[Birders] (
    [BirderID] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [Phone] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Regions'
CREATE TABLE [dbo].[Regions] (
    [RegionID] nvarchar(5)  NOT NULL,
    [RegionName] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [SupplierID] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([SupplierID] ASC);
GO

-- Creating primary key on [OrderID] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([OrderID] ASC);
GO

-- Creating primary key on [PartID] in table 'Parts'
ALTER TABLE [dbo].[Parts]
ADD CONSTRAINT [PK_Parts]
    PRIMARY KEY CLUSTERED ([PartID] ASC);
GO

-- Creating primary key on [BirdID] in table 'Birds'
ALTER TABLE [dbo].[Birds]
ADD CONSTRAINT [PK_Birds]
    PRIMARY KEY CLUSTERED ([BirdID] ASC);
GO

-- Creating primary key on [CountID] in table 'BirdCounts'
ALTER TABLE [dbo].[BirdCounts]
ADD CONSTRAINT [PK_BirdCounts]
    PRIMARY KEY CLUSTERED ([CountID] ASC);
GO

-- Creating primary key on [BirderID] in table 'Birders'
ALTER TABLE [dbo].[Birders]
ADD CONSTRAINT [PK_Birders]
    PRIMARY KEY CLUSTERED ([BirderID] ASC);
GO

-- Creating primary key on [RegionID] in table 'Regions'
ALTER TABLE [dbo].[Regions]
ADD CONSTRAINT [PK_Regions]
    PRIMARY KEY CLUSTERED ([RegionID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SupplierID] in table 'Parts'
ALTER TABLE [dbo].[Parts]
ADD CONSTRAINT [FK_SupplierPart]
    FOREIGN KEY ([SupplierID])
    REFERENCES [dbo].[Suppliers]
        ([SupplierID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SupplierPart'
CREATE INDEX [IX_FK_SupplierPart]
ON [dbo].[Parts]
    ([SupplierID]);
GO

-- Creating foreign key on [OrderID] in table 'Parts'
ALTER TABLE [dbo].[Parts]
ADD CONSTRAINT [FK_OrderPart]
    FOREIGN KEY ([OrderID])
    REFERENCES [dbo].[Orders]
        ([OrderID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderPart'
CREATE INDEX [IX_FK_OrderPart]
ON [dbo].[Parts]
    ([OrderID]);
GO

-- Creating foreign key on [BirdID] in table 'BirdCounts'
ALTER TABLE [dbo].[BirdCounts]
ADD CONSTRAINT [FK_BirdCount_Bird]
    FOREIGN KEY ([BirdID])
    REFERENCES [dbo].[Birds]
        ([BirdID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BirdCount_Bird'
CREATE INDEX [IX_FK_BirdCount_Bird]
ON [dbo].[BirdCounts]
    ([BirdID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------