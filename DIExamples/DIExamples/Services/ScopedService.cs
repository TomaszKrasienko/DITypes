namespace DIExamples.Services;

public class ScopedService : IScopedService
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