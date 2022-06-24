using DapperExtensions.Sql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Services
DapperExtensions.DapperExtensions.SqlDialect = new SqliteDialect();
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddSingleton<TodoRepo>();
builder.Services.AddCors();

var app = builder.Build();

app.MapTodoRoutes();
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
