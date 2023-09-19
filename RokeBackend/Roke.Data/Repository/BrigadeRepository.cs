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
    public class BrigadeRepository : IBrigadeRepository
    {
        private readonly RokeContext _context;
        public BrigadeRepository(RokeContext ctx)
        {
            _context = ctx;

        }



        public async Task<brigadeAssigne> asignBrigades(brigadeAssigne data)
        {
            try
            {
                _context.brigadeAssinge.Add(data);
                await _context.SaveChangesAsync();
                return data;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return data;
            }
        }

        public Task<brigadeDetails> asignBrigades(brigadeDetails data)
        {
            throw new NotImplementedException();
        }

        public async Task<brigade> CreateBrigade(brigade brigade)
        {
            brigade plan = new brigade();
            try
            {
                _context.brigades.Add(brigade);
                await _context.SaveChangesAsync();
                plan = brigade;
                return plan;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return plan;
            }
        }


        public IEnumerable<brigade> getAllBrigades()
        {
            try
            {
                var brigade = _context.brigades.ToList();
                return brigade;
            }
            catch (Exception)
            {

                throw;
            }
        }

   
        public async Task<brigadeDetails> getBrigadeByIdAsync(Guid id)
        {
            try
            {
                brigade plan = await _context.brigades.FindAsync(id);
                brigadeDetails twl = new brigadeDetails();
                List<user> user = new List<user>();
                twl.Name = plan.Name;
              
                List<brigadeAssigne> x =  _context.brigadeAssinge.Where((e)=>e.brigadeId == id).ToList();
                foreach (var item in x)
                {
                    var tmpUser = await _context.users.FindAsync(item.tecnicosId);
                    user.Add(tmpUser);
                }

                twl.tecnicos = user;
                
                return twl;
            }
            catch (Exception)
            {

                throw;
            }
        }

   

        public async Task<int> RemoveBrigade(Guid id)
        {
            try
            {
                try
                {
                    brigade plan = await _context.brigades.FindAsync(id);
                    //_context.tickets.Remove(Ticket);
                    plan.status = Roke.Core.Enums.Status.Deleted;
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

   

        public async Task<brigade> UpdateBrigade(brigade brigade)
        {
            try
            {
                
                 _context.brigades.Update(brigade);
                await _context.SaveChangesAsync();
                return brigade;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return brigade;
            }


        }

      
    }
}
