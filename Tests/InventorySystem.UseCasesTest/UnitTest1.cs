namespace InventorySystem.UseCasesTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.NotEqual(4, Add(2, 2));
    }

    int Add(int x, int y)
    {
        return x + y;
    }
}