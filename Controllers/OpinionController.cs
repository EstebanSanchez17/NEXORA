using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PaginaTec.Models;

namespace PaginaTec.Controllers;

public class OpinionController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new Opinion());
    }

    [HttpPost]
    public IActionResult Index(Opinion opinion)
    {
        if (!ModelState.IsValid)
        {
            return View(opinion);
        }
        
        return View("Resultado", opinion);
    }
}
