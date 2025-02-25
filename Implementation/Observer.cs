namespace Implementation;

using System.Collections.Generic;

public class Subject
{
    private readonly List<IObserver> _observers = [];
    private int _state;

    public int State
    {
        get => _state;
        set
        {
            _state = value;
            NotifyObservers();
        }
    }

    public void Attach(IObserver observer) => _observers.Add(observer);

    public void Detach(IObserver observer) => _observers.Remove(observer);

    private void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}

public interface IObserver
{
    string Update();
}

public class ConcreteObserverA : IObserver
{
    private readonly Subject _subject;

    public ConcreteObserverA(Subject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }

    public string Update() => $"ConcreteObserverA: Zustand des Subjects wurde aktualisiert: {_subject.State}";
}

public class ConcreteObserverB : IObserver
{
    private readonly Subject _subject;

    public ConcreteObserverB(Subject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }

    public string Update() => $"ConcreteObserverB: Zustand des Subjects wurde aktualisiert: {_subject.State}";
}