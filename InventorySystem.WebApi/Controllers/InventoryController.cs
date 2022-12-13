using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Inventories;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IViewInventoryUseCase _viewInventoryUseCase;
        private readonly IAddInventoryUseCase _addInventoryUseCase;
        private readonly IUpdateInventoryUseCase _updateInventoryUseCase;

        public InventoryController(IViewInventoryUseCase viewInventoryUseCase, IAddInventoryUseCase addInventoryUseCase, IUpdateInventoryUseCase updateInventoryUseCase)
        {
            _viewInventoryUseCase = viewInventoryUseCase;
            _addInventoryUseCase = addInventoryUseCase;
            _updateInventoryUseCase = updateInventoryUseCase;
        }

        [HttpGet]
        public Task<List<Inventory>> GetInventories() {
            return _viewInventoryUseCase.GetAllInventoryItems();
        }

        [HttpPost]
        public async Task AddInventory([FromBody] Inventory inventory)
        {
            await _addInventoryUseCase.ExecuteAsync(inventory);
        }

        [HttpPut("/update")]
        public async Task UpdateInventory([FromBody] Inventory inventory)
        {
            await _updateInventoryUseCase.ExecuteAsync(inventory);
        }
    }
}