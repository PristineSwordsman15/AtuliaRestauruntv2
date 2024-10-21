SELECT p.ProductName, c.CategoryName
FROM Product p
JOIN Category c ON p.CategoryId = c.CategoryId;