
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/07/2016 18:07:36
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
IF OBJECT_ID(N'[dbo].[FK_UserCreditCard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CreditCards] DROP CONSTRAINT [FK_UserCreditCard];
GO
IF OBJECT_ID(N'[dbo].[FK_MovieSessionReservation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservations] DROP CONSTRAINT [FK_MovieSessionReservation];
GO
IF OBJECT_ID(N'[dbo].[FK_UserReservation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservations] DROP CONSTRAINT [FK_UserReservation];
GO
IF OBJECT_ID(N'[dbo].[FK_SeatReservation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservations] DROP CONSTRAINT [FK_SeatReservation];
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
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[CreditCards]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CreditCards];
GO
IF OBJECT_ID(N'[dbo].[Reservations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reservations];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Movies'
CREATE TABLE [dbo].[Movies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [ReleaseYear] nvarchar(max)  NULL,
    [ImageUrl] nvarchar(max)  NOT NULL
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
    [Number] int  NOT NULL,
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

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Admin] bit  NOT NULL
);
GO

-- Creating table 'CreditCards'
CREATE TABLE [dbo].[CreditCards] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [ExpirationDate] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Reservations'
CREATE TABLE [dbo].[Reservations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PricePayed] float  NOT NULL,
    [MovieSessionId] int  NOT NULL,
    [UserId] int  NOT NULL,
    [SeatId] int  NOT NULL
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

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CreditCards'
ALTER TABLE [dbo].[CreditCards]
ADD CONSTRAINT [PK_CreditCards]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [PK_Reservations]
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

-- Creating foreign key on [UserId] in table 'CreditCards'
ALTER TABLE [dbo].[CreditCards]
ADD CONSTRAINT [FK_UserCreditCard]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCreditCard'
CREATE INDEX [IX_FK_UserCreditCard]
ON [dbo].[CreditCards]
    ([UserId]);
GO

-- Creating foreign key on [MovieSessionId] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_MovieSessionReservation]
    FOREIGN KEY ([MovieSessionId])
    REFERENCES [dbo].[MovieSessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieSessionReservation'
CREATE INDEX [IX_FK_MovieSessionReservation]
ON [dbo].[Reservations]
    ([MovieSessionId]);
GO

-- Creating foreign key on [UserId] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_UserReservation]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserReservation'
CREATE INDEX [IX_FK_UserReservation]
ON [dbo].[Reservations]
    ([UserId]);
GO

-- Creating foreign key on [SeatId] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_SeatReservation]
    FOREIGN KEY ([SeatId])
    REFERENCES [dbo].[Seats]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SeatReservation'
CREATE INDEX [IX_FK_SeatReservation]
ON [dbo].[Reservations]
    ([SeatId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------