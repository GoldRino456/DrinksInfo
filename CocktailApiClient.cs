using System.Net.Http.Headers;


namespace DrinksInfo
{
    internal class CocktailApiClient
    {
        static readonly HttpClient client = new();
       
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

        }
    }
}
