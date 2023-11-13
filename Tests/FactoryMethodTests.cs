using Implementation;

[TestFixture]
public class FactoryMethodTests
{
    [Test]
    public void ConcreteCreator_CreateProduct_ReturnsConcreteProduct()
    {
        var creator = new ConcreteCreator();

        var product = creator.FactoryMethod();

        Assert.IsNotNull(product);
        Assert.IsInstanceOf<ConcreteProduct>(product);
    }

    [Test]
    public void ConcreteProduct_Display_ReturnsExpectedOutput()
    {
        var expectedOutput = "Concrete Product";

        IProduct product = new ConcreteProduct();
        var output = product.Display();

        Assert.AreEqual(expectedOutput, output);
    }
}
