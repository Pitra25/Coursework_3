CREATE TRIGGER Products_INSERT
ON Books
AFTER INSERT
AS
INSERT INTO History (ProductId, Operation)
SELECT Id, 'Добавлена книга ' + `Name` + '   автора ' + `Avtar`
FROM INSERTED
