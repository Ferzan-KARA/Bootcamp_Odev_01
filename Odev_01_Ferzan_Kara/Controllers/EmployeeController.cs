using Microsoft.AspNetCore.Mvc;
using Odev_01_Ferzan_Kara.Models;

namespace Odev_01_Ferzan_Kara.Controllers
{
    public class EmployeeController : Controller
    {
        private NrthwndContext northwind = new NrthwndContext();

        [HttpGet]
        public IActionResult EmployeeList()
        {
            var employees = northwind.Employees.ToList();

            return View(employees);
        }

        [HttpGet]
        //[ActionName("InsertEmployee")]
        public IActionResult EmployeeAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee) 
        {
                if (ModelState.IsValid)
                {
                    northwind.Employees.Add(employee);
                    northwind.SaveChanges();
                    return RedirectToAction("EmployeeList");
                }
            return View(employee);
        }
    }
}
