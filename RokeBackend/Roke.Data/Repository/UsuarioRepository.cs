using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Roke.Core.Model;
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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly RokeContext _context;
        public UsuarioRepository(RokeContext ctx)
        {
            _context = ctx;
        }
        public async Task<user> CreateUsuario(user Usuario)
        {
            user finaluser = new user();
            try
            {
                _context.users.Add(Usuario);
                await _context.SaveChangesAsync();
                finaluser = Usuario;
                return finaluser;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return finaluser;
            }
        }

      

        public IEnumerable<user> getAllUsuario()
        {
            try
            {
                var user = _context.users.ToList();
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<user> getAllUsuarios()
        {
            try
            {
                var user = _context.users.ToList();
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<user> getUsuarioByIdAsync(Guid id)
        {
            try
            {
                user usuario = await _context.users.FindAsync(id);
                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<int> RemoveTicket(Guid idUsuario)
        {
            try
            {
                try
                {
                    user usuario = await _context.users.FindAsync(idUsuario);
                    //_context.tickets.Remove(Ticket);
                    usuario.Statusuario = Roke.Core.Enums.UsuarioStatus.Deleted;
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

        public Task<int> RemoveUsuario(Guid idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<user> UpdateTicket(user user)
        {
            throw new NotImplementedException();
        }

        public Task<user> UpdateUsuario(user Usuario)
        {
            throw new NotImplementedException();
        }
    }
}
