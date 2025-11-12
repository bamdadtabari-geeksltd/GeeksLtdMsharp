-- Owners Table ========================
CREATE TABLE Owners (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    FirstName nvarchar(200)  NULL,
    LastName nvarchar(200)  NULL
);

