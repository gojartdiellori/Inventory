using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Inventories
{
    public interface IUpdateInventoryUseCase
    {
        public Task ExecuteAsync(Inventory inventory);        
    }
}