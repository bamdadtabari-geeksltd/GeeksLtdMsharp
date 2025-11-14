-- Companies Table ========================
CREATE TABLE Companies (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NOT NULL,
    RegistrationDate datetime2  NOT NULL,
    MarketShare numeric(27, 2)  NOT NULL,
    NumberOfEmployees int  NOT NULL,
    Country2 uniqueidentifier  NOT NULL
);

