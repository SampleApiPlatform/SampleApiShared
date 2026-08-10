using NuGet.SampleSharedModels.Interfaces;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;

namespace NuGet.SampleSharedModels.Services
{
    public class SharedServicesClient : ISharedServicesClient
    {

        private readonly HttpClient _httpClient;

        public SharedServicesClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task LogAsync(string category, string message, LogLevel level)
        {
            try
            {
                var payload = new
                {
                    Category = category,
                    Message = message,
                    Level = level.ToString()
                };

                var response = await _httpClient.PostAsJsonAsync("/logging", payload);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"SharedServicesApi returned error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SharedServicesApi unreachable: {ex.Message}");
            }
        }
    }
}
