using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Inventories.PluginInterfaces
{
    public interface IInventoryRepository
    {
        public Task<List<Inventory>> GetAllInventoryItems();

        public Task AddInventoryAsync(Inventory inventory);

        public Task UpdateInventoryAsync(Inventory inventory);

    }
}