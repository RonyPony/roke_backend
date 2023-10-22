using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Roke.Core.Model;
using RokeBackend.core.Contracts;
using RokeBackend.data.DataContext;
using RokeBackend.Model;
using RokeBackend.data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roke.Data.DTOs;

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

        public IEnumerable<user> getAllTech()
        {
            try
            {
                var user = _context.users.Where((e)=> e.rol == Roke.Core.Enums.Roles.Technician).ToList();
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


        public async Task<int> RemoveUsuario(Guid idUsuario)
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

        public Task<int> RemoveUsuarios(Guid idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<user> UpdateTicket(user user)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUsuarios(Guid id)
        {

            _context.Entry(id).State = EntityState.Modified;
            await _context.SaveChangesAsync();
                
           
        }

        public Task<user> UpdateUsuariso(user Usuario)
        {
            throw new NotImplementedException();
        }

      

     public async Task<user> UpdateUsuario(user user)
        {
            try
            {
                
                 _context.users.Update(user);
                await _context.SaveChangesAsync();
                return user;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return user;
            }


        }

     
    }
}
