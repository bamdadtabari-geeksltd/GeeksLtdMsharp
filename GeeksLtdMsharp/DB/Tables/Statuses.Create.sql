-- Statuses Table ========================
CREATE TABLE Statuses (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NULL
);

EXEC sp_addextendedproperty @name=N'ReferenceData', @value='Enum', @level0type=N'SCHEMA', @level0name='dbo', @level1type=N'TABLE', @level1name='Statuses';
