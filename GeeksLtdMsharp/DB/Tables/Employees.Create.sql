-- Employees Table ========================
CREATE TABLE Employees (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    FirstName nvarchar(200)  NULL,
    LastName nvarchar(200)  NULL,
    Email nvarchar(200)  NULL,
    IDCard_FileName nvarchar(1500)  NULL
);

