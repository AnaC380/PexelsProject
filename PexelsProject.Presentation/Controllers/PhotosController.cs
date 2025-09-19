using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PexelsProject.Controllers
{
    public class PhotosController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public PhotosController(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _apiKey = configuration["Pexels:ApiKey"] ?? throw new ArgumentNullException("Pexels:ApiKey não encontrada no appsettings.json");
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);
        }

        public async Task<IActionResult> Index(string query = "cats")
        {
            try
            {
                var response = await _httpClient.GetStringAsync($"https://api.pexels.com/v1/search?query={Uri.EscapeDataString(query)}&per_page=5");
                var json = JObject.Parse(response);
                var photos = json["photos"]?.Select(p => p?["src"]?["medium"]?.ToString())?.ToList() ?? new List<string?>();

                if (photos == null || !photos.Any())
                {
                    return View(new List<string?> { "Nenhuma foto encontrada ou erro na API." });
                }

                return View(photos);
            }
            catch (HttpRequestException ex)
            {
                return View(new List<string?> { $"Erro ao buscar fotos: {ex.Message}" });
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                return View(new List<string?> { $"Erro ao processar resposta: {ex.Message}" });
            }
        }
    }
}