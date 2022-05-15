using Microsoft.AspNetCore.Mvc;
using RyansOrderApp.Models;
using System.Diagnostics;

namespace RyansOrderApp.Controllers
{
    public class HomeController : Controller
    {
        private ryanContext ryanContext;

        public HomeController(ryanContext ryanContext)
        {
            this.ryanContext = ryanContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitOrder(Order order)
        {
            // save to database
            ryanContext.Orders.Add(order);
            ryanContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Orders()
        {
            var orders = ryanContext.Orders.ToList();

            return View(orders);
        }
    }
}