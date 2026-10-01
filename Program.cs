var builder = WebApplication.CreateBuilder(args);

// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();

// Ruta principal
app.MapGet("/", () =>
{
    return "API TecnoMarket funcionando";
});

// Ruta de productos
app.MapGet("/api/productos", () =>
{
    return Results.Ok(new[]
    {
        new
        {
            id = 1,
            codigo = "P001",
            nombre = "Laptop Lenovo IdeaPad",
            categoria = "Laptops",
            precio = 2499.90,
            stock = 10
        },
        new
        {
            id = 2,
            codigo = "P002",
            nombre = "Procesador AMD Ryzen 7",
            categoria = "Procesadores",
            precio = 1399.90,
            stock = 15
        },
        new
        {
            id = 3,
            codigo = "P003",
            nombre = "Placa de Video NVIDIA RTX",
            categoria = "Placas de Video",
            precio = 2499.90,
            stock = 8
        },
        new
        {
            id = 4,
            codigo = "P004",
            nombre = "Refrigeradora Samsung",
            categoria = "Refrigeradoras",
            precio = 3299.90,
            stock = 5
        },
        new
        {
            id = 5,
            codigo = "P005",
            nombre = "Microondas LG",
            categoria = "Microondas",
            precio = 599.90,
            stock = 12
        }
    });
});

// Puerto para Render
var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";

app.Run($"http://0.0.0.0:{port}");