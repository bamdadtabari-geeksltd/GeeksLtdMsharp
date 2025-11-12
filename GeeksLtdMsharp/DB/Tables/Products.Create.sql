-- Products Table ========================
CREATE TABLE Products (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NOT NULL,
    ProductionDate_time datetime2  NOT NULL,
    IsFood bit  NOT NULL,
    ProductWebsite nvarchar(200)  NOT NULL,
    Photo_FileName nvarchar(1500)  NULL,
    Thumbnail_FileName nvarchar(1500)  NULL,
    ProductCategory uniqueidentifier  NOT NULL
);
CREATE INDEX [IX_Products->ProductCategory] ON Products (ProductCategory);

GO

