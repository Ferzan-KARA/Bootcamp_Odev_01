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

        [HttpPost]
        [ActionName("AddEmployee")]
        public IActionResult EmployeeAdd()
        {
            return View();
        }
    }
}
