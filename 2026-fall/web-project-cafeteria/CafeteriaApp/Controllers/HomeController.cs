using CafeteriaApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace CafeteriaApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.InfoTitle = "Collected Orders";
            var Orders = OrdersRepo.Orders.Where(o => o.Collected == true).ToList();
            return View(Orders);
        }
    }
}
