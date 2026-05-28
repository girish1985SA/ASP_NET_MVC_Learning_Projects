using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class ViewComponentInMVCController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
