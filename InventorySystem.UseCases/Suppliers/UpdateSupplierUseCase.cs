using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Suppliers.Interfaces;
using InventorySystem.UseCases.Suppliers.PluginInterfaces;

namespace InventorySystem.UseCases.Suppliers
{
    public class UpdateSupplierUseCase : IUpdateSupplierUseCase
    {
        private readonly ISupplierRepository _supplierRepository;

        public UpdateSupplierUseCase(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task ExecuteAsync(Supplier supplier)
        {
            await _supplierRepository.UpdateSupplier(supplier);
        }
    }
}