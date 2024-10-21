SELECT i.IngredientName
FROM Ingredient i
JOIN ProductIngredient pi ON i.IngredientId = pi.IngredientId
WHERE pi.ProductId = 1;
