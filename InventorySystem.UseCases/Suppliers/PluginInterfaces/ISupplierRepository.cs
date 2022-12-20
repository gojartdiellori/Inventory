using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Suppliers.PluginInterfaces
{
    public interface ISupplierRepository
    {
        public Task<List<Supplier>> GetSuppliers();
        public Task AddSuppliers(Supplier supplier);
        public Task UpdateSupplier(Supplier supplier);
        public Task DeleteSupplier(int id);
    }
}