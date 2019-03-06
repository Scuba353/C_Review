    using Microsoft.AspNetCore.Mvc;
    namespace Firstwebapp.Controllers     
    {
        public class HomeController : Controller   //remember inheritance??
        {
            [HttpGet]       
            [Route("")]    
            public ViewResult Index()
            {
                return View();
            }


            [HttpGet]       
            [Route("projects")]    
            public string Projects()
            {
                return "This is my Projects Page!";
            }


            [HttpGet]       
            [Route("contact")]    
            public string Contact()
            {
                return "This is my Contact page!";
            }


            [HttpGet]
            [Route("displayanon")]
            public JsonResult DisplayAnon()
            {
                var AnonObject = new {
                    FirstName = "Raz",
                    LastName = "Aquato",
                    Age = 10
                };
                
                return Json(AnonObject);
            }
        }
    }