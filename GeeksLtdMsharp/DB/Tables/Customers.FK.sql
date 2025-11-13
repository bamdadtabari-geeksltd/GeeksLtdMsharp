ALTER TABLE Customers ADD Constraint
                [FK_Customer.Reseller]
                FOREIGN KEY (Reseller)
                REFERENCES Resellers (ID)
                ON DELETE NO ACTION;
GO
ALTER TABLE Customers ADD Constraint
                [FK_Customer.Country]
                FOREIGN KEY (Country)
                REFERENCES Countries (ID)
                ON DELETE NO ACTION;
GO