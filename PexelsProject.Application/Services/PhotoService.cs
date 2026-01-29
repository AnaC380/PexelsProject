using PexelsProject.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace PexelsProject.Application.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public PhotoService(
            IHttpClientFactory httpClientFactory,
            IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<string> SearchPhotosAsync(string query)
        {
            var apiKey = _configuration["Pexels:ApiKey"];

            if (string.IsNullOrEmpty(apiKey))
                throw new Exception("Chave da API do Pexels não configurada.");

            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", apiKey);
            client.DefaultRequestHeaders.Add("User-Agent", "PexelsProject/1.0");

            var response = await client.GetAsync(
                $"https://api.pexels.com/v1/search?query={query}&per_page=10");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
