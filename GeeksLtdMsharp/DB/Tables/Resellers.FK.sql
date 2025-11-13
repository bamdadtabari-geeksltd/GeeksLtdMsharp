ALTER TABLE Resellers ADD Constraint
                [FK_Reseller.Country]
                FOREIGN KEY (Country)
                REFERENCES Countries (ID)
                ON DELETE NO ACTION;
GO