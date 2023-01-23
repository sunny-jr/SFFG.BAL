using AutoMapper;
using SFFG.BAL.Interface;
using SFFG.BAL.Models;
using SFFG.DAL;
using SFFG.DAL.Entities;
using SFFG.DAL.IRepositories;
using SFFG.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Logic
{
    public class UserRepository : Interface.IUserRepository
    {
        DAL.IRepositories.IUserRepository user;
        IMapper _mapper;
        public UserRepository(DAL.IRepositories.IUserRepository repo, IMapper mapper)
        {
            user = repo;
            _mapper = mapper;
        }
        public bool AddNewUser(UserDTO u)
        {
            if (u is not null)
            {
                return user.AddNewUser(_mapper.Map<UserDTO,User>(u));
            }

            return false;

        }

        public bool DeleteUserRefreshTokens(string userId, string refreshToken)
        {
            if(userId is not null && refreshToken != String.Empty)
            {
                var isDeleted = user.DeleteUserRefreshTokens(userId, refreshToken);
                if (isDeleted) return true;

                return false;
            }

            return false;
        }

        public UserDTO? FindUser(string userId, string password)
        {
            var u = user.FindUser(userId, password);
            
            if(user is not null && u is not null) return _mapper.Map<User,UserDTO>(u); 
            

            return null; 
        }

        public RefreshTokenDTO GetSavedRefreshTokens(string userId, string refreshToken)
        {
            return _mapper.Map<RefreshToken,RefreshTokenDTO>(user.GetSavedRefreshTokens(userId, refreshToken));
        }

        public UserDTO? GetUser(string id)
        {
            var getUserById = user.GetUserById(id);
            if (user is not null && getUserById is not null) return _mapper.Map<User, UserDTO>(getUserById);
            
            return null;
        }

        public bool SaveRefreshToken(RefreshTokenDTO token)
        {
            var convertToken = _mapper.Map<RefreshTokenDTO,RefreshToken>(token);
            if (token is not null) return user.SaveRefreshToken(convertToken);

            return false;
        }
    }
}
