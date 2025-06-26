using DrinksInfo;

CocktailApiClient client = CocktailApiClient.Instance;

await client.GetCategoryList();