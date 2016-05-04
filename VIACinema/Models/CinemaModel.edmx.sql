
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/04/2016 10:47:07
-- Generated from EDMX file: C:\Users\arnas\OneDrive\VisualStudio\VIACinema\VIACinema\VIACinema\Models\CinemaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [C:\USERS\ARNAS\ONEDRIVE\VISUALSTUDIO\VIACINEMA\VIACINEMA\VIACINEMA\APP_DATA\DBCINEMA.MDF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_StageSeat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Seats] DROP CONSTRAINT [FK_StageSeat];
GO
IF OBJECT_ID(N'[dbo].[FK_MovieSessionMovie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieSessions] DROP CONSTRAINT [FK_MovieSessionMovie];
GO
IF OBJECT_ID(N'[dbo].[FK_MovieSessionStage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MovieSessions] DROP CONSTRAINT [FK_MovieSessionStage];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Movies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Movies];
GO
IF OBJECT_ID(N'[dbo].[Stages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stages];
GO
IF OBJECT_ID(N'[dbo].[Seats]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Seats];
GO
IF OBJECT_ID(N'[dbo].[MovieSessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MovieSessions];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Movies'
CREATE TABLE [dbo].[Movies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [ReleaseDate] datetime  NULL
);
GO

-- Creating table 'Stages'
CREATE TABLE [dbo].[Stages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [MaxNumberOfSeats] int  NOT NULL
);
GO

-- Creating table 'Seats'
CREATE TABLE [dbo].[Seats] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [StageId] int  NOT NULL
);
GO

-- Creating table 'MovieSessions'
CREATE TABLE [dbo].[MovieSessions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Price] float  NOT NULL,
    [SessionDate] datetime  NOT NULL,
    [MovieId] int  NOT NULL,
    [StageId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Movies'
ALTER TABLE [dbo].[Movies]
ADD CONSTRAINT [PK_Movies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Stages'
ALTER TABLE [dbo].[Stages]
ADD CONSTRAINT [PK_Stages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Seats'
ALTER TABLE [dbo].[Seats]
ADD CONSTRAINT [PK_Seats]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MovieSessions'
ALTER TABLE [dbo].[MovieSessions]
ADD CONSTRAINT [PK_MovieSessions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StageId] in table 'Seats'
ALTER TABLE [dbo].[Seats]
ADD CONSTRAINT [FK_StageSeat]
    FOREIGN KEY ([StageId])
    REFERENCES [dbo].[Stages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StageSeat'
CREATE INDEX [IX_FK_StageSeat]
ON [dbo].[Seats]
    ([StageId]);
GO

-- Creating foreign key on [MovieId] in table 'MovieSessions'
ALTER TABLE [dbo].[MovieSessions]
ADD CONSTRAINT [FK_MovieSessionMovie]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[Movies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieSessionMovie'
CREATE INDEX [IX_FK_MovieSessionMovie]
ON [dbo].[MovieSessions]
    ([MovieId]);
GO

-- Creating foreign key on [StageId] in table 'MovieSessions'
ALTER TABLE [dbo].[MovieSessions]
ADD CONSTRAINT [FK_MovieSessionStage]
    FOREIGN KEY ([StageId])
    REFERENCES [dbo].[Stages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieSessionStage'
CREATE INDEX [IX_FK_MovieSessionStage]
ON [dbo].[MovieSessions]
    ([StageId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------