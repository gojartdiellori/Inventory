using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Suppliers.PluginInterfaces;

namespace InventorySystem.Plugins.Suppliers
{
    public class SupplierRepository : ISupplierRepository
    {
        public Task<List<Supplier>> GetSuppliers()
        {
            return Task.FromResult(new List<Supplier>() {
                new Supplier {ID =1 ,Name="American MED"},
                new Supplier {ID =2 ,Name="American EDU"},

            });
        }
    }
}