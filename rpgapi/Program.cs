using Microsoft.EntityFrameworkCore;
using RpgApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoLocal")));


// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.MapControllers();
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}


//INSTRUÇÕES GIT
/*--Configuração Inicial
git config --global init.defaultBranch main  
git config --global user.name "SEU NOME"  
git config --global user.email "seuemail@seuemail" 

echo "#API de jogo RPG - Turma 3AI" >> README.md  
dotnet new gitignore

--Subindo para o repositório
git init  
git add . 
git commit -m "Exemplo: Aula 01 - Criação do Projeto RPG API - Métodos GET"
git branch -M main  
git remote add origin https://github.com/COMPLEMENTO 
-----EM CASOS DE ERRO-----
git remote remove origin
-----FIM DO TRECHO EM CASO DE ERROS-----
git push -u origin main

--Atualizar projeto no respotitório
git status 
git add . 
git commit -m “Aula 01 - Atualização das instruções de Git” 
git push [-u origin main] */