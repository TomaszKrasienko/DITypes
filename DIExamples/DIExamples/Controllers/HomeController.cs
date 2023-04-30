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
    public HomeController(
        ILogger<HomeController> logger,
        ISingletonService singletonService,
        IScopedService scopedService,
        ITransientService transientService)
    {
        _logger = logger;
        _singletonService = singletonService;
        _scopedService = scopedService;
        _transientService = transientService;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Singleton()
    {
        return View(_singletonService.GetStringGuid());
    }
}

