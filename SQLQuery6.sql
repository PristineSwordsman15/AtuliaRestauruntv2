SELECT SUM(oi.Quantity * oi.UnitPrice) AS TotalRevenue
FROM OrderItem oi;