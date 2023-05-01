using Microsoft.AspNetCore.Mvc;

namespace Project_OOP_.Net_7.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
