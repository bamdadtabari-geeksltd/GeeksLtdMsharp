-- Country2s Table ========================
CREATE TABLE Country2s (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NOT NULL,
    Code nvarchar(200)  NOT NULL
);

