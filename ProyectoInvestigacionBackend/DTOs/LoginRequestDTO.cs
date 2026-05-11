namespace ProyectoInvestigacionBackend.DTOs
{
    public class LoginRequestDTO
    {
        public string Correo { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public string CaptchaToken { get; set; } = string.Empty;
    }
}