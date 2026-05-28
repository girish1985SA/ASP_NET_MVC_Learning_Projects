using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                // Save the employee to the database (not implemented in this example)
                // Redirect to the index page after successful creation
                return RedirectToAction("Success");
            }
            return View(employee);
        }


        public IActionResult Success()
        {
            return View();
        }
    }
}
