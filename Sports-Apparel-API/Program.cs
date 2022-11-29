using Microsoft.EntityFrameworkCore;
using Sports_Apparel_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("SportsApparelContext");
builder.Services.AddDbContext<SportsApparelContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllers();

builder.Services.AddCors(p => p.AddPolicy("corsapp",builder=>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
