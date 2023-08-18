
using RokeBackend.core.Interface;
using RokeBackend.Model;
using RokeBackend.data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.data.Services
{
    public class UserService : IUserService
    {
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
            throw new NotImplementedException();
        }

        public Task<user> getUserByuser(string user)
        {
            throw new NotImplementedException();
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
