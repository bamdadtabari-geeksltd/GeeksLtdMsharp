ALTER TABLE TimeLogs ADD Constraint
                [FK_TimeLog.Project2]
                FOREIGN KEY (Project2)
                REFERENCES Project2s (ID)
                ON DELETE NO ACTION;
GO
ALTER TABLE TimeLogs ADD Constraint
                [FK_TimeLog.Developer]
                FOREIGN KEY (Developer)
                REFERENCES Developers (ID)
                ON DELETE NO ACTION;
GO