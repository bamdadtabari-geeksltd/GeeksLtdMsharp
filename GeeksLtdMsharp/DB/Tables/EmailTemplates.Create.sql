-- EmailTemplates Table ========================
CREATE TABLE EmailTemplates (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    [Key] nvarchar(200)  NOT NULL,
    Subject nvarchar(200)  NOT NULL,
    Body nvarchar(MAX)  NOT NULL,
    MandatoryPlaceholders nvarchar(200)  NULL
);

EXEC sp_addextendedproperty @name=N'ReferenceData', @value='Enum', @level0type=N'SCHEMA', @level0name='dbo', @level1type=N'TABLE', @level1name='EmailTemplates';
