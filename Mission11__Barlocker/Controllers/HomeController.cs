using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission11__Barlocker.Models;

namespace Mission11__Barlocker.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}