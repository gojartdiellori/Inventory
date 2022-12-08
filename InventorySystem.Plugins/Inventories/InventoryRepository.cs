using InventorySystem.UseCases.Inventories.PluginInterfaces;
using InventorySystem.CoreBusiness;

namespace InventorySystem.Plugins.Inventories
{
    public class InventoryRepository : IInventoryRepository
    {

        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>{

            new Inventory{
                ID=1,
                Name="Shoes"
            },
            new Inventory{
                ID=2,
                Name="Books"
            }
            
        };

        }

        public Task AddInventoryAsync(Inventory inventory)
        {
            if (_inventories.Any(x=>x.Name==inventory.Name)) 
                return Task.CompletedTask;

            // find max of id 
            var maxId=_inventories.Max(x=>x.ID);
            inventory.ID=maxId;
            
            _inventories.Add(inventory);
            return Task.CompletedTask;
        }

        public async Task<List<Inventory>> GetAllInventoryItems()
        {
            return await Task.FromResult(_inventories);
        }

        public Task UpdateInventoryAsync(Inventory inventory)
        {
           var inv = _inventories.FirstOrDefault(x=> x.ID == inventory.ID);
           if(inv != null) 
           {
              inv.Name=inventory.Name;
           }
            return Task.CompletedTask;
        }
    }
}