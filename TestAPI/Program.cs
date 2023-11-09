using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TestContext>(opt => { });
builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
    );

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
 }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();