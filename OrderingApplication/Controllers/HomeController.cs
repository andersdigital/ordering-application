using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderingApplication.Models;

namespace OrderingApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var orders = new List<Order>()
            {
                new Order() { Name = "Denoc id elit non", LastUpdated = DateTime.Now.AddDays(-2), Description = "More Latin" },
            new Order() { Name = "Desdfanoc sdgid ealgit nodn", LastUpdated = DateTime.Now.AddDays(-1), Description = "More Latin" },
            new Order() { Name = "Dendghoc idkgh edghklit nddghkn", LastUpdated = DateTime.Now.AddDays(-4), Description = "More Latin" },
            new Order() { Name = "Dendghkoc idghkd edghklit ndghkon", LastUpdated = DateTime.Now.AddDays(-6), Description = "More Latin" },
            new Order() { Name = "Denouytc iduyt eletyuit nuyton", LastUpdated = DateTime.Now.AddDays(-5), Description = "More Latin" }
        };

            ViewBag.Orders = orders;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
