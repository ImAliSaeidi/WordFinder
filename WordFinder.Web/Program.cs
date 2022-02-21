using Microsoft.EntityFrameworkCore;
using WordFinder.Core.IRepositories.Words;
using WordFinder.Core.Repositories.Words;
using WordFinder.Data.Context;
using WordFinder.Data.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IWordService, WordService>();
builder.Services.AddScoped<IWordRepository, WordRepository>();
builder.Configuration.GetSection("ConnectionStringConfig").Bind(new ConnectionStringConfig());
builder.Services.AddDbContext<WordFinderContext>(option => { option.UseSqlServer(ConnectionStringConfig.ConnectionString); });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();

app.Run();
