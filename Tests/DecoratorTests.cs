using Implementation;

namespace Tests;

public class DecoratorTests
{
    [Test]
    public void Espresso_ShouldReturnCorrectDescriptionAndCost()
    {
        var drink = new Espresso();

        var description = drink.GetDescription();
        var cost = drink.GetCost();

        Assert.That(description, Is.EqualTo("Espresso"));
        Assert.That(cost, Is.EqualTo(1.50m));
    }

    [Test]
    public void EspressoWithMilk_ShouldReturnCorrectDescriptionAndCost()
    {
        IDrink drink = new Espresso();
        drink = new MilkDecorator(drink);

        var description = drink.GetDescription();
        var cost = drink.GetCost();

        Assert.That(description, Is.EqualTo("Espresso, Milch"));
        Assert.That(cost, Is.EqualTo(2.00m));
    }

    [Test]
    public void EspressoWithMilkAndSugar_ShouldReturnCorrectDescriptionAndCost()
    {
        IDrink drink = new Espresso();
        drink = new MilkDecorator(drink);
        drink = new SugarDecorator(drink);

        var description = drink.GetDescription();
        var cost = drink.GetCost();

        Assert.That(description, Is.EqualTo("Espresso, Milch, Zucker"));
        Assert.That(cost, Is.EqualTo(2.20m));
    }
}