
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/19/2019 20:25:54
-- Generated from EDMX file: C:\Users\cristian\Desktop\TNET\Git\TSNET\tema3\ConsoleApp1\ConsoleApp1\Model1.edmx
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

IF OBJECT_ID(N'[dbo].[FK_AutoSasiu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sasius] DROP CONSTRAINT [FK_AutoSasiu];
GO
IF OBJECT_ID(N'[dbo].[FK_ComandaClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comandas] DROP CONSTRAINT [FK_ComandaClient];
GO
IF OBJECT_ID(N'[dbo].[FK_ComandaAuto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comandas] DROP CONSTRAINT [FK_ComandaAuto];
GO
IF OBJECT_ID(N'[dbo].[FK_ImagineComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Imagines] DROP CONSTRAINT [FK_ImagineComanda];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[Sasius]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sasius];
GO
IF OBJECT_ID(N'[dbo].[Mecanics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mecanics];
GO
IF OBJECT_ID(N'[dbo].[Autoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autoes];
GO
IF OBJECT_ID(N'[dbo].[Materials]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Materials];
GO
IF OBJECT_ID(N'[dbo].[Imagines]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Imagines];
GO
IF OBJECT_ID(N'[dbo].[Operaties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Operaties];
GO
IF OBJECT_ID(N'[dbo].[Comandas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comandas];
GO

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
    [Foto] varbinary(max)  NOT NULL,
    [DetaliuComanda_Id] int  NULL
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
    [Auto_AutoId] int  NOT NULL,
    [DetaliuComanda_Id] int  NOT NULL
);
GO

-- Creating table 'DetaliuComandas'
CREATE TABLE [dbo].[DetaliuComandas] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'DetaliuComandaMecanic'
CREATE TABLE [dbo].[DetaliuComandaMecanic] (
    [DetaliuComandaMecanic_Mecanic_Id] int  NOT NULL,
    [Mecanics_MecanicId] int  NOT NULL
);
GO

-- Creating table 'DetaliuComandaMaterial'
CREATE TABLE [dbo].[DetaliuComandaMaterial] (
    [DetaliuComandaMaterial_Material_Id] int  NOT NULL,
    [Materials_MaterialId] int  NOT NULL
);
GO

-- Creating table 'ComandaOperatie'
CREATE TABLE [dbo].[ComandaOperatie] (
    [ComandaOperatie_Operatie_ComandaID] int  NOT NULL,
    [Operaties_OperatieId] int  NOT NULL
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

-- Creating primary key on [Id] in table 'DetaliuComandas'
ALTER TABLE [dbo].[DetaliuComandas]
ADD CONSTRAINT [PK_DetaliuComandas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [DetaliuComandaMecanic_Mecanic_Id], [Mecanics_MecanicId] in table 'DetaliuComandaMecanic'
ALTER TABLE [dbo].[DetaliuComandaMecanic]
ADD CONSTRAINT [PK_DetaliuComandaMecanic]
    PRIMARY KEY CLUSTERED ([DetaliuComandaMecanic_Mecanic_Id], [Mecanics_MecanicId] ASC);
GO

-- Creating primary key on [DetaliuComandaMaterial_Material_Id], [Materials_MaterialId] in table 'DetaliuComandaMaterial'
ALTER TABLE [dbo].[DetaliuComandaMaterial]
ADD CONSTRAINT [PK_DetaliuComandaMaterial]
    PRIMARY KEY CLUSTERED ([DetaliuComandaMaterial_Material_Id], [Materials_MaterialId] ASC);
GO

-- Creating primary key on [ComandaOperatie_Operatie_ComandaID], [Operaties_OperatieId] in table 'ComandaOperatie'
ALTER TABLE [dbo].[ComandaOperatie]
ADD CONSTRAINT [PK_ComandaOperatie]
    PRIMARY KEY CLUSTERED ([ComandaOperatie_Operatie_ComandaID], [Operaties_OperatieId] ASC);
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

-- Creating foreign key on [DetaliuComandaMecanic_Mecanic_Id] in table 'DetaliuComandaMecanic'
ALTER TABLE [dbo].[DetaliuComandaMecanic]
ADD CONSTRAINT [FK_DetaliuComandaMecanic_DetaliuComanda]
    FOREIGN KEY ([DetaliuComandaMecanic_Mecanic_Id])
    REFERENCES [dbo].[DetaliuComandas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Mecanics_MecanicId] in table 'DetaliuComandaMecanic'
ALTER TABLE [dbo].[DetaliuComandaMecanic]
ADD CONSTRAINT [FK_DetaliuComandaMecanic_Mecanic]
    FOREIGN KEY ([Mecanics_MecanicId])
    REFERENCES [dbo].[Mecanics]
        ([MecanicId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaMecanic_Mecanic'
CREATE INDEX [IX_FK_DetaliuComandaMecanic_Mecanic]
ON [dbo].[DetaliuComandaMecanic]
    ([Mecanics_MecanicId]);
GO

-- Creating foreign key on [DetaliuComandaMaterial_Material_Id] in table 'DetaliuComandaMaterial'
ALTER TABLE [dbo].[DetaliuComandaMaterial]
ADD CONSTRAINT [FK_DetaliuComandaMaterial_DetaliuComanda]
    FOREIGN KEY ([DetaliuComandaMaterial_Material_Id])
    REFERENCES [dbo].[DetaliuComandas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Materials_MaterialId] in table 'DetaliuComandaMaterial'
ALTER TABLE [dbo].[DetaliuComandaMaterial]
ADD CONSTRAINT [FK_DetaliuComandaMaterial_Material]
    FOREIGN KEY ([Materials_MaterialId])
    REFERENCES [dbo].[Materials]
        ([MaterialId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaMaterial_Material'
CREATE INDEX [IX_FK_DetaliuComandaMaterial_Material]
ON [dbo].[DetaliuComandaMaterial]
    ([Materials_MaterialId]);
GO

-- Creating foreign key on [ComandaOperatie_Operatie_ComandaID] in table 'ComandaOperatie'
ALTER TABLE [dbo].[ComandaOperatie]
ADD CONSTRAINT [FK_ComandaOperatie_Comanda]
    FOREIGN KEY ([ComandaOperatie_Operatie_ComandaID])
    REFERENCES [dbo].[Comandas]
        ([ComandaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Operaties_OperatieId] in table 'ComandaOperatie'
ALTER TABLE [dbo].[ComandaOperatie]
ADD CONSTRAINT [FK_ComandaOperatie_Operatie]
    FOREIGN KEY ([Operaties_OperatieId])
    REFERENCES [dbo].[Operaties]
        ([OperatieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaOperatie_Operatie'
CREATE INDEX [IX_FK_ComandaOperatie_Operatie]
ON [dbo].[ComandaOperatie]
    ([Operaties_OperatieId]);
GO

-- Creating foreign key on [DetaliuComanda_Id] in table 'Imagines'
ALTER TABLE [dbo].[Imagines]
ADD CONSTRAINT [FK_DetaliuComandaImagine]
    FOREIGN KEY ([DetaliuComanda_Id])
    REFERENCES [dbo].[DetaliuComandas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaImagine'
CREATE INDEX [IX_FK_DetaliuComandaImagine]
ON [dbo].[Imagines]
    ([DetaliuComanda_Id]);
GO

-- Creating foreign key on [DetaliuComanda_Id] in table 'Comandas'
ALTER TABLE [dbo].[Comandas]
ADD CONSTRAINT [FK_ComandaDetaliuComanda]
    FOREIGN KEY ([DetaliuComanda_Id])
    REFERENCES [dbo].[DetaliuComandas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaDetaliuComanda'
CREATE INDEX [IX_FK_ComandaDetaliuComanda]
ON [dbo].[Comandas]
    ([DetaliuComanda_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------