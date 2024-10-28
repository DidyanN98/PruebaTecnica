using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

public class ApiService
{
    private readonly HttpClient _client;

    public ApiService(string apiKey)
    {
        _client = new HttpClient();
        _client.DefaultRequestHeaders.Add("ApiKey", apiKey);
    }

    public async Task<string> GetDataAsync(string fecha)
    {
        var response = await _client.GetAsync($"https://iis-des.cnbs.gob.hn/ws.TestData/api/data?Fecha={fecha}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}
