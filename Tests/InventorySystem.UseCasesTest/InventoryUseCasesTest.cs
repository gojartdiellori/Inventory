using InventorySystem.CoreBusiness;
using InventorySystem.UseCases.Inventories;

namespace InventorySystem.UseCasesTest;
public class InventoryUseCasesTest
{

    [Fact]
    public void AddInventoryUse_AddNull_ShouldRetrunEmpty()
    {
        var mockContactRepository = new Mock<IAddInventoryUseCase>();

        mockContactRepository.Setup(mock => mock.ExecuteAsync(It.Ref<Inventory>.IsAny)).Returns(Task.CompletedTask);

        Assert.Equal(Task.CompletedTask, mockContactRepository.Object.ExecuteAsync(It.Ref<Inventory>.IsAny));
    }


}
