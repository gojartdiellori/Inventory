using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Suppliers.PluginInterfaces;

namespace InventorySystem.Plugins.Suppliers
{
    public class SupplierRepository : ISupplierRepository
    {
        private List<Supplier> listOfSuppliers;
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
            return Task.FromResult(listOfSuppliers);
        }

        public Task UpdateSupplier(Supplier supplier)
        {
            var sup = listOfSuppliers.FirstOrDefault(x => x.ID == supplier.ID);

            if(sup is not null)
            {

                sup.Name=supplier.Name;

            }
            return Task.CompletedTask;

        }
    }
}