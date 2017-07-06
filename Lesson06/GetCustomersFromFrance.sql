CREATE PROCEDURE GetCustomersFromFrance
AS
	SELECT * FROM Customers
	WHERE Country = 'France'
RETURN 
