using Microsoft.EntityFrameworkCore;
using WebAPIProducto.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(
    options =>options.UseSqlite(connectionString)
    );
// Agregar servicios a la aplicación
builder.Services.AddControllers();  // Agrega soporte para controladores
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline de HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization(); // Asegura que las solicitudes respeten reglas de autorización

app.MapControllers();  // Mapea automáticamente todos los controladores

app.Run();
