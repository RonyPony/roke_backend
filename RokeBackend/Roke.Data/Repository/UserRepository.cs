using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RokeBackend.core.Contracts;
using RokeBackend.data.DataContext;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RokeContext _context;
        public UserRepository(RokeContext ctx)
        {
            _context = ctx;
        }
        public async Task<user> CreateUser(user user)
        {
            user finalUser = new user();
            try
            {
                _context.users.Add(user);
                await _context.SaveChangesAsync();
                finalUser= user;
                return finalUser;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return finalUser;
            }
        }

      

        public IEnumerable<user> getAllUsers()
        {
            try
            {
                var users = _context.users.ToList();
                return users;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<user> getUserByEmailAsync(string _username)
        {
            try
            {
                user user = _context.users.Where((ee)=>ee.username == _username).FirstOrDefault();
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<user> getUserByIdAsync(Guid id)
        {
            try
            {
                user user = await _context.users.FindAsync(id);
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<user> getUserByuser(string user)
        {
            throw new NotImplementedException();
        }

        public async Task<int> RemoveUser(Guid UserId)
        {
            try
            {
                try
                {
                    user user = await _context.users.FindAsync(UserId);
                    _context.users.Remove(user);
                    _context.SaveChanges();
                    return 1;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task UpdateUser(user User)
        {
            throw new NotImplementedException();
        }
    }
}
