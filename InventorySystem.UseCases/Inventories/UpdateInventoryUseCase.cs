using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Inventories.PluginInterfaces;

namespace InventorySystem.UseCases.Inventories
{
    public class UpdateInventoryUseCase : IUpdateInventoryUseCase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public UpdateInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public Task ExecuteAsync(Inventory inventory){

            return _inventoryRepository.UpdateInventoryAsync(inventory);
        }        
    }
}