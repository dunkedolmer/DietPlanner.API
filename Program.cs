using DietPlannerAPI;
using DietPlannerAPI.Product;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers(); 

// Register Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register MongoDbContext
builder.Services.AddSingleton<MongoDbContext>();

// Product services
builder.Services.AddScoped<ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("swagger/v1/swagger.json", "Dolmer API v0.0.1");
        c.RoutePrefix = string.Empty; // Set Swagger UI at the app's root.
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();