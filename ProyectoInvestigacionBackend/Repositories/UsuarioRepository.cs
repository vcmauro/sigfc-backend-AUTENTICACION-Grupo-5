using Microsoft.EntityFrameworkCore;
using ProyectoInvestigacionBackend.Data;
using ProyectoInvestigacionBackend.Models;

namespace ProyectoInvestigacionBackend.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario?> ObtenerPorCorreo(string correo)
        {
            return await _context.Usuarios
                .FirstOrDefaultAsync(u => u.CorreoInstitucional == correo);
        }
    }
}