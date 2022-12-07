using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Inventories.PluginInterfaces
{
    public interface IInventoryRepository
    {
        public Task<List<Inventory>> GetAllInventoryItems();
    }
}