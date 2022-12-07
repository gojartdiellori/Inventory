using InventorySystem.UseCases.Inventories.PluginInterfaces;

namespace InventorySystem.Plugins.Inventories
{
    public class InventoryRepository : IInventoryRepository
    {

        List<Inventory> listOfInventory = new List<Inventory>{

            new Inventory{
                ID=1,
                Name="Shoes"
            },
            new Inventory{
                ID=2,
                Name="Books"
            }
            
        };
        public async Task<List<Inventory>> GetAllInventoryItems()
        {
            return await Task.FromResult(listOfInventory);
        }

    }
}