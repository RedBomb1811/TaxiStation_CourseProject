using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        [Route("Index")]
        public IActionResult Index()
        {

            return View("Index", _context.Orders.ToList());
        }

        [HttpGet]
        [Route("MakeOrder")]
        public IActionResult MakeOrder()
        {
            ViewBag.Id_order_type = new SelectList(_context.Order_types, "id", "name");
            return View("MakeOrder");
        }

        [HttpPost]
        [Route("MakeOrder")]
        public IActionResult MakeOrder(MakeOrder order)
        {
            ///TODO: MakeOrder
            try
            {
                int id_order = _context.MakeOrder(order.Phone_number, order.Id_order_type, order.Start_point_lat, order.Start_point_long,
                    order.End_point_lat, order.End_point_long, order.Child, order.Pets);
                ViewData["Id_order"] = id_order;
                return View("ConfirmOrder");
            }
            catch(Exception sqlException)
            {
                ///TODO: обработка ошибки и вызврат существующего номера заказа
                ModelState.AddModelError("", sqlException.Message);
                return View("MakeOrder");
            }
        }

        [HttpGet]
        [Route("Confirm")]
        public IActionResult ConfirmOrder()
        {
            return View("ConfirmOrder");
        }

        [HttpPost]
        [Route("Confirm")]
        public IActionResult ConfirmOrder(long Id_order, int Code)
        {
            ///TODO: время начала заказа отсчитывается от момента подтверждения заказа
            if (Code > 0 && Id_order > 0)
                if (_context.ConfirmOrder(Id_order, Code) == 1)
                    return RedirectToAction("Index", "Home");

            ModelState.AddModelError("", "Not correct code, try again");
            ViewData["Id_order"] = Id_order;
            return View("ConfirmOrder");
        }

        [HttpGet]
        [Route("Monitor")]
        [Authorize]
        public IActionResult MonitorOrders()
        {
            IEnumerable<NotAcceptedOrdersForDriver_Result> list = _context.NotAcceptedOrdersForDriver(2);
            return View("MonitorOrders", list);
        }
    }
}
