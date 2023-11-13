using Implementation;

namespace Tests;

public class SingletonTests
{
    [Test]
    public void Singleton_InstanceIsNotNull()
    {
        var instance = Singleton.Instance;

        Assert.IsNotNull(instance);
    }

    [Test]
    public void Singleton_SameInstance()
    {
        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;

        Assert.AreSame(instance1, instance2);
    }
}