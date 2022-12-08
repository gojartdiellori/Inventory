using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Inventories
{
    public interface IViewInventoryUseCase
    {
         Task<List<Inventory>> GetAllInventoryItems();
    }
}