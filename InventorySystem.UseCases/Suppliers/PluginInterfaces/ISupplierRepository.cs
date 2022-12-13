using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Suppliers.PluginInterfaces
{
    public interface ISupplierRepository
    {
        
        public Task<List<Supplier>> GetSuppliers();

    }
}