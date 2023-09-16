using Microsoft.AspNetCore.Mvc;
using Odev_01_Ferzan_Kara.Models;

namespace Odev_01_Ferzan_Kara.Controllers
{
    public class OrderController : Controller
    {
        private NrthwndContext northwind = new NrthwndContext();

        [HttpGet("{id}")]
        public IActionResult OrderList(int employeeId)
        {
            var orders = northwind.Orders.Where(o => o.EmployeeId == employeeId).ToList();
            return View(orders);
        }
    }
}
