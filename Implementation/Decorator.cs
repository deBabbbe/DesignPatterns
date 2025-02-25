namespace Implementation;


public interface IDrink
{
    string GetDescription();
    decimal GetCost();
}

public class Espresso : IDrink
{
    public string GetDescription() => "Espresso";

    public decimal GetCost() => 1.50m;
}

public abstract class DrinkDecorator(IDrink drink) : IDrink
{
    public virtual string GetDescription() => drink.GetDescription();

    public virtual decimal GetCost() => drink.GetCost();
}

public class MilkDecorator(IDrink drink) : DrinkDecorator(drink)
{
    private readonly IDrink _drink = drink;

    public override string GetDescription() => _drink.GetDescription() + ", Milch";

    public override decimal GetCost() => _drink.GetCost() + 0.5m;
}

public class SugarDecorator(IDrink drink) : DrinkDecorator(drink)
{
    private readonly IDrink _drink = drink;

    public override string GetDescription() => _drink.GetDescription() + ", Zucker";

    public override decimal GetCost() => _drink.GetCost() + 0.2m;
}
