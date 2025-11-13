-- Resellers Table ========================
CREATE TABLE Resellers (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NULL,
    Country uniqueidentifier  NOT NULL
);
CREATE INDEX [IX_Resellers->Country] ON Resellers (Country);

GO

