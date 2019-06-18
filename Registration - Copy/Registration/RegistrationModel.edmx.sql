
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2019 13:16:32
-- Generated from EDMX file: C:\Users\Astreia\Documents\PROG210\Registration\Registration\RegistrationModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RegistrationDB];
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

-- Creating table 'Registrations'
CREATE TABLE [dbo].[Registrations] (
    [RegisterID] int IDENTITY(1,1) NOT NULL,
    [StudentID] nvarchar(max)  NOT NULL,
    [ClassID] nvarchar(max)  NOT NULL,
    [RegisterDate] nvarchar(max)  NOT NULL,
    [Class_ClassID] int  NOT NULL,
    [Student_StudentID] int  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [StudentID] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Classes'
CREATE TABLE [dbo].[Classes] (
    [ClassID] int IDENTITY(1,1) NOT NULL,
    [ClassName] nvarchar(max)  NOT NULL,
    [Capacity] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Waitlists'
CREATE TABLE [dbo].[Waitlists] (
    [WaitlistID] int IDENTITY(1,1) NOT NULL,
    [StudentID] nvarchar(max)  NOT NULL,
    [ClassID] nvarchar(max)  NOT NULL,
    [Class_ClassID] int  NOT NULL,
    [Student_StudentID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [RegisterID] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [PK_Registrations]
    PRIMARY KEY CLUSTERED ([RegisterID] ASC);
GO

-- Creating primary key on [StudentID] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([StudentID] ASC);
GO

-- Creating primary key on [ClassID] in table 'Classes'
ALTER TABLE [dbo].[Classes]
ADD CONSTRAINT [PK_Classes]
    PRIMARY KEY CLUSTERED ([ClassID] ASC);
GO

-- Creating primary key on [WaitlistID] in table 'Waitlists'
ALTER TABLE [dbo].[Waitlists]
ADD CONSTRAINT [PK_Waitlists]
    PRIMARY KEY CLUSTERED ([WaitlistID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Class_ClassID] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [FK_ClassesRegistration]
    FOREIGN KEY ([Class_ClassID])
    REFERENCES [dbo].[Classes]
        ([ClassID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassesRegistration'
CREATE INDEX [IX_FK_ClassesRegistration]
ON [dbo].[Registrations]
    ([Class_ClassID]);
GO

-- Creating foreign key on [Student_StudentID] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [FK_StudentsRegistration]
    FOREIGN KEY ([Student_StudentID])
    REFERENCES [dbo].[Students]
        ([StudentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentsRegistration'
CREATE INDEX [IX_FK_StudentsRegistration]
ON [dbo].[Registrations]
    ([Student_StudentID]);
GO

-- Creating foreign key on [Class_ClassID] in table 'Waitlists'
ALTER TABLE [dbo].[Waitlists]
ADD CONSTRAINT [FK_ClassesWaitlist]
    FOREIGN KEY ([Class_ClassID])
    REFERENCES [dbo].[Classes]
        ([ClassID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassesWaitlist'
CREATE INDEX [IX_FK_ClassesWaitlist]
ON [dbo].[Waitlists]
    ([Class_ClassID]);
GO

-- Creating foreign key on [Student_StudentID] in table 'Waitlists'
ALTER TABLE [dbo].[Waitlists]
ADD CONSTRAINT [FK_StudentsWaitlist]
    FOREIGN KEY ([Student_StudentID])
    REFERENCES [dbo].[Students]
        ([StudentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentsWaitlist'
CREATE INDEX [IX_FK_StudentsWaitlist]
ON [dbo].[Waitlists]
    ([Student_StudentID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------