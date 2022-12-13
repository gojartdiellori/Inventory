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

        public SupplierController(IViewSuppliersUseCase viewSuppliersUseCase, IAddSupplierUseCase addSupplierUseCase)
        {
            _viewSuppliersUseCase = viewSuppliersUseCase;
            _addSupplierUseCase = addSupplierUseCase;
        }

        [HttpGet]
        public Task<List<Supplier>> GetSuppliers(){

            return _viewSuppliersUseCase.ExecuteAsync();

        }

        [HttpPost]
        public async Task AddSupplier([FromBody]Supplier supplier) 
        {
            await _addSupplierUseCase.ExecuteAsync(supplier);
        }

    }
}