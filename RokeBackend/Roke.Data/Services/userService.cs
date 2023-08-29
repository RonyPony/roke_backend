
using RokeBackend.core.Interface;
using RokeBackend.Model;
using RokeBackend.data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RokeBackend.core.Contracts;

namespace RokeBackend.data.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public Task<int> DeleteUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<user> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<user> GetUserById(Guid id)
        {
            return _repo.getUserByIdAsync(id);
        }


        public Task<user> getUserByuser(string user)
        {
            return _repo.getUserByuser(user);
        }

        public Task removeContactInfo(int contactInfoId)
        {
            throw new NotImplementedException();
        }

        public Task<user> SaveUser(user user)
        {
            throw new NotImplementedException();
        }
    }
}
