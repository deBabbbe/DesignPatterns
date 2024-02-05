using Implementation;

namespace Tests;

public class SingletonTests
{
    [Test]
    public void Singleton_InstanceIsNotNull()
    {
        var instance = Singleton.Instance;

        Assert.That(instance, Is.Not.Null);
    }

    [Test]
    public void Singleton_SameInstance()
    {
        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;

        Assert.That(instance2, Is.SameAs(instance1));
    }
}