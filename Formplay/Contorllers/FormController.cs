using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Formplay.Models;

namespace Formplay.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("renderdata")]
        public IActionResult Data(Survey answers)
        {
                // ViewBag.name= answers.fullname;
                // ViewBag.loc= answers.location;
                // ViewBag.lan= answers.language;
                // ViewBag.com= answers.comment;

            return View("Data", answers);
        }
    }
}