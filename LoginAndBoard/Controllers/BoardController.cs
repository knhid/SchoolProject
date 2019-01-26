using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginAndBoard.Controllers
{
    public class BoardController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //trying to link page. so far, It still can not load https page.
            //Response.Redirect("https://sites.google.com/view/10-28-sun-leeanncake/home");
            Response.Redirect("https://www.pexels.com/search/north%20carolina/");
            return View();
        }

        public IActionResult MainBoard()
        {
            return View();
        }
    }
}
