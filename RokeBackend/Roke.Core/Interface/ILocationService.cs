
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Interface
{
    public interface ILocationService
    {
        public IEnumerable<location> GetAllLocation();
        public Task<location> GetLocationById(Guid id);
        public Task<location> SaveLocation(location locaton);
        public Task<location> UpdateLocation(location location);
        public Task<int> DeleteLocation(Guid id);
        public Task<locationMapping> assignInvetory(locationMapping location);
        IEnumerable<location> GetAllLocations();
    }
}
