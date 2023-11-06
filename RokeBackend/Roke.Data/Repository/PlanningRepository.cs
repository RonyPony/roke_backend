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
using System.Numerics;
using System.Collections;

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
        public async Task<IEnumerable<planningCalendar>> getAllPlanningforCalendar()
        {
             try
             {
                List<planning> planning = _context.planning.ToList();
                
                List<planningCalendar> obj = new List<planningCalendar>();
                
                foreach (var item in planning)
                {
                    planningCalendar ob = new planningCalendar();
                    brigade tmpPlan = await _context.brigades.FindAsync(item.idBrigade);
                    ob.id = item.idTemplate;
                    ob.title = tmpPlan.Name;
                    ob.start = item.StartDate;
                    ob.end = item.finalDate;
                    obj.Add(ob);
                }
              
                return obj;

             }
             catch (Exception)
             {

                 throw;
             }
        }

            public async Task<List<List<planning>>> getAllPlannings()
        {
            /* try
             {
                 var planning = _context.planning.ToList();
                 return planning;
             }
             catch (Exception)
             {

                 throw;
             }*/
            try
            {
                List<List<planning>> plan = new List<List<planning>>();
                
                List<Guid> result = _context.planning.Select(m => m.IdPlan).Distinct().ToList();

                var tmpPlan2 = _context.planning.Where(e => e.IdPlan == Guid.NewGuid()).ToList();

                foreach (var item in result)
                {

                    List<planning> tmpPlan = _context.planning.Where(e=>e.IdPlan==item).ToList();
                    plan.Add(tmpPlan);

                }
            
                return plan;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<planning> getPlanningById(Guid id)
        {
            try
            {
                planning planning = await _context.planning.FindAsync(id);
                return planning;
            }
            catch (Exception)
            {

                throw;
            }
        }

       /* public async List<Task<planning>> getPlanningByIdMonthAsync(Guid id)
        {
            try
            {
                List<planning> planning = await _context.planning.Where((e) => e.idMonth == id).Distinct();
                return  planning;
            }
            catch (Exception)
            {

                throw;
            }
        }
      */
        public async Task<planningDetails> getPlanningByIdAsync(Guid id)
        {
            try
            {
                planning plan = await _context.planning.FindAsync(id);
                planningDetails twl = new planningDetails();
                List<brigade> user = new List<brigade>();
                twl.Name = plan.Name;
                twl.idTemplate = plan.idTemplate;
                twl.finalDate = plan.finalDate;
                twl.StartDate = plan.StartDate;
                          
                List<planning> x =  _context.planning.Where((e)=>e.idBrigade == plan.idBrigade && e.idTemplate == plan.idTemplate).ToList();
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

        public async Task<planning> UpdatePlanning(planning planning)
        {
            try
            {
                
                 _context.planning.Update(planning);
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
