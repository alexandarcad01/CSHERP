﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using firstsitecsharp.Models;

namespace firstsitecsharp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
  
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult registration()
    {
        return View();
    }
    public IActionResult Brandstore()
    {
        return View();
    }

    public IActionResult Contactus()
    {
        return View();
    }

     public IActionResult Privacy()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
