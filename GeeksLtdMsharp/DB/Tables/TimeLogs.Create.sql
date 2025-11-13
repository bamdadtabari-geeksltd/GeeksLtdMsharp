-- TimeLogs Table ========================
CREATE TABLE TimeLogs (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Project2 uniqueidentifier  NOT NULL,
    Developer uniqueidentifier  NOT NULL,
    [Date] datetime2  NOT NULL,
    StartTime time  NOT NULL,
    EndTime time  NOT NULL,
    Details nvarchar(200)  NULL
);
CREATE INDEX [IX_TimeLogs->Project2] ON TimeLogs (Project2);

GO

CREATE INDEX [IX_TimeLogs->Developer] ON TimeLogs (Developer);

GO

