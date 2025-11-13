-- Customers Table ========================
CREATE TABLE Customers (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NULL,
    Reseller uniqueidentifier  NOT NULL,
    Country uniqueidentifier  NOT NULL
);
CREATE INDEX [IX_Customers->Country] ON Customers (Country);

GO

