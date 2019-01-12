using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginAndBoard.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginAndBoard.Controllers
{
    public class MyController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //var firstuser = new User();
            //firstuser.UserNo = 1;
            //firstuser.UserName = "QWE";

            //1st way
            //var firstUser = new User()
            //{
            //    UserNo = 1,
            //    UserName = "QWE"
            //};
            //return View(firstUser);

            var firstUser = new User()
            {
                UserNo = 1,
                UserName = "QWE"
            };
            ViewBag.MyUser = firstUser;
            return View();

            //3st way
            //var firstUser = new User()
            //{
            //    UserNo = 1,
            //    UserName = "QWE"
            //};
            //ViewData["UserName"] = firstUser.UserName;
            //ViewData["UserNo"] = firstUser.UserNo;
            //return View();
        }

        public IActionResult Java()
        {
            return View();
        }

        public IActionResult CSharp()
        {
            return View();
        }

        public IActionResult Cpp()
        {
            return View();
        }
    }
}
