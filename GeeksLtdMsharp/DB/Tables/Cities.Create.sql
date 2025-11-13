-- Cities Table ========================
CREATE TABLE Cities (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NULL,
    Country uniqueidentifier  NOT NULL
);
CREATE INDEX [IX_Cities->Country] ON Cities (Country);

GO

