using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

public class Producto
{
    public int Id { get; set; }
    public string Codigo { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string Categoria { get; set; } = "";
    public string Marca { get; set; } = "";
    public string Modelo { get; set; } = "";
    public string Garantia { get; set; } = "";
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public decimal Descuento { get; set; }
    public string Imagen { get; set; } = "";
    public string Descripcion { get; set; } = "";
}

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", policy =>
            {
                policy
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
        });

        var app = builder.Build();

        app.UseCors("AllowAll");

        var productos = new List<Producto>
        {
            new Producto
            {
                Id = 1,
                Codigo = "GPU001",
                Nombre = "Tarjeta Gráfica RTX 4070 Super",
                Categoria = "Tarjetas Gráficas",
                Marca = "NVIDIA",
                Modelo = "GeForce RTX 4070 12GB",
                Garantia = "24 meses",
                Precio = 2899.90m,
                Stock = 10,
                Descuento = 10,
                Imagen = "https://images.unsplash.com/photo-1591488320449-011701bb6704",
                Descripcion = " GPU de alto rendimiento con arquitectura Ada Lovelace y DLSS 3"
            },
            new Producto
            {
                Id = 2,
                Codigo = "CPU001",
                Nombre = "Procesador AMD Ryzen 7 7800X3D",
                Categoria = "Procesadores",
                Marca = "AMD",
                Modelo = "Ryzen 7 7800X3D AM5",
                Garantia = "36 meses",
                Precio = 1899.00m,
                Stock = 15,
                Descuento = 5,
                Imagen = "https://images.unsplash.com/photo-1591799264318-7e6ef8ddb7ea",
                Descripcion = "Procesador de 8 núcleos y 16 hilos con tecnología 3D V-Cache para gaming"
            },
            new Producto
            {
                Id = 3,
                Codigo = "LAP001",
                Nombre = "Laptop ASUS ROG Zephyrus G16",
                Categoria = "Laptops",
                Marca = "ASUS",
                Modelo = "ROG G16 2026",
                Garantia = "12 meses",
                Precio = 6499.00m,
                Stock = 6,
                Descuento = 15,
                Imagen = "https://images.unsplash.com/photo-1603302576837-37561b2e2302",
                Descripcion = "Laptop gamer ultraligera con pantalla OLED 240Hz y RTX 4070"
            },
            new Producto
            {
                Id = 4,
                Codigo = "MON001",
                Nombre = "Monitor Gamer LG UltraGear 27\"",
                Categoria = "Monitores",
                Marca = "LG",
                Modelo = "27GP850-B QHD",
                Garantia = "24 meses",
                Precio = 1399.90m,
                Stock = 12,
                Descuento = 10,
                Imagen = "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf",
                Descripcion = "Monitor IPS QHD 180Hz con 1ms de tiempo de respuesta"
            },
            new Producto
            {
                Id = 5,
                Codigo = "TEC001",
                Nombre = "Teclado Mecánico Keychron K8 Pro",
                Categoria = "Periféricos",
                Marca = "Keychron",
                Modelo = "K8 Pro QMK/VIA",
                Garantia = "12 meses",
                Precio = 449.90m,
                Stock = 20,
                Descuento = 5,
                Imagen = "https://images.unsplash.com/photo-1595225476474-87563907a212",
                Descripcion = "Teclado mecánico inalámbrico TKL con switches Gateron e iluminación RGB"
            },
            new Producto
            {
                Id = 6,
                Codigo = "MOU001",
                Nombre = "Mouse Logitech G Pro X Superlight 2",
                Categoria = "Periféricos",
                Marca = "Logitech",
                Modelo = "Superlight 2 Lightspeed",
                Garantia = "24 meses",
                Precio = 599.90m,
                Stock = 18,
                Descuento = 10,
                Imagen = "https://images.unsplash.com/photo-1615663245857-ac93bb7c39e7",
                Descripcion = "Mouse gamer inalámbrico ultraligero de 60g con sensor HERO 2"
            },
            new Producto
            {
                Id = 7,
                Codigo = "SSD001",
                Nombre = "SSD NVMe Samsung 990 PRO 2TB",
                Categoria = "Almacenamiento",
                Marca = "Samsung",
                Modelo = "MZ-V9P2T0B PCIe 4.0",
                Garantia = "36 meses",
                Precio = 799.90m,
                Stock = 25,
                Descuento = 12,
                Imagen = "https://images.unsplash.com/photo-1597872200969-2b65d56bd16b",
                Descripcion = "Unidad de estado sólido M.2 con velocidades de hasta 7450 MB/s"
            },
            new Producto
            {
                Id = 8,
                Codigo = "RAM001",
                Nombre = "Memoria RAM Corsair Vengeance 32GB",
                Categoria = "Memorias RAM",
                Marca = "Corsair",
                Modelo = "DDR5 6000MHz Dual",
                Garantia = "36 meses",
                Precio = 549.90m,
                Stock = 22,
                Descuento = 8,
                Imagen = "https://images.unsplash.com/photo-1562976540-1502c2145186",
                Descripcion = "Kit de 2x16GB DDR5 6000MHz optimizado para perfiles AMD EXPO e Intel XMP"
            },
            new Producto
            {
                Id = 9,
                Codigo = "MBD001",
                Nombre = "Placa Madre Gigabyte B650 AORUS Elite",
                Categoria = "Placas Madre",
                Marca = "Gigabyte",
                Modelo = "B650 AORUS Elite AX",
                Garantia = "24 meses",
                Precio = 999.90m,
                Stock = 9,
                Descuento = 10,
                Imagen = "https://images.unsplash.com/photo-1518770660439-4636190af475",
                Descripcion = "Placa madre socket AM5 con Wi-Fi 6E, PCIe 5.0 M.2 y VRM digital"
            },
            new Producto
            {
                Id = 10,
                Codigo = "AUD001",
                Nombre = "Audífonos HyperX Cloud III Wireless",
                Categoria = "Audio",
                Marca = "HyperX",
                Modelo = "Cloud III Red/Black",
                Garantia = "12 meses",
                Precio = 529.90m,
                Stock = 14,
                Descuento = 15,
                Imagen = "https://images.unsplash.com/photo-1546435770-a3e426bf472b",
                Descripcion = "Audífonos inalámbricos para gaming con hasta 120 horas de batería"
            },
            new Producto
            {
                Id = 11,
                Codigo = "PSU001",
                Nombre = "Fuente Corsair RM850e 850W 80+ Gold",
                Categoria = "Fuentes de Poder",
                Marca = "Corsair",
                Modelo = "RM850e ATX 3.0",
                Garantia = "36 meses",
                Precio = 579.90m,
                Stock = 11,
                Descuento = 5,
                Imagen = "https://images.unsplash.com/photo-1587202372775-e229f172b9d7",
                Descripcion = "Fuente de alimentación modular certificada 80 Plus Gold compatible con PCIe 5.0"
            },
            new Producto
            {
                Id = 12,
                Codigo = "REF001",
                Nombre = "Refrigeración Líquida NZXT Kraken 360",
                Categoria = "Refrigeración",
                Marca = "NZXT",
                Modelo = "Kraken 360 RGB",
                Garantia = "24 meses",
                Precio = 849.90m,
                Stock = 7,
                Descuento = 10,
                Imagen = "https://images.unsplash.com/photo-1587202372634-32705e3bf49c",
                Descripcion = "Cooler líquido AIO de 360mm con pantalla LCD personalizable"
            },
            new Producto
            {
                Id = 13,
                Codigo = "CAS001",
                Nombre = "Case Lian Li O11 Dynamic EVO",
                Categoria = "Gabinetes",
                Marca = "Lian Li",
                Modelo = "O11D EVO Mid-Tower",
                Garantia = "12 meses",
                Precio = 729.90m,
                Stock = 8,
                Descuento = 10,
                Imagen = "https://images.unsplash.com/photo-1587831990711-23ca6441447b",
                Descripcion = "Gabinete de doble cámara con paneles de vidrio templado y flujo de aire óptimo"
            },
            new Producto
            {
                Id = 14,
                Codigo = "CPU002",
                Nombre = "Procesador Intel Core i7-14700K",
                Categoria = "Procesadores",
                Marca = "Intel",
                Modelo = "Core i7 14va Gen LGA1700",
                Garantia = "36 meses",
                Precio = 1949.90m,
                Stock = 13,
                Descuento = 10,
                Imagen = "https://images.unsplash.com/photo-1555617981-dac3880eac6e",
                Descripcion = "Procesador híbrido de 20 núcleos y hasta 5.6 GHz para multitarea extrema"
            },
            new Producto
            {
                Id = 15,
                Codigo = "GPU002",
                Nombre = "Tarjeta Gráfica AMD Radeon RX 7800 XT",
                Categoria = "Tarjetas Gráficas",
                Marca = "SAPPHIRE",
                Modelo = "NITRO+ RX 7800 XT 16GB",
                Garantia = "24 meses",
                Precio = 2499.90m,
                Stock = 9,
                Descuento = 12,
                Imagen = "https://images.unsplash.com/photo-1591488320449-011701bb6704",
                Descripcion = "Tarjeta de video con 16GB GDDR6 ideal para resolución 1440p Ultra"
            },
            new Producto
            {
                Id = 16,
                Codigo = "LAP002",
                Nombre = "Laptop Lenovo Legion Pro 5i Gen 9",
                Categoria = "Laptops",
                Marca = "Lenovo",
                Modelo = "Legion Pro 5i 16IRX9",
                Garantia = "12 meses",
                Precio = 5899.00m,
                Stock = 5,
                Descuento = 15,
                Imagen = "https://images.unsplash.com/photo-1525547719571-a2d4ac8945e2",
                Descripcion = "Potente laptop para ingeniería y gaming con Core i9 y 32GB de RAM"
            },
            new Producto
            {
                Id = 17,
                Codigo = "MON002",
                Nombre = "Monitor Curvo Samsung Odyssey G5 32\"",
                Categoria = "Monitores",
                Marca = "Samsung",
                Modelo = "Odyssey G55C 165Hz",
                Garantia = "24 meses",
                Precio = 1199.90m,
                Stock = 10,
                Descuento = 10,
                Imagen = "https://images.unsplash.com/photo-1551645120-d70bfe84c826",
                Descripcion = "Monitor curvo 1000R WQHD con tasa de refresco de 165Hz y FreeSync"
            },
            new Producto
            {
                Id = 18,
                Codigo = "MIC001",
                Nombre = "Micrófono Condensador Elgato Wave:3",
                Categoria = "Audio",
                Marca = "Elgato",
                Modelo = "Wave:3 USB-C",
                Garantia = "12 meses",
                Precio = 649.90m,
                Stock = 16,
                Descuento = 5,
                Imagen = "https://images.unsplash.com/photo-1590602847861-f357a9332bbc",
                Descripcion = "Micrófono profesional para streaming y podcast con tecnología Clipguard"
            },
            new Producto
            {
                Id = 19,
                Codigo = "ROU001",
                Nombre = "Router Gamer TP-Link Archer GX90",
                Categoria = "Redes",
                Marca = "TP-Link",
                Modelo = "Archer GX90 AX6600",
                Garantia = "24 meses",
                Precio = 899.90m,
                Stock = 8,
                Descuento = 20,
                Imagen = "https://images.unsplash.com/photo-1544197150-b99a580bb7a8",
                Descripcion = "Router Tri-Banda Wi-Fi 6 con banda dedicada para juegos y puerto 2.5 Gbps"
            },
            new Producto
            {
                Id = 20,
                Codigo = "SIL001",
                Nombre = "Silla Ergonómica Razer Iskur V2",
                Categoria = "Mobiliario",
                Marca = "Razer",
                Modelo = "Iskur V2 Adaptive",
                Garantia = "24 meses",
                Precio = 1799.90m,
                Stock = 6,
                Descuento = 10,
                Imagen = "https://images.unsplash.com/photo-1598550476439-6847785fcea6",
                Descripcion = "Silla gamer con soporte lumbar adaptativo 6D para largas sesiones"
            }
        };

        // Ruta raíz de estado de la API (Versión 2.0)
        app.MapGet("/", () =>
        {
            return Results.Ok(new
            {
                mensaje = "API TECNOMARKET FUNCIONANDO",
                version = "2.0",
                estado = "OK"
            });
        });

        // GET: Consultar todos los productos
        app.MapGet("/api/productos", () =>
        {
            return Results.Ok(productos);
        });

        // GET por ID: Consultar un producto específico
        app.MapGet("/api/productos/{id:int}", (int id) =>
        {
            var producto = productos.FirstOrDefault(x => x.Id == id);
            if (producto == null)
            {
                return Results.NotFound(new
                {
                    mensaje = $"No existe un producto con ID {id}"
                });
            }
            return Results.Ok(producto);
        });

        // POST: Registrar un nuevo producto con validaciones
        app.MapPost("/api/productos", (Producto nuevoProducto) =>
        {
            if (string.IsNullOrWhiteSpace(nuevoProducto.Codigo))
            {
                return Results.BadRequest(new{mensaje = "El código es obligatorio"});
            }
            if (string.IsNullOrWhiteSpace(nuevoProducto.Nombre))
            {
                return Results.BadRequest(new{mensaje = "El nombre es obligatorio"});
            }
            if (nuevoProducto.Precio < 0)
            {
                return Results.BadRequest(new{mensaje = "El precio no puede ser negativo"});
            }
            if (nuevoProducto.Stock < 0)
            {
                return Results.BadRequest(new{mensaje = "El stock no puede ser negativo"});
            }
            if (nuevoProducto.Descuento < 0 || nuevoProducto.Descuento > 100)
            {
                return Results.BadRequest(new{mensaje = "El descuento debe estar entre 0 y 100"});
            }
            nuevoProducto.Id = productos.Count == 0
                ? 1
                : productos.Max(x => x.Id) + 1;

            productos.Add(nuevoProducto);

            return Results.Created(
                $"/api/productos/{nuevoProducto.Id}",
                nuevoProducto
            );
        });

        // PUT: Actualizar un producto existente por ID
        app.MapPut("/api/productos/{id:int}", (int id, Producto datos) =>
        {
            var producto = productos.FirstOrDefault(x => x.Id == id);
            if (producto == null)
            {
                return Results.NotFound(new
                {
                    mensaje = $"No existe un producto con ID {id}"
                });
            }
            if (datos.Precio < 0)
            {
                return Results.BadRequest(new
                {
                    mensaje = "El precio no puede ser negativo"
                });
            }
            if (datos.Stock < 0)
            {
                return Results.BadRequest(new
                {
                    mensaje = "El stock no puede ser negativo"
                });
            }
            if (datos.Descuento < 0 || datos.Descuento > 100)
            {
                return Results.BadRequest(new
                {
                    mensaje = "El descuento debe estar entre 0 y 100"
                });
            }

            producto.Codigo = datos.Codigo;
            producto.Nombre = datos.Nombre;
            producto.Categoria = datos.Categoria;
            producto.Marca = datos.Marca;
            producto.Modelo = datos.Modelo;
            producto.Garantia = datos.Garantia;
            producto.Precio = datos.Precio;
            producto.Stock = datos.Stock;
            producto.Descuento = datos.Descuento;
            producto.Imagen = datos.Imagen;
            producto.Descripcion = datos.Descripcion;

            return Results.Ok(producto);
        });

        // DELETE: Eliminar un producto por ID
        app.MapDelete("/api/productos/{id:int}", (int id) =>
        {
            var producto = productos.FirstOrDefault(x => x.Id == id);
            if (producto == null)
            {
                return Results.NotFound(new
                {
                    mensaje = $"No existe un producto con ID {id}"
                });
            }

            productos.Remove(producto);

            return Results.Ok(new
            {
                mensaje = $"Producto con ID {id} eliminado correctamente",
                eliminado = producto
            });
        });

        // Ruta de prueba con parámetro
        app.MapGet("/prueba/{id:int}", (int id) =>
        {
            return Results.Ok(new
            {
                mensaje = "Ruta con parámetro funcionando",
                id = id
            });
        });

        var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
        app.Run($"http://0.0.0.0:{port}");
    }
}