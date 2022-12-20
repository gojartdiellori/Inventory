using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Suppliers.Interfaces;
using InventorySystem.UseCases.Suppliers.PluginInterfaces;

namespace InventorySystem.UseCases.Suppliers
{
    public class DeleteSupplierUseCase : IDeleteSupplierUseCase
    {
        private readonly ISupplierRepository _supplierRepository;

        public DeleteSupplierUseCase(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task ExecuteAsync(int id)
        {
            await _supplierRepository.DeleteSupplier(id);
        }
    }
}