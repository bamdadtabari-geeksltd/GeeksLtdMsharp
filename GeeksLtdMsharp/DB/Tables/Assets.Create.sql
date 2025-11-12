-- Assets Table ========================
CREATE TABLE Assets (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Code nvarchar(200)  NULL,
    Name nvarchar(200)  NULL,
    Type uniqueidentifier  NULL,
    Cost numeric(27, 2)  NULL,
    Owner uniqueidentifier  NULL
);

