using api.Models;
using api.Services;
var builder = WebApplication.CreateBuilder(args);

var allowedOrigins = "allowedOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowedOrigins,
        policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseCors(allowedOrigins);

app.MapGet("/primeNumbers/{i}", (int i) =>
{
    var primeNumbers = PrimeNumbersService.GetPrimeNumbers(i);

    ApiResponse response = new ApiResponse(primeNumbers);

    return (response);
});

app.Run();
