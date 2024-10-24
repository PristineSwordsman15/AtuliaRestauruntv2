SELECT p.ProductName, c.CategoryName 
FROM Products p 
JOIN Categories c ON p.CategoryId = c.CategoryId; 
 