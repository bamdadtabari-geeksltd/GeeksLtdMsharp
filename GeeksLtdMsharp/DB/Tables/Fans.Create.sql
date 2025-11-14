-- Fans Table ========================
CREATE TABLE Fans (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Player uniqueidentifier  NOT NULL,
    Name nvarchar(200)  NOT NULL,
    Email nvarchar(200)  NOT NULL,
    StartDate datetime2  NOT NULL,
    DateOfBirth datetime2  NULL,
    SupportComments nvarchar(200)  NULL,
    IsRegistrationCompleted bit  NOT NULL
);
CREATE INDEX [IX_Fans->Player] ON Fans (Player);

GO

