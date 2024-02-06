IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Class1] (
    [ClassId] int NOT NULL IDENTITY,
    [ClassName] int NOT NULL,
    CONSTRAINT [PK_Class1] PRIMARY KEY ([ClassId])
);
GO

CREATE TABLE [Student] (
    [StudentId] int NOT NULL IDENTITY,
    [ClassId] int NOT NULL,
    [Name] int NOT NULL,
    [Age] int NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY ([StudentId])
);
GO

CREATE TABLE [Subject] (
    [SubjectId] int NOT NULL IDENTITY,
    [Name] int NOT NULL,
    CONSTRAINT [PK_Subject] PRIMARY KEY ([SubjectId])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240206130108_stumig', N'6.0.26');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240206130305_subMig', N'6.0.26');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240206130403_Class1Mig', N'6.0.26');
GO

COMMIT;
GO

