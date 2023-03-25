using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ppp2.Models;

namespace ppp2.Controllers;

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

    public IActionResult Ex1()
    {
        return View();
    }

    public IActionResult Ex2()
    {
        return View();
    }

    public IActionResult Ex3()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Ex1(string spacebar)
    {
        var bars = 0;
        var colvo = 0;
        int i;
        for (i = 0; i < spacebar.Length; i++)
            if (spacebar[i] == ' ')
            {
                colvo++;
                bars = colvo;
            }

        ViewBag.Otvet = "Количество пробелов:" + bars;
        return View();
    }

    [HttpPost]
    public IActionResult Ex2(int n)
    {
        double rez = 0;
        for (var i = 1; i <= n; i++)
            rez += Math.Pow(-1, i + 1) * (1.0 + (double)i / 10);

        ViewBag.Otvet = rez;
        return View();
    }

    [HttpPost]
    public IActionResult Ex3(string sentence)
    {
        var leng = sentence.Length;
        if (sentence[0] == sentence[leng - 1])
            ViewBag.Otvet = "Верно";
        else ViewBag.Otvet = "Не верно";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}