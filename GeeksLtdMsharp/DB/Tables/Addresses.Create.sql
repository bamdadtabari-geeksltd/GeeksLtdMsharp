-- Addresses Table ========================
CREATE TABLE Addresses (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    AddressLine1 nvarchar(200)  NOT NULL,
    AddressLine2 nvarchar(200)  NOT NULL,
    PostalCode nvarchar(200)  NOT NULL,
    Town nvarchar(200)  NOT NULL,
    Property uniqueidentifier  NOT NULL
);
CREATE UNIQUE INDEX [IX_Addresses->Property] ON Addresses (Property);

GO

