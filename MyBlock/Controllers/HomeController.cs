using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MyBlock.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}