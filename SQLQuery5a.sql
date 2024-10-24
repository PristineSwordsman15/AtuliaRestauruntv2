SELECT i.IngredientName 
FROM Ingredients i 
JOIN ProductIngredients pi ON i.IngredientId = pi.IngredientId 
WHERE pi.ProductId = 1; 
 