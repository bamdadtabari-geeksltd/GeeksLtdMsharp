-- Invoices Table ========================
CREATE TABLE Invoices (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Client uniqueidentifier  NOT NULL,
    [Date] datetime2  NULL,
    Amount numeric(27, 2)  NULL,
    Description nvarchar(2500)  NULL
);
CREATE INDEX [IX_Invoices->Client] ON Invoices (Client);

GO

