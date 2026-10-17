using CafeteriaApp.Data;
using CafeteriaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CafeteriaApp.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet]
        public IActionResult List()
        {
            ViewBag.InfoTitle = "All Orders";
            var Orders = OrdersRepo.Orders;
            return View(Orders);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var Order = OrdersRepo.GetById(id);
            return View(Order);
        }

        [HttpGet]
        public IActionResult Collect()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Collect(Order order)
        {
            if (ModelState.IsValid)
            {
                OrdersRepo.Collect(order.OrderId!.Value);
                return RedirectToAction("Details", "Orders", new { @id = order.OrderId!.Value });
            }
            return View();
        }
    }
}
