using Implementation;

namespace Tests;

public class StrategyTests
{
    [TestCase(0, ExpectedResult = 0)]
    [TestCase(1, ExpectedResult = 3)]
    [TestCase(3, ExpectedResult = 9)]
    public decimal GetShippingCostTest_StandardShipping(decimal amount)
    {
        var strategy = new StandardShipping();
        var target = new Strategy(strategy);

        return target.GetShippingCost(amount);
    }

    [TestCase(0, ExpectedResult = 0)]
    [TestCase(1, ExpectedResult = 5)]
    [TestCase(3, ExpectedResult = 15)]
    public decimal GetShippingCostTest_ExpressShipping(decimal amount)
    {
        var strategy = new ExpressShipping();
        var target = new Strategy(strategy);

        return target.GetShippingCost(amount);
    }
}
