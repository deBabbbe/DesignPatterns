namespace Implementation;

public interface IProduct
{
    string Display();
}

public class ConcreteProduct : IProduct
{
    public string Display() => "Concrete Product";
}

public interface ICreator
{
    IProduct FactoryMethod();
}

public class ConcreteCreator : ICreator
{
    public IProduct FactoryMethod() => new ConcreteProduct();
}
