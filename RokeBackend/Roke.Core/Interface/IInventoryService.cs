
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Interface
{
    public interface IInventoryService
    {
        public IEnumerable<Inventory> GetAllInventorys();
        public Task<Inventory> GetInventoryById(Guid id);
      
        public Task<Inventory> SaveInventory(Inventory Inventory);
        public Task<Inventory> UpdateInventory(Inventory Inventory);
        public Task<int> DeleteInventory(Guid Id);
        
    }
}
