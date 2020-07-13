IF (NOT EXISTS(SELECT *
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = 'dbo'
    AND TABLE_NAME = 'todos'))
               BEGIN
    CREATE TABLE todos
    (
        [id] CHAR(36) NOT NULL,
        [title] VARCHAR(255) NOT NULL,
        [completed] BIT NOT NULL,
        PRIMARY KEY ([id])
    );
END