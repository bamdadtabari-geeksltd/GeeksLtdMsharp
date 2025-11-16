-- Candidates Table ========================
CREATE TABLE Candidates (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    FirstName nvarchar(200)  NOT NULL,
    LastName nvarchar(200)  NOT NULL,
    Email nvarchar(200)  NULL,
    Telephone nvarchar(200)  NULL,
    ConveringLetter nvarchar(200)  NULL,
    DateAdded datetime2  NOT NULL,
    Status uniqueidentifier  NULL
);

