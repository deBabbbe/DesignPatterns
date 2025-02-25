using static Implementation.ChainOfResponsibility;

namespace Tests;

public class ChainOfResponsibilityTests
{
    [Test]
    public void FeedTest_RabbitEatsCarrot()
    {
        var result = new AnimalFeeder().Feed("carrot");

        Assert.That(result, Is.EqualTo("Rabbit eats the carrot."));
    }

    [Test]
    public void FeedTest_MonkeyEatsBanana()
    {
        var result = new AnimalFeeder().Feed("banana");

        Assert.That(result, Is.EqualTo("Monkey eats the banana."));
    }

    [Test]
    public void FeedTest_LionEatsSteak()
    {
        var result = new AnimalFeeder().Feed("steak");

        Assert.That(result, Is.EqualTo("Lion eats the steak."));
    }

    [Test]
    public void FeedTest_NoAnimalEatsGrass()
    {
        var result = new AnimalFeeder().Feed("grass");

        Assert.That(result, Is.EqualTo("No animal eats the grass."));
    }
}