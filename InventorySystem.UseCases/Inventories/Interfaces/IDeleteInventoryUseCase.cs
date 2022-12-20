using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Inventories
{
    public interface IDeleteInventoryUseCase
    {
        public Task ExecuteAsync(int id);
    }
}