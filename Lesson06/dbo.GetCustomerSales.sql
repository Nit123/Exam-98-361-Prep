CREATE PROCEDURE dbo.GetCustomerSales
(
	@CustomerId char(5),
	@TotalSales money OUTPUT
)
AS
	SELECT @TotalSales = SUM(Quantity * UnitPrice)
	FROM (Customers INNER JOIN Orders
	ON Customers.CustomerId = Orders.CustomerId)
	INNER JOIN [Order Details]
	On Orders.OrderId = [Order Details].OrderID
	WHERE Customers.CustomerId = @CustomerId
RETURN 
