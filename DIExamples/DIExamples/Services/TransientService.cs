namespace DIExamples.Services;

public class TransientService : ITransientService
{
    private Guid _guidField;
    public TransientService()
    {
        _guidField = Guid.NewGuid();
    }
    public string GetStringGuid()
    {
        return $"Scoped guid: {_guidField}";
    }
}