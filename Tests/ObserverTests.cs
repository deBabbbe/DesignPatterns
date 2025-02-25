namespace Tests;

using Implementation;

public class ObserverTests
{
    [Test]
    public void ConcreteObserverA_Update_ReturnsExpectedString()
    {
        var subject = new Subject();
        var observerA = new ConcreteObserverA(subject);
        var newState = 42;
        var expectedOutput = $"ConcreteObserverA: Zustand des Subjects wurde aktualisiert: {newState}";

        subject.State = newState;

        Assert.That(observerA.Update(), Is.EqualTo(expectedOutput));
    }
}
