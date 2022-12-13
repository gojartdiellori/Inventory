using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Suppliers.Interfaces;
using InventorySystem.UseCases.Suppliers.PluginInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly IViewSuppliersUseCase _viewSuppliersUseCase;

        public SupplierController( IViewSuppliersUseCase viewSuppliersUseCase)
        {
            _viewSuppliersUseCase = viewSuppliersUseCase;
        }

        [HttpGet]
        public Task<List<Supplier>> GetSuppliers(){

            return _viewSuppliersUseCase.ExecuteAsync();

        }

    }
}