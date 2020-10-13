using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AS_ViewModel.Models;

namespace AS_ViewModel.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Names()
        {
            // to a View that has defined a model as @model string[]
            string[] names = new string[]
            {
                "Sally", "Billy", "Joey", "Moose"
            };
            return View(names);
        }

        [HttpGet]
        [Route("User")]
        public IActionResult User()
        {
            User someUser = new User()
            {
                FirstName = "Sally",
                LastName = "Sanderson"
            };
            

            return View(someUser);
        }


        //collection
        [HttpGet]
        [Route("Users")]

        public IActionResult Users()
        {
            List<User> Users = new List<User>();
            Users.Add(new User(){
                FirstName = "Sally",
                LastName = "Sanderson"
            });
            Users.Add(new User(){
                FirstName = "Ben",
                LastName = "Henderson"
            });
            return View(Users);
        }

        //no model?
        [HttpGet]
        [Route("Numbers")]
        public IActionResult Numbers()
        {
            int[] numArray = new int[] {1,2,3};
            // foreach (int num in numArray)
            // {
            //     Console.WriteLine($"{numArray[num]}");
            // }
            return View(numArray);
        }

    }
}
