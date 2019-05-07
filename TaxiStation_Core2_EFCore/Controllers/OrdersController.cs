using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaxiStation_Core2_EFCore.Models.ViewModels;
using TestExample.DB;

namespace TaxiStation_Core2_EFCore.Controllers
{
    [Route("Order")]
    public class OrdersController : Controller
    {
        private readonly TaxiStationContext _context;

        public OrdersController(TaxiStationContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("MakeOrder")]
        public IActionResult MakeOrder()
        {
            ViewBag.Order_types = new SelectList(_context.Order_types, "id", "name");
            return View("MakeOrder");
        }

        [HttpPost]
        [Route("MakeOrder")]
        public IActionResult MakeOrder(MakeOrder order)
        {
            ///TODO: MakeOrder
            ViewBag.Order_types = new SelectList(_context.Order_types, "id", "name");
            return View("MakeOrder");
        }
    }
}
