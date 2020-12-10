using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blazor.Dev.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new HttpClient {BaseAddress = new Uri("http://localhost.fiddler:9351")};

            var login = "admin";
            var pwd = "admin";

            var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, "token")
            {
                Headers =
                {
                    Authorization = new AuthenticationHeaderValue(
                        "Basic", Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{login}:{pwd}")))
                },
                Content = new StringContent($"grant_type=password&username={login}&password={pwd}")
            });

            var jsonToken = await System.Text.Json.JsonSerializer.DeserializeAsync<TokenResponse>(
                await response.Content.ReadAsStreamAsync());

            client.DefaultRequestHeaders.Authorization 
                = new AuthenticationHeaderValue(jsonToken.token_type, jsonToken.access_token);

            response = await client.PostAsync(@"api/security", null);
            var security = await response.Content.ReadAsStringAsync();
        }

        internal sealed class TokenResponse
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
            public string refresh_token { get; set; }
            public string user { get; set; }
        }

    }
}
