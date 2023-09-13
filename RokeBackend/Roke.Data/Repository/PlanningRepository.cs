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
            planning plan = new planning();
            try
            {
                _context.plannings.Add(planning);
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


        public IEnumerable<planning> getAllPlannings()
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

       

        public async Task<planning> getPlanningByIdAsync(Guid id)
        {
            try
            {
                planning plan = await _context.plannings.FindAsync(id);
                return plan;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<int> RemovePlanning(Guid id)
        {
            try
            {
                try
                {
                    planning plan = await _context.plannings.FindAsync(id);
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

    

      

  

     
      

     public async Task<planning> UpdatePlanning(planning planning)
        {
            try
            {
                
                 _context.plannings.Update(planning);
                await _context.SaveChangesAsync();
                return planning;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return planning;
            }


        }

      
    }
}
