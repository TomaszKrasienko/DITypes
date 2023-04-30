namespace DIExamples.Services;

public class SingletonService : ISingletonService
{
    private Guid _guidField;
    public SingletonService()
    {
        _guidField = Guid.NewGuid();
    }
    public string GetStringGuid()
    {
        return $"Singleton guid: {_guidField}";
    }
}