using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Suppliers.Interfaces;
using InventorySystem.UseCases.Suppliers.PluginInterfaces;

namespace InventorySystem.UseCases.Suppliers
{
    public class AddSupplierUseCase : IAddSupplierUseCase
    {
        private readonly ISupplierRepository _supplierRepository;

        public AddSupplierUseCase(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task ExecuteAsync(Supplier supplier)
        {
             await _supplierRepository.AddSuppliers(supplier);
        }
    }
}