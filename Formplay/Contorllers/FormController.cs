using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Data(string fullname, string location, string language, string comment)
        {
                ViewBag.name= fullname;
                ViewBag.loc=location;
                ViewBag.lan= language;
                ViewBag.com=comment;

            return View("Data");
        }
    }
}