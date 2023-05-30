using Microsoft.AspNetCore.Mvc;
using new_project.Models;
using System.Diagnostics;

namespace new_project.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Untree()
        {
            return View();
        }

    }
}