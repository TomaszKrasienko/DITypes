using DIExamples.Services;

namespace DIExamples;

public class Helper : IHelper
{
    private readonly IScopedService _scopedService;
    private readonly ITransientService _transientService;
    private readonly ISingletonService _singletonService;
    public Helper(
        IScopedService scopedService, 
        ITransientService transientService,
        ISingletonService singletonService)
    {
        _scopedService = scopedService;
        _transientService = transientService;
        _singletonService = singletonService;
    }
    public string GetScoped()
    {
        return _scopedService.GetStringGuid();
    }
    public string GetTransient()
    {
        return _transientService.GetStringGuid();
    }
    public string GetSingleton()
    {
        return _singletonService.GetStringGuid();
    }
}