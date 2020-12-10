using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DXBlazorNorthWind
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            await AddHttpClient(builder); 
            
            builder.Services.AddDevExpressBlazor();
            await builder.Build().RunAsync();
        }

        private static async Task AddHttpClient(WebAssemblyHostBuilder builder)
        {
            var login = "admin";
            var pwd = "admin";
            var baseAddress = "http://localhost.fiddler:9351";
            //var baseAddress = "http://localhost:9351";

            var httpClient = new HttpClient {BaseAddress = new Uri(baseAddress)};
            var response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Post, "token")
            {
                Headers =
                {
                    Authorization = new AuthenticationHeaderValue(
                        "Basic", Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{login}:{pwd}")))
                },
                Content = new StringContent($"grant_type=password&username={login}&password={pwd}")
            });

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.StatusCode.ToString());
            }

            var jsonToken = await System.Text.Json.JsonSerializer.DeserializeAsync<TokenResponse>(
                await response.Content.ReadAsStreamAsync());

            if (jsonToken == null)
            {
                throw new Exception(response.StatusCode.ToString());
            }

            httpClient.DefaultRequestHeaders.Authorization
                = new AuthenticationHeaderValue(jsonToken.token_type, jsonToken.access_token);

            builder.Services.AddSingleton(sp => httpClient);
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
