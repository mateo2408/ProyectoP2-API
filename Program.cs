using Microsoft.EntityFrameworkCore;
using NotasAcademicasApi.Data; // Use the correct namespace for AppDbContext

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("NotasDb"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors();
app.MapControllers();

app.Run();