namespace Tests;

using Implementation;

public class ObserverTests
{
    [Test]
    public void ConcreteObserverA_Update_ReturnsExpectedString()
    {
        // Arrange
        var subject = new Subject();
        var observerA = new ConcreteObserverA(subject);
        int newState = 42;
        string expectedOutput = $"ConcreteObserverA: Zustand des Subjects wurde aktualisiert: {newState}";

        // Act
        subject.State = newState;

        // Assert
        Assert.AreEqual(expectedOutput, observerA.Update());
    }
}
