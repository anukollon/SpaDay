using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            Console.WriteLine("Inside add httpget method");
            return View(addUserViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            Console.WriteLine("Inside add http post method");
            if (ModelState.IsValid)
            {
                Console.WriteLine("ModelState.IsValid");
                if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {
                    Console.WriteLine("Passwords match");
                    User user = new User
                    {
                        Username = addUserViewModel.Username,
                        Email = addUserViewModel.Email,
                        Password = addUserViewModel.Password
                    };

                     return View("Index", user);
                }
                /*else
                {
                    ViewBag.error = "Passwords do not match! Try again!";
                    ViewBag.userName = newUser.Username;
                    ViewBag.eMail = newUser.Email;
                    return View("Add");                   
                }*/
            }

            return View(addUserViewModel);

    }

    }
}
