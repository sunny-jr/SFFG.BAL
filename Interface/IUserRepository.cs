using SFFG.BAL.Models;
using SFFG.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Interface
{
    public interface IUserRepository
    {
       UserDTO? GetUser(string id);

       bool AddNewUser(UserDTO user);

        UserDTO? FindUser(string userId, string password);

        bool SaveRefreshToken(RefreshTokenDTO token);

        RefreshTokenDTO GetSavedRefreshTokens(string userId, string refreshToken);

        bool DeleteUserRefreshTokens(string userId, string refreshToken);
    }
}
