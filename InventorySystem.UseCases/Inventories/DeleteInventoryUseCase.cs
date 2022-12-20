using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Inventories.PluginInterfaces;

namespace InventorySystem.UseCases.Inventories
{

    public class DeleteInventoryUseCase : IDeleteInventoryUseCase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public DeleteInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(int id)
        {
            await _inventoryRepository.DeleteInventory(id);
        }
    }
}