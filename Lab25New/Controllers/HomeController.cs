using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab25New.Models;

namespace Lab25New.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
        public IActionResult UserModel()
        {
            return View();
        }
        public IActionResult TheResultPage()
        {


            return View();
        }
        [HttpGet]
        public IActionResult TheResultPage(UserModel u)
        {
            if (ModelState.IsValid)
            {
                return View(u);
            }
            else
            {
                return RedirectToAction("Error");
            }

        }
        public IActionResult TheView()
        {
            return View();
        }


    }
}
