using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LogReg.Models;

namespace LogReg.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("/register")]
        public IActionResult Register(Registration model)
        {
            if(ModelState.IsValid){
                return RedirectToAction("ShowSuccessPage");
            }
            else{
                return View("Index");
            }
        }

        [HttpPost]
        [Route("/login")]
        public IActionResult Login(Login model)
        {
            if(ModelState.IsValid){
                return RedirectToAction("ShowSuccessPage");
            }
            else{
                return View("Index");
            }
        }

        [HttpGet]
        [Route("success")]
        public IActionResult ShowSuccessPage()
        {
            return View("Success");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
