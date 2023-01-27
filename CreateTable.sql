

-- Create a new table called '[Deliveries]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Deliveries]', 'U') IS NOT NULL
DROP TABLE [dbo].[Deliveries]
GO
-- Create a new table called '[Contacts]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Contacts]', 'U') IS NOT NULL
DROP TABLE [dbo].[Contacts]
GO
-- Create a new table called '[Employees]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Employees]', 'U') IS NOT NULL
DROP TABLE [dbo].[Employees]
GO
-- Create a new table called '[Departments]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Departments]', 'U') IS NOT NULL
DROP TABLE [dbo].[Departments]
GO

-- Create a new table called '[Companyes]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Companyes]', 'U') IS NOT NULL
DROP TABLE [dbo].[Companyes]
GO




-- Create the table in the specified schema
CREATE TABLE [dbo].[Departments]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column
    [Name] NVARCHAR(50) NOT NULL,
    -- Specify more columns here
);
GO

-- Create the table in the specified schema
CREATE TABLE [dbo].[Employees]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column
    [DepartmentId] INT NOT NULL,
    [Name] NVARCHAR(50) NOT NULL,
    [Position] NVARCHAR(50) NOT NULL,
    [Salary] MONEY NOT NULL,
    [Price] MONEY NOT NULL,
    [Month] INT NOT NULL,
    -- Specify more columns here
    CONSTRAINT FK_Employees_Departments FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Departments]([Id])
    ON DELETE CASCADE
    ON UPDATE CASCADE
);
GO

-- Create the table in the specified schema
CREATE TABLE [dbo].[Companyes]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column
    [CountryCode] INT NOT NULL,
    [City] NVARCHAR(50) NOT NULL,
    [Address] NVARCHAR(50) NOT NULL,
    [Phone] NVARCHAR(15) NOT NULL,
    [Email] NVARCHAR(50) NOT NULL,
    [Site] NVARCHAR(100) NULL
    -- Specify more columns here
);
GO

-- Create the table in the specified schema
CREATE TABLE [dbo].[Contacts]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column
    [CompanyId] INT NOT NULL,
    [DateCreate] DATETIME2(7) NOT NULL,
    [Price] MONEY NOT NULL,
    [Valid] BIT NOT NULL DEFAULT 0,
    [EmployeeId] INT NOT NULL,
    -- Specify more columns here
    CONSTRAINT FK_Contracts_Companyes FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Companyes]([Id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
    CONSTRAINT FK_Contracts_Employees FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees]([Id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);
GO

-- Create the table in the specified schema
CREATE TABLE [dbo].[Deliveries]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column
    [ContractId] INT NOT NULL,
    [EquipmentType] NVARCHAR(50) NOT NULL,
    [Description] NVARCHAR(MAX) NULL,
    [EmployeeId] INT NOT NULL,
    -- Specify more columns here
    CONSTRAINT FK_Deliveries_Contracts FOREIGN KEY ([ContractId]) REFERENCES [dbo].[Contacts]([Id])
    ON DELETE CASCADE
    ON UPDATE CASCADE,
    CONSTRAINT FK_Deliveries_Employees FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees]([Id])
    ON DELETE CASCADE
    ON UPDATE CASCADE
);
GO
-- Create a new table called '[Users]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Users]', 'U') IS NOT NULL
DROP TABLE [dbo].[Users]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Users]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column
    [Name] NVARCHAR(50) NOT NULL,
    [Email] NVARCHAR(50) NOT NULL,
    [Password] NVARCHAR(50) NOT NULL,
    [Role] INT NOT NULL
    -- Specify more columns here
);
GO