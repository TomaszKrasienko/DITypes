using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DIExamples.Models;
using DIExamples.Services;

namespace DIExamples.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ISingletonService _singletonService;
    private readonly IScopedService _scopedService;
    private readonly ITransientService _transientService;
    private readonly IHelper _helper;
    public HomeController(
        ILogger<HomeController> logger,
        ISingletonService singletonService,
        IScopedService scopedService,
        ITransientService transientService,
        IHelper helper)
    {
        _logger = logger;
        _singletonService = singletonService;
        _scopedService = scopedService;
        _transientService = transientService;
        _helper = helper;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Singleton()
    {
        BaseViewModel baseViewModel = new()
        {
            GuidFromHelper = _helper.GetSingleton(),
            GuidFromService = _singletonService.GetStringGuid()
        };
        return View(nameof(Singleton), baseViewModel);
    }

    public IActionResult Scoped()
    {
        BaseViewModel baseViewModel = new()
        {
            GuidFromHelper = _helper.GetScoped(),
            GuidFromService = _scopedService.GetStringGuid()
        };
        return View(nameof(Scoped), baseViewModel);
    }

    public IActionResult Transient()
    {
        BaseViewModel baseViewModel = new()
        {
            GuidFromHelper = _helper.GetTransient(),
            GuidFromService = _transientService.GetStringGuid()
        };
        return View(nameof(Transient),  baseViewModel);
    }
}

