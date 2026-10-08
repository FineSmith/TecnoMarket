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
// 1. Recurso de Categorías
app.MapGet("/api/categorias", () => Results.Ok(new[] {
    new { id = 1, nombre = "Laptops", descripcion = "Portátiles y equipos de alto rendimiento" },
    new { id = 2, nombre = "Procesadores", descripcion = "CPUs Intel y AMD Ryzen" },
    new { id = 3, nombre = "Placas de Video", descripcion = "Tarjetas gráficas dedicadas NVIDIA y AMD" },
    new { id = 4, nombre = "Monitores", descripcion = "Pantallas de alta tasa de refresco" },
    new { id = 5, nombre = "Memorias RAM", descripcion = "Módulos DDR4 y DDR5 para gaming y trabajo" }
}));

// 2. Recurso de Promociones
app.MapGet("/api/promociones", () => Results.Ok(new[] {
    new { id = 1, titulo = "Semana Gamer", descuento = 15, categoria = "Placas de Video" },
    new { id = 2, titulo = "Liquidación Escolar", descuento = 10, categoria = "Laptops" }
}));

// 3. Recurso de Pedidos
app.MapGet("/api/pedidos", () => Results.Ok(new[] {
    new { id = 101, cliente = "Mateo Quispe", total = 2499.90, estado = "Completado" },
    new { id = 102, cliente = "Lucía Morales", total = 1199.90, estado = "En Proceso" }
}));
// Puerto para Render
var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";

app.Run($"http://0.0.0.0:{port}");
