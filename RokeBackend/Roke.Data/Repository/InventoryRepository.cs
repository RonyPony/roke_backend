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
    public class InventoryRepository : IInventoryRepository
    {
        private readonly RokeContext _context;
        public InventoryRepository(RokeContext ctx)
        {
            _context = ctx;
        }
        public async Task<Inventory> CreateInventory(Inventory inventory)
        {
            Inventory finaluser = new Inventory();
            try
            {
                _context.Inventories.Add(inventory);
                await _context.SaveChangesAsync();
                finaluser = inventory;
                return finaluser;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return finaluser;
            }
        }

      

        public IEnumerable<Inventory> getAllInventorys()
        {
            try
            {
                var inventories = _context.Inventories.ToList();
                return inventories;
            }
            catch (Exception)
            {

                throw;
            }
        }

    

        public async Task<Inventory> getInventoryByIdAsync(Guid id)
        {
            try
            {
                Inventory inventory = await _context.Inventories.FindAsync(id);
                return inventory;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<int> RemoveInventory(Guid id)
        {
            try
            {
                try
                {
                    Inventory inventory = await _context.Inventories.FindAsync(id);
                    //_context.tickets.Remove(Ticket);
                    inventory.Status = Roke.Core.Enums.Status.Deleted;
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

     

  

       

      

     public async Task<Inventory> UpdateInventory(Inventory inventory)
        {
            try
            {
                
                 _context.Inventories.Update(inventory);
                await _context.SaveChangesAsync();
                return inventory;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return inventory;
            }


        }

    
    }
}
