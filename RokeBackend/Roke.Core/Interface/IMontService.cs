
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Interface
{
    public interface IMonthService
    {
        public IEnumerable<month> GetAllMonths();
        public Task<month> GetMonthById(Guid id);

        
    }
}
