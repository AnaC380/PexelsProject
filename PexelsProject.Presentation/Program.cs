using PexelsProject.Application.Interfaces;
using PexelsProject.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Controllers (MVC / API)
builder.Services.AddControllers();

// HttpClient para integrações externas
builder.Services.AddHttpClient();

// Injeção de dependência da aplicação
builder.Services.AddScoped<IPhotoService, PhotoService>();

// Swagger/OpenAPI para .NET 8.0
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Pipeline HTTP
// app.UseHttpsRedirection(); // Desabilitado temporariamente

app.UseHttpsRedirection();

// Mapeia controllers
app.MapControllers();

app.Run();
