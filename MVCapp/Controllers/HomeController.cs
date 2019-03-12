using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCapp.Models;

namespace MVCapp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string aString= "blah blah blah blah blah blah";
            return View("Index", aString);
        }
        [HttpGet]
        [Route("numbers")]
        public IActionResult Numbers()
        {
            int[] nums= new int[]{
                1, 2, 3, 4, 5, 6
            };

            return View(nums);
        }

        [HttpGet]
        [Route("users")]
        public IActionResult Users()
        {
            User one= new User{
                FirstName= "allyse",
                LastName= "fischer"
            };
            User two= new User{
                FirstName= "freyja",
                LastName= "fischer"
            };
            User three= new User{
                FirstName= "chris",
                LastName= "fischer"
            };

            List<User> allpeople= new List<User>(){
                one, two, three
            };

            return View(allpeople);
        }

        [HttpGet]
        [Route("oneuser")]
        public IActionResult OneUser()
        {
            User one= new User{
                FirstName= "allyse",
                LastName= "fischer"
            };
            return View(one);
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
