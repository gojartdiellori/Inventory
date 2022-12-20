using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Suppliers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SupplierController : ControllerBase
    {
        private readonly IViewSuppliersUseCase _viewSuppliersUseCase;

        private readonly IAddSupplierUseCase _addSupplierUseCase;

        private readonly IUpdateSupplierUseCase _updateSupplierUseCase;
        private readonly IDeleteSupplierUseCase _deleteSupplierUseCase;

        public SupplierController(IViewSuppliersUseCase viewSuppliersUseCase, IAddSupplierUseCase addSupplierUseCase, IUpdateSupplierUseCase updateSupplierUseCase, IDeleteSupplierUseCase deleteSupplierUseCase)
        {
            _viewSuppliersUseCase = viewSuppliersUseCase;
            _addSupplierUseCase = addSupplierUseCase;
            _updateSupplierUseCase = updateSupplierUseCase;
            _deleteSupplierUseCase = deleteSupplierUseCase;
        }

        [HttpGet]
        public Task<List<Supplier>> GetSuppliers()
        {

            return _viewSuppliersUseCase.ExecuteAsync();

        }

        [HttpPost("add")]
        public async Task AddSupplier([FromBody] Supplier supplier)
        {
            await _addSupplierUseCase.ExecuteAsync(supplier);
        }

        [HttpPut("update")]
        public async Task UpdateSupplier([FromBody] Supplier supplier)
        {
            await _updateSupplierUseCase.ExecuteAsync(supplier);
        }

        [HttpDelete("{id}")]
        public async Task DeleteSupplier(int id)
        {
            await _deleteSupplierUseCase.ExecuteAsync(id);
        }
    }
}