-- Contacts Table ========================
CREATE TABLE Contacts (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    FirstName nvarchar(200)  NOT NULL,
    LastName nvarchar(200)  NOT NULL,
    Name nvarchar(200)  NULL,
    PhoneNumber nvarchar(200)  NOT NULL
);

