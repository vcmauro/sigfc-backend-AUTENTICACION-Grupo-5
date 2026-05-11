using Microsoft.EntityFrameworkCore;
using ProyectoInvestigacionBackend.Data;
using ProyectoInvestigacionBackend.Repositories;
using ProyectoInvestigacionBackend.Services;

var builder = WebApplication.CreateBuilder(args);

// 🧩 Habilitar Controllers
builder.Services.AddControllers();

// 🧩 Swagger (para probar la API en navegador)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🧩 Configurar conexión a SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 🧠 Inyección de dependencias

// Repository
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

// Service
builder.Services.AddScoped<IAuthService, AuthService>();

var app = builder.Build();

// 🧪 Activar Swagger solo en desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 🔒 Middleware básico
app.UseHttpsRedirection();

// 🌐 Mapear controllers
app.MapControllers();

// 🚀 Ejecutar aplicación
app.Run();