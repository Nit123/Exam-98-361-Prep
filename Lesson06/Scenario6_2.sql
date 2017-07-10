CREATE PROCEDURE Scenario6_2 
(
@Country char(15)
)
AS
	SELECT * FROM Customers
	WHERE Country = @Country;
RETURN 0
