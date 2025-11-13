ALTER TABLE Cities ADD Constraint
                [FK_City.Country]
                FOREIGN KEY (Country)
                REFERENCES Countries (ID)
                ON DELETE NO ACTION;
GO