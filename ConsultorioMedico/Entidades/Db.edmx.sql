
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/01/2021 13:31:07
-- Generated from EDMX file: C:\Proyecto2020\ConsultorioMedico\ConsultorioMedico\Entidades\Db.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ConsultorioMedico];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Cobranza_Doctores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cobranza] DROP CONSTRAINT [FK_Cobranza_Doctores];
GO
IF OBJECT_ID(N'[dbo].[FK_Cobranza_Paciente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cobranza] DROP CONSTRAINT [FK_Cobranza_Paciente];
GO
IF OBJECT_ID(N'[dbo].[FK_Cobranza_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cobranza] DROP CONSTRAINT [FK_Cobranza_Usuarios];
GO
IF OBJECT_ID(N'[dbo].[FK_DetalleCobro_Cobranza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleCobro] DROP CONSTRAINT [FK_DetalleCobro_Cobranza];
GO
IF OBJECT_ID(N'[dbo].[FK_DetalleCobro_Medicamentos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleCobro] DROP CONSTRAINT [FK_DetalleCobro_Medicamentos];
GO
IF OBJECT_ID(N'[dbo].[FK_Folios_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Folios] DROP CONSTRAINT [FK_Folios_Usuarios];
GO
IF OBJECT_ID(N'[dbo].[FK_Usuarios_rol]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [FK_Usuarios_rol];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cobranza]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cobranza];
GO
IF OBJECT_ID(N'[dbo].[Consulta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consulta];
GO
IF OBJECT_ID(N'[dbo].[DetalleCobro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalleCobro];
GO
IF OBJECT_ID(N'[dbo].[Doctores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Doctores];
GO
IF OBJECT_ID(N'[dbo].[Folios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Folios];
GO
IF OBJECT_ID(N'[dbo].[Medicamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Medicamento];
GO
IF OBJECT_ID(N'[dbo].[Paciente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Paciente];
GO
IF OBJECT_ID(N'[dbo].[rol]', 'U') IS NOT NULL
    DROP TABLE [dbo].[rol];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DetalleCobro'
CREATE TABLE [dbo].[DetalleCobro] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_cobranza] int  NOT NULL,
    [id_medicamento] int  NOT NULL,
    [Importe] float  NOT NULL,
    [Cantidad] int  NOT NULL,
    [Subtotal] float  NOT NULL
);
GO

-- Creating table 'Doctores'
CREATE TABLE [dbo].[Doctores] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(150)  NOT NULL,
    [Titulo] nvarchar(100)  NOT NULL,
    [CedProfesional] int  NOT NULL,
    [Estudio] nvarchar(50)  NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(100)  NOT NULL,
    [Usuario] nchar(10)  NOT NULL,
    [Password] nvarchar(100)  NOT NULL,
    [State] int  NOT NULL,
    [Fecha] datetime  NULL,
    [email] nvarchar(100)  NULL,
    [idRol] int  NULL
);
GO

-- Creating table 'Folios'
CREATE TABLE [dbo].[Folios] (
    [idfolio] int IDENTITY(1,1) NOT NULL,
    [folio] float  NOT NULL,
    [idusuario] int  NOT NULL
);
GO

-- Creating table 'Consulta'
CREATE TABLE [dbo].[Consulta] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_doctor] int  NOT NULL,
    [id_paciente] int  NOT NULL,
    [fecha] datetime  NOT NULL,
    [Edad] int  NULL,
    [Peso] int  NULL,
    [Talla] float  NULL,
    [TenArt] nchar(10)  NULL,
    [Pulso] int  NULL,
    [FreCardiaca] int  NULL,
    [FrecResp] int  NULL,
    [Temperatura] int  NULL,
    [Alergias] nvarchar(50)  NULL,
    [PbDx] nvarchar(150)  NULL,
    [Medicamentos] nvarchar(max)  NULL,
    [Cita] nchar(10)  NULL
);
GO

-- Creating table 'rol'
CREATE TABLE [dbo].[rol] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(50)  NULL
);
GO

-- Creating table 'Paciente'
CREATE TABLE [dbo].[Paciente] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(100)  NOT NULL,
    [Edad] int  NULL,
    [Domicilio] nvarchar(50)  NOT NULL,
    [Colonia] nvarchar(50)  NOT NULL,
    [CodPost] char(5)  NULL,
    [Telefono] char(10)  NULL
);
GO

-- Creating table 'Cobranza'
CREATE TABLE [dbo].[Cobranza] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Concepto] nvarchar(50)  NOT NULL,
    [Nombre] nvarchar(150)  NULL,
    [Domicilio] nvarchar(150)  NULL,
    [Total] decimal(10,2)  NOT NULL,
    [TotalenLetra] nvarchar(150)  NOT NULL,
    [id_usuario] int  NOT NULL,
    [StatusCancel] int  NOT NULL,
    [id_paciente] int  NOT NULL,
    [Folio] int  NULL,
    [id_doctor] int  NOT NULL
);
GO

-- Creating table 'Medicamento'
CREATE TABLE [dbo].[Medicamento] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(50)  NOT NULL,
    [Compuesto] nvarchar(150)  NULL,
    [Presentacion] nvarchar(50)  NULL,
    [Gramaje] nvarchar(70)  NULL,
    [Descripcion] nvarchar(100)  NULL,
    [Laboratorio] nvarchar(50)  NULL,
    [Precio] float  NOT NULL,
    [FechaCompra] datetime  NULL,
    [Costo] float  NOT NULL,
    [Lote] nchar(10)  NULL,
    [Caducidad] nchar(10)  NULL,
    [Stock] int  NULL,
    [CodigoBarra] decimal(18,0)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'DetalleCobro'
ALTER TABLE [dbo].[DetalleCobro]
ADD CONSTRAINT [PK_DetalleCobro]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Doctores'
ALTER TABLE [dbo].[Doctores]
ADD CONSTRAINT [PK_Doctores]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [idfolio] in table 'Folios'
ALTER TABLE [dbo].[Folios]
ADD CONSTRAINT [PK_Folios]
    PRIMARY KEY CLUSTERED ([idfolio] ASC);
GO

-- Creating primary key on [id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [PK_Consulta]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'rol'
ALTER TABLE [dbo].[rol]
ADD CONSTRAINT [PK_rol]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Paciente'
ALTER TABLE [dbo].[Paciente]
ADD CONSTRAINT [PK_Paciente]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Cobranza'
ALTER TABLE [dbo].[Cobranza]
ADD CONSTRAINT [PK_Cobranza]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'Medicamento'
ALTER TABLE [dbo].[Medicamento]
ADD CONSTRAINT [PK_Medicamento]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [id_doctor] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_Consulta_Doctores]
    FOREIGN KEY ([id_doctor])
    REFERENCES [dbo].[Doctores]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Consulta_Doctores'
CREATE INDEX [IX_FK_Consulta_Doctores]
ON [dbo].[Consulta]
    ([id_doctor]);
GO

-- Creating foreign key on [idusuario] in table 'Folios'
ALTER TABLE [dbo].[Folios]
ADD CONSTRAINT [FK_Folios_Usuarios]
    FOREIGN KEY ([idusuario])
    REFERENCES [dbo].[Usuarios]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Folios_Usuarios'
CREATE INDEX [IX_FK_Folios_Usuarios]
ON [dbo].[Folios]
    ([idusuario]);
GO

-- Creating foreign key on [idRol] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [FK_Usuarios_rol]
    FOREIGN KEY ([idRol])
    REFERENCES [dbo].[rol]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Usuarios_rol'
CREATE INDEX [IX_FK_Usuarios_rol]
ON [dbo].[Usuarios]
    ([idRol]);
GO

-- Creating foreign key on [id_doctor] in table 'Cobranza'
ALTER TABLE [dbo].[Cobranza]
ADD CONSTRAINT [FK_Cobranza_Doctores]
    FOREIGN KEY ([id_doctor])
    REFERENCES [dbo].[Doctores]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Cobranza_Doctores'
CREATE INDEX [IX_FK_Cobranza_Doctores]
ON [dbo].[Cobranza]
    ([id_doctor]);
GO

-- Creating foreign key on [id_paciente] in table 'Cobranza'
ALTER TABLE [dbo].[Cobranza]
ADD CONSTRAINT [FK_Cobranza_Paciente]
    FOREIGN KEY ([id_paciente])
    REFERENCES [dbo].[Paciente]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Cobranza_Paciente'
CREATE INDEX [IX_FK_Cobranza_Paciente]
ON [dbo].[Cobranza]
    ([id_paciente]);
GO

-- Creating foreign key on [id_usuario] in table 'Cobranza'
ALTER TABLE [dbo].[Cobranza]
ADD CONSTRAINT [FK_Cobranza_Usuarios]
    FOREIGN KEY ([id_usuario])
    REFERENCES [dbo].[Usuarios]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Cobranza_Usuarios'
CREATE INDEX [IX_FK_Cobranza_Usuarios]
ON [dbo].[Cobranza]
    ([id_usuario]);
GO

-- Creating foreign key on [id_cobranza] in table 'DetalleCobro'
ALTER TABLE [dbo].[DetalleCobro]
ADD CONSTRAINT [FK_DetalleCobro_Cobranza]
    FOREIGN KEY ([id_cobranza])
    REFERENCES [dbo].[Cobranza]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalleCobro_Cobranza'
CREATE INDEX [IX_FK_DetalleCobro_Cobranza]
ON [dbo].[DetalleCobro]
    ([id_cobranza]);
GO

-- Creating foreign key on [id_medicamento] in table 'DetalleCobro'
ALTER TABLE [dbo].[DetalleCobro]
ADD CONSTRAINT [FK_DetalleCobro_Medicamentos]
    FOREIGN KEY ([id_medicamento])
    REFERENCES [dbo].[Medicamento]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalleCobro_Medicamentos'
CREATE INDEX [IX_FK_DetalleCobro_Medicamentos]
ON [dbo].[DetalleCobro]
    ([id_medicamento]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------