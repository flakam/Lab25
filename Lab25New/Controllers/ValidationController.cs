using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab25New.Models;

namespace Lab25New.Controllers
{
    public class ValidationController:Controller
    {
        public IActionResult HtmlValidation()
        {
            return View();
        }
        public IActionResult UserResult(UserModel u)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = u.Name;
                return View(u);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
    }
}
