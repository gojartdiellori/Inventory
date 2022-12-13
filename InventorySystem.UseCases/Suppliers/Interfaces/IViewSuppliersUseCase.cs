using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Suppliers.Interfaces
{
    public interface IViewSuppliersUseCase
    {

        Task<List<Supplier>> ExecuteAsync();
        
    }
}