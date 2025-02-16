
using AUTHSERVICES.DOMAIN.DTO.Auth;

namespace AUTHSERVICES.APPLICATION.Interface
{
    public interface IAuthService
    {
        Task<IniciaSesionResponse> IniciaSesionAsync(IniciaSesionRequest request);

    }
}
