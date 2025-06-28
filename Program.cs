using DrinksInfo;

public class DrinksInfoApp
{
    public static void Main()
    {
        CocktailApiClient client = CocktailApiClient.Instance;
        
        while(true)
        {
            string categoryChoice = DisplayCategories(client);
        }
    }

    private static string DisplayCategories(CocktailApiClient client)
    {
        var categories = client.GetCategoryList().Result;

        string[] choices = new string[categories.Count];
        for(int i = 0; i < categories.Count; i++)
        {
            choices[i] = categories[i].StrCategory;
        }

        return DrinksDisplayEngine.PromptUserForStringSelection("Please select a category: ", choices);
    }

    private static string DisplayDrinksInCategory(CocktailApiClient client, Category categoryChoice)
    {
        var drinks = client.GetDrinksByCategory(categoryChoice).Result;

        string[] choices = new string[drinks.Count];
        for (int i = 0; i < drinks.Count; i++)
        {
            choices[i] = drinks[i].StrDrink;
        }

        return DrinksDisplayEngine.PromptUserForStringSelection("Which drink would you like to view?", choices);
    }
}