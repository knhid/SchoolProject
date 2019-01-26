using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginAndBoard.Models;
using Microsoft.AspNetCore.Http;

namespace LoginAndBoard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("before login check -> " + HttpContext.Session.GetInt32("USER_STUDENT_KEY"));
            var gIn = HttpContext.Session.GetInt32("USER_STUDENT_KEY");
            if (HttpContext.Session.GetInt32("USER_STUDENT_KEY") == null) return RedirectToAction("Login", "Account");
            else return RedirectToAction("Java", "My");

            //return View();
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

        public IActionResult Contact()
        {
            ViewData["My Message"] = "Your contact page.";
            return View();
        }
    }
}
