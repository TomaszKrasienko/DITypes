namespace DIExamples.Services;

public class SingletonGuid : IService
{
    private Guid _guidField;
    public SingletonGuid()
    {
        _guidField = Guid.NewGuid();
    }
    public string GetStringGuid()
    {
        return $"Singleton guid: {_guidField}";
    }
}