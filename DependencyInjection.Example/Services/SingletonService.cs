namespace DependencyInjection.Example.Services;

public class SingletonService : ISingletonService
{
    public readonly Guid guid;

    public SingletonService()
    {
        guid = Guid.NewGuid();
    }

    public Guid GetDIValue()
    {
        return guid;
    }
}