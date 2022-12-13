using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Suppliers.PluginInterfaces;

namespace InventorySystem.Plugins.Suppliers
{
    public class SupplierRepository : ISupplierRepository
    {
        List<Supplier> listOfSuppliers;
        public SupplierRepository()
        {
            listOfSuppliers = new List<Supplier>(){
                new Supplier{ID=1,Name="Amex"},
                new Supplier{ID=2,Name="Cisco"}
            };
        }

        public Task AddSuppliers(Supplier supplier)
        {   
            if(listOfSuppliers.Any(s=>s.Name==supplier.Name))
                return Task.CompletedTask;
            
            var maxId=listOfSuppliers.Max(x=>x.ID);

            var newId= maxId+1;

            supplier.ID=newId;

            listOfSuppliers.Add(supplier);
            return Task.CompletedTask;
        }

        public Task<List<Supplier>> GetSuppliers()
        {
            return Task.FromResult(new List<Supplier>() {
                new Supplier {ID =1 ,Name="American MED"},
                new Supplier {ID =2 ,Name="American EDU"},

            });
        }
    }
}