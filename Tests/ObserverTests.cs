namespace Tests;

using Implementation;

public class ObserverTests
{
    [Test]
    public void ConcreteObserverA_Update_ReturnsExpectedString()
    {
        var observerA = new ConcreteObserverA();
        var subject = new Subject();
        subject.Attach(observerA);
        subject.NotifyObservers("Test message");

        var expectedMessage = "ConcreteObserverA: Test message";

        Assert.That(observerA.Message, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void ConcreteObserverB_Detach()
    {
        var observerB = new ConcreteObserverB();
        var subject = new Subject();
        subject.Attach(observerB);
        subject.NotifyObservers("Different message");

        var expectedMessage = "ConcreteObserverB: Different message";

        Assert.That(observerB.Message, Is.EqualTo(expectedMessage));

        subject.Detach(observerB);

        subject.NotifyObservers("Test message");
        Assert.That(observerB.Message, Is.EqualTo(expectedMessage));
    }
}
