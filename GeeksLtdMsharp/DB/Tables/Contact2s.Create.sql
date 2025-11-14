-- Contact2s Table ========================
CREATE TABLE Contact2s (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Category uniqueidentifier  NOT NULL,
    Name nvarchar(200)  NULL,
    Email nvarchar(200)  NULL,
    Telephone nvarchar(200)  NULL,
    AddressLine1 nvarchar(200)  NULL,
    AddressLine2 nvarchar(200)  NULL,
    Town nvarchar(200)  NULL,
    Postcode nvarchar(200)  NULL,
    Comments nvarchar(200)  NULL,
    DateOfBirth datetime2  NULL
);
CREATE INDEX [IX_Contact2s->Category] ON Contact2s (Category);

GO

