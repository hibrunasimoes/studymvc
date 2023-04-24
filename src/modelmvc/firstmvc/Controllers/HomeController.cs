using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using firstmvc.Models;
using firstmvc.Database;

namespace firstmvc.Controllers;

public class HomeController : Controller
{
    //private readonly ILogger<HomeController> _logger;

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
    //}

    //public IActionResult Index()
    //{
    //    return View();
    //}

    //public IActionResult Privacy()
    //{
    //    return View();
    //}

    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}

    private readonly IPedidoRepository _pedidoRepository;

    public HomeController(IPedidoRepository pedidoRepository)
    {
        _pedidoRepository = pedidoRepository;
    }
}

