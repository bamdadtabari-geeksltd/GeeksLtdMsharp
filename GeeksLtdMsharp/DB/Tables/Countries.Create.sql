-- Countries Table ========================
CREATE TABLE Countries (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NULL,
    IsEuropean bit  NOT NULL
);

