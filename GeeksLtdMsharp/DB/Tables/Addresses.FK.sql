ALTER TABLE Addresses ADD Constraint
                [FK_Address.Property]
                FOREIGN KEY (Property)
                REFERENCES Properties (ID)
                ON DELETE NO ACTION;
GO