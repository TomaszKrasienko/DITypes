namespace DIExamples.Services;

public class ScopedService : IService
{
    private Guid _guidField;
    public ScopedService()
    {
        _guidField = Guid.NewGuid();
    }
    public string GetStringGuid()
    {
        return $"Scoped guid: {_guidField}";
    }
}