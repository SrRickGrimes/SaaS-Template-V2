using Scalar.AspNetCore;
using FastEndpoints;
using Server.Module.Framework.Extensions;
using Server.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.InstallAllModules(builder.Configuration);
builder.Services.RegisterEndPoints();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseOpenApi(c => c.Path = "/openapi/{documentName}.json");
    app.MapScalarApiReference(_ => _.Servers = []);
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseFastEndpoints();
app.Run();
