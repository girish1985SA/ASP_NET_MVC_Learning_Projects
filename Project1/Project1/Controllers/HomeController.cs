using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Project1.Filters;
using Project1.Models;
using System.Diagnostics;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //return View();
            // return Json(new { m = 10, l = 20, z = 30 });
            // return 
            // return PartialView("path")
            // return StatusCode(200);
            // return new RedirectResult("https://example.com");
            // return RedirectToAction("/");
            // string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files/invoice.pdf");

            //// Parameters: (File path, Content-Type)
            // return File(filePath, "application/pdf");
            Product product = new Product()
            {
                Id = 1,
                Name = "Test",
            };
            return PartialView("_ProductDetailsPartialView", product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [AjaxOnly]
        public PartialViewResult Details()
        {
            Product product = new Product()
            {
                Id = 1,
                Name = "Test Product",
            };
            return PartialView("_ProductDetailsPartialView", product);
        }



        // Defining an action method named Index that returns a JsonResult
        //public JsonResult DataJsonReulsts()
        //{
        //    // Creating an anonymous object with properties Name, ID, and DateOfBirth
        //    var jsonData = new
        //    {
        //        Name = "Pranaya",
        //        ID = 4,
        //        DateOfBirth = new DateTime(1988, 02, 29)
        //    };
        //    // Returning a JsonResult object with the jsonData as the content to be serialized to JSON
        //    return new JsonResult(jsonData);
        //}


        public IActionResult DataJsonReulsts()
        {
            // Creating an anonymous object with properties Name, ID, and DateOfBirth
            var jsonData = new
            {
                Name = "Pranaya",
                ID = 4,
                DateOfBirth = new DateTime(1988, 02, 29)
            };

            var jsonArray = new[]
            {
                new { Name = "Pranaya", Age = 25, Occupation = "Designer" },
                new { Name = "Ramesh", Age = 30, Occupation = "Manager" }
            };
            // Returning a JsonResult object with the jsonData as the content to be serialized to JSON
            return Json(jsonArray);
        }
    }
}
