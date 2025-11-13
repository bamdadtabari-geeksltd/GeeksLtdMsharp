-- EmailMessages Table ========================
CREATE TABLE EmailMessages (
    [.Deleted] bit NOT NULL,
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Body nvarchar(MAX)  NOT NULL,
    FromAddress nvarchar(200)  NULL,
    FromName nvarchar(200)  NULL,
    ReplyToAddress nvarchar(200)  NULL,
    ReplyToName nvarchar(200)  NULL,
    Subject nvarchar(200)  NULL,
    [To] nvarchar(200)  NULL,
    Attachments nvarchar(MAX)  NULL,
    Bcc nvarchar(2000)  NULL,
    Cc nvarchar(2000)  NULL,
    VCalendarView nvarchar(200)  NULL,
    Retries int  NOT NULL,
    SendableDate datetime2  NOT NULL,
    Html bit  NOT NULL
);
CREATE INDEX [IX_EmailMessages->Soft_Delete] ON EmailMessages ([.Deleted]);

GO

