-- PriceSamples Table ========================
CREATE TABLE PriceSamples (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Price numeric(27, 2)  NOT NULL,
    SampleDate datetime2  NOT NULL
);

