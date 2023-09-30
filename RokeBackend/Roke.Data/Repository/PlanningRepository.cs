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

        public Task<brigadeAssigne> asignBrigades(brigadeAssigne data)
        {
            throw new NotImplementedException();
        }

        public Task<brigadeAssigne> asignBrigadesByTemplate(brigadeAssigne data)
        {
            throw new NotImplementedException();
        }

        public async Task<planning> asignplannings(planning data)
        {
            try
            {
                _context.planning.Add(data);
                await _context.SaveChangesAsync();
                return data;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return data;
            }
        }

        public Task<brigade> CreateBrigade(brigade brigade)
        {
            throw new NotImplementedException();
        }

        public async Task<planning> CreatePlanning(planning data)
        {
            try
            {
                _context.planning.Add(data);
                await _context.SaveChangesAsync();
                return data;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return data;
            }
        }

        public IEnumerable<brigade> getAllBrigades()
        {
            throw new NotImplementedException();
        }





        /*    public async Task<planning> CreateBrigade(planning planning)
            {
                planning plan = new planning();
                try
                {
                    _context.planning.Add(planning);
                    await _context.SaveChangesAsync();
                    plan = planning;
                    return plan;
                }
                catch (Exception ex)
                {
                    _context.ChangeTracker.Clear();
                    return plan;
                }
            }
        */


        public IEnumerable<planning> getAllPlannings()
        {
            try
            {
                var planning = _context.planning.ToList();
                return planning;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<brigadeDetails> getBrigadeByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<planningDetails> getPlanningByIdAsync(Guid id)
        {
            try
            {
                planning plan = await _context.planning.FindAsync(id);
                planningDetails twl = new planningDetails();
                List<brigade> user = new List<brigade>();
                twl.Name = plan.Name;
              
                List<planning> x =  _context.planning.Where((e)=>e.idBrigade == id).ToList();
                foreach (var item in x)
                {
                    var tmpUser = await _context.brigades.FindAsync(item.idBrigade);
                    user.Add(tmpUser);
                }

                twl.Brigade = user;
                
                return twl;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<int> RemoveBrigade(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> RemovePlanning(Guid id)
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

        public Task<brigade> UpdateBrigade(brigade brigade)
        {
            throw new NotImplementedException();
        }

        public async Task<brigade> UpdatePlanning(brigade brigade)
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

        public Task<planning> UpdatePlanning(planning brigade)
        {
            throw new NotImplementedException();
        }

      
    }
}
