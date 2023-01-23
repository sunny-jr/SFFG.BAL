using SFFG.BAL.Models;
using System.Security.Claims;

namespace SFFG.BAL.Interface
{
    public interface ITokenRepository
    {
        TokenDTO GenerateToken(LoginDTO user);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
