
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
    public class MonthService : IMonthService
    {
        private readonly IMonthRepository _repo;

        public MonthService(IMonthRepository repo)
        {
            _repo = repo;
        }

    

       

        public IEnumerable<month> GetAllMonths()
        {
            return _repo.getAllMonths();
        }

        public Task<month> GetMonthById(Guid id)
        {
            return _repo.getMonthByIdAsync(id);
        }

        public Task<month> GetMonthnById(Guid id)
        {
            return _repo.getMonthByIdAsync(id);
        }

     
    }
}
