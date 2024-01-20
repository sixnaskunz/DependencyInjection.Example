namespace DependencyInjection.Example.Services;

public class ScopedService : IScopedService
{
    public readonly Guid guid;

    public ScopedService()
    {
        guid = Guid.NewGuid();
    }

    public Guid GetDIValue()
    {
        return guid;
    }
}