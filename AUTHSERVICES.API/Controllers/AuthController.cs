using AUTHSERVICES.APPLICATION.Interface;
using AUTHSERVICES.DOMAIN.DTO.Auth;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AUTHSERVICES.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [SwaggerOperation(
         Summary = "Servicio que valida las credenciales del usuario",
         OperationId = "IniciaSesionAsync")]
        [SwaggerResponse(200, "Ok")]
        [SwaggerResponse(500, "Error interno en el servidor")]
        [HttpPost("iniciaSesionAsync")]
        public async Task<IActionResult> IniciaSesionAsync([FromBody] IniciaSesionRequest request)
        {
            return Ok(await _authService.IniciaSesionAsync(request));
        }
    }
}
