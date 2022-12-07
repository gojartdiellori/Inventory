using InventorySystem.CoreBusiness;

namespace InventorySystem.UseCases.Inventories
{
    public class ViewInventoryUseCase
    {
        public async Task<List<Inventory>> GetAllInventoryItems(){

                var listOfInventory = new List<Inventory>{
                    new Inventory{ ID=1,Name="Shoes"},
                    new Inventory{ ID=2,Name="Bread"}

                };

                return await Task.FromResult(listOfInventory);


        }
    }
}