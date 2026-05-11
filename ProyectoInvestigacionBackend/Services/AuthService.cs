using ProyectoInvestigacionBackend.Repositories;

namespace ProyectoInvestigacionBackend.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public AuthService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<bool> Login(string correo, string contrasena, string captcha)
        {
            // Validación simple de captcha
            if (string.IsNullOrEmpty(captcha))
                return false;

            var usuario = await _usuarioRepository.ObtenerPorCorreo(correo);

            if (usuario == null)
                return false;

            // Comparación simple (luego puedes usar BCrypt)
            if (usuario.ContrasenaHash != contrasena)
                return false;

            return true;
        }
    }
}