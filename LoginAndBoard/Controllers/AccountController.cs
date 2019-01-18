using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginAndBoard.Models;
using LoginAndBoard.UserControl;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginAndBoard.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Join()
        {
            //using (var db = new UserAccount())
            //{
            //    db.JoinUser.Add(new Join { UserID = "AAA", UserPW = "PWPW", UserName = "SONY", UserEmail = "sony.com" });
            //    var count = db.SaveChanges();

            //    Console.WriteLine("{0} records saved to database", count);

            //    Console.WriteLine();
            //    Console.WriteLine("All blogs in database:");
            //    foreach (var user in db.LoginUser)
            //    {
            //        Console.WriteLine(" - {0}", user.UserID);
            //    }
            //}

            //using (var db = new UserAccount())
            //{

            //    db.LoginUser.Add(new Login { UserID = "AAA"+DateTime.Now, UserPW = "PWPW"});
            //    var count = db.SaveChanges();

            //    Console.WriteLine("{0} records saved to database", count);

            //    Console.WriteLine();
            //    Console.WriteLine("All blogs in database:");
            //    foreach (var user in db.LoginUser)
            //    {
            //        Console.WriteLine(" - {0}", user.UserID);
            //    }

            //}



            return View();
        }

        [HttpPost]
        public IActionResult Join(User lmodel)
        {
            Console.WriteLine("--------- {0}, {1}, {2}, {3}", lmodel.UserID, lmodel.UserPW, lmodel.UserEmail, lmodel.UserName);
            if (ModelState.IsValid)
            {
                using (var db = new UserAccount())
                {
                    //var usr = db.LoginUser.FirstOrDefault(u => u.UserID.Equals(lmodel.UserID)
                    //                                        && u.UserPW.Equals(lmodel.UserPW));
                    //if (usr == null)
                    //{
                    //    Console.WriteLine("FAIL to login");
                    //    ModelState.AddModelError(string.Empty, "User id or password is wrong");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Success to loging");
                    //    return RedirectToAction("Java", "My");
                    //}

                    db.LoginUser.Add(new Login
                    {
                        UserID = lmodel.UserID,
                        UserPW = lmodel.UserPW,
                        UserEmail = lmodel.UserEmail,
                        UserName = lmodel.UserName
                    });
                    var count = db.SaveChanges();
                    Console.WriteLine("{0} records saved to database", count);

                    Console.WriteLine();
                    Console.WriteLine("All blogs in database:");
                    foreach (var usr in db.LoginUser)
                    {
                        Console.WriteLine(" - {0}", usr.UserID);
                    }
                }
            }
            return RedirectToAction("Login", "Account");
        }


        public IActionResult SignIn()
        {
            using (var db = new BlogExample())
            {
                db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            Console.WriteLine("TTTTTTTTTTTTTTTTTTTt");
            return View();
        }

        [HttpPost]
        public IActionResult Login(User lmodel)
        {
            Console.WriteLine("--------- {0}, {1}", lmodel.UserID, lmodel.UserPW);
            if(ModelState.IsValid)
            {
                using (var db = new UserAccount())
                {
                    var usr = db.LoginUser.FirstOrDefault(u=>u.UserID.Equals(lmodel.UserID) 
                                                            && u.UserPW.Equals(lmodel.UserPW));
                    if(usr == null)
                    {
                        Console.WriteLine("FAIL to login");
                        ModelState.AddModelError(string.Empty, "User id or password is wrong");
                    }
                    else
                    {
                        Console.WriteLine("Success to loging");
                        return RedirectToAction("Csharp", "My");
                    }
                }
            }
            return View();
        }
    }
}
