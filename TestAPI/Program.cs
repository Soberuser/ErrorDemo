using Microsoft.EntityFrameworkCore;
using TestAPI.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<TestContext>(opt => { });
builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
           options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
    );


var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
 }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();