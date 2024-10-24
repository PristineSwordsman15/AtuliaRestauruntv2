SELECT c.CategoryName, COUNT(p.ProductId) AS ProductCount 
FROM Categories c 
LEFT JOIN Products p ON c.CategoryId = p.CategoryId 
GROUP BY c.CategoryName 
ORDER BY c.CategoryName; 
 