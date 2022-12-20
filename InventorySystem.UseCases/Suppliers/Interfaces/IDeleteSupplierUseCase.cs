using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Suppliers.Interfaces
{
    public interface IDeleteSupplierUseCase
    {
        public Task ExecuteAsync(int id);
    }
}