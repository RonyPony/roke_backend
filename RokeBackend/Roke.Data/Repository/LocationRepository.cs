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
    public class LocationRepository : ILocationRepository
    {
        private readonly RokeContext _context;
        public LocationRepository(RokeContext ctx)
        {
            _context = ctx;
        }

        public Task<location> CreateLocatio(location location)
        {
            throw new NotImplementedException();
        }

        public async Task<locationMapping> assignInvetory(locationMapping Location)
        {
            try
            {
                _context.locationMapping.Add(Location);
                await _context.SaveChangesAsync();
                return Location;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return Location;
            }
        }

        public async Task<location> CreateLocation(location Location)
        {
            location finaluser = new location();
            try
            {
                _context.location.Add(Location);
                await _context.SaveChangesAsync();
                finaluser = Location;
                return finaluser;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return finaluser;
            }
        }

      

        public IEnumerable<location> getAllLocation()
        {
            try
            {
                var location = _context.location.ToList();
                return location;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<location> getAllLocations()
        {
            try
            {
                var location = _context.location.ToList();
                return location;
            }
            catch (Exception)
            {

                throw;
            }
        }




        public async Task<location> getLocationByIdAsync(Guid id)
        {
            try
            {
                location location = await _context.location.FindAsync(id);
                return location;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<int> RemoveLocation(Guid id)
        {
            try
            {
                try
                {
                    location location = await _context.location.FindAsync(id);
                    //_context.tickets.Remove(Ticket);
                    location.status = Roke.Core.Enums.LocationStatus.Deleted;
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

        public Task<int> RemoveLocatio(Guid idLocation)
        {
            throw new NotImplementedException();
        }

        public Task<location> UpdateLocation(location location)
        {
            throw new NotImplementedException();
        }

        public Task<location> UpdateLocations(location location)
        {
            throw new NotImplementedException();
        }
    }
}
