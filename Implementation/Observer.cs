namespace Implementation;

using System.Collections.Generic;

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void NotifyObservers(string message);
}

public class Subject : ISubject
{
    private readonly List<IObserver> _observers = [];

    public void Attach(IObserver observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        if (_observers.Contains(observer))
            _observers.Remove(observer);
    }


    public void NotifyObservers(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }
}

public interface IObserver
{
    void Update(string message);
}

public class ConcreteObserverA : IObserver
{
    public string? Message { get; set; }

    public void Update(string message)
    {
        Message = "ConcreteObserverA: " + message;
    }
}

public class ConcreteObserverB : IObserver
{
    public string? Message { get; set; }

    public void Update(string message)
    {
        Message = "ConcreteObserverB: " + message;
    }
}