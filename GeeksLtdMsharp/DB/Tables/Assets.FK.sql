ALTER TABLE Assets ADD Constraint
                [FK_Asset.Type->AssetType]
                FOREIGN KEY (Type)
                REFERENCES AssetTypes (ID)
                ON DELETE NO ACTION;
GO
ALTER TABLE Assets ADD Constraint
                [FK_Asset.Owner]
                FOREIGN KEY (Owner)
                REFERENCES Owners (ID)
                ON DELETE NO ACTION;
GO