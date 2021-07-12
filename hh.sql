INSERT INTO DatabaseImageTable ([image name], [image])
SELECT 'SQL Server Image', *
FROM OPENROWSET(BULK N'C:\images\sql-server-image-file.jpg', SINGLE_BLOB) image;