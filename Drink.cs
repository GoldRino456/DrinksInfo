using Newtonsoft.Json;

namespace DrinksInfo
{
    public class Drink
    {
        public string StrDrink { get; set; }
        public int IdDrink { get; set; }
    }

    public class Drinks
    {
        [JsonProperty("drinks")]
        public List<Drink> DrinksList { get; set; }
    }
}
