using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            Console.WriteLine("username-"+user.Username+"-");
            ViewBag.name = user.Username;
            ViewBag.email = user.Email;

            if (verify == user.Password)
            {
                ViewBag.time = user.TimeJoined;
                return View("index");
            }
            else
            {
                ViewBag.error = "Passwords does not match. Try again!";
                Redirect("/User/Add");
            }
            return View();
        }
    }
}
