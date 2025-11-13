-- Registers Table ========================
CREATE TABLE Registers (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    FirstName nvarchar(200)  NOT NULL,
    LastName nvarchar(200)  NOT NULL,
    DateOfBirth datetime2  NOT NULL,
    Email nvarchar(200)  NULL,
    Password nvarchar(200)  NULL
);

