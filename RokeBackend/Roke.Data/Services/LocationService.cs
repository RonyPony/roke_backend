
using RokeBackend.core.Interface;
using RokeBackend.Model;
using RokeBackend.data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RokeBackend.core.Contracts;
using Roke.Core.Model;

namespace RokeBackend.data.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _repo;

        public LocationService(ILocationRepository repo)
        {
            _repo = repo;
        }

        public Task<int> DeleteLocation(Guid idLocation)
        {
            return _repo.RemoveLocation(idLocation);

        }

        public IEnumerable<location> GetAllLocation()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<location> GetAllLocations()
        {
            return _repo.getAllLocations();
        }

        public Task<location> GetLocationById(Guid id)
        {
            return _repo.getLocationByIdAsync(id);
        }



        public Task<location> SaveUsuario(location location)
        {
            return _repo.CreateLocation(location);
        }

        public async Task<location> UpdateLocation(location location)
        {
            return await _repo.UpdateLocation(location);
        }

        public Task<location> UpdateLocatio(location location)
        {
            throw new NotImplementedException();
        }

        public Task<location> SaveLocation(location locaton)
        {
            throw new NotImplementedException();
        }
    }
}
