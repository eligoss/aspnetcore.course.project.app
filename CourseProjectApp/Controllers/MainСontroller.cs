using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseProjectApp.Controllers
{
    [Route("Main")]
    public class MainСontroller : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.value = "My First MVC Route!!!";
            return View();
        }
    }
}
