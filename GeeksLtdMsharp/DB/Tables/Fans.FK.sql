ALTER TABLE Fans ADD Constraint
                [FK_Fan.Player]
                FOREIGN KEY (Player)
                REFERENCES Players (ID)
                ON DELETE NO ACTION;
GO