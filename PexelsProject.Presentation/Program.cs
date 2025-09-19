using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddOpenApi();  

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();

app.MapGet("/test-config", (IConfiguration config) =>
{
    var apiKey = config["Pexels:ApiKey"];
    return $"Chave configurada: {!string.IsNullOrEmpty(apiKey)}\n" +
           $"Tamanho: {apiKey?.Length ?? 0} caracteres\n" +
           $"Valor: {apiKey?.Substring(0, 10)}...";
});

app.MapGet("/", () => "Bem-vindo ao PexelsProject! Acesse /weatherforecast para ver a previsão ou /Photos para buscar fotos.");

var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast(DateOnly.FromDateTime(DateTime.Now.AddDays(index)), Random.Shared.Next(-20, 55), summaries[Random.Shared.Next(summaries.Length)]))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.MapGet("/photos/{query}", async (string query, IHttpClientFactory httpClientFactory, IConfiguration configuration) =>
{
    var apiKey = configuration["Pexels:ApiKey"];
    if (string.IsNullOrEmpty(apiKey))
    {
        return Results.Problem("Chave da API não configurada");
    }

    try
    {
    var client = httpClientFactory.CreateClient();
    client.DefaultRequestHeaders.Clear();
    client.DefaultRequestHeaders.Add("Authorization", apiKey);
    client.DefaultRequestHeaders.Add("User-Agent", "PexelsProject/1.0");

        
        var response = await client.GetAsync($"https://api.pexels.com/v1/search?query={query}&per_page=10");
        
        if (!response.IsSuccessStatusCode)
        {
            return Results.Problem($"Erro na API: {response.StatusCode}");
        }

       var content = await response.Content.ReadAsStringAsync();
    return Results.Content(content, "application/json");

    }
    catch (Exception ex)
    {
        return Results.Problem($"Erro: {ex.Message}");
    }
})
.WithName("SearchPhotos");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}