
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/13/2019 11:22:13
-- Generated from EDMX file: F:\Personal Storage\faculta\TNET\tema3\ConsoleApp1\ConsoleApp1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [Adresa] nvarchar(50)  NOT NULL,
    [Localitate] nvarchar(10)  NOT NULL,
    [Judet] nvarchar(10)  NOT NULL,
    [Telefon] smallint  NOT NULL,
    [Email] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Sasius'
CREATE TABLE [dbo].[Sasius] (
    [SasiuId] int IDENTITY(1,1) NOT NULL,
    [CodSasiu] nvarchar(2)  NOT NULL,
    [Denumire] nvarchar(25)  NOT NULL,
    [AutoSasiu_Sasiu_AutoId] int  NOT NULL
);
GO

-- Creating table 'Mecanics'
CREATE TABLE [dbo].[Mecanics] (
    [MecanicId] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Autoes'
CREATE TABLE [dbo].[Autoes] (
    [AutoId] int IDENTITY(1,1) NOT NULL,
    [NumarAuto] nvarchar(max)  NOT NULL,
    [SerieSasiu] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'Materials'
CREATE TABLE [dbo].[Materials] (
    [MaterialId] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(50)  NOT NULL,
    [Cantitate] decimal(18,0)  NOT NULL,
    [Pret] decimal(18,0)  NOT NULL,
    [DataAprovizionare] datetime  NOT NULL
);
GO

-- Creating table 'Imagines'
CREATE TABLE [dbo].[Imagines] (
    [ImagineId] int IDENTITY(1,1) NOT NULL,
    [Titlu] nvarchar(15)  NOT NULL,
    [Descriere] nvarchar(256)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Foto] nvarchar(max)  NOT NULL,
    [Comanda_ComandaID] int  NOT NULL
);
GO

-- Creating table 'Operaties'
CREATE TABLE [dbo].[Operaties] (
    [OperatieId] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(256)  NOT NULL,
    [TimpExecutie] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Comandas'
CREATE TABLE [dbo].[Comandas] (
    [ComandaID] int IDENTITY(1,1) NOT NULL,
    [StareComanda] int  NOT NULL,
    [DAtaSystem] datetime  NOT NULL,
    [DataProgramare] datetime  NOT NULL,
    [DataFinalizare] datetime  NULL,
    [KmBord] int  NOT NULL,
    [Descriere] nvarchar(1024)  NOT NULL,
    [ValoarePiese] decimal(18,0)  NOT NULL,
    [Client_Id] int  NOT NULL,
    [Auto_AutoId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [SasiuId] in table 'Sasius'
ALTER TABLE [dbo].[Sasius]
ADD CONSTRAINT [PK_Sasius]
    PRIMARY KEY CLUSTERED ([SasiuId] ASC);
GO

-- Creating primary key on [MecanicId] in table 'Mecanics'
ALTER TABLE [dbo].[Mecanics]
ADD CONSTRAINT [PK_Mecanics]
    PRIMARY KEY CLUSTERED ([MecanicId] ASC);
GO

-- Creating primary key on [AutoId] in table 'Autoes'
ALTER TABLE [dbo].[Autoes]
ADD CONSTRAINT [PK_Autoes]
    PRIMARY KEY CLUSTERED ([AutoId] ASC);
GO

-- Creating primary key on [MaterialId] in table 'Materials'
ALTER TABLE [dbo].[Materials]
ADD CONSTRAINT [PK_Materials]
    PRIMARY KEY CLUSTERED ([MaterialId] ASC);
GO

-- Creating primary key on [ImagineId] in table 'Imagines'
ALTER TABLE [dbo].[Imagines]
ADD CONSTRAINT [PK_Imagines]
    PRIMARY KEY CLUSTERED ([ImagineId] ASC);
GO

-- Creating primary key on [OperatieId] in table 'Operaties'
ALTER TABLE [dbo].[Operaties]
ADD CONSTRAINT [PK_Operaties]
    PRIMARY KEY CLUSTERED ([OperatieId] ASC);
GO

-- Creating primary key on [ComandaID] in table 'Comandas'
ALTER TABLE [dbo].[Comandas]
ADD CONSTRAINT [PK_Comandas]
    PRIMARY KEY CLUSTERED ([ComandaID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AutoSasiu_Sasiu_AutoId] in table 'Sasius'
ALTER TABLE [dbo].[Sasius]
ADD CONSTRAINT [FK_AutoSasiu]
    FOREIGN KEY ([AutoSasiu_Sasiu_AutoId])
    REFERENCES [dbo].[Autoes]
        ([AutoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoSasiu'
CREATE INDEX [IX_FK_AutoSasiu]
ON [dbo].[Sasius]
    ([AutoSasiu_Sasiu_AutoId]);
GO

-- Creating foreign key on [Client_Id] in table 'Comandas'
ALTER TABLE [dbo].[Comandas]
ADD CONSTRAINT [FK_ComandaClient]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaClient'
CREATE INDEX [IX_FK_ComandaClient]
ON [dbo].[Comandas]
    ([Client_Id]);
GO

-- Creating foreign key on [Auto_AutoId] in table 'Comandas'
ALTER TABLE [dbo].[Comandas]
ADD CONSTRAINT [FK_ComandaAuto]
    FOREIGN KEY ([Auto_AutoId])
    REFERENCES [dbo].[Autoes]
        ([AutoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaAuto'
CREATE INDEX [IX_FK_ComandaAuto]
ON [dbo].[Comandas]
    ([Auto_AutoId]);
GO

-- Creating foreign key on [Comanda_ComandaID] in table 'Imagines'
ALTER TABLE [dbo].[Imagines]
ADD CONSTRAINT [FK_ImagineComanda]
    FOREIGN KEY ([Comanda_ComandaID])
    REFERENCES [dbo].[Comandas]
        ([ComandaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ImagineComanda'
CREATE INDEX [IX_FK_ImagineComanda]
ON [dbo].[Imagines]
    ([Comanda_ComandaID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------