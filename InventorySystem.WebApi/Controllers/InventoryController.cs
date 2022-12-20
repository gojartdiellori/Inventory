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
        private readonly IDeleteInventoryUseCase _deleteInventoryUseCase;

        public InventoryController(IViewInventoryUseCase viewInventoryUseCase, IAddInventoryUseCase addInventoryUseCase, IUpdateInventoryUseCase updateInventoryUseCase, IDeleteInventoryUseCase deleteInventoryUseCase)
        {
            _viewInventoryUseCase = viewInventoryUseCase;
            _addInventoryUseCase = addInventoryUseCase;
            _updateInventoryUseCase = updateInventoryUseCase;
            _deleteInventoryUseCase = deleteInventoryUseCase;
        }

        [HttpGet]
        public Task<List<Inventory>> GetInventories()
        {
            return _viewInventoryUseCase.GetAllInventoryItems();
        }

        [HttpPost("add")]
        public async Task AddInventory([FromBody] Inventory inventory)
        {
            await _addInventoryUseCase.ExecuteAsync(inventory);
        }

        [HttpPut("update")]
        public async Task UpdateInventory([FromBody] Inventory inventory)
        {
            await _updateInventoryUseCase.ExecuteAsync(inventory);
        }

        [HttpDelete("{id}")]
        public async Task DeleteInventory(int id)
        {
            await _deleteInventoryUseCase.ExecuteAsync(id);
        }
    }
}