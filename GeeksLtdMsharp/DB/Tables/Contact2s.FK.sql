ALTER TABLE Contact2s ADD Constraint
                [FK_Contact2.Category]
                FOREIGN KEY (Category)
                REFERENCES Categories (ID)
                ON DELETE NO ACTION;
GO