namespace ProyectoInvestigacionBackend.Services
{
    public interface IAuthService
    {
        Task<bool> Login(string correo, string contrasena, string captcha);
    }
}