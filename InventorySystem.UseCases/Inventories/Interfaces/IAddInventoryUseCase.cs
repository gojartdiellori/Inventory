using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Inventories
{
    public interface IAddInventoryUseCase
    {
        public Task ExecuteAsync(Inventory inventory);        
    }
}