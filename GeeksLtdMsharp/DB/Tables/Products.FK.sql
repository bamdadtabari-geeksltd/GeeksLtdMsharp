ALTER TABLE Products ADD Constraint
                [FK_Product.ProductCategory]
                FOREIGN KEY (ProductCategory)
                REFERENCES ProductCategories (ID)
                ON DELETE NO ACTION;
GO