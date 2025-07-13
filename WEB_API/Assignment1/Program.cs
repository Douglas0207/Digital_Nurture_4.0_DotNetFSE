var builder = WebApplication.CreateBuilder(args);

// ✅ Register MVC-style controllers
builder.Services.AddControllers();

// ✅ Enable Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ Enable Swagger UI in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// ✅ Map your controller routes (e.g. /api/values)
app.MapControllers();

app.Run();
