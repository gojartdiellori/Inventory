using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Suppliers.Interfaces;
using InventorySystem.UseCases.Suppliers.PluginInterfaces;

namespace InventorySystem.UseCases.Suppliers
{
 
    public class ViewSuppliersUseCase : IViewSuppliersUseCase
    {

        private readonly ISupplierRepository _supplierRepository;

        public ViewSuppliersUseCase(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task<List<Supplier>> ExecuteAsync()
        {

            return await _supplierRepository.GetSuppliers();
        }

    }
}