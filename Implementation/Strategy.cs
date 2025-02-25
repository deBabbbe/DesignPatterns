namespace Implementation;

public interface IShippingStrategy
{
    decimal CalculateShippingCost(decimal orderTotal);
}

public class StandardShipping : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal orderTotal)
    {
        return 3 * orderTotal;
    }
}

public class ExpressShipping : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal orderTotal)
    {
        return 5 * orderTotal;
    }
}

public class Strategy(IShippingStrategy strategy)
{
    public decimal GetShippingCost(decimal amount)
    {
        return strategy.CalculateShippingCost(amount);
    }
}
