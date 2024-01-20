namespace DependencyInjection.Example.Services;

public class TransientService : ITransientService
{
    private readonly Guid guid;

    public TransientService()
    {
        guid = Guid.NewGuid();
    }

    public Guid GetDIValue()
    {
        return guid;
    }
}