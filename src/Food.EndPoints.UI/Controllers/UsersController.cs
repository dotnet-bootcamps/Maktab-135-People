using System.Diagnostics;
using Food.EndPoints.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Food.EndPoints.UI.Controllers;

[Authorize(Roles = "Admin")]
public class UsersController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public UsersController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}