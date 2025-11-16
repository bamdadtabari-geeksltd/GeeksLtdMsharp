ALTER TABLE Candidates ADD Constraint
                [FK_Candidate.Status]
                FOREIGN KEY (Status)
                REFERENCES Statuses (ID)
                ON DELETE NO ACTION;
GO