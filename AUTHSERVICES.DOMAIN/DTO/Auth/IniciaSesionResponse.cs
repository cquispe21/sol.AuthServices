using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTHSERVICES.DOMAIN.DTO.Auth
{
    public class IniciaSesionResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiracion { get; set; }
    }
}
