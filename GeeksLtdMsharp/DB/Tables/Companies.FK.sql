ALTER TABLE Companies ADD Constraint
                [FK_Company.Country2]
                FOREIGN KEY (Country2)
                REFERENCES Country2s (ID)
                ON DELETE NO ACTION;
GO