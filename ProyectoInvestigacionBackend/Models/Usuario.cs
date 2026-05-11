namespace ProyectoInvestigacionBackend.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string CorreoInstitucional { get; set; } = string.Empty;
        public string ContrasenaHash { get; set; } = string.Empty;
    }
}