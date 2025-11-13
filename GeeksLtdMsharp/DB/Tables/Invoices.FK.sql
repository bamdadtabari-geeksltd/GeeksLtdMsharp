ALTER TABLE Invoices ADD Constraint
                [FK_Invoice.Client]
                FOREIGN KEY (Client)
                REFERENCES Clients (ID)
                ON DELETE NO ACTION;
GO