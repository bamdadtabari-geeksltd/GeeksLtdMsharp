-- Clients Table ========================
CREATE TABLE Clients (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Company nvarchar(200)  NOT NULL
);

