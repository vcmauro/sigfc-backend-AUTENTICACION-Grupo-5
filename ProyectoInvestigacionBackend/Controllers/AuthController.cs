using Microsoft.AspNetCore.Mvc;
using ProyectoInvestigacionBackend.DTOs;
using ProyectoInvestigacionBackend.Services;

namespace ProyectoInvestigacionBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDTO request)
        {
            var resultado = await _authService.Login(
                request.Correo,
                request.Contrasena,
                request.CaptchaToken
            );

            if (!resultado)
                return Unauthorized("Credenciales inválidas");

            return Ok("Login exitoso");
        }
    }
}