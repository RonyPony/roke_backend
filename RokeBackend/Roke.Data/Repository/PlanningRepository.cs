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
    public class PlanningRepository : IPlanningRepository
    {
        private readonly RokeContext _context;
        public PlanningRepository(RokeContext ctx)
        {
            _context = ctx;
        }
        public async Task<planning> CreatePlanning(planning planning)
        {
            planning finaluser = new planning();
            try
            {
                _context.plannings.Add(planning);
                await _context.SaveChangesAsync();
                finaluser = planning;
                return planning;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return finaluser;
            }
        }

      

        public IEnumerable<planning> getAllPlanning()
        {
            try
            {
                var planning = _context.plannings.ToList();
                return planning;
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

        public Task<Ticket> CreatePlanning(Ticket Ticket)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> getAllPlannings()
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> getPlanningByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> UpdatePlanning(Ticket Ticket)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemovePlanning(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
