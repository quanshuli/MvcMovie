using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    public ViewResult Index()
    {
        return View();
        // return "This is my default";
    }

    public string Welcome(string name, int num = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, time {num}");
    }
}