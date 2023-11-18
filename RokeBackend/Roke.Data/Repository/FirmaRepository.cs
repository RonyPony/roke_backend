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
using System.Collections;

namespace RokeBackend.data.Repository
{
    public class FirmaRepository : IFirmaRepository
    {
        private readonly RokeContext _context;
        public FirmaRepository(RokeContext ctx)
        {
            _context = ctx;

        }



        public async Task<Firma> CreateFirma(Firma data)
        {
            try
            {
                _context.firmas.Add(data);
                await _context.SaveChangesAsync();
                return data;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return data;
            }
        }
     
        public async Task<Firma> getFirmaByIdAsync(Guid id)
        {
            try
            {
                Firma firma = await _context.firmas.FindAsync(id);
                return firma;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public  IEnumerable<Firma>getAllFirma()
        {
            try
            {
                var firma = _context.firmas.ToList();
                return firma;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<int> RemoveFirma(Guid id)
        {
            try
            {
                try
                {
                    Firma firma = await _context.firmas.FindAsync(id);
                    //_context.tickets.Remove(Ticket);
                    //plan.status = Roke.Core.Enums.Status.Deleted;
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

   

        public async Task<Firma> UpdateFirma(Firma data)
        {
            try
            {
                
                 _context.firmas.Update(data);
                await _context.SaveChangesAsync();
                return data;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return data;
            }


        }

      
    }
}
