using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Inventories.PluginInterfaces;

namespace InventorySystem.UseCases.Inventories
{

    public class ViewInventoryUseCase : IViewInventoryUseCase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public ViewInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<List<Inventory>> GetAllInventoryItems()
        {

            return await _inventoryRepository.GetAllInventoryItems();

        }
    }
}