SELECT p.ProductName 
FROM Products p 
LEFT JOIN ProductIngredients pi ON p.ProductId = pi.ProductId 
WHERE pi.ProductId IS NULL; 
 
 
 