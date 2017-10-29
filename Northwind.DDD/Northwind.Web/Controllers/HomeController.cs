using Microsoft.AspNetCore.Mvc;

namespace Northwind.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}