using System.Net;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapPost(
    "/asterisk",
    ([FromBody] AsteriskCommandDto dto) =>
    {
        Console.WriteLine("Making API Call...");
        using (
            var client = new HttpClient(
                new HttpClientHandler
                {
                    AutomaticDecompression =
                        DecompressionMethods.GZip | DecompressionMethods.Deflate
                }
            )
        ) {
            client.BaseAddress = new Uri($"http://{dto.Login}:{dto.Password}@{dto.Ip}:{dto.Port}");
            HttpResponseMessage response = client
                .GetAsync(dto.Command)
                .Result;
            response.EnsureSuccessStatusCode();
            string result = response.Content.ReadAsStringAsync().Result;
            return Results.Ok(result);
        }
    }
).WithName("arst");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();

public class AsteriskCommandDto
{
    public string Ip { get; set; } = null!;
    public string Port { get; set; } = null!;
    public string Command { get; set; } = null!;

    public string Login { get; set; } = "asterisk";
    public string Password { get; set; } = "asterisk";
}
