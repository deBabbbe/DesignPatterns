using Implementation;

namespace Tests;

public class FactoryMethodTests
{
    [Test]
    public void ConcreteCreator_CreateProduct_ReturnsConcreteProduct()
    {
        var creator = new ConcreteCreator();

        var product = creator.FactoryMethod();

        Assert.That(product, Is.Not.Null);
        Assert.That(product, Is.InstanceOf<ConcreteProduct>());
    }

    [Test]
    public void ConcreteProduct_Display_ReturnsExpectedOutput()
    {
        var expectedOutput = "Concrete Product";

        IProduct product = new ConcreteProduct();
        var output = product.Display();

        Assert.That(output, Is.EqualTo(expectedOutput));
    }
}
