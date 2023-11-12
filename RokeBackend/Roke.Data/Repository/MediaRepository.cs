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
    public class MediaRepository : IMediaRepository
    {
        private readonly RokeContext _context;
        public MediaRepository(RokeContext ctx)
        {
            _context = ctx;

        }



        public async Task<Media> CreateMedia(Media data)
        {
            try
            {
                _context.media.Add(data);
                await _context.SaveChangesAsync();
                return data;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return data;
            }
        }
    



        public IEnumerable<Media> getAllMedias()
        {
            try
            {
                var media = _context.media.ToList();
                return media;
            }
            catch (Exception)
            {

                throw;
            }
        }


        
        public async Task<Media> getMediaByIdAsync(Guid id)
        {
            try
            {
                Media media = await _context.media.FindAsync(id);
                return media;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /*
        public async Task<brigadeDetails> getBrigadeByIdByTechAsync(Guid id)
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
        }*/

   

        public async Task<int> RemoveMedia(Guid id)
        {
            try
            {
                try
                {
                    Media plan = await _context.media.FindAsync(id);
                    //_context.tickets.Remove(Ticket);
                    plan.isDeleted = true;
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

   

        public async Task<Media> UpdateMedia(Media media)
        {
            try
            {
                
                 _context.media.Update(media);
                await _context.SaveChangesAsync();
                return media;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return media;
            }


        }

      
    }
}
