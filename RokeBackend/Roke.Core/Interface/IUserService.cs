
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Interface
{
    public interface IUserService
    {
        public IEnumerable<user> GetAllUsers();
        public Task<user> GetUserById(Guid id);
        public Task<user> getUserByuser(string user);
        public Task<user> SaveUser(user user);
        public Task<int> DeleteUser(Guid userId);
        
        Task removeContactInfo(int contactInfoId);
    }
}
