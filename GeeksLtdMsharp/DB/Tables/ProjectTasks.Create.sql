-- ProjectTasks Table ========================
CREATE TABLE ProjectTasks (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Project uniqueidentifier  NULL,
    Title nvarchar(200)  NULL,
    Description nvarchar(500)  NULL,
    Done bit  NOT NULL
);

