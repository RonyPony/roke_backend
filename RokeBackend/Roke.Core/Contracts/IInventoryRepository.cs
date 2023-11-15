using Microsoft.AspNetCore.Mvc;
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Contracts
{
    public interface IInventoryRepository
    {
        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<Inventory> CreateInventory(Inventory Inventory);

        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>


        public Task<IEnumerable<InventoryDetails>> getAllInventorys();
        public Task<Inventory> getInventoryByIdAsync(Guid id);
        public IEnumerable<Inventory> getInventoryByLocationAsync(Guid id);


        /// <summary>
        /// Update a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<Inventory> UpdateInventory(Inventory Inventory);

        /// <summary>
        ///  Remove a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<int> RemoveInventory(Guid id);
    
    }
}
