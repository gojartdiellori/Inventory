using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Suppliers.Interfaces
{
    public interface IUpdateSupplierUseCase
    {
        public Task ExecuteAsync(Supplier supplier);
    }
}