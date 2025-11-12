-- Properties Table ========================
CREATE TABLE Properties (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NOT NULL,
    Owner nvarchar(200)  NOT NULL,
    Age int  NULL,
    Price numeric(27, 2)  NOT NULL
);

