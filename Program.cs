using System.Net.Http.Headers;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/json"));

await ProcessRepositoryAsync(client);

static async Task ProcessRepositoryAsync(HttpClient client)
{
    var json = await client.GetStringAsync(
        "https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list");

    Console.WriteLine(json);
}