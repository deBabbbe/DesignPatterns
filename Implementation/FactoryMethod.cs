namespace Implementation;

using System;

public interface IProduct
{
    string Display();
}

public class ConcreteProduct : IProduct
{
    public string Display()
    {
        return "Concrete Product";
    }
}

public interface ICreator
{
    IProduct FactoryMethod();
}

public class ConcreteCreator : ICreator
{
    public IProduct FactoryMethod()
    {
        return new ConcreteProduct();
    }
}
