using RestSharp;
using Newtonsoft.Json;


namespace DrinksInfo
{
    internal class CocktailApiClient
    {
        public static CocktailApiClient Instance { get; } = new();
        private readonly RestClientOptions _options;
        private readonly RestClient _client;

        private CocktailApiClient()
        {
            _options = new RestClientOptions("https://www.thecocktaildb.com/api/json/v1/1/");
            _client = new RestClient(_options); 
        }

        public async Task GetCategoryList()
        {
            var request = new RestRequest("list.php?c=list");
            var response = await _client.GetAsync(request);
        }
        
        /*static readonly HttpClient client = new();
       
        static async void BuildAPIRequest(string url)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            await ProcessRequestAsync(client, url);
        }

        static async Task ProcessRequestAsync(HttpClient client, string url)
        {
            var json = await client.GetStringAsync(url);

        }*/
    }
}
