using ProyectoInvestigacionBackend.Models;

namespace ProyectoInvestigacionBackend.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> ObtenerPorCorreo(string correo);
    }
}