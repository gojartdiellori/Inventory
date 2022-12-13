using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Suppliers.Interfaces
{
    public interface IAddSupplierUseCase
    {
        
        public Task ExecuteAsync(Supplier supplier);
        

    }
}