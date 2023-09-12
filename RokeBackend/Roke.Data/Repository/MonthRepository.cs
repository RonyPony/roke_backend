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
    public class    MonthRepository : IMonthRepository
    {
        private readonly RokeContext _context;
        public MonthRepository(RokeContext ctx)
        {
            _context = ctx;
        }


      

        public IEnumerable<month> getAllMonths()
        {
            try
            {
                var month = _context.months.OrderBy(item => item.order).ToList();
                return month;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<month> getMonthByIdAsync(string value)
        {
            try
            {
              
                month month = await _context.months.FirstOrDefaultAsync(u => u.Month == value);
                return month;
            }
            catch (Exception)
            {

                throw;
            }
        }

      
    }
}
