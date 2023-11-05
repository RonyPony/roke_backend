
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
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _repo;


     


        public InventoryService(IInventoryRepository repo)
        {
            _repo = repo;
        }

       

   

   

        public Task<int> DeleteInventory(Guid id)
        {
            return _repo.RemoveInventory(id);

        }

      

        public IEnumerable<Inventory> GetAllInventorys()
        {
            return _repo.getAllInventorys();
        }

        public Task<Inventory> GetInventoryById(Guid id)
        {
            return _repo.getInventoryByIdAsync(id);
        }

        public IEnumerable<Inventory> getInventoryByLocationAsync(Guid id)
        {
            return _repo.getInventoryByLocationAsync(id);
        }


        public Task<Inventory> SaveInventory(Inventory inventory)
        {
            return _repo.CreateInventory(inventory);
        }

        public async Task<Inventory> UpdateInventory(Inventory inventory)
        {
            return await _repo.UpdateInventory(inventory);
        }

       
    }
}
