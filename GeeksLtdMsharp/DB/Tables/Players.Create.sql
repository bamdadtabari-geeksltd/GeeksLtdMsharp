-- Players Table ========================
CREATE TABLE Players (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NOT NULL,
    Photo_FileName nvarchar(1500)  NULL
);

